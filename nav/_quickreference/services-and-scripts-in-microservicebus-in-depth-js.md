---
layout: post
title:  "Developing JavaScript Services in microServiceBus.com"
description: "This section will dive into the details of how to write a Service. Learn more about how you can enhance productivity through our Tips & Tricks."
categories: quickreference
order: 80
---

Before you read this post you should familiarize yourself with how flows and services in *microServiceBus.com* works. If you are not familiar with these concepts yet, please visit the [Getting started](../gettingStarted-list) first. If you're looking at creating **Python** based services navigate to [Developing Python Services in microServiceBus.com](../services-and-scripts-in-microservicebus-in-python)

When you as a developer is writing a JavaScript service to use in a flow, you are extending the *microservice* object *microServiceBus.com* is exposing. This object has a number of functions and properties that could help you develop your code. First we will go through what is required in your own service, then what is available to you and lastly som best practices.

## Required functions

* **Start()**

  This function will be called when your node starts and your service has been downloaded.
  
  `@parameters` : none

  `@returns` : _void_

  `@example`

  ```javascript
    Start : function(){
        let timerEvent = setInterval(function(){
            //start your reoccuring logic
        }, 10000)
    }
  ```

> **Tip!**
> Here it is great to add all your NPM packages.

* **Stop()**

  This function will be called when you disable or restart your node.
  
  `@parameters` : none

  `@returns` : _void_

  `@example`

  ```javascript
    Stop : function(){
        ClearInterval(timerEvent);
    }
  ```

> **Tip!**
> Here it is recommended to stop your timers or clear your processes.

* **Process()**

  This function will be called when you send messages from another service to this
  
  `@parameters` : _message_ , _context_

  `@returns` : _void_

  `@example`

  ```javascript
    Process : function(){
        let newData = JSON.stringify(message);
    }
  ```

> **Tip!**
> Here is where you can integrate your services to share data with each other.

## Properties on the *microservice* object

```javascript
    this.timezone // The current timezone of the device
    this.Config // General, Static and Security parameters set in the Flow
    this.NodeName // The id of the node running the service
    this.Name // The name of the service
    this.settingsHelper // Has a lot of useful properties such as paths
    this.Com // Com includes many functions for making sure your device is connected as it should be 
  ```

> **Tip!**
> These are just some examples of properties you can access. Check the source code at [GitHub](https://github.com/axians/microservicebus-core/blob/dev/lib/MicroServiceBusNode.js) to find more. Search for _**new MicroService**_ ;)


## Functions on the *microservice* object

* **this.GetCurrentState()**

  Returns the "device twin" or "shadow" of the device from the connected IoT Hub.
  
  `@parameters` : none

  `@returns` : _Object_

  `@example`

  ```javascript
    Start : function(){
        //Fetch latest state
        let state = this.GetCurrentState();
        if(state.desired.temperature > state.reported.temperature){
            //Turn on the heater
        }
    }
  ```

* **this.AddNpmPackage(npmPackages, logOutput, callback)**

  Downloads the packages in run time and calls the callback when download and installation is completed
  
  `@parameters` : npmPackages (string), logOutput (Boolean), callback (function)

  `@returns` : _Void_

  `@example`

  ```javascript
        this.AddNpmPackage('request,serialport@7.0.0', true, function(err){
        if(!err){
            request = require('request');
        }
        else{
            self.ThrowError(null, '00001', 'Unable to install the npm packages');
            return;
        }
    });
  ```

* **this.SubmitMessage(msg, format, headers)**

  Creates a new context and sends the message to the next service in the flow in a specified format with or without headers. 

  `@parameters` : msg (object or binary), format (string), headers (needs to be formatted as following : [{Variable : "[key]", Value : "[value]"}])

  `@returns` : _Void_

  `@example`

  ```javascript
       this.SubmitMessage({Sensor : "mySensor", Value : 22}, 'application/json', [{Variable : "messageType", Value : "tempSensor"}]);
  ```

* **this.SubmitResponseMessage(msg, context, contentType)**

  Similar to SubmitMessage but is using the same *context*. Most often used for *Internal*- and Outboud services

  `@parameters` : msg (object or binary), context (including itinerary and variables), contentType (E.g. 'application/json')

  `@returns` : _Void_

  `@example`

  ```javascript
       this.SubmitResponseMessage({Sensor : "mySensor", Value : 22}, context,'application/json');
  ```
* **this.Configuration()**

  Used to retrieve Meter Configuration. See [Working with meter configuration]({{site.baseurl}}/meter-configuration)

  `@parameters` : None

  `@returns` : All Meter configuration for the Node

  `@example`

  ```javascript
       const meterConfiguration = await this.Configuration();
       meterConfiguration.forEach(meter=>{
        // Connect to meter using meter.connectivity section
        meter.forEach(dataSet=>{
           dataSet.forEach(dataPoint=>{
            // Read data point
           };)
        });
       });
  ```
* **this.GetLocalTime()**

  Used to get local time depending on location set on the Node (Properties page of Node)
  `@parameters` : None

  `@returns` : DateTime

  `@example`

  ```javascript
       const localTime = this.GetLocalTime();
  ```
* **this.GetInstanceOf(serviceName, callback)**

  Returns the service instance by name. This can be usefull when you have a service that needs to run as a singleton and server multiple services. For instance, if you connect to two or more RTU meters using the same serial port you might have to run the in sequense. In such case you might want to use an Modbus Master service as a singleton to access the actual meter while multiple other services are doing the request.

  `@parameters` :  serviceName (name of service), callback (err, instance))

  `@returns` : DateTime

  `@example`

  ```javascript
       this.GetInstanceOf("modbusMater1", (err, instance)=>{
        // call function on service instance
        // E.g. instance.readRegister(connection, address, datatype)
       });
  ```
* **this.SetCronInterval(callback, cronExp)**

  Returns a CRON job which will trigger on interval.

  `@parameters` :  callback (function that will trigger), cronExp (CRON Expression))

  `@returns` : CRON job

  `@example`

  ```javascript
       var cronInterval = this.SetCronInterval(()=>{console.log("CRON job triggered")}), "* * * 1 *");
  ```
* **this.SetCronInterval(cronJob)**

  Stops the CRON interval.

  `@parameters` :  cronJob (instance of CRON job))

  `@returns` : _void_

  `@example`

  ```javascript
       this.ClearCronInterval(cronInterval);
  ```

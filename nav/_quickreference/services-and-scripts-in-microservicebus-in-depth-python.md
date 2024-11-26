---
layout: post
title:  "Developing Python Services in microServiceBus.com"
description: "This section will dive into the details of how to write a Service. Learn more about how you can enhance productivity through our Tips & Tricks."
categories: quickreference
order: 80
---

Before you read this post you should familiarize yourself with how flows and services in *microServiceBus.com* works. If you are not familiar with these concepts yet, please visit the [Getting started](../gettingStarted-list) first. If you're looking at creating **JavaScript** based services navigate to [Developing JavaScript Services in microServiceBus.com](../services-and-scripts-in-microservicebus-in-depth-js)

When you as a developer is writing a Python service to use in a flow, you are inheriting the *CustomService* object. This object has a few methods and properties that could help you develop your code. 

## Overall architecture
Your service is developed in the microServiceBus.com portal, added to a *Flow* and assigned a *Node* name or a Tag. When the *Node* signs in, it will download all assigned services including your custom services.

Once downloaded, the **Orchestrator** service will instantiate your service and call the **Start** method. When the *Node* is restarted or disabled, the **Orchestrator** service will call the **Stop** method. Whatever happens between these two calls is up to you.

The **Orchestrator** service has a queue, which is passed into the constructor of your service. This queue can be used to pass messages between your service and others. You can also subscribe to messages (events) from other services.

Apart from yours and other custom services, the Python agent also come with some built-in services which you might find useful, such as the **Logger** service

## Create a new Python service
Before we can start writing code, we first need to create our service. Navigate to the `Scripts & Services` page and click the `CREATE NEW` button.

1. Next you have the option of creating a service from scratch, importing from file or copying existing services. Select `CREATE NEW`.
2. Give your service a name, filename, description and select "Python file" from the Service type list. Notice that the extension of your filename changes to `.py`.
> Important! Your filename must match the class name of your service. For instance, if you file is "ReadGPIO.py" your class must be named "ReadGPIO". Since classes are usually named using `PascalCase`, this will also be true for your filename.
3. If you want to give the user of your service options, such as which GPIO pin to use you can add these dynamic properties in the **Static Properties** tab. You can later access these properties in your code using the `GetPropertyValue` method. More on this later.
4. Click `Edit` of the "0.1" version to open the code editor and start coding.

> Services are versioned. You can always update the version by selecting "Update minor" or "Update major" in the lower right corner of the code editor. 

5. Remove the sample code, and paste in the following:

```python
from queue import Queue
from base_service import CustomService

class YOUR_SERVICE_NAME(CustomService):
    def __init__(self, id, queue, config):
        # Write your code here
        super(YOUR_SERVICE_NAME, self).__init__(id, queue, config)
    
    async def Start(self):
        try:
            await self.Debug("Started")
            # Write your code here
        except Exception as ex:
            await self.Debug(f"Failed to start: {ex}")

    async def Stop(self):
        try:
            # Write your code here
            await self.Debug("Stopped")
        except Exception as ex:
            await self.Debug(f"Failed to stop: {ex}")

```

6. Update the name of your class, and continue coding ;)


## Required methods
* **Constructor**

  This would be a good place to instanciate properties.

* **Start**
  
  This method will be called when your node starts and your service has been downloaded. This can be the place to start an interval or set up an event listener. However, it's important to understand that other services might not be ready yet. For example, if you want to read GPIO events and send them to Azure, the Azure IoT Hub service migh not be ready yet. In such cases, you might be better of to start your GPIO listener in the `StateUpdate` method. More on this later.
  
  > **Tip!** Here's a great place to add all your PIP packages.

* **Stop**

  This function will be called when you disable or restart your Node. If you for example have a timer event, this would be where to stop it.  

  > **Tip!** Here it is recommended to stop your timers or clear your processes.

## Built in methods on the *CustomService* object

* **self.get_settings()**

  Returns all settings received when the Node signed in. This includes name of the Node among many internally used settings.
  
  `@parameters` : None

  `@returns` : dictionary 

  `@example`

  ```python
    self.settings = self.get_settings() # node settings received upon signin
    self.nodeName = self.settings["nodeName"]
  ```

* **self.GetPropertyValue(type, property_name)**

  Returns all dynamic properties defined in the `Static Properties` tab provided by the user.
  
  `@parameters` : type (string) either "static" or "security"

  `@returns` : value of dynamic property 

  `@example`

  ```python
    self.pin = self.GetPropertyValue("static", "gpio_pin") 
  ```

* **self.SubmitAction(destination, action, message)**

  *SubmitAction* is used to send messages between services and puts a message on the queue, managed by the *Orchestrator* which in turn transmitts the message to the destinated service.
  
  > The SubmitAction method requires you to have an understanding of the receiving service, such as which method should receive the message. There are other built-in method which are using the SubmitAction method underneth, but are designed for specific purposes, such as:
  > * self.Debug
  > * self.Warning
  > * self.ThrowError
  > * self.SubmitMessage

  `@parameters` : 
  * **destination** (string) *The name of the service to receive the message (lower case name + "_py"). Use wildcard (\*) for all services.*
  * **action** (string) *The name of the method on the destination service*

  `@returns` : None 

  `@example`

  ```python
    await self.SubmitAction("someService_py", "some_method", {"id": 42}})
  ```

* **self.Debug(message)**

  The *Debug* method transmits the messsage to the **Logger** service for Console output
  
  `@parameters` : message (string)

  `@returns` : None 

  `@example`

  ```python
    await self.Debug("Started")
  ```
  
* **self.Warning(message)**

  Same as `self.Debug` but is shown in yellow
  
  `@parameters` : message (string)

  `@returns` : None 

  `@example`

  ```python
    await self.Warning("Started")
  ```

* **self.ThrowError(message, fault_code = None, fault_description = None)**

  Errors are automaticly transmitted to the microServiceBus.com portal where used for alerts. Errors are also shown in the Console, but in red. 
  
  `@parameters` : message (string), fault_code (string), fault_description (string)

  `@returns` : None 

  `@example`

  ```python
    await self.ThrowError("Started")
  ```

  
* **self.SubmitMessage(message)**

  *SubmitMessage* transmits messages to the Azure IoT Hub Service
  
  `@parameters` : message (object)

  `@returns` : None 

  `@example`

  ```python
    await self.ThrowError("Started")
  ```

* **self.AddPipPackage(package, module, name)**

  Downloads the packages from PIP at run-time and return the type
  
  `@parameters` : 
  * **package** (string) *pip package E.g "azure-iot-device"*
  * **module** (string) *module name E.g "azure.iot.device.aio"*
  * **name** (string) *name of object E.g "IoTHubDeviceClient"*

  `@returns` : Type

  `@example`

  ```python
    MqttClient = self.AddPipPackage("paho-mqtt", "paho.mqtt.client", "Client")
    # is equivalent to:
    # pip install paho-mqtt
    # from paho.mqtt.client import Client
  ```

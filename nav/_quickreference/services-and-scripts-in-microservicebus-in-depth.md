---
layout: post
title:  "Services & Scripts in microServiceBus.com in depth"
description: "This section will dive into the details of how to write a Service. Learn more about how you can enhance productivity through our Tips & Tricks."
categories: quickreference
order: 80
---

This page is dedicated to those with a bit of prior knowledge regarding how flows and services in *microServiceBus.com* works. If you are not familiar with these concepts yet, please visit the [Getting started](../gettingstarted/) first.

When you as a developer is writing a service to use in a flow, you are extending the *microservice* object *microServiceBus.com* is exposing. This object has a number of functions and properties that could help you develop your code. First we will go through what is required in your own service, then what is available to you and lastly som best practices.

## Required functions

* **Start()**

  This function will be called when your node starts and your service has been downloaded.
  
  `@parameters` : none

  `@returns` : <_void_>

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

## Properties on the *microservice* object

## Functions on the *microservice* object

* **this.GetCurrentState()**

  Returns the "device twin" or "shadow" of the device from the connected IoT Hub.
  
  `@parameters` : none

  `@returns` : <_Object_>

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

## Best practices

Back to home page: [Home](/)
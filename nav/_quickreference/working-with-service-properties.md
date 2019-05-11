---
layout: post
title:  "Working with service properties"
description: "The service property window is where you define the characteristics of your service. All properties are divided into three categories; General, Static and Security properties."
categories: quickreference
order: 50
---
The service property window is where you define the characteristics of your service. All properties are divided into three categories; General, Static and Security properties.

While Static and Security properties are specific to each micro service, the General properties are generic and applies to all services.
## General properties

| Property        | Description |
 | -------------- |-------------|
| Name    | The name of the micro service. This name needs to be unique and will be used in the tracking. | 
| Description | A description of your service      |  
| Node |   The name of the node where the service is going to be executed. If there is no node with this particular name, it will be created as you save the flow.    | 
| Enabled| By disabling the service, it will not get started. |

## Dynamic values
Most properties can be set using dynamic expressions. For instance, the sample below shows Static properties for the File outbound service.
## Macros
While the Path property is staticly set, the File name property is set to _%guid%_. This is called a Marco, and is unique to certain services. For the File outbound service, this means the name is going to get a unique name.
## Using payload data
Sometimes you might want to use some value from the payload to set a property. In such cases we use brackets. In the sample above we are transmitting an order with a property called orderid. You can combine two or more properties such as **[firstName]_[lastName].json.**  

## Using context data

You can also use context variables, in which case use curly brackets as above.

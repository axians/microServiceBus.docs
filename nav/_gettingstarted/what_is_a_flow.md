---
layout: post
title:  "What is a Flow?"
description: A Flow defines the interaction between Micro Services, - A workflow that controls how messages gets sent from one service to another.
categories: gettingstarted
order: 30
---

Flows are entities responsible for orchestrating the execution of Services. 

Each instance of a flow, sometimes referred to as a *Itinerary*, holds state of all Services, [Variables]({{site.baseurl}}/what-is-a-flow#variables) and [Messages]({{site.baseurl}}/what-is-a-flow#message). While [Variables]({{site.baseurl}}/what-is-a-flow#variables) and [Messages]({{site.baseurl}}/what-is-a-flow#message) may change over the lifetime of the Flow, the structure remains immutable, meaning once started, -Services and their related connections will not change although updated in the portal.

## Create a flow
You create Flows by going to the Flow page using the menu or by using the short-key CTRL+R and type “flow”. Clicking the “Create new” button on the top of the page takes you to the a page where give your flow a name and description. Clicking the “Create” button takes you to the Flow details page, and will present you with the Flow designer:

<img src="{{site.baseurl}}/images/what-is-a-flow/1.png">

The Flow designer is made up of two parts; the toolbox and the designer. The toolbox shows all the Services created in your organization and Services that belongs to the *Root* organization which is not directly accessible to you, other than you have access to all its Services.

As you might remember from the [What is a Service?]({{site.baseurl}}/what-is-a-service) section, there are different kind of Services. Only three kind of Services are visible in the toolbox.

## The toolbox

### Inbound services
Inbound Services starts the Flow. These Services will always create the [Message]({{site.baseurl}}/what-is-a-flow#message) along with the context.

Inbound Services are often triggered on an interval or event such as reading a Modbus register every minute.

### Outbound services
Outbound Services receives [Messages]({{site.baseurl}}/what-is-a-flow#message) from Inbound- or Internal Services and are used to control meters and devices or transmitting [Messages]({{site.baseurl}}/what-is-a-flow#message) to IoT Hubs for example.

### Interval (or other)
Internal Services are generally used to manipulate [Messages]({{site.baseurl}}/what-is-a-flow#message) or [Variables]({{site.baseurl}}/what-is-a-flow#variables), such as transforming, batching or compressing [Messages]({{site.baseurl}}/what-is-a-flow#message).

## Flow execution

### Message
Each instance of a flow (itinerary) has ONE [Message]({{site.baseurl}}/what-is-a-flow#message) which might change over the course of the lifetime of the itinerary. [Messages]({{site.baseurl}}/what-is-a-flow#message) are often a JavaScript object but does not have to. 

### Routing
Connecting two Services instructs the orchestrator to pass the execution from one Service to the other. The default routing condition is 'true', meaning the [Message]({{site.baseurl}}/what-is-a-flow#message) will always take this route. 

However, you can set the routing condition by double-clicking the connection and set the **route** variable. Eg.

```javascript
var route = [Message]({{site.baseurl}}/what-is-a-flow#message).temperature > 30;
```
*Setting this condition means only route Messages to the destination if the temperature is more than 30 degrees.*

### Variables
Variables are available through the the whole execution of the itinerary and can be read or updated. However, you need to create them prior to using them. Click the "VARIABLES" button at the bottom to add variables.

>
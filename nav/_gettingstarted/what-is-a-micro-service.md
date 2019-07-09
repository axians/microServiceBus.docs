---
layout: post
title:  "What is a micro Service?"
description: Learn more about how to use micro services for receiving, processing and transmitting messages to and from other services. Learn about the different types of services and how use them in different scenarios.
categories: gettingstarted
order: 40
---

A micro service is a part of a larger more complex solution, with a specific role. The service may be of different types where the most common types are:

* **Inbound Service**  | Responsible for retrieving data or events. Or simply trigger a flow based on time, custom logic, etc.
* **Outbound Service** | Responsible for delivering data to another service/party or controlling locally connected systems.
* **Internal Service** | Responsible for processing & transforming data, as well as forwarding data to another service/party.

In microServiceBus a micro service is used in one or several [flows]({{site.baseurl}}/what-is-a-flow).

microServiceBus.com provides a large set of services out of the box, that you may use **freely** in your flows.

## How to create a micro service

Navigate to the main menu and select **Scripts & Services**. Click the button **Create New** and select
1) **Create New**, to start from scratch creating a service.
2) **Import from file**, if you have previously downloaded a service locally to your machine.
3) **Copy from**, to start from an already existing *service*

`In this example you're going to start from scratch with 'Create New'`.

Next, we'll need to give the service a name, a description and select what kind of service.

```
Name:         'MyGoodOldTimer'
File name:    'myGoodOldTimer.js' [auto-generated]
Description:  'I trigger all the time.'
Service type: 'One-way inbound service'
```

and press **Create**...

In the new window (*Edit Service Script*) you can now:
1) Provide a suitable image/icon for your service - **Image URI**
2) Add *properties* to your service to allow a re-usable configurable service, in multiple flows. - **Static/Security Properties**
3) Edit the service code **Edit** (top the top right)

For now we'll simply press **Edit** (top right) and edit our service template.

We will only make a small modification to the template service and provide an additional JSON key/value **"hello:World"** and lower the trigger interval to every **5** second.

Update the upper part of the service to match:
```javascript
    Start: function () {
        self = this;

        // The timer event is used for creating message on a 
        // scheduled interval. In this case every 10 seconds.
        timerEvent = setInterval(function () {

            // TO DO! 
            // This is where you add code to read a sensor
            // and create a payload message.
            let payload = {
                hello: 'World', // ADDED
                someRandomValue: Math.random()
            };

            // Submit payload to Node.
           self.SubmitMessage(payload, 'application/json', []);
        }, 5000); // CHANGED, number of milliseconds between
                  // messages being submitted to the next service in flow.
    },
```

Since we're doing a minor change to the flow we'll choose **Update minor** in drop-down to the botton right.

Now, press **Save** and let's celebrate your first custom service! :-)

You now have the '**MyGoodOldTimer**' service avaliable in the **Toolbox**, when modeling your flow (see below)!

Continue on to how flows work to realise logic [Introduction to flows]({{site.baseurl}}/what-is-a-flow)

Documentation in **more depth** on writing scripts can be found at [Microservices in depth]({{site.baseurl}}/services-and-scripts-in-microservicebus-in-depth)

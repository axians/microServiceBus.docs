---
layout: post
title:  "What is a Node?"
description: The node is where the magic happens, and is the place where all micro Services are hosted. Learn about the different kind of hosts and what platforms they can run on.
categories: gettingstarted
order: 20
---

With an understanding of what a [Micro Service]({{site.baseurl}}/what-is-a-micro-Service) is, it’s time to look at the Node.

The Node is the agent running on your gateway or device. It is connected, owned and managed by an [Organization]({{site.baseurl}}/what_is_an_organization). The Node is responsible for starting and stopping [Flows]({{site.baseurl}}/what_is_a_flow) and [Services]({{site.baseurl}}/what_is_a_micro-Service).

-Essentially, the Node is where everything get processed. Every Service has a property called "Node", which tells you where the Service is going to be executed, which could be any or all Nodes, regardless of location or platform.

For instance, in the sample below we have a Flow, which describes the interchanges of the message. In this sample we have three Services; an **Inbound FILE Service**, a **JavaScript Service** and a **Outbound Azure Send Event Service**.

<img src="{{site.baseurl}}/images/what_is_a_flow/1.png">

*These Services can all run on the same or on different Nodes. In the sample above, all Services are run on the same Node.*

When a file is save in a specific folder, the **Inbound FILE Service** will pick it up, create a [Messages]({{site.baseurl}}/what-is-a-flow#message) and pass it back to the Node orchestrator. The Node will attach the Flow definition to the Message and check to see if the next Service in line (the **JavaScript Service** in this case) is hosted on the same Node. If this is the case, as in our sample, the Service will just pass the Message to the next Service without ever leaving the Node. If Services are configured to be executed on different Nodes, the Node will send the Message to microServicebus.com, which in turn will re-direct the Message from the first Node to the Node hosting the next Service in line.

> To send a Message from one Node to the other as in the sample above, you'd need to enable the "Allow send" on properties window of the first Node.

## Node properties
You access the Nodes properties through the Action button on each Node on the Nodes page, and there are many properties that might be important:

### Common properties

| Property | Description |
|-------|--------|
| **Tags** | Tags can be used as groups of Nodes and can be used in Flows to address which Nodes the Flow should run at. |
| **Mode** | There are three Modes; Normal, Maintenance and Test. Setting a Node in Maintenance Mode will prevent it from reporting errors. The Test Mode is required for running [Site Verification Tests](site-verification). |
| **Bind to** | The *Bind to* property is used to simplify the transition from Stage to Production Flows  |
| **Port** | If your Node is hosting REST services, this will be the port used. Make sure the port is not already used on the device. |
| **Protocol** | Different IoT Hub vendors support different protocols, with different capabilities. Make sure the chose the appropriate protocol. |
| **Lock to machine** | If enabled, this Node will never be able to be started from a different device. |
| **Retention period** | The number of seconds to store history data on the node. The persisted history can later be played back and sent from the node. Messages and events are only persisted provided there is more than 25% free disk space in the home directory. |

### Policies properties
Disconnect policies are very important, and dictates when a device is considered off-line and what action to take.

| Property | Description |
|-------|--------|
| **Heartbeat timeout** | Heartbeat timeout refers to the elapsed time between each heartbeat. |
| **Heartbeat limit** | Number of missed heartbeats before concluding the Node is in Disconnected state and taking Disconnected action (see below).. |
| **Disconnected action** | Disconnected action refers to what you'd like to do if the Node becomes offline. Restart means the process will restart, and Reboot will restart the whole device. |
| **Reconnected action** | When the Node recover from losing internet connection without entering Disconnected state (reconnected within the heartbeat interval), you can choose Update to force the node to download latest configuration (Flows, Services and configuration) or just continue as normal. |
| **Offline mode** |Enabling this option allows to Node to start in offline mode, using any pre-fetched configuration.. |

## Get Node environment information
Clicking the *ENVIRONMENT* button will present you with valuable information such as Networks, CPU, Memory and environment variables.

## Get and manage Node State
Most IoT platforms respects the notion of State. Microsoft calls it Device Twin, whereas Amazon calls it Things Shadow. In both cases it is a JSON document that represents the State of the Node. 

Click the *DEVICE STATE* button to review and change the State.

## Audit logs
See the [Reviewing the Audit log]({{site.baseurl}}/reviewing-the-auditlog) section.

## Retrieve system logs
By clicking the *RETRIEVE SYSLOG* button a call is sent to the Node to compress and submit syslogs to the portal. These logs can be downloaded from the **Logs** tab.

## Running Nodes on different platforms

Nodes are running on the [Node.js platform](https://nodejs.org), and as such is supported on every platform node.js is working on, which luckily is most of them. For more information about Node.js, please visit [nodejs.org](https://nodejs.org)
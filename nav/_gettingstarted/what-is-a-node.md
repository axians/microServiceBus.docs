---
layout: post
title:  "What is a Node?"
description: The node is where the magic happens, and is the place where all micro services are hosted. Learn about the different kind of hosts and what platforms they can run on.
categories: gettingstarted
order: 20
---

With an understanding of what a micro service is, it’s time to look at the Node.

The Node is where everything get processed. Every service has a property called “Node”, which tells you where the service is going to be executed, which could be anywhere, regardless of location or platform.

For instance, in the sample below we have a "flow", which describes the interchanges of the message. In this sample we have three services; an Inbound FILE service, a JavaScript service and a Outbound Azure service. alt text

These services can all run on the same or on different Nodes. In the sample above, all services are run on the same Node.

When a file is received, the Node will attach the Flow definition to the message and check to see if the next service in line is hosted on the same Node. If this is the case, as in our sample, the service will just send the message to the next service without ever leaving the Node. If services are run on different nodes, the Node will send the message to microservicebus.com. The site knows about all connected Nodes, and will re-direct the message from the Node to the Node hosting the next service in line.

When the Node has run the file inbound script it will proceed to send it to the JavaScript service. After running its script, the JavaScript service will forward the message to the Outbound SMTP service.

### Running Nodes on different platforms

Each node is running in node.js, and as such is supported on every platform node.js is working on, which luckily is most of them. For more information about nodejs.org, please visit [nodejs.org](https://nodejs.org)
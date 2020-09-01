---
layout: post
title:  "Using the Node terminal"
description: "The Node terminal gives users a remote ssh session to the Node. This can be very helpful in times where you need full control of the gateway."
categories: quickreference
order: 40
---

The Node terminal gives users a remote ssh session to the Node. This can be very helpful in times where you need full control of the gateway.

# Accessing the Node terminal
The Node terminal is only available to **Organization Owners**, and can be accessed either through the *ACTION* menu on the *Node* page or by hitting CTRL+R and type:
```bash
ssh [node name]
```

<img src="{{site.baseurl}}/images/using-node-terminal/1.png">

# IMPORTANT
As you open the terminal, you are logged in as the same user as the *microservicebus-node* service is running with. Depending on your setup, this might only give you limited privileges.

Also, the back-end of the terminal is hosted by *microservicebus-node* process. If you kill this process, -you terminate the terminal session.

### Be careful, and remember
## -With great powers comes great responsibilities!
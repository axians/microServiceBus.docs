---
layout: post
title:  "Remote debug your microservices"
description: "There are times when there is no substitute to stepping through the code line-by-line. Learn about how to enable remote debugging on your device."
categories: quickreference
order: 60
---

## Remote debug your microservices

Microservicebus does not include a specific tool for code debugging, it instead offers the possibility of remote debug using Chrome developing tools.

In order to debug remote, the node must be online. You will find the option by clicking on the *Actions* button, then select *Debug* under *More options*.

<img src="{{site.baseurl}}/images/remote-debug/RemoteDebug1.png">

A message window will be displayed with two options: Start and Stop Debug. *Start Debug* is for initiating the debugging process. That implies the node going into a inspection mode, hence starting a listener event. 
For this reason, it is important to click on the *Stop Debug* right after you are done with your work. Or else the link to DevTools will still be active and anyone having access to it will also have direct access to your node. 

<img src="{{site.baseurl}}/images/remote-debug/RemoteDebug2.png">

<img src="{{site.baseurl}}/images/remote-debug/RemoteDebug3.png">

You will be provided with a link which you can open in your web browser to access to your Node in Chrome DevTools. 
The services in the active flows your node is running will appear in the folder path under *Sources* > *Page*. The developing tools will enable you to walk through your code's execution by setting breakpoints and checking variable values.

<img src="{{site.baseurl}}/images/remote-debug/RemoteDebug4.png">

Now you have full access to your device!

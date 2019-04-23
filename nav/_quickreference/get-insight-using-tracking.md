---
layout: post
title:  "Get insight using tracking"
description: "Sometimes the Console output is not enough, and you need more insight to what messages and meta data is looking like. If this is the case, look no further."
categories: quickreference
order: 50
---

Though [the Console]({{site.baseurl}}/using-the-onsole) can give you valuable understanding of the execution of your Services, it might not provide insight to your overall process and messages. -This is where Tracking comes to rescue. 

When enabling Tracking for a Node, the message along with its context for **every executed Service** will be transmitted to the Tracking database of microServiceBus.com. The data will be automatically deleted after 30 days, but is the single exception to storing content- (payload) and context data (meta data) in microServiceBus.com. Apart from this exception, sensor and meter data sent to the IoT Hub never passes microServiceBus.com.

That being said, it's a valuable tool when identifying and resolving issues.

## Enable Tracking
By default, Tracking is disabled, and you should always remember to disable it when your are done as Tracking will add extensively to your data usage.

To enable the Tracking, navigate to the Nodes page, and simply toggle the Tracking button of the Node you'd like to work with.

<img src="{{site.baseurl}}/images/get-insight-using-tracking/1.png">

## View and query Tracking
Navigate to the *Management* page using the menu, click the Tracking tab at the top. If your Node has executed any Services since you enabled Tracking you should see a list of events:

<img src="{{site.baseurl}}/images/get-insight-using-tracking/2.png">

Each line represent one execution of your Flow. Select one of the instances by clicking the *View Details* button.

<img src="{{site.baseurl}}/images/get-insight-using-tracking/3.png">

This takes you to a new window, showing a snapshot of the state after each Service executed. The first tab shows you where in the flow the snapshot was captured. The other tabs reveal any errors, what the payload (content) looks like but also variables and metadata (context). 
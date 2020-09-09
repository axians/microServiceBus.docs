---
layout: post
title:  "Data Visualizer"
description: "Visualize data"
categories: quickreference
order: 30
---
# Add visualization to your datapoints

Start by adding the Grafana outbound service to your flow

<img src="{{site.baseurl}}/images/data-visualizer/1.png">

Double-click the Grafana service and go to Static Properties

<img src="{{site.baseurl}}/images/data-visualizer/2.png">

Change the properties to map your data.
- Data field is the field containing the sensor value
- Date field is the field containing the datetime in epoch time(milliseconds)
- Label field is the field containing the name of the value. Eg. TemperatureSensor14 
The label field will show in the graph containing the value. Eg. TemperatureSensor14 - 23.4 C


In the menu, go to Data Visualizer to see your data.



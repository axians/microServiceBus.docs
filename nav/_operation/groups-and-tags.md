---
layout: post
title:  "Grouping and tagging Nodes"
description: "Grouping Nodes by tags is a powerful way to target your Services to many Nodes."
categories: operation
order: 40
---
Tags are commonly used when you want to address an action on many *Nodes* such as when patching *Nodes* through the API, or as group when developing *Flows* that should run on multiple *Nodes*.

## Using tags with Flows
Tags can be set on both *Nodes* and *Flows*. There are a few tags that are built-in such as #ALL and #BETA, but generally you'd create your own tags.

For example, lets assume you create a flow that should read and transmit the current state of a heat pump. Lets also assume you'd be reading the values from the heat pump using Modbus.

If every *Node* in your *Organization* is connected to a heat pump and you want the same *Flow* to execute an all *Nodes*, you would set the *Node* attribute of the first (inbound) *Service* to **#ALL**:

<img src="{{site.baseurl}}/images/groups-and-tags/1.png">

*The **#ALL** tags, as the name implies, causes the this Flow to run on all Nodes*

An other scenario would be where not all *Nodes* are connected to heat pumps, and you only want the flow to execute on a sub-set up *Nodes* within the *Organization*. It could also be that some of your *Nodes* are using a different manufacture of heat pumps, which in turn might require a different *Flow/Service*. In such cases, you'd be better off using a custom tag such as **#NIBE-F2120**:

<img src="{{site.baseurl}}/images/groups-and-tags/2.png">

## Using tags with API's
You can patch individual *Nodes* from the the Node page in the portal, but when you want to patch many *Nodes*, this approach is not efficient. In such cases you are better off using the API. For instance if you want to update the firmware on many *Nodes* you should use the Update Firmware API (/api/organizations/{id}/tags/{tag}/updatefirmware), where {id} is the Id of your *Organization* and the {tag} is the used to filter the *Nodes*.

Again, if you want to update all the *Nodes* use the #ALL tag:
```
PUT /api/organizations/{YOU ORG ID}/tags/ALL/updatefirmware
```
While if you are a bit more cautious, you might consider rolling the update per region:
```
PUT /api/organizations/{YOU ORG ID}/tags/BERLIN/updatefirmware
```
*The last sample assumes you have a number of Nodes with "BERLIN" tag set.*

## Applying tags on Nodes
Tags can be applied to *Nodes* from the Node Property page:

<img src="{{site.baseurl}}/images/groups-and-tags/2.png">

You might also consider using the API:
```
PUT/POST /api/organizations/{id}/nodes/{name}/tags
```

## Setting microservicebus-core version
The majority of the *Node* is defined in a package called microservicebus-core, and you can set the preferred version at the *Organization* page. However, sometimes you might want to test one or two *Nodes* with the BETA release before updating all *Nodes*. To do this, you can tag the *Node* with **#BETA** or **#EXPERIMENTAL**. After restarting the *Node* the microservicebus-core component will update to BETA or EXPERIMENTAL release.

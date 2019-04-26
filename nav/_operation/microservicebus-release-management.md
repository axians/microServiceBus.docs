---
layout: post
title:  "microServiceBus.com release management"
description: "This section will teach you about the agent architecture of microservicebus-node and microservicebus-core. It will provide you details on how to manage and control versioning."
categories: operation
order: 20
---

**microServiceBus.com** (portal) along with agent packages; **microServiceBus-node** and **microServiceBus-core** are normally release as:

* **microServiceBus.com** – Every 2-3 weeks
* **microServiceBus-node** – 2-4 times a year
* **microServiceBus-core** – Every 2-3 weeks

## microServiceBus.com
New releases of the public portal (https://microServiceBus.com) are initially released to the developing environment (DEV) dev.microServiceBus.com, which is publicly available with no connection to the production data. This environment is predominantly used for developing and integration testing.

Once testing is complete, changes are replicated to the STAGE environment (stage.microServiceBus.com). This environment is connected to the same data source as the production environment and should be used for acceptance testing. When code is submitted to the STAGE branch, ALL stage environments are affected **including private and self-hosted, environments.**

Once acceptance testing is complete, PROD and STAGE environment are “swapped”, meaning IP addresses of https://microServiceBus.com and https://stage.microServiceBus.com are swapped leaving the STAGE environment in “last working state” and can be used as backup should issues be found in a later state. 

The process of swapping PROD and STAGE for private and self-hosted environments are done upon acceptance of the customer. It is however recommended to update at least once a month.

## Custom microServiceBus-node and microServiceBus-core repos
Depending on the underlying architecture of the hardware, updates of the mSB-node can be handled differently. If, for instance, the mSB-node package is running in a Ubuntu Snap or a Docker container the updates of these packages are handled either manually or automatically along with the selected infrastructure. 

Should a customer want to have control over the releases of mSB-node, they can choose to fork the microServiceBus-node github repo and/or publish their forked repo as a custom npm package. Following this pattern, customer can choose when they decide when to publish new releases. 

Worth pointing out, that although this options gives the most control, it also requires a great deal of insight.


## Lock version of microServiceBus-core 
Organizations can also control the version of microServiceBus-core using the settings on the [Organization](https://microservicebus.com/Organizations/Details). The *Node Version* setting can be set to either **latest**, **beta**, **ignore** or a specific version.
* **latest** means all *Nodes* in the *Organization* will always try to download the latest stable version of mSB-core on startup
* **beta** means all *Nodes* in the *Organization* will always try to download the beta version of mSB-core on startup
* **ignore** means mSB-core version will not be evaluated on startup
* **version** eg 1.3.0 means *Nodes* will try to download this specific version of mSB-core on startup

Normally, organizations would choose **latest** or a specific version for their production environment, however if you’d like to test the beta version on one or a subset of nodes, you can tag the node with **BETA** on the *property* page of the node.

## Managing Service and Script versions.
Once your *Flow* are in production we recommend locking the version of each *Service* by opening the property window of each *Service* and check the “Lock to version” checkbox. This will make sure the specific version of the *Service* is used, regardless of if it has been updated.

Sometimes we need to test an update of a *Service* in production, while making sure other *Nodes* are still using the last stable version. This is common in scenarios where a *Flow* is used by many *Nodes* using tags. In such cases, a specific tag is applied to one or more nodes, such as “Amsterdam”, and rather than configuring a *Service* run on a specific *Node*, you’d use the tag instead (#Amsterdam).

However, using tags this way will force all *Nodes* using the same version of the *Service*. -If you want to run one of the nodes on the latest version, you can apply the “BETA” tag to the node, in which case it will always ignore the “Lock to version” setting

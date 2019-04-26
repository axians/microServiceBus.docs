---
layout: post
title:  "What is microServicebus.com?"
date:   2019-04-19 20:22:33 +0200
categories: general
permalink: /what-is-msb
---

Ultimately, microServiceBus.com is designed fill the gap between the out-of-the box device management provided by vendors such as Microsoft, Amazon and IBM, and what is required by the enterprise. 

It aims to address common challenges in the industry of IoT, such as planning for change, steep learning curves and provisioning of new devices. 

*microServiceBus.com* is a platform based on agents, also known as *Nodes*, running on gateways and controlled from a portal known as microServiceBus.com. 

microServiceBus.com and all related products and services are owned by AXIANS IoT Operation and is part of VINCI-Energies


## Provisioning and on-boarding
On-boarding new devices is difficult at scale. Gateways needs to automatically get assigned a cloud identity, receive keys and certificates. -All in a highly secure manner.
microServiceBus.com provide a scalable, cross cloud vendor solution based either on integration with SIM card management tools like Cisco Jasper or MAC address white-listening.

For more information:
* [Install your first gateway]({{site.baseurl}}/installing-microservicebus-node)
* [On-boarding and Provisioning using Cisco Jasper]({{site.baseurl}}/integrate-sim-card-management)


## Updates and patching
No part of any system will stand the test of time. Software is constantly updated to align with security threats or new required features.
Update and patching are easily handled through microServiceBus.com, either through replacing entire firmware or individual services. Updates can be done manually or through scheduled tasks, for single, all or groups of devices.
Easy deployments to IoT devices make ways for Agile development!

For more information:
* [What is a micro service?]({{site.baseurl}}/what-is-a-micro-service)
* [Running microServiceBus-node on a yocto image]({{site.baseurl}}/running-microservicebus-node-on-a-yocto-image)
* [microServiceBus.com release management]({{site.baseurl}}/microservicebus-release-management)


## Source code management
Source code and services are not only deployed to devices, but needs to be audited and versioned to ensure the end-to-end business process.
With complete insight and traceability, code can be fully managed and versioned within the microServiceBus.com portal. However, we also integrate with Git repositories such as GitHub and Azure DevOps.


For more information:
* [What is a micro service?]({{site.baseurl}}/what-is-a-micro-service)
* [Working with external source code providers]({{site.baseurl}}/working-with-external-source-code-providers)

## Find and resolve issues
Identifying and resolving problems can be a difficult mission in any system, but spread over many thousands of remotely located units brings it to a whole other level!
microServiceBus.com provides great insight to what is and has happened on the device. Through it’s tracking capabilities, developers and operation staff can gain understanding of what is happening, and even remotely debugging the code, and instantly deploy fixes.

For more information:
* [Using the *Console*]({{site.baseurl}}/using-the-console)
* [Get insight using tracking]({{site.baseurl}}/get-insight-using-tracking)
* [Remote debug your *microservices*]({{site.baseurl}}/remote-debug-your-microservices)


## API and Integration
microServiceBus.com extends to a complete Application Lifecycle Management system through its integration with 3rd party vendors, and continues to expand through its extensive API.
As of today, microServiceBus.com integrate with ServiceNow for Issue, problem- and release management, allowing customers to align their existing service desk and Nightly Operation Center (NOC). Integration with Cisco Jasper makes way for a compete SIM card management, along with GitHub, Azure DevOps, Active Directory and more.


For more information:
* [Integrate SIM card management]({{site.baseurl}}/integrate-sim-card-management)
* [Working with external source code providers]({{site.baseurl}}/working-with-external-source-code-providers)
* [Integrate external ticketing system (ServiceNow)]({{site.baseurl}}/integrate-external-ticketing-system)
* [microServiceBus API]({{site.baseurl}}/using-microservicebus-api)

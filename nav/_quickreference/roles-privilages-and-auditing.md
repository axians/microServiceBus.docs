---
layout: post
title:  "Roles, privilages and auditing"
description: "Roles, privilages and auditing"
categories: quickreference
order: 55
---
*Users can become members of an Organization by either creating the Organization or by being invited to the Organization by an owner. 
User security and privileges are managed through Roles. Significant actions such as changing Organization settings or deleting a Node are subjects of Audit logging.*

## Roles & privileges
microServiceBus.com comes with two roles; Owner and Co-administrator. As a rule of thumb, a Co-administrator can do everything except managing users and the Organization. Co-administrator are also prevented from Claiming Nodes, grant themself access to Nodes and use the remote terminal, although these privileges can be changed by an Owner.

### Privileges reserved to Owners are:
* Change settings of Organization such as Name, Description
* Change SLA and Cost center
* Change behavior for whitelist provisioning
* Manage Alerts
* Manage Teams including invites
* Manage Service Now integration
* Manage Active Directory integration
* Change IoT Hub provider
* Manage Node agent version
* Manage GitHub and Azure DevOps integration
* Manage Cisco Jasper integration
* Manage SystemCORP integration
* Store and view Node root passwords

### Audit logs
* Changes to entities below are all subject to Audit logs:
* Organization settings
* Node settings and actions
* Flows
* Service & Scripts
* Firmware images 

[More informaiton about how to access Audit logs](https://docs.microservicebus.com/reviewing-the-auditlog)



---
layout: post
title:  Integrate external ticketing system (ServiceNow)
description: microServiceBus.com is not the tool for first-line support. Luckily it integrates with ServiceNow enabling a complete ITIL process with Issue tracking, Problem management and Release management.
categories: integration
order: 30
---

[ServiceNow](https://www.servicenow.com) was a software-as-a-service provider, providing technical management support, such as incident- asset- and license management, to the IT operations of large corporations, including providing help desk functionality. The company's core business revolves around management of "incident, problem, and change" IT operational events.

microServiceBus.com integrates with ServiceNow to delegate incidents to service desks and NOC's (nightly operation center). ServiceNow also extends microServiceBus.com by providing automation capabilities for handling things like restarting Nodes. But more importantly ServiceNow really takes off where microServiceBus.com ends by escalating incidents to designated resources along with solid ITIL processes further extended to problem and release management.

## Enable integration with [ServiceNow](https://www.servicenow.com) 
1. Navigate to the Organization page and Click **Edit** at the button of the page
2. Scroll down to the ServiceNow section and fill in the *Instance*, *Company ID*, *User name* and *Password*. 
> For better audit visibility, we recommend using a designated API user
3. Click **Save**
4. If you already have existing Nodes, click the **SYNCRONIZE CI's** button which will create *Configuration Items* (CI's) for all your existing Nodes

## How does it work?
With the integration set up, all Nodes are represented as *Configuration Items* (CI's) meaning any incident or problem will always be linked to the CI. This also gives you a great history view where you might find patterns of problems related to specific Nodes.

### Default Issues
By default, any *Off-line* node will be reported in ServiceNow as an incident together with any *Unhandled* exception. *Off-line* nodes however, will not get escalated until the connectivity has been verified again which by default happens ten minutes after the incident was reported. This is to mitigate Nodes that are connected using 2G/3G/LTE where short disconnected periods are common.

### Custom Issues
Although it's important to handle *Off-line* nodes, organizations often need to handle their own errors and exceptions. For instance, imagine a sensor reporting low battery or a heat pump reporting high pressure. These are not exceptions related to the platform, although it's very important that such incidents gets escalated to ServiceNow.

To handle custom issues, navigate to the *Organization* page, scroll down to the ServiceNow section and click the **MANAGE INCIDENT POLICIES**. As you can see in the list of *Incident policies*, you already have *Unhandled Exceptions* and *Node is offline*. 
1. Click the **Add new record** button and provide a error code and a description
2. Click **Save** and close the window.
3. Navigate to your *Service*, open the script and scroll to the section where you'd identify the problem. Use the following code to escalate the issue:

```javascript
this.ThrowError(null, [your error code], [description])
```
If you're calling this from a **Process** function, you may add the context variable as the first parameter.


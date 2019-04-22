---
layout: post
title:  "What is an Organization?"
description: Learn more about how to use micro services for receiving and transmitting messages to and from other services. Learn about the different types of services and how use them in different scenarios.
categories: gettingstarted
order: 1
---

Organizations separates ownership of artefacts (see Flows, Services and Nodes). This is also where you manage users and integration with ServiceNow, Cisco Jasper, Azure DevOps, GitHub and more.

## Manage users
There are two roles within your *organization*; **Owners** and **Co-Admins**. Only owners can do user administration and moving *nodes* between *organizations*.

To add a user to your *organization*, go to the **Organization** page and click the "ADD CO-ADMIN" button. Provide the email address of the person you'd like to invite. The invited person will then get an email with instructions of how to register and join the *organization*.

If the invited person already have an account, he or she can go the the **Organization** page of any *organization* to accept the invite.

## ADFS integration
ADFS is a standards-based service that allows the secure sharing of identity information between trusted business partners (known as a federation) across domains. The ADFS integration allows for people in your organization to authenticate themselves using your organization’s ADFS. By setting up integration with ADFS you’re essentially telling microServiceBus.com to trust your domain.

Should you prefer having users signing in with an Active Directory account, you can provide necessary settings on the **Organization** page.

For more information:
* [Working with external source code providers](https://axians.github.io/microServiceBus.docs/nav/integrations/source)
* [On-boarding and Provisioning using Cisco Jasper](/microServiceBus.docs/nav/integrations/jasper)
* [Integrate external ticketing system (ServiceNow)](/microServiceBus.docs/nav/integrations/servicenow)

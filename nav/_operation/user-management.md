---
layout: post
title:  "User management"
description: "You are not alone! Learn more about how to manage you team, like roles and invites."
categories: operation
order: 10
---

Sharing is caring, and that goes for your organizations as well. Time to go through different user scenarios for your organizations.  

## User Roles

There are two roles within your *organization*; **Owners** and **Co-Admins**. Only owners can do user administration and moving *nodes* between *organizations*.

To add a user to your *organization*, go to the **Organization** page and click the "ADD CO-ADMIN" button. Provide the email address of the person you'd like to invite. The invited person will then get an email with instructions of how to register and join the *organization*.

<img src="{{site.baseurl}}/images/user-management/1.png">

If the invited person already have an account, he or she can go the  **Organization** page of any *organization* to accept the invite.

Note in the picture above that once you have added a **Co-Admin** to your *organization* you now have the option to assign the **Owner** role to that user. You need to be *owner* of an *organization* to assign the *owner* role. Once you have assign the *owner* role to a user it can't be reverted by you, only the user in question can remove the role assigned to them.

## ADFS integration

ADFS is a standards-based service that allows the secure sharing of identity information between trusted business partners (known as a federation) across domains. The ADFS integration allows people in your organization to authenticate themselves using your organization’s ADFS. By setting up integration with ADFS you’re essentially telling microServiceBus.com to trust your domain.

Should you prefer having users signing in with an Active Directory account, you can provide necessary settings on the **Organization** page.

Once you have klicked the *Edit* button on the **Organization** page you will have to edit these fields:

<img src="{{site.baseurl}}/images/user-management/2.png">

Once the correct information is applied, you should now be able to login with your Active Directory account. Don't forget to invite your Active Directory account before you try to login with it.
---
layout: post
title:  "Active Directory integration (Single Sign On)"
description: "Sign in to microServiceBus.com using your own identity provider"
categories: integration
order: 11
---
Through the `Active Directory feature` you can bring your own identity provider allowing your users a single sign one experience. 

Federated identity allows authorized users to access multiple applications and domains using a single set of credentials. It links a user’s identity across multiple identity management systems so they can access different applications securely and efficiently.

When organizations implement federated identity solutions, their users can access web applications, partner websites, Active Directory, and other applications without logging in separately every time.

Federated identity – also known as Federated Identity Management (FIM) – works on the basis of mutual trust relationships between a Service Provider (SP) such as an application vendor and an external party or Identity Provider (IdP).

The IdP creates and manages user credentials and the SP and IdP agree on an authentication process. Multiple SPs can participate in a federated identity agreement with a single IdP. The IdP has mutual trust agreements with all these organizations.

> Although you can integrate with Active Directory using ADFS, we recommend using Open Id as described below. Information about integration using ADFS is available [here](https://docs.microservicebus.com/integrate-with-aad)

## Set up federated security using Azure Active Directory

### Create an App registration
1. In the Azure portal navigate to the Active Directory. Select `App registrations` from the menu and click the "New registration" button
2. In the name type "microServiceBus.com". Leave the supported account type as "Single tenant" and set the `Redirect URI` to "WEB" and "https://[Your mSB instance URI]/signin-oidc/[Your organization]. E.g.
```
https://kramerica-industries.microservicebus.com/signin-oidc/kramerica-industries
```
3. With the App registered, navigate to the `Authentication` menu option and check the "ID tokens (used for implicit and hybrid flows)" option
4. Navigate to the `Certificates & secrets` menu option and create a new `Client secret`. **Copy the secret value**.
5. Navigate to the `Token configuration` menu option and Client the "Add optional claim" button. Mark the "ID" option and select the following claims:
* email
* family_name
* given_name
* upn

### Set up Azure Active Directory feature

1. Back at microServiceBus.com, navigate to the *Organization page* and edit the Active Directory feature.
2. In the "Open Id and Azure Active directory" section, click "Add new record". Fill in the following:

| Column        | Description |
| --------------|-------------|
| **Domain** | The name of your domain found at the "Overview" section under "Primary domain" in your Azure Active Directory |
| **Email domain**| Usually the same as the Domain, but the domain used of the emails |
| **Name** |The organization name you used when you set up the `Redirect URI` in the first step|
| **Tenant Id** | The tenant identifier found at the "Overview" section of your Azure Active Directory |
|**Client Id**|Copy the "Application (client) ID" from the App registration |
|**Client secret**|The secret you copied in step 5 in the previous section|


Finish by hitting the "SAVE" button

> **IMPORTANT** These settings will not have effect until the site is restarted. Please notify your microServiceBus.com contact.



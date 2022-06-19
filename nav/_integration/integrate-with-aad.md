---
layout: post
title:  Integrate with Azure Active Directory using ADFS
description: microServiceBus.com is not the tool for first-line support. Luckily it integrates with ServiceNow enabling a complete ITIL process with Issue tracking, Problem management and Release management.
categories: integration
order: 30
---

[Azure Active Directory](https://azure.microsoft.com/en-us/services/active-directory/) The Azure Active Directory (Azure AD) enterprise identity service provides single sign-on and multi-factor authentication to help protect your users from 99.9 percent of cyber security attacks.

## Register a new application using the Azure portal
1.	Sign in to the [Azure portal](https://portal.azure.com) using a work account.
2.	If your account gives you access to more than one tenant, select your account in the top right corner, and set your portal session to the Azure AD tenant that you want.
3.	In the left-hand navigation pane, select the Azure Active Directory service, and then select **App registrations** > **New registration**.
4.	When the Register an application page appears, enter your application's registration information.

- **Name** – *example:* microServiceBus-AD-Integration

- **Supported account types** – Single tenant accounts.

5. Click **Register**

<img src="{{site.baseurl}}/images/integrate-with-aad/1.png">

## Retrive Endpoint
1. When the Application registration is completed. Click on **Endpoints**

<img src="{{site.baseurl}}/images/integrate-with-aad/2.png">

2. Copy the **Federation metadata document** url. (Clicking the copy button at the right will copy the url)

<img src="{{site.baseurl}}/images/integrate-with-aad/3.png">

## Setup integration for microServiceBus instance
1. Go to https://instancename.microservicebus.com and login.
2. Navigate to the **Organization** page and Click **Edit** at the bottom of the page
3. Scroll down to the Federation section and fill in the *Provider*, *Account domain* and *Metadata address*. 

- Provider: *Name of your company*

- Account domain: *The suffix of your organizations emailaddresses (example: company.com)*

- Metadata address: *Paste the url copied from Azure Portal*

4. Scroll down and **Save** the changes.


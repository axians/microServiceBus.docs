---
layout: post
title:  "Using microServiceBus API"
description: "The microServiceBus API hosts many of the operations otherwise available through the UI, allowing other applications to interact with Nodes and Meters."
categories: integration
order: 0
---

The microServiceBus API hosts many of the operations otherwise available through the UI, allowing other applications to interact with Nodes and Meters. 

In many cases, the API is used from the **Business Operation** allowing them to configure and interact with *nodes*, meters and sensors. **Business Operation** generally work more with configuration tasks, using tools provided elsewhere. 

## Usage
microServiceBus.com API is a REST based API that can be called from any application. To use the API you need an **API key** which you can receive by navigating to the **Account** page (click your user account in the top right corner). On the **Account** page, click "API keys". Enter your password and token expiration and hit the *GET API KEY* button. Copy the token, and navigate to the swagger page.

Paste your token in the *api_key* field at the top of the field.

> Tip: To use the API from outside the swagger page, add the token to the Authorization header.

```bash
url -X GET --header 'Accept: application/json' --header 'Authorization: bearer ....' 'https://microservicebus.com/api/organizations'
```

> Tip: It's not recommended to use a normal user account as the API account. Instead create a user account for each service or application that will use the API. This way it's easier to track and audit updates.

## Explore the API
The microServiceBus API is segmented into groups of entities:

* Account
* Nodes
* NodeImages
* Organization
* Tags

Back to home page: [Home](/microServiceBus.docs/)
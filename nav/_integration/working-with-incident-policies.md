---
layout: post
title:  Working with incident policies
description: Incident policies is part of Device Management and allow you to take actions on exceptions and alerts, such as when Nodes comes of line or custom alerts.
categories: integration
order: 30
---

Managing and taking actions on *Incidents* is a crucial part of IoT Device Management and allows you to react to events such as notifying a technician to replace a sensor if the battery is low or send a text message if the pressure of the heat pump is running high.
Apart from custom policies, there are two policies enabled by default which are **Unhanded Exceptions** and **Offline Nodes** and are described in detail below.
> **Incident Policies** is only available on managed *Organizations* and can be enabled on the [Organization page](https://microservicebus.com/organizations/detail).

## What is an incident?
An *incident* can be created from anywhere but most commonly from a *Node* and is commonly some abnormality you’d like to take action on. All *incidents* have an identifier (error code), a description and an action. Actions are described in detail (below)[#Actions].  

## Create a custom alert
A custom alert is implemented using an **Incident Policy** which defines three elements: The *identifier* (error code), description and an action. Navigate to the [Organization page](https://microservicebus.com/organizations/detail), and scroll down to the *ServiceNow* section. If your organization is managed, the *MANAGE INCIDENT POLICIES* button is enabled. Click the button to open the *Incident policies* dialog.

> By default, there should be two *policies* already created for you; **Unhanded Exceptions** and **Offline Nodes**. These are described in detail in the [Default policies section](# Default policies) below.
Click the *Add new record* button on top to create a new row in the table. Set a *Error code* and describe the policy. Finally, select an *Action* and set the parameters.

![SD-Card composition](/images/working-with-incident-policies/incidentPoliciesWindow.png)
*Please note that you can have multiple actions on the same Error code.*

## Actions

### Send issue email
The * Send issue email* action sends an hourly aggregated notification of all *incidents* to participants you’ve configured clicking the *Params* button (…). The *to* element can hold a comma separated list of email addresses who subscribes to this event.
``` json
{
    "to": "peter@organization.com,elsa@organization.com"
}
```

### Send issue SMS
Similar to the * Send issue email* action, this action sends an hourly notification to participants you’ve configured clicking the *Params* button (…). The *to* element can hold a comma separated list of phone numbers.

### Call API
The *Call API* will send a *POST* request of every incident to a REST service of your choice. Configure the parameters as the table below:

| Property        | Description |
 | -------------- |-------------|
| postUrl | The address of your service. | 
| authToken | (Optional) If your service require token authentication.|  
| authTokenType | (Optional) Eg **Bearer** or **Basic**   | 
| headers| A list of custom headers. |

#### Samples:

**Using bearer token**
```json
{
    "postUrl": "https://localhost:44302/api/test",
    "authToken": "0Emg2W42NysRnxdnMUlIzrkbxGDPo4m31cOZ8NHWS7OPxkXPf4hJobBjH45HIivRDn6VKPxKoFYzQeIF3VOlBToSUi36xmys1I1aGyHQ8",
    "authTokenType": "Bearer"
} 
```
**Using custom header**
```json
{
    "postUrl": "https://localhost:44302/api/test",
    "heades": ["api-key","6U5mb1L4zeaD8QXXpladlL1y50vv "]
} 
```

#### Sample REST service (C#)
``` csharp
public class TestController : BaseApiController
    {
        [HttpPost]
        [Route("api/test")]
        public async Task<HttpResponseMessage> Post()
        {
            string result = await Request.Content.ReadAsStringAsync();
            var request = JsonConvert.DeserializeObject<dynamic>(result);

            // YOUR CODE

            var response = Request.CreateResponse(HttpStatusCode.Created, new { success = true, request = request });
            return response;
        }
    }
```

### Create ticket (default policy)
The *Create ticket* action will create an incident in *ServiceNow* and does not require any parameters. This action is part for the **Unhanded Exception** (error code 90000) default policy.

### Handle offline Node (default policy)
When *Nodes* come offline a workflow will be triggered which does the following:
1. Create an incident in *ServiceNow* (error code 90001)
2. After 10 minutes, check if the *Node* is still offline
3. If the *Node* is still offline, update the status of the *ServiceNow* incident to *In Process*, otherwise close the incident.


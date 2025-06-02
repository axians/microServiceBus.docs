---
layout: post
title:  Working with Alerts
description: Alerts are part of Device Management and allow you to take actions on exceptions and alerts, such as when Nodes comes of line or custom alerts.
categories: operation
order: 10
---

Managing and taking actions on *Alerts* is a crucial part of IoT Device Management and allows you to react to events such as notifying a technician to replace a sensor if the battery is low or send a text message if the pressure of the heat pump is running high. There are several built-in *Alerts* and you can also configure your own.
> **Alerts** are only available on managed *Organizations* and can be enabled on the [Organization page](https://microservicebus.com/organizations/detail).

## What is an Alert?
An *Alert* can be created from anywhere but most commonly from a *Node* and is commonly some abnormality you’d like to take action on. All *incidents* have an identifier (error code), a description and an action. Actions are described in detail [below](#Actions).  

## Create a custom alert
A *Custom Alert* is implemented using three parts: The *identifier* (error code), description and an action. Navigate to the [Organization page](https://microservicebus.com/organizations/details), and scroll down to the *ServiceNow* section. If your organization is managed, the *MANAGE ALERTS* button is enabled. Click the button to open the *Manage Alert* dialog.

> By default, there should be two *policies* already created for you; **Unhanded Exceptions** and **Offline Nodes**. These are described in detail in the [Default policies section](# Default policies) below.
Click the *Add new record* button on top to create a new row in the table. Set a *Error code* and describe the Alert. Finally, select an *Action* and set the parameters.

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
Similar to the * Send issue email* action, this action sends an hourly notification to participants you’ve configured clicking the *Params* button (…). 

| Property        | Description |
 | -------------- |-------------|
| to | Comma separated list of phone numbers. Don't forget to use country code. | 
| workingHours | (Optional) To prevent receiving text messages during certain hours of the day set the **to** and **from** for when you accept messages. Set the **timeZone** field according to [supported timezones](https://techsupport.osisoft.com/Documentation/PI-Web-API/help/topics/timezones/windows.html). |  

**Sample**
``` json
{
  "to": "+4612121212,+43334343453",
  "workingHours": {
    "from": "08: 00",
    "to": "18: 00",
    "timeZone": "W. Europe Standard Time"
  }
}
```

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

### Create ticket (default Alert)
The *Create ticket* action will create an *Alert* in *ServiceNow* and does not require any parameters. This action is part for the **Unhanded Exception** (error code 90000) default policy.

### Handle offline Node (default Alert)
When *Nodes* come offline a workflow will be triggered which does the following:
1. Create an *Alert* in *ServiceNow* (error code 90001)
2. After 10 minutes, check if the *Node* is still offline
3. If the *Node* is still offline, update the status incident to *In Process*, otherwise close the incident.

## Supported triggers and error codes

| Error code        | Description |
 | -------------- |-------------|
| **90000** | Unhandled Exception | 
| **90001** | Node is offline | 
| **90002** | Node has reconnected without triggering reconnect | 
| **90003** | Node has reconnected without triggering signin| 
| **90006** | Organization has npm vulnerabilities | 
| **90007** | Organization has Snaps to be updated |
| **90010** | Failed login |
| **90011** | Invalid user login | 
| **90020** | Data plan limit approaching | 
| **90021** | Data plan reached | 
| **90030** | Missing sensor readings | 
| **90040** | High storage utilizations | 
| **90041** | Storage failure | 
| **90050** | High memory utilization | 
| **90060** | Failed to start snap | 
| **90061** | Snap crash | 
| **90070** | High cpu utilization | 
| **90080** | Unable to connect to the IoT Hub |
| **90081** | Unable to connect device twin |
| **90100** | Failed to start docker container | 
| **90101** | Docker containers crash | 
| **90102** | Custom docker log event | 

---
layout: post
title:  "Integrate SIM card management"
description: "Cisco Jasper is a powerful SIM card management tool, and well integrated with microServiceBus.com. Learn more about how to set up integration with Cisco Jasper."
categories: integration
order: 20
---

Cisco Jasper is a powerful SIM card management tool where you can manage state and set up automation rules for your SIM cards. The integration with Cisco Jasper enables automatically on-boarding of new devices wit no effort part from powering on the device. For this provisioning process to work, you need to set up a two-way trust between microServiceBus.com and Cisco Jasper; one for Cisco Jasper to notify microServiceBus.com of newly activated devices (SIM cards) and one for microServiceBus.com to call Cisco Jasper to make changes of updates to the configuration. microServiceBus.com will also query Cisco Jasper to notify users when data plans are reaching their limits.

To set up the Cisco Jasper integration, follow these tow steps:

## 1. Create an API user in Cisco Jasper
Although microServiceBus.com can call Cisco Jasper on behalf of any user, it's always a good practice to use a dedicated user. This way it becomes clearly visible in Cisco Jasper in which context any changes has been done.
1. Begin by navigating to your Jasper instance. Navigate to the **Admin** page and click on **Users** in the right hand menu. 
2. Click the **Edit** link at the top and provide a secret. The secret is used to verify the origin of the call. 
3. User the *Action menu* to create a new user, and fill in the fields. In the *Access Type* field select the "API only" option in the drop-down menu. Click **OK** to save the user.
4. Click the user name in the list to navigate to the user *Detail page*, and click the "Show API key* link at the top. Copy and save the **API key**.
5. Go back to the main page and click the "Knowledge Base" tile, and continue to the REST API page.
6. Click the "API key" section in the right hand menu and copy and save the "Resource URL".
7. Open a new window, navigate to microServiceBus.com and continue to the [Organization page](https://microservicebus.com/Organizations/Details). Scroll to the button and click **Edit**.
8. In the *Cisco Jasper* section, fill in the *Instance, User name, REAST API key and the Secret* fields with the values from the previous steps.
9. Before you hit *Save*, copy the API address for the next step. 

Your microServiceBus.com Organization is now set to call the Cisco Jasper API.

## 2. Set up Cisco Jasper to notify microServiceBus.com on status changes of SIM cards

1. Go back to Cisco Jasper and click the **Automation** tile. User the *Action menu* to create a new *Rule*.
2. In the "Define Rule" section, select "SIM Provisioning" category and then select "SIM State Change".
3. In the "When this happens..." section set "If any SIM changes SIM State from" to **"Activation Ready" and **"Activated"**.
4. In the "Do this..." section select "Push an API message" and set the URL to the API address you copied in step 8 in the previous section.
5. Click **Activate Rule** to save the automation rule.

With these steps completed, SIM cards that gets activated will automatically trigger your automation rule which will cause Cisco Jasper to call microServiceBus.com to create the Node in both  microServiceBus.com and your IoT Hub. Shortly after the Node gets online it should automatically receive credentials to log on to the IoT Hub.




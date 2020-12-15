---
layout: post
title:  Integrate with IoT Hub
description: To run microServiceBus.com with full capabilities, an IoT Hub is needed. You can easily connect your existing Azure, Amazon or IBM IoT Hub to microServiceBus.com.
categories: integration
order: 31
---

*An IoT hub is a cloud hosted platform responsible for all communications to- and from Nodes. Other on-prem or cloud based services which would benefit from interacting with the *Nodes* would do so through the IoT hub.*

*microServiceBus.com support three different IoT hubs from Microsoft, Amazon and IBM. Through this integration, devices and things can be fully managed far beyond what is provided out-of-the-box.*

>*Although IoT hubs in general provide the same basic functionality, the main difference would be what is behind the IoT hub, such as machine lerning, reporting and processing. Your choice  of IoT hub would, in the majority of cases, depend on what you want to do with the data.*

---

## Get the IoT Hub Connection String from Azure Portal
1.	Sign in to the [Azure portal](https://portal.azure.com).
2.	Go to your IoT-Hub resource and click on Shared access policies.
3.	Select the iothubowner policy and copy your "Connection string—primary key".

[Azure IoT Hub](https://azure.microsoft.com/en-us/services/iot-hub/) - Enable highly secure and reliable communication between your Internet of Things (IoT) application and the devices it manages. Azure IoT Hub provides a cloud-hosted solution back end to connect virtually any device. Extend your solution from the cloud to the edge with per-device authentication, built-in device management, and scaled provisioning.

---

## Get Connection Settings from AWS
1. Open the IAM console at https://console.aws.amazon.com/iam/.
2. On the navigation menu, choose Users.
3. Choose your IAM user name (not the check box).
4. Open the My Security Credentials from your account, and then choose Create access key.
5. Expand the **Access keys** section and click the "Create New Access Key" button.
- Access key ID: E.g. *AKIAIOSFODNN7EXAMPLE*
- Secret access key: E.g. *wJalrXUtnFEMI/K7MDENG/bPxRfiCYEXAMPLEKEY*

[Amazon AWS IoT](https://aws.amazon.com/iot/) - There are billions of devices in homes, factories, oil wells, hospitals, cars, and thousands of other places. With the proliferation of devices, you increasingly need solutions to connect them, and collect, store, and analyze device data.

---

## Get Connection Settings from Google IoT Core
1. Navigate to [Google Cloud Platform](https://console.cloud.google.com/home), select your project and navigate to the **Project settings page**.
2. Form the Project settings page, select **Service Accounts** from the left-hand menu.
3. Create a new Service Account and name it "microServiceBus". The account must have `Cloud IoT Owner` privileges or higher.
> The `Cloud IoT Owner` privileges are required to browse the registry and manage devices.
4. In the Service account details page, add a new key using the *ADD KEY* drop-down list and select *Create new key*. Select the JSON key type. Save the downloaded file.
> The downloaded project credentials file contains secure information. Store it in a safe place!
5. From the menu, select **IoT Core**
6. If you haven't already created a *Registry*, click the **CREATE REGISTRY** button. Give the *Registry* a name and select a region. 
7. Navigate to the [Getting started wizard](https://microservicebus.com/gettingstarted) and click the  **GET STARTED BUTTON**
8. Fill out the *Account* and *Organization* details and hit **Next**.
9. In the *Configure IoT Hub* section, select **Google IoT Core**
10. Click the **LOAD PROJECT CREDENTIAL FILE** and select the file you save in step 4. Continue to set the `Registry Id` and the `Region`.
11. Hit the **TEST CONNECTION** button to verify the connection.

[Google IoT Core](https://cloud.google.com/iot-core) - Cloud IoT Core is a fully managed service that allows you to easily and securely connect, manage, and ingest data from millions of globally dispersed devices. Cloud IoT Core, in combination with other services on Cloud IoT platform, provides a complete solution for collecting, processing, analyzing, and visualizing IoT data in real time to support improved operational efficiency.

---

## Get Connection Settings from IBM Watson
1. On the Bluemix dashboard, click the card that represents the application that you are working with.
2. From the application overview, click the Internet of Things Platform card.
3. On the Watson IoT Platform welcome page, click Launch dashboard.
4. On the All Boards screen, make a note of the ID value that displays with your user name. The organization ID is a six-digit, alphanumerical value. If you want to use a different organization, click your user name to view a list of all organizations.
5. Select the organization that you want to use and click the Apps icon.
6. Click Generate API Key. The Generate API Key dialog box shows the values of the API key and the authorization token.
7. Copy the API key and the authorization token values.

[IBM Watson IoT Platform](https://www.ibm.com/se-en/business-operations/iot-platform) - Securely connect, collect and start processing IoT data quickly and easily with Watson IoT™ Platform. And because it uses IBM Cloud, your company can scale and adapt quickly to changing business needs without compromising security, privacy or risk levels.

---

## No IoT Hub
There are scenarios where an IoT hub is not required, or rather required for the microServiceBus **Node**. For instance, if you have already built a working solution and only require *Device Management* (OTA, logging, monitoring, vulnerability scan and control), -the "No IoT Hub" option might be best suited for you.
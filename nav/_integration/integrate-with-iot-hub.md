---
layout: post
title:  Integrate with IoT Hub
description: To run microServiceBus.com with full capabilities, an IoT Hub is needed. You can easily connect your existing Azure, Amazon or IBM IoT Hub to microServiceBus.com.
categories: integration
order: 31
---

[Azure IoT Hub](https://azure.microsoft.com/en-us/services/iot-hub/) - Enable highly secure and reliable communication between your Internet of Things (IoT) application and the devices it manages. Azure IoT Hub provides a cloud-hosted solution back end to connect virtually any device. Extend your solution from the cloud to the edge with per-device authentication, built-in device management, and scaled provisioning.

## Get the IoT Hub Connection String from Azure Portal
1.	Sign in to the [Azure portal](https://portal.azure.com).
2.	Go to your IoT-Hub resource and click on Shared access policies.
3.	Select the iothubowner policy and copy your "Connection string—primary key".

---

[Amazon AWS IoT](https://aws.amazon.com/iot/) - There are billions of devices in homes, factories, oil wells, hospitals, cars, and thousands of other places. With the proliferation of devices, you increasingly need solutions to connect them, and collect, store, and analyze device data.

## Get Connection Settings from AWS
1. Open the IAM console at https://console.aws.amazon.com/iam/.
2. On the navigation menu, choose Users.
3. Choose your IAM user name (not the check box).
4. Open the My Security Credentials from your account, and then choose Create access key.
5. Expand the **Access keys** section and click the "Create New Access Key" button.
- Access key ID: *AKIAIOSFODNN7EXAMPLE*
- Secret access key: *wJalrXUtnFEMI/K7MDENG/bPxRfiCYEXAMPLEKEY*

---

[IBM Watson IoT Platform](https://www.ibm.com/se-en/business-operations/iot-platform) - Securely connect, collect and start processing IoT data quickly and easily with Watson IoT™ Platform. And because it uses IBM Cloud, your company can scale and adapt quickly to changing business needs without compromising security, privacy or risk levels.

## Get Connection Settings from IBM Watson
1. On the Bluemix dashboard, click the card that represents the application that you are working with.
2. From the application overview, click the Internet of Things Platform card.
3. On the Watson IoT Platform welcome page, click Launch dashboard.
4. On the All Boards screen, make a note of the ID value that displays with your user name. The organization ID is a six-digit, alphanumerical value. If you want to use a different organization, click your user name to view a list of all organizations.
5. Select the organization that you want to use and click the Apps icon.
6. Click Generate API Key. The Generate API Key dialog box shows the values of the API key and the authorization token.
7. Copy the API key and the authorization token values.


---
layout: post
title:  "Migration information"
description: "Important information about May release of 2020"
categories: quickreference
order: 200
---
microServiceBus.com has been undergoing a migration which is coming close to general availability. The new release, scheduled for late May 2020, promises improved performance and scale, but also a platform allowing us to adapt new features at a much higher rate.
Everything will work as normal part from two things:

##  Reset password
After the release has come available, you will be prompt to change your password. The reason for this is that we cannot read and migrate your password as your password information is not accessible to us.

## Deprecated support for the free IoT Hub
We still offer a free edition of microServiceBus.com, but we are no longer supporting the free IoT Hub. If you have a free IoT hub, you’ll need to migrate it to one from Microsoft, AWS or IBM. This process is simple and will provide you with more features and a more robust solution.
Simply create a new IoT Hub, copy the connection information such as connection string or Access token depending on your choice of provider. Navigate to the Organization tab and click the SWITCH IOT PROVIDER button. Select you provider and click the CHANGE IOT PROVIDER button. All you existing Nodes will instantly be migrated to your new IoT Hub.

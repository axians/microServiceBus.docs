---
layout: post
title:  "Managing firmware and devices"
description: "How do you update firmware, snaps and containers."
categories: operation
order: 15
---

The ability to update firmware's or application containers is essential to secure your system. 

## Get access to device information
*Device information* refers to low-level components of your hardware, such as kernel, firmware, containers and other settings such as memory, storage and environment variables. All these can be accessed through a single view in on the [Nodes page](https://microservicebus.com/nodes).

From the [Nodes page](https://microservicebus.com/nodes), click the **ACTION** button of any one of your online *Nodes* and select **Device*. This will send a request to your *Node* and open the *Device information* dialog. The dialog presents four different tabs:

### General
This tab reveals common resources such as CPU, Memory and network, all to get a good overview of resource usage, but also a good place to find the IP address of your *Node*.

<img src="{{site.baseurl}}/images/managing-firmware-and-device/general.png">

### Firmware
[Yocto based devises](https://docs.microservicebus.com/running-microservicebus-node-on-a-yocto-image), usually comes with two or more kernel partitions. These are manage by a bootloader manager such as [RAUC](https://rauc.io/). 

The *Device information* dialog provides detailed information about each partition such as which is active, when it was activated and more.

The *Device information* dialog also gives you the options of settings which partitions should be booted. You can also update the firmware from this dialog (also available using the [microServiceBus API]({{site.baseurl}}/using-microservicebus-api)). 

<img src="{{site.baseurl}}/images/managing-firmware-and-device/firmware.png">

### Snap (Ubuntu)
If you are running Ubuntu Core or Ubuntu IoT, this is your go-to place for managing Snaps running on your device. The list gives you an overview of all installed Snaps and lets you refresh (update) them by clicking the **REFRESH** button. Keep in mind that updating Snaps may require rebooting the system.

Although you can update your Snaps using this dialog, you may consider using the  [microServiceBus API]({{site.baseurl}}/using-microservicebus-api) to update more or all devices at once.

<img src="{{site.baseurl}}/images/managing-firmware-and-device/snaps.png">

### Environment variables
Environment variables are a variables whose value is set outside the program, typically through functionality built into the operating system or microservice. An environment variable is made up of a name/value pair, and any number may be created and available for reference at a point in time.

### Run scripts
Configuring your system using bash scripts is a powerful and easy way to make sure consistency and integrity of your system is kept.

Bash scripts are created just as you create a [microservice]({{site.baseurl}}/what-is-a-micro-service), but make sure to *Service type* of your script to **Patch script**, as it will otherwise not be visible in the *Device information* dialog.

With the *Patch script* created, you can select it in the drop-down list, and click the **EXECUTE** button to have the script executed on the gateway.


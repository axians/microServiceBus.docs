---
layout: post
title:  "On-boarding and provisioning of new devices"
description: "Installing gateways for test and development is one thing, but rolling you many devices is a whole other beast. Learn about how to provision Nodes using Cisco Jasper or MAC address whitelisting."
categories: operation
order: 30
---


There are three supported ways you can provision devices:
* Per *Node* using verification code
* Using MAC whitelist
* Using IMEI

## Provision Nodes using temporarily verification code
Once you have installed a *Node* and are ready to start it up, you can do so using a temporarily verification code which you can get from the [Nodes page](https://microservicebus.com/Nodes). The code is valid for 30 minutes and can be used as:
```
> node start -c [YOUR CODE] -n [NODE NAME] (optional: -env [YOUR ENVIRONMENT])
Eg.

> node start -c ABC123 -n node-00034
or using private/self hosted environment
> node start -c ABC123 -n node-00034 -env myorganization.microservicebus.com

```
The *code* and the *Node name* are only required the first time you start the node *Node*. Once provisioned, you can start it using only:
```
> node strt
```

[For more information about how to install a Node]({{site.baseurl}}/installing-microservicebus-node)

## Using MAC whitelist
A media access control address (MAC address) of a device is a unique identifier assigned to a network interface controller (NIC). Each device has it's own unique MAC address, and you can register these addresses in *microServiceBus.com* to simplify on-boarding bulks of devices.

Once a device has been provisioned using the MAC address, the address is consumed and can not be used again. It's recommended only to register  devices than you are planning to provision at a specific point in time. Keep in mind that MAC addresses can be spoofed.

Follow the steps below to on-board devices using MAC addresses

1. Create the white list
The whitelist is expected to be a two columns CSV file, separated by comma. First column should be *name* and the second column the *MAC address*.
2. Navigate to the [Nodes page](https://microservicebus.com/Nodes), select the *Whitelist* tab and click *IMPORT WHITELIST* button. Select your file to upload the whitelist
3. Start the *Node* using the **-w** flag:
```
> node start -w (optional: -env [YOUR ENVIRONMENT])
Eg.
> node start -w
or
> node start -w -env myorganization.microservicebus.com
```

## Using IMEI 
The *International Mobile Equipment Identity* or **IMEI** is a unique number to identify the modem of the device.

Before provisioning devices using the SIM card id, you need to integrate your organization with Cisco Jasper. To setup the Cisco Jasper integration, [follow this guide]({{site.baseurl}}/integrate-sim-card-management).

Once integrated, you can start the *Node* using only the --imei:

```
> node start --imei (optional: -env [YOUR ENVIRONMENT])
Eg.
> node start --imei
or
> node start --imei -env myorganization.microservicebus.com
```

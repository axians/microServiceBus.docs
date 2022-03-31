---
layout: post
title:  "Work with Node VPN interface and peers"
description: "Work with Node VPN interface and peers"
categories: quickreference
order: 55
---

The **microservicebus-node** agent can be enabled to host or join a VPN network using [WireGuard®](https://www.wireguard.com/). WireGuard® is a modern VPN that utilizes state-of-the-art cryptography. For more information about its supported [protocols and cryptography](https://www.wireguard.com/protocol/).

## General concept and usage
There are two main purposes for the *Node VPN feature*:

### Secure transport of data
There are scenarios where data is not transmitted to an IoT Hub endpoint, but to other locations using a none TLS or secure protocols. This can be the case when transmitting data to a local SCADA system using for instance IEC 60870-5-104. In such situations you can set up a secure tunnel for transport encryption.

### Proxy IoT Hub access from secure zones
When *Nodes* are operating in a secure environment with no in- or outbound access to internet, a secondary *Node* can access as a "proxy" from a less secure zone.

## Prerequisites
Before you begin, -WireGuard® needs to be installed on your gateway. You can follow the installation descriptions [here](https://www.wireguard.com/install/) to manually install it, or select one of our many [Yocto images](https://github.com/axians/meta-microservicebus) that comes with WireGuard® pre-installed.

## Setup a VPN network
1. From the *Nodes* page select a *Node* which will serve as **host**. Click *Properties* from the *ACTION* menu and select the *VPN* tab.
2. Enable VPN, and click the *Generate* button to create a public and private key.
> *The private key is stored securely in Azure Key Vault, and once the key is generated it will only be accessible from the *Node* after successful sign in.*
3. Continue to assign an IP address, and provide the public IP address in the *Endpoint field. The default port is 51820.

Use the *Post Up* and *Post Down* fields if you for instance would like the host Node to forward traffic. For instance:

*The following example adds forwarding when VPN is started*
```
iptables -A FORWARD -i wg0 -j ACCEPT; iptables -t nat -A POSTROUTING -o eth0 -j MASQUERADE; ip6tables -A FORWARD -i wg0 -j ACCEPT; ip6tables -t nat -A POSTROUTING -o eth0 -j MASQUERADE
```
*The following example removes forwarding when VPN is shutdown *
```
iptables -D FORWARD -i wg0 -j ACCEPT; iptables -t nat -D POSTROUTING -o eth0 -j MASQUERADE; ip6tables -D FORWARD -i wg0 -j ACCEPT; ip6tables -t nat -D POSTROUTING -o eth0 -j MASQUERADE
```
**Please be careful when using forwarding!**

4. Add a *Peer Node* by clicking the *Add Node peer" button. Type the name of another *Node* you'd like to include in the same network. Give the peer an IP address and hit the *ADD PEER* button.
5. Save by clicking the *SAVE VPN SETTINGS* button

If your *Nodes* are online, they should now fetch their respective VPN configurations and establish the connections. 


By default, the IPv4 policy in linux kernels disables support for IP forwarding. This prevents machines that run linux server from functioning as dedicated edge routers. To enable IP forwarding, use the following command:

```
> sysctl -w net.ipv4.ip_forward=1
```

This configuration change is only valid for the current session; it does not persist beyond a reboot or network service restart. To permanently set IP forwarding, edit the /etc/sysctl.conf file as follows: Locate the following line:

```
net.ipv4.ip_forward = 0
```
Edit it to read as follows:

```
net.ipv4.ip_forward = 1
```

Use the following command to enable the change to the sysctl.conf file:

```
> sysctl -p /etc/sysctl.conf
```


### Connect to the network from a workstation
Their might be scenarios where you need to connect to the network using for instance your laptop. To do this begin by installing the WireGuard® VPN software from [here](https://www.wireguard.com/install/).

1. Next, go back to the *Properties* page of the host *Node* and click the *Add user peer* button.
2. Assign yourself an IP address and click *ADD PEER* to view the configuration. Click the *SAVE CONFIG* button to download and save the configuration.

> It is important to save this file in secure location as as it holds the *private key* 

3. Open WireGuard® and click the *Add Tunnel* button at the bottom. Select the file you downloaded in step 2.
4. To activate the tunnel, click the *Activate* button.

> Private keys are not stored in **microServiceBus.com** for *User peers*, so it's important not too loose the file. But if you do loose it, remove the *User peer* and create a new one.

## Key rotation
If a key get compromised you can re-generate the key by simply clicking the *Generate* button in the *VPN* tab. This will give the *Node* a new private key and update the public key of all *Nodes* on the network.
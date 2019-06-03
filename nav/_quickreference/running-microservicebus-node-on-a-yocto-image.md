---
layout: post
title:  "Running microServiceBus-node on a yocto image"
description: "Yocto is about creating your own embedded Linux distribution, by cherry-picking Yocto meta-layers to suit your needs and create a powerful, yet minimal firmware. microservicebus-node is available as a Yocto meta-layer! Learn more about how to use it."
categories: quickreference
order: 20
---


## Intro
Yocto is an huge topic and to get you started we are going to setup an Raspberry Pi to run an custom pre built Yocto image. The pre built image contains 4 partitions with some key parts that enables microServiceBus to do remote frimware updates.

![SD-Card composition](/images/running-microservicebus-node-on-a-yocto-image/rpi-sd-image.svg)

### Partition 1 /boot
The boot partition contains the bootloader, in this case U-Boot. The bootloader is first to run after power up. U-Boot is responisble to load the Linux kernel into memory and decide if RootFS 1 or 2 should be mounted by the kernel.

### Partition 2 and 3 /rootfs
In the rootfs partitions all Linux user space software is installed. There is two rootfs partitions to be able to update and swap firmware, only one is active at a time. The software most intresting for us is *microServiceBus-node* and *RAUC*. *MicroServiceBus-node* is responsible to install and update *microServiceBus-core*. *MicroServiceBus-core* will check for new firmware, if newer firmware exists *microServiceBus-core* will download firmware and then call *RAUC* to install and swap rootfs next boot.

### Partition 4 /data
Data partition is used to store data that will be persistent between firmware updates. *MicroServiceBus-node* runs by "msb" user whose home directory is located under /data/home/msb. *MicroServiceBus* stores scripts and data under the home directory by default. 

### Yocto
Yocto build system runs on Linux but this tutorial will use pre build files and is targeted Windows.

In this tutorial we will use target to reference the Raspberry Pi and host to reference the PC used to write SD-card.

## Hardware
To follow along this tutorial you need some hardware.

#### Target
- Raspberry Pi 3 B/B+
- USB power supply
- Micro SD card with a capacity of at least 8 GB
- LAN, cable or WiFi
- HDMI cable and screen (Optional)
- USB keyboard (Optional)

#### Host
- Windows PC, Linux or MAC should be fine
- Micro SD card reader
- Access to same LAN as target is conncted to, cable or WiFi
## 1. Getting started
Here is some software that is good to download/install before moving on
- [SD-Image](https://microservicebusstorage.blob.core.windows.net/yocto/rpi/msb-image-rauc-raspberrypi3-20190529155638.rootfs.rpi-sdimg.zip) complete Yocto image for RPi SD-card
- [Firmware-bundle]() an bundled rootfs for remote update

- [PuTTY](https://www.chiark.greenend.org.uk/~sgtatham/putty/latest.html) will be used to connect to target and to generate ssh keys
- [Etcher](https://www.balena.io/etcher/) to write image to SD-card

## 2. SSH-Keys
The Raspberry Pi setup use SSH-keys for authorization when connection with SSH fom host. If you alreday have an public and private key pair you can skip this section.
1. Start PuTTYgen( Start menu -> All Programs -> PuTTY-> PuTTYgen)
2. Press "Generate" and start moving mouse to generate randomness, when complete the public key appears in the window
3. Specify an passphrase to protect the private key, this is optional
4. Save private and public key, good to keep PuTTYgen open for copy/paste later.

>Tip! If you have problem you can follow this [guide](https://www.ssh.com/ssh/putty/windows/puttygen)

## 3. Write SD-Card
This will erase all content on the SD-Card, backup any data before continuing!
1. Open Etcher and select image and drive and then flash!
2. After completion the boot partition should appear under Computer in the explorer.

## 4. SSH authorized_keys
To add your public SSH-key to the Raspberry Pi image you need to create an authorized_keys file.

1. Open an text editor like [Notpad++](https://notepad-plus-plus.org/download/v7.7.html).
2.  Copy paste the public key from PuTTYgens key field, if you closed PuTTYgen you can open it and load your private key again
3. If you use [Notpad++](https://notepad-plus-plus.org/download/v7.7.html) change end of line (EOL) to Unix, go to Edit->EOL Conversion->Unix (LF)
4. Save file to the boot partition as "authorized_keys"(no file ending)

Your file should look somthing like below exept as one line:
``` shell
ssh-rsa AAAAB3NzaC1yc2EAAAABJQAAAQB6tFAQLjZyldp187xJ4WANAikn6kf5o1u8HQBB1TpJFYfFhCNskX9oT1XC6rfD5Ar817p329vjppzY4kNOjIEIYIOLy8dWGcGGNEDjB9G+pczLp3J8cAWEic+bpB9mI6HGQwABb6AOIwuTw91INJwt7++4S6I9xbtECCTGWyb70pLWstqwlN8GXovLe/+vkMHI5PSJeQJLfabTk/SjM4gbD9GemHBcLbbCnpmXQYbG5jLPpF7Hhc8Gc7/NrzB7GwZ55HPkcz/oISVuCWReKGpSWIJno72FvpF4OeIyc/bLiw5H8VReyT9A9W3RUNQOmTuVfkBcIQZ4tdocBc0PxTkB rsa-key-20190603
```

The init script will copy your key to the active rootfs on boot.

## 5. WiFi config
If you use cable to connect to LAN you can skip this section.
As the Raspberry Pi is intended to run headless(no display) and be able to swap rootfs without losing your WiFi settings an configuration file can be copied to the boot partition. WPA-Supplicant is used to setup WiFi on the Raspberry Pi.

WPA-Supplicant template for WPA and WPA2:

``` shell
ctrl_interface=/var/run/wpa_supplicant
ctrl_interface_group=0
update_config=1
country=SE

network={
        ssid="RPI_WIFI_SSID"
        scan_ssid=1
        psk="RPI_WIFI_PSK"
}
```
1. Open an text editor like [Notpad++](https://notepad-plus-plus.org/download/v7.7.html) copy paste the above template
2. Edit contry code to match you [location](https://en.wikipedia.org/wiki/ISO_3166-1)
3. Edit ssid and psk to match your WiFi SSID and password
4. If you use [Notpad++](https://notepad-plus-plus.org/download/v7.7.html) change end of line (EOL) to Unix, go to Edit->EOL Conversion->Unix (LF)
5. Save the to the boot partition named "wpa_supplicant-wlan0.conf"

>Tip! For more info regarding WPA-Supplicant conf you can read [here](https://www.raspberrypi.org/documentation/configuration/wireless/wireless-cli.md)

## 6. microServiceBus-node service config
To start *microServicebus-node* on the Raspberry Pi an service file is used to auto start it and restart it in case of failure. There is an default service file on the SD-image already but you can add an custom service file to the boot partition to set different configurations for microServiceBus. We are going to use this to set sign in name and verification code. The default service file use white list and MAC address for sign in.

microServiceBus-node service template:

``` shell
[Unit]
Description=MicroServiceBus as a Service

[Service]
ExecStart=/usr/bin/node /usr/lib/node/microservicebus-node/start.js -c [YOUR CODE] -n  [YOUR NODE NAME]
WorkingDirectory=/usr/lib/node/microservicebus-node
Restart=always
StandardOutput=syslog
StandardError=syslog
SyslogIdentifier=nodejs
User=msb
Group=msb
Environment=PATH=/usr/bin:/usr/local/bin:/bin/:/usr/local/sbin:/usr/sbin:/sbin
Environment=NODE_ENV=production
Environment=MSB_PLATFORM=YOCTO
Environment=MSB_HOST=microservicebus.com
Environment=DAM_SOCKETPATH=/var/run/dam

[Install]
WantedBy=multi-user.target
```

1. Open an text editor like [Notpad++](https://notepad-plus-plus.org/download/v7.7.html) copy paste the above template
2. Change [YOUR CODE] and [YOUR NODE NAME] to match name and code on [msb.com/Nodes](https://microservicebus.com/Nodes)
3. If you use [Notpad++](https://notepad-plus-plus.org/download/v7.7.html) change end of line (EOL) to Unix, go to Edit->EOL Conversion->Unix (LF)
4. Save the to the boot partition named "microservicebus-node.service"
5. Unmount you SD-Card

## 7. Bootup
At this stage you hopfylly have an working SD-Card to use in your Raspberry Pi. If you like to see the boot process connect an HDMI display to your Raspberry Pi and maybe an keyboard to be able to interact. But if all off the above configuration is correct you should be able to connect from your host using SSH over the LAN.
1. Insert SD-Card in Raspberry Pi and connect power
2. Now you need to get the IP address of your Raspberry Pi. If you have access to the network router it is convinient to look att DHCP lease. An alternative is to scan your network using an IP-scanner like nmap or [Angry IP Scanner](https://angryip.org/download/#windows). If you have an display and keyboard connected you can simply logg in using root and no password, then write ipconfig on the command line and press enter.
``` shell
root@raspberrypi3:~# ifconfig
eth0      Link encap:Ethernet  HWaddr XX:XX:XX:XX:XX:XX  
          inet addr:192.168.0.100 Bcast:172.21.40.255  Mask:255.255.255.0

lo        Link encap:Local Loopback  
          inet addr:127.0.0.1  Mask:255.0.0.0

wlan0     Link encap:Ethernet  HWaddr XX:XX:XX:XX:XX:XX  
          inet addr:192.168.1.100  Bcast:172.21.20.255  Mask:255.255.255.0
```
3. When you have successfully located the IP address open PuTTY
4. Enter the Raspberry Pi address
![PuTTY config](/images/running-microservicebus-node-on-a-yocto-image/putty-config.png)
5. Now we have to select our private SSH-key, in the tree to the left open Connection->SSH->Auth, then browse your private key.
![PuTTY config auth](/images/running-microservicebus-node-on-a-yocto-image/putty-authentication-public-key-options.png)
6. Press open to start SSH session, if prompt for username enter root



Back to home page: [Home](/)

This is a demo
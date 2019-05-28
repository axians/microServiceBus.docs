---
layout: post
title:  "Running microServiceBus-node on a yocto image"
description: "Yocto is about creating your own embedded Linux distribution, by cherry-picking Yocto meta-layers to suit your needs and create a powerful, yet minimal firmware. microservicebus-node is available as a Yocto meta-layer! Learn more about how to use it."
categories: quickreference
order: 20
---


## Intro
Yocto is an huge topic and to get you started we are going to setup an Raspberry Pi to run an custom pre build Yocto image.

Yocto build system runs on Linux but this tutorial will use pre build files and is targeted Windows.

In this tutorial we will use target to reference the Raspberry Pi and host to reference the PC.

## 1.Hardware
To follow along this tutorial you need some hardware.

#### Target
- Raspberry Pi 3 B/B+
- USB power supply
- Micro SD card with a capacity of at least 8 GB
- LAN, cable or WiFi
##### Optional
- HDMI cable and screen
- USB keyboard

#### Host
- Windows PC, Linux or MAC should be fine
- Micro SD card reader
- Access to same LAN as target is conncted to, cable or WiFi
### 2.Software
Here is some software that is good to download/install before moving on
- [SD-Image]() complete Yocto image for RPi SD-card
- [Firmware-bundle]() an bundled rootfs for remote update

- [PuTTY](https://www.chiark.greenend.org.uk/~sgtatham/putty/latest.html) will be used to connect to target and to generate ssh keys
- [Etcher](https://www.balena.io/etcher/) to write image to SD-card
#### Best practices

* Always checkout branch before editing so no conflict happens. When you are done with your edit, create a pull request.

* Specify code language in code examples.

    ```javascript
    forEach(codeExample in docs){
        useInlining(Force);
        // ```javascript
        // [My javascript code goes here]
        // look at raw code for this markdown file to understand
        // ```
    }
    ```

* >Tip! Tips should be written like this

* Always use cursive on reserved words like *node*, *microservice*, *microServiceBus.com*, *flows*, *organization*, *tags* etc.

* Images can be added in different ways. Depending on the use and size of the image you whant to use.

  * Standard: `![altText](/images/Logosmall.png)`

    ![altText](/images/Logosmall.png)

    *Imports the image at the original size*

  * Advanced: Use raw_html to resize and modify your image. You can use padding, width, hight etc.

    ```text
    Example: <img src="https://axians.github.io/microServiceBus.docs/images/Logo5.png" width="50">
    ```

    <img src="./images/Logo5.png" width="100">

Back to home page: [Home](/)

This is a demo
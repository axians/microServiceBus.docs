---
layout: post
title:  "Get remote access to your Nodes"
description: "There are times when there is no substitute to a plain old SSH session. Learn more about how to upload public keys and grant yourself access to Nodes."
categories: operation
order: 50
---

There are times when you might need to access your *Nodes* to dig through the local file system, check log files locally or just do some configuration of networks and services. SSH passwords is sufficient when you have a few *Nodes*, but imagine the hassle and the ensuing fight you will have with security when all of these passwords are stored on a file on your local computer. Or when you send a password to your collegue. Enter, SSH keys. By uploading the public part of your own SSH key to *microServiceBus.com*, you can get remote access to your *Nodes*. You will get your own user on the machine and therefore traceability on actions taken during your SSH sessions.

## Adding your public SSH key

Navigate to your user page  [Manage user](https://microservicebus.com/Account/Manage). Go to the tab *SSH keys* and either type in a username or have us generate one for you. These are case insensitive and will always have all lower-case characters. This will be the user that you use for your SSH session towards the *Node*. Refresh the page and navigate to the same tab. 

You can now add a SSH key that is linked to your user. If you do not have a SSH key you can create one by starting up a terminal on your computer and run:

```bash
    ssh-keygen
  ```

Add your device name and the public part of your key. You are now ready to request remote access to *Nodes* to be able to log in directly on the device.

## Getting remote access to a *Node*

Navigate to the node page [Nodes](https://microservicebus.com/Nodes).

Click on the *Actions* dropdown on the *Node* you would like to get access to and press on *Grant Access*. The *Node* will now fetch your public key and add it as a user on the device. The key will be removed after 3 hours for security reasons, so if you need more time than that you will have to *Grant Access* again.

## Starting a SSH session with your key

Once you have your public key uploaded and have *Granted Access* for yourself, you can now start a SSH sesssion from your device to the *Node* with the command:

```bash
    ssh username@1.1.1.1 -i /.ssh/id_rsa
  ```

You can now do all of your operation, configuration and routing without having to worry about security and passwords ever again.


---
layout: post
title:  "Controlling Nodes"
description: "Controlling Nodes is about much more than just enable or disable them. Learn more about how to Reset, Restart, Wipe, Move and Transfer your Nodes."
categories: operation
order: 60
---

# Control Nodes

### Restart Node

There is two recommended ways of restarting nodes.

1. Navigate to the [Nodes page](https://microservicebus.com/Nodes), find the **ACTION** button of your *Node* then click **restart**

2. Restarting a node by command

    Hit CTRL + R , and type **restart [YOUR NODE]** Eg.: · · ·

    ``` restart node001 ``` 


### Reboot Node
Will make the node to do a complete reboot of the system

1. Navigate to the *Nodes* page.
2. Click the **ACTIONS** button and select **Reboot**


### Shutdown Node (Be careful)
Will completely turn the system off and you will not be able to access the node unless you do a power cycle.

1. Navigate to the *Nodes* page.
2. Click the **ACTIONS** button and select **Shutdown**


### Delete Node
1. Navigate to the *Nodes* page.
2. Click the **ACTIONS** button and select **Delete**

### Wipe Node (Not recommended)
Wiping the node will clear its settings!

1. Navigate to the *Nodes* page.
2. Click the **ACTIONS** button and select **Wipe**

### Move Node
Moving a node to another organization will cause the Node to reconfigure, restart and join a new organiztion based on it's IMEI identifier

1. Navigate to the *Nodes* page.
2. Click the **ACTIONS** button and select **Move**
3. Choose a new node name and choose Organization
4. Click Move
5. Change organization to  confirm that the node have been moved.

### Remote debugging
>Remote debugging is a very powerful option which can provide you with valuable insight to your *Service*. You can also run profiling on your *Node* to find potential memory leaks or high memory/CPU contention.

1. Navigate to the *Node* page. Click the **ACTIONS** button and select **Debug**, then click **START DEBUG**.
>The *Node* will now get restarted in "Debug mode". Wait a few seconds and you'll be presented a debug url.
2. Click the **COPY** button, open a new tab (in chrome), and paste the url into the address field. This opens the Chrome Debug Tool.
3. Go to the Sources tab. Expand the top item in left pane ("no domain") to see an overwhelming number of files (sorry about that). Scroll down to your script file. Should be something like: *C:\Users\YOU\microServiceBus\services\alexCpuService.js*
4. Set a breakpoint at approx row 36 (```var computer = os.platform();```) by clicking the row number in the gutter of the editor. Wait a few seconds and the breakpoint should hit.
5. Step over the line by hitting F10, and hover the **computer** variable and view the value.

The problem is that you use ```os.platform()``` rather than ```os.hostname()```. Easy enough to fix. Let's head over to the *Scripts & Services* again. -But first, in *Node* page, make sure to stop debugging by click on the **STOP DEBUG** button in the debugging window before you proceed. Go back to the Chrome Debug Tool and hit the resume button.

# Node information

### History data
>Sometimes it can be very useful to look back in time to find patterns of communication issues and other events. For this we have *History data*

1. Navigate to the *Nodes* page.
2. Click the **ACTIONS** button and select **History**
3. Give it a few seconds, and *Last week events* window should pop up. This shows a graph of all Events (things happend on the *Node*), Audit log (actions taken from the portal), Failed- and successfull transmition of messages.
4. Close the *Last week events* window.

>Historic data is not sent to microServiceBus.com, unless requested.

### Audit log
>The *Audit log* shows any action taken on Nodes

1. Navigate to the [Nodes page](https://microservicebus.com/Nodes).
2. From the *ACTION* button of your *Node*, select *Properties*.
3. Click the **AUDIT LOG** button.

### Environment data
> Environment data refers to things like available memory and storage along with environment variables and CPU information.
1. Navigate to the [Nodes page](https://microservicebus.com/Nodes).
2. From the *ACTION* button of your *Node*, select *Properties*.
3. Click the **ENVIRONMENT** button
4. Evaluate the result.
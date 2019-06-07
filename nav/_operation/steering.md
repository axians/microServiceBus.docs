---
layout: post
title:  "Controlling Nodes"
description: "Controlling Nodes is about much more than just enable or disable them. Learn more about how to Reset, Restart, Wipe, Move and Transfer your Nodes."
categories: operation
order: 60
---

## Restart Node

There is two recommended ways of restarting nodes.

1. Navigate to the [Nodes page](https://microservicebus.com/Nodes), find the **ACTION** button of your *Node* then click **restart**

2. Restarting a node by command

    Hit CTRL + R , and type **restart [YOUR NODE]** Eg.: · · ·

    ``` restart node001 ``` 

## Wipe Node (Not recommended)
Wiping the node will clear its setting!

1. Navigate to the *Nodes* page.
2. Click the **ACTIONS** button and select **Wipe**


## Move Node
Moving a node to another organization will cause the Node to reconfigure, restart and join a new organiztion based on it's IMEI identifier

1. Navigate to the *Nodes* page.
2. Click the **ACTIONS** button and select **Move**
3. Choose a new node name and choose Organization
4. Click Move
5. Change organization to  confirm that the node have been moved.

## History data
>Sometimes it can be very useful to look back in time to find patterns of communication issues and other events. For this we have *History data*

1. Navigate to the *Nodes* page.
2. Click the **ACTIONS** button and select **History**
3. Give it a few seconds, and *Last week events* window should pop up. This shows a graph of all Events (things happend on the *Node*), Audit log (actions taken from the portal), Failed- and successfull transmition of messages.
4. Close the *Last week events* window.

>Historic data is not sent to microServiceBus.com, unless requested.

## Audit log
>The *Audit log* shows any action taken on Nodes

1. Navigate to the [Nodes page](https://microservicebus.com/Nodes).
2. From the *ACTION* button of your *Node*, select *Properties*.
3. Click the **AUDIT LOG** button.

## Environment data
> Environment data refers to things like available memory and storage along with environment variables and CPU information.
1. Navigate to the [Nodes page](https://microservicebus.com/Nodes).
2. From the *ACTION* button of your *Node*, select *Properties*.
3. Click the **ENVIRONMENT** button
4. Evaluate the result.
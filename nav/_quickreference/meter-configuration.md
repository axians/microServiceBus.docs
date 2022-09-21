---
layout: post
title:  "Working with meter configuration"
description: "Learn how to provide individual meter configuration to Nodes"
categories: quickreference
order: 42
---
Assigning individual configuration to Nodes is an important aspect of IoT as Nodes may be integrating with different meters, sensors and other equipment from one site to another. Even if they are connected to the same kind of equipment, connecting might require specific settings. Node `Meter Configuration' allows you to create any number of specific settings that can be accessed from the Node and later used to connect, read and update meters.

> See also [Working with Meter schemas](https://docs.microservicebus.com/working-with-schemas) for a better understanding of schemas and how you can customize them.

## Glossary
As there are many different words describing similar things, there are a few commonly used terms that might be good to familiarize yourself with. 

#### Datasets
Datasets define the meter connected to the Gateway. If you were to connect to an `Modbus` meter, the meter would be a *Dataset*. If on the other hand were connecting to a `MBus` meter, the sensors connected to the *Mbus master* would represent the *Dataset*.

In cases such as `Modbus`, you may have any number of *Datasets* as other meters may be connected to the meter connected to the Gateway. In this case, each *Dataset* would have a `Slave Id` and `Function`.

#### Datapoints
While a *Dataset* represents the meter or sensor, the *Datapoint* represents a value of interest. If you for instance, an `MBus` telegram may have any number of *Data blocks*, where each *Data blocks* represents a different reading such as Indoor temperature and Outdoor temperature. Each *Data blocks* is a *Datapoint*.

`Modbus` meters have *Registers* which collectively holds many values. Each of those values  is a *Datapoint*.

## Meter schemas
Meter schemas defines the structure of the Meter Configuration and is tailored to serve a specific protocol. There are several schemas already available in **microServiceBus.com**, but you are free to create your own. 

Each schemas is devided into three top level sections:

#### Meter Info
General information about the meter such as identifier, manufacturer and model

#### Connectivity
The *Connectivity* section holds the necessary information about how we can connect to the meter such as Ip address or serial port

#### Datasets
See *Datasets* description above.

## Create a Meter Configuration
*Meter Configuration* is available through the **Action** menu on the Nodes page or through the **CTRL+R** option by typing 

```
config [node name]
```
Select a type of meter from the drop list and click the `ADD CONFIGURATION` button. This will open the configuration dialog where you can set all the parameters.

Saving the configuration, automatically updates the state of the Node. You can verify this by going to the properties page of the Node and click `DEVICE STATE` button. The **desired** section should have a `msbConfig` field with a URI pointing to the configuration.

## Using the Meter Configuration
The *Meter Configuration* is available in the Node services using the following command:
```javascript
// Access the configuration
const config = await this.Configuration();
// Get the actual meter configuration
const meterConfig = config.find((c) => c.meterinfo.id === '123456789');
// Use the configuration
var mbusOptions = {
    host: meterConfig.connectivity.ip,
    port: meterConfig.connectivity.port,
    timeout: 2000
    autoConnect: true
};

``` 
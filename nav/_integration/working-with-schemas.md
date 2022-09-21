---
layout: post
title:  Working with Meter schemas
description: Meter schemas are the definition of all properties and setting of meters. Meter schems are used when working with Meter Cconfiguration and can be cusomized to your needs.
categories: integration
order: 11
---

Meter schemas are the definition of all properties and setting of meters. Meter schems are used when working with Meter Cconfiguration and can be cusomized to your needs.

# Overview
When creating a `Meter configuration`, you select a schema aligned with your meter, such as Mbus TCP or Modbus RTU. You then proceed to add `Datasets`, `Datapoints` and `Metadata`. When you save your configuration, you have essentially added the configuration to your Node.
Services running on your Node, such as Modbus master will read the configuration to access the meter/sensor and retrieve the data.

# Terminology
The base structure of the schema is always the same. Hence, it needs to be generic. The table below explains some of these terminologies in the context of different types of meters and sensors: 

| Terminology    | MBus        | Modbus      | LoRA        |
| -------------- |-------------|-------------|-------------|
| **Meter configuration** | MBus gateway | Modbus meter | LoRA server 
| **Dataset** | Sensor | Modbus function/register | Sensor 
| **Datapoint** | Data record | Register address | Data point


# Working with JSON schemas
This is not the place to explain everything about schemas, but we will cover enough to get started. You should have a common knowledge about JSON before you get started.
Every section in the schema will have fields like:

| Field       | Description |
| -------------- |-------------|
| **$id** | A namespace/URL identifier of the field and need to be unique | 
| **type** | Such as "string", "integer", "boolean", "object" and "array" | 
| **title** | Common name visible to the end-user | 
| **description** | Often used as *placeholders* | 
| **default** | Default value | 
| **enum** | List of acceptable values |
| **properties** | List of **properties** of an element of type "object" |
| **items** | List of **elements** of an element of type "array".|

## Samples

### Basic
```json
"meterinfo": {
    "$id": "#/properties/meterinfo",
    "type": "object",
    "title": "Meter information",
    "description": "The General information about the meter",
    "required": [
        "id",
        "manufacturer",
        "model",
        "meterType"
    ],
    "properties": {
        "id": {
            "$id": "#/properties/meterinfo/properties/id",
            "type": "string",
            "title": "Meter identifier",
            "description": "The identifier of the meter"
        },
        "meterType": {
            "$id": "#/properties/meterinfo/properties/meterType",
            "type": "string",
            "title": "Meter type",
            "description": "E.g. Energy meter"
        },
        "manufacturer": {
            "$id": "#/properties/meterinfo/properties/manufacturer",
            "type": "string",
            "title": "Manufacturer",
            "description": "E.g. Kamstrup"
        },
        "model": {
            "$id": "#/properties/meterinfo/properties/model",
            "type": "string",
            "title": "Meter model",
            "default": "Sample"
        }
    }
}
```
*The sample above defines a `meterinfo` element with four properties;* `id`, `manufacturer`, `model` *and* `meterType` *all of which are required. The JSON output would look something like this:

```json
{
    "meterinfo":{
        "id": null,
        "meterType": null,
        "manufacturer": null,
        "model": "Sample",
    }
}
```
### Lists

```json
"metadata": {
    "$id": "#/properties/datasets/items/properties/datapoints/items/properties/metadata",
    "type": "array",
    "title": "Metadata",
    "description": "Metadata such as Unit and Scale can be added",
    "items": {
        "$id": "#/properties/datasets/items/properties/datapoints/items/properties/metadata/items",
        "type": "object",
        "title": "Metadata entry",
        "required": [
            "key",
            "value"
        ],
        "properties": {
            "key": {
                "$id": "#/properties/datasets/items/properties/datapoints/items/properties/metadata/items/properties/key",
                "type": "string",
                "title": "Key"
            },
            "value": {
                "$id": "#/properties/datasets/items/properties/datapoints/items/properties/metadata/items/properties/value",
                "type": "string",
                "title": "Value"
            }
        },
        "additionalProperties": false
    }
}
```
*The sampel above decsribes an element called `metadata` which is of type "array". The "items" element defines the structure of the containing objects, which in turn can have their own fields as decribed above.*

# Common structure
Needless to say, -the easiest way to get started is to copy an existing schema and customize it to your need.

## Root element
The root element is always an "object" and defines the unique identifier (`$id`) which needs to be unique throughout all schemas in the microServiceBus.com instance. The name and description is shown in the drop-box when the user selects the schema.

There are five mandatory sections of a schema:
* $baseType
* $type
* meterinfo
* connectivity
* datasets

### $baseType
There are some meters of similar kind such as MBus TCP, MBus RTU W-Mbus. These are all similar and would also share the same `$baseType` ("MBUS").

### $type
Related to the sample above, this could be "Modbus TCP" for example.

### meterinfo
The `meterinfo` section is metadata about the meter and would always look the same:
| Field       | Description |
| -------------- |-------------|
| **id** | A unique identifier of the meter | 
| **meterType** | E.g. Energy meter | 
| **manufacturer** | E.g. Elvaco | 
| **model** | E.g. CMeX50 | 

### connectivity
The `connectivity` section needs to be customized to provide all properties needed to connect to the device

### datasets
The `datasets` section needs to be customized to provide all properties needed to read the device

#### datapoints (list of dataset) 
The `datasets` section needs to be customized to provide all properties needed filter the telegram

##### metadata (list of datapoint) 
The `metadata` section should not be changed and gives the user the option of adding additional information. 

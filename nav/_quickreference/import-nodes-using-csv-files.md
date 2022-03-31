---
layout: post
title:  "Import nodes from CSV files"
description: "Enabling Console output, is perhaps one of the most useful means to get insight into the processes running on your device. Learn more about how to enable Console output in the portal, and how to control the debug logging from the Node."
categories: quickreference
order: 42
---
For users who need to create many Nodes, we recommend using the CSV import rather than creating one at the time from the Node page. Alternately, users can also use the microServiceBus.com© API, which is not going to be covered in this article.

To use the import file feature, it’s important that the file follows a specific format which is covered in the next section. Once the file is imported and validated, it is sent of for processing. This step might take a few minutes depending on the number of records in the file. When the process is completed, all users will get notified in the portal and an email is sent to the user who initiated the import.
When your file is ready to be imported, you can import it from the Nodes page by clicking the **CREATE NODE** drop-down button at the top, and then select the **Import from CSV** option.

## File format
The format must align with the following:

* The file should be UTF-8 encoded
* No header row. All rows of the file are considered records to be imported
* No empty rows at the end.
* Each row represents a record to be imported
* Each row is delimited with a line break ("/n") 
* Each field is delimited by a semi colon (";")
* All fields are required for all rows. Empty fields should just be left empty between semicolons

### Fields (per row)

| Position | Field                         | Format                                                | Mandatory             |
|----------|-------------------------------|-------------------------------------------------------|-----------------------|
| 1        | Name                          | Between 5 and 128 ASCII 7-bit alphanumeric characters | Yes                   |
| 2        | Type                          | Name of device type E.g."Elvaco CMe2100 G3"           | No                   |
| 3        | Description                   |                                                       | No                    |
| 4        | CostCenter                    | Cost center for billing                               | No                    |
| 5        | SlaLevel                      | LEVEL1 or LEVEL2                                      | No                    |
| 6        | Tags                          | Comman separaed list of tags                          | No                    |
| 7        | Mode                          | NORMAL or MAINTENANCE                                 | Yes                   |
| 8        | Template                      | Name of Node template                                 | No                    |
| 9        | Longitude                     |                                                       | No                    |
| 10       | Latitude                      |                                                       | No                    |
| 11       | TimeZone                      | E.g. US/Alaska                                        | No                    |
| 12       | IMEI                          | 14 numeric characters                                 | No                    |
| 13       | ICCID                         | SIM card id                                           | No                    |
| 14       | MacAddresses                  | Comma separated list of MAC addresses                 | No                    |
| 15       | SerialNo                      | HW serial number                                      | No                    |
| 16       | Gateway endpoint              |                                                       | Only if Type is TIER3 |
| 17       | Phone number                  |                                                       | No                    |
| 18       | APN                           |                                                       | Only if Type is TIER3 |
| 19       | Metadata                      | Used for routing. E.g. mt=42                          | Only if Type is TIER3 |
| 20       | Number of devices to scan for | Numeric value                                         | Only if Type is TIER3 |
| 21       | Interval                      | Numeric value                                         | Only if Type is TIER3 |
| 22       | Time unit                     | minute, hour, day                                     | Only if Type is TIER3 |


### Sample row
```
Name;Type;Description;CostCenter;SlaLevel;Tags;Mode;Template;Longitude;Latitude;TimeZone;12345678912345;ICCID;MacAddresses;SerialNo;Gateway endpoint;Phone number;APN;Metadata;Number of devices;Interval;Time unit
```
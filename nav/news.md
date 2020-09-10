---
layout: post
title:  "News"
categories: general
permalink: /news
---
<style>
summary{
    font-size: 1.3em;
        color: #777;
}
</style>

<details open><summary markdown="span">September 10th, 2020</summary> 

### [microservicebus.com](https://microservicebus.com)
* Data Visualizer
    * *Data Visualizer is a tool accessible through the menu and lets you demo and view live stream data. Check out the [documentation]({{site.baseurl}}/data-visualizer) for more info.*
* FIXED: Autocomplete menu on script editor (*Scripts & Services*) not visible
* FIXED: Oneway outbound services showing outbound connection
* BREAKING CHANGE: API POST whitelist
    * *POST `/api/organizations/{id}/whitelist` will no longer clear the whitelist. To clear the whitelist use the `/api/organizations/{id}/whitelist`.*


### [microservicebus-core](https://github.com/axians/microservicebus-core) version 3.5.3 (BETA) 
* Added node-pty dependancy
    * *node-pty is used as the back-end of the remote Node terminal and was previously installed as needed, but is now included by default.*

</details>


<details><summary markdown="span">September 1st, 2020</summary> 

### [microservicebus.com](https://microservicebus.com)
* Limit Node terminal to Organization owners
* Added API to update state with object
* GitHub integration - File pattern
    * *Users can now optionally set file pattern to match files imported through GitHub*
* FIXED: Issue with uploading Yocto images has been fixed
* FIXED: Session IdleTimeout has been increased from 20 => 8 hours

### [microservicebus-core](https://github.com/axians/microservicebus-core) version 3.5.0 
* Updated Azure SDK's
    * *All azure-iot-\* packages has been updated to latest version*
* Added meta data on sign-in
    * *IP- and MAC address together with firmware information is added to the sign-in request*

</details>


<details><summary markdown="span">August 26th, 2020</summary> 

### [microservicebus.com](https://microservicebus.com)
* Copy and paste in Terminal
    * *Users can now enjoy copy & paste functionality in the Node terminal*
* Warning users when using the remote Node terminal
    * *First time users are using the Node terminal they are made aware not to use commmands like `halt`, `shutdown` and `kill`.*
* Receive more data from Node upon sign-in
    * *Nodes (core version > 3.4.3) signing in will now include, IP- and MAC address together with firmware info if available. Although the portal is persisting this data, we have yet to figure out where to make it accessible*
* Ui improvements 
    * *Script & Service page has got some long overdue refresh.* 
* mSB API update
    * *Create Node API no longer require Node name. If no name is provided, the node will get assigned a new name.*
* More Node sign-in changes
    * *If the Node is registerd in the whitelist, the "claim" sign-in request will be bypassed and the Node will automaticly be registered*
* FIXED: json files are no longer being imported from GitHub

### [microservicebus-core](https://github.com/axians/microservicebus-core) version 3.4.3 (BETA)
* Updated Azure SDK's
    * *All azure-iot-\* packages has been updated to latest version*
* Added meta data on sign-in
    * *IP- and MAC address together with firmware information is added to the sign-in request*

### [meta-microservicebus 2.0.45 (BETA) (Yocto layer)](https://github.com/axians/meta-microservicebus)
* FIXED RAUC issue
    * *Fixed issue with RAUC service triggering to and causing parsision info to be incomplete*
</details>


<details><summary markdown="span">August 20th, 2020</summary> 

### [microservicebus.com](https://microservicebus.com)
* Filter by tag
    * *Users can now filter their search by Tag by selecting one or more tags in the new drop-down list on the Node page*
* Toggle grid view on Flow canvas
    * *In the upper-right corner of the Flow designer, users now find a grid toggle button. Toggling grid view will enable services to snap to grid,*
* Ui improvements 
    * *Some overall improvements on the Flow design dialog* 
* FIXED: Fixed issue where user sometimes got redirected to msb.com:44390

### [meta-microservicebus 2.0.42 (Yocto layer)](https://github.com/axians/meta-microservicebus)
* New terminal screen
    * *Terminal users are welcomed with a new shiny screen complemented with commonly used shortcuts*
* Added NTP service
    * *The Network Time Protocol (NTP) is used to synchronize the time of a computer client or server to another server or reference time source, such as a radio or satellite receiver or modem. http://support.ntp.org*
</details>

<details><summary markdown="span">August 18th, 2020</summary> 

### [microservicebus.com](https://microservicebus.com)
* Remote Terminal
    * *Users can now enjoy a remote ssh terminal from mSB.com with full access to the Node.*
* Claim node to existing node
    * *Nodes signing in using claims can now be assigned to existing Nodes*
* More info for Claim Node 
    * *Nodes that are visible using claims now presents all IP-and MAC addresses* 
* Added commands to 3rd party devices
    * *A new Action menu appears on the Node property page for 3rd party devices*
* Route to url on login 
    *  *If users navigate to a page before login they will now get redirected to this page after login* 
* Added API to execute scripts on a Node
    * *Previously the runScript API was only available with tag filter.*
* Passing parameters when running scripts on Node
    * *Users can now pass parameters to the runScript API (Organization and Node API)*
* Missing readings GA
    * *Alerts on Missing readings is now available*
* UI Update: Updated styles for campaign and price calculator
* FIXED: Fixed issue with not being able to remove prod itineraries w/o unbinding version
* FIXED: Fixed issue where it was not possible to remove items from Node Whitelist
* FIXED: Fixed issue when moving Node to other organization

### [microservicebus-core](https://github.com/axians/microservicebus-core) version 3.4.0
* Remote Terminal
    * *Users can now enjoy a remote ssh terminal from mSB.com with full access to the Node.*
* Passing parameters when running scripts on Node
    * *Users can now pass parameters to the runScript API (Organization and Node API)*
* MSB_NODE_HOST => MSB_HOST
    * *Previous environment variable MSB_NODE_HOST is now called MSB_HOST* 
* Improved Docker support 
    *  *The Node can now control and manage containers running in Snap/Docker* 
* Immediate version update on restart
    * *Nodes are now updated after first restart*
* Logging mSB-core version
    * *Added msb-core version to logs when starting*
* Login using MAC address is now using all MAC addresses for identification
* FIXED: Removed legacy signalR and added restart method to AzureIoT
* FIXED: Fixed issue with installing docker images

</details>

<details><summary markdown="span">April 23th, 2020</summary> 

### [microservicebus.com](https://microservicebus.com)
* Added support for managing docker containers 
    *  *You are now able to manage docker containers on your Node. Through the Device interface on the Node, you can now install images and containers while also stop start and update them* 
* Improved support for Yocto images
    * *Better versioning and support for switching partitions*
* Preparations for May release
    * *The May release of 2020 will require users to reset passwords*

### [microservicebus-core](https://github.com/axians/microservicebus-core) version 3.0.0
* Preparations for May release
    * *The V2 version of micriServiceBus.com will come with an updated protocol for device management communication.* 
* Added support for StopAsync and StartAsync
    * *While Start and Stop functions still works as before, the StartAsync and StopAsync provides a more controlled process* 
* Added support for managing docker containers 
    *  *You are now able to manage docker containers on your Node. Through the Device interface on the Node, you can now install images and containers while also stop start and update them* 

### [meta-microservicebus](Yocto)
* Added new meta layer for Compulab IMX7
* Improved support for microServiceBus-dam

</details>



<details><summary markdown="span">Mars 27th, 2020</summary> 

### [microservicebus.com](https://microservicebus.com)
* Added DeviceManagement API 
    *  *You can now manage devices which are not running the microServiceBus Node agent though the manufacturers provided API.* 
* Support for Elvaco CMe2100G3
    * *The CMe2100G3 is an MBus metering gateway from Elvaco, compatible with most standard MBus meters and can be configured and managed through miroServiceBus.com*
* Generic installation scripts for Linux and Windows
    * *After created a Node, you are guided to the installation and setup page providing you with all possible ways to install the Node. The generic scripts will not only install the Node but all necessary dependencies*
* Updated privileges for claiming nodes
    * *Co-administrators are now allowed to claim nodes*
* Copy emails
    * *You can now copy email addresses from all your team members on the Organization page*

### [microservicebus-core](https://github.com/axians/microservicebus-core) version 2.9.0
* Added support for setting the mSB instance as environment variable (MSB_NODE_HOST) 
* FIXED: Formatting errors when showing flows
* FIXED: Nodes should not try to recover from disconnected state while disabled
</details>

<details><summary markdown="span">Mars 13th, 2020</summary> 

### [microservicebus.com](https://microservicebus.com)
* Support for agent-less devices 
    *  *You can now manage devices which are not running the microServiceBus Node agent though the manufacturers provided API.* 
* Support for Elvaco CMe2100G3
    * *The CMe2100G3 is an MBus metering gateway from Elvaco, compatible with most standard MBus meters and can be configured and managed through miroServiceBus.com*
* Generic installation scripts for Linux and Windows
    * *After created a Node, you are guided to the installation and setup page providing you with all possible ways to install the Node. The generic scripts will not only install the Node but all necessary dependencies*
* Updated privileges for claiming nodes
    * *Co-administrators are now allowed to claim nodes*
* Copy emails
    * *You can now copy email addresses from all your team members on the Organization page*

### [microservicebus-core](https://github.com/axians/microservicebus-core) version 2.9.0
* Added support for setting the mSB instance as environment variable (MSB_NODE_HOST) 
* FIXED: Formatting errors when showing flows
* FIXED: Nodes should not try to recover from disconnected state while disabled
</details>

<details><summary markdown="span">February 21th, 2020</summary> 

### [microservicebus.com](https://microservicebus.com)
* Share Flows accross Organizations
    *  *Flows created in the Root Organization will automaticly be accessable to all Organizations, but only editable in the Root Organization. Services in such FLows are therefor only addressable using Tags and not Node name* 
* Notify team members
    * *If you need to quickly notifying team members, you can do so using CTRL+R and type "info " + your message. Eg.*

    ```
    info I'm restarting node-00002
    ```
* Improved Delete Node page
    * *Users are now provided more details on deleting Nodes.*
* Co-administrators can now delete Nodes
    * *This was previously only allow for Owners*
* Provision using serial number
    * *This was previously only done using IMEI*
* API Update
    * *Added API to force Nodes to report Vulnerabilities*
* Azure DevOps integration
    * *Improved error handling for setting up Azure DevOps*

* FIXED: Issues with NPM Vulnerability list.
* FIXED: Organization and Node SLA was not shown properly
* FIXED: Changing policies on Nodes which had never signed in failed.
* FIXED: Broken help link from Create Node page

### [microservicebus-core](https://github.com/axians/microservicebus-core) version 2.8.0
* Script/Service version shown on start up
* Flow environment shown on start up
* Vulnerabilities report update
* FIXED: Updated mSB-dam error handling
* FIXED: SNAP list version where wrong

### [microservicebus-dam](https://github.com/axians/microservicebus-dam) version 1.2.3 (Snap stable)
* Get grants using serial number
* mSB-dam now calls directly to designated instance of mSB.com
* Improved stability
* Improved error handling
</details>

<details><summary markdown="span">February 7th, 2020</summary> 

### [microservicebus.com](https://microservicebus.com)
* Creating nodes
    *  *There is now a guide of dialog boxes/forms (wizard) that lead the user through a series of well-defined steps when creating a node. The purpose of this is to simplify the way of creating nodes and the onboarding nodes.* 
* Improvments to Console
    * *Resolved issue where Console got overflow by moving the content to a sized buffer. The new Console allows a more flexiable search and highlighting.*
* More data-plan details on Node
    * *IP-address, session start time and end time has been added to Node details page*
* FIXED: Tracking issues resolved where tracking data was not shown in the history.
* FIXED: Deleting Organizations was not working

### [microservicebus-core](https://github.com/axians/microservicebus-core) version 2.7.0
* Updated dependancies
    * *Updated nyc => 15.0.0 & azure-iot-device => 1.12.2*
* Snap refresh
    * *Preserve devmode for snaps installed as devmode*
* Console overflow
    * *Truncating log messages > 1000 chars*
* FIXED: Vulnerability scan had some issues that has been resolved
</details>

<details><summary markdown="span">January 17th, 2020</summary> 

### [microservicebus.com](https://microservicebus.com)
* Show snap list in vulnerabilities view
    * *The Vulnerabilities page is now showing an aggregated view of all Snaps used, along with information about latest versions*
* Improved visualization of tags
    * *Tags on Nodes are now shown as "tags" rather than a comma separated list.*
* Organizations are created as CI's in ServiceNow
    * *For the purpose of aggregated incidens (such as "One or more nodes has outdated Snaps...", Organizations are now registered as CI's in ServiceNow.*
* Added new System error codes:
    * *90006 - Organization has npm vulnerabliteies*
    * *90007 - Organization has Snaps to be updated*
    * *90010 - Failed login*
    * *90011 - Invalid user login*
    * *90020 - Data plan limit approaching*   
    * *90021 - Data plan reached*      

### [microservicebus-core](https://github.com/axians/microservicebus-core) version 2.6.0
* Improved support for cloud to device messaging
* Improved handling of octet-stream 
* Daily reporting of installed Snaps
</details>

<details ><summary markdown="span">December 12th, 2019</summary> 

### [microservicebus.com](https://microservicebus.com)
* Service usage
    * *You can now find out wich Flows are using a service directly from the Service/Script page*
* Flow usage
    * *Ever wanted to know which FLows are used by a Node. You can now find out using the Action button on the Nodes page.*

</details>

<details ><summary markdown="span">December 1st, 2019</summary> 

### [microservicebus.com](https://microservicebus.com)
* Improved Node vulnerabilities view
* Improved ServiceNow integration
    * *Better syncronization with CI's*
* Performance update
    * *Performance imrovements done to Node, Flow and MAnagement page*



### [microservicebus-core](https://github.com/axians/microservicebus-core) version 2.4.0
* Improved support for Node vulnerabilities
    * *Nodes now provide informatoin about snaps*
* Updated Azure IoT SDK
    * *azure-iot-device => 1.12.0*
    * *azure-iot-device-mqtt => 1.11.0*
    * *azure-iot-device-amqp => 1.11.0*
* Avoiding loading dependancy files multiple time
    * *Depenancy files will now only get downloaded once although referenced from many  services.*

* Better support for cloud messaging
* Added support for octet stream
* Added support for rauc and azure iot-edge
* Improved integration with snap

### [microservicebus-yocto](https://github.com/axians/microservicebus-yocto) 
* Added support for Azure IoT Edge

</details>

<details ><summary markdown="span">November 7th, 2019</summary> 

### [microservicebus.com](https://microservicebus.com)
* Un-suck IoT campaign
    * *https://microservicebus.com/iotsucks and home page carousel.*
* Added suport for Azure IoT Edge. 
    * *IoT Edge nodes are based on docker and can run cloud modules such as machine learning side-by-side with the microServiceBus node. By moving certain workloads to the edge of the network, your devices spend less time communicating with the cloud, react more quickly to local changes and operate reliably even in extended offline periods.*
* Claim Node
    * *Nodes started without parameters can now be claimed in portal*
* microServiceBus.API 
    * *Restart Node by id*
* Updated price calculator
    * *https://microservicebus.com/pricecalculator*
* Minor UI updates
    * *Some minor graphical updates and fixes has been applied on the Node page.*

* FIXED: Bug with invites not deleted 
* FIXED: Pricecalculator 24/7 prices fixed 
* FIXED: Tag are not saved when cloning stage flow

### [microservicebus-core](https://github.com/axians/microservicebus-core) version 2.4.0
* Added suport for Azure IoT Edge. 
    * *IoT Edge nodes are based on docker and can run cloud modules such as machine learning side-by-side with the microServiceBus node. By moving certain workloads to the edge of the network, your devices spend less time communicating with the cloud, react more quickly to local changes and operate reliably even in extended offline periods.*
* Disable debug after 30 minutes.
    * *Debug console will automaticly be disabled after 30 min.*

* FIXED: Fixed History (TTLCollection)

### [microservicebus-node](https://github.com/axians/microservicebus-node) version 2.0.10
* Updated node.js version
    * *Node.js version 12.11*
* Updated snap version to 2.0.10
    * *Logic for logging in with IMEI is moved to mSB-core*

### [meta-microservicebus-raspberrypi (Yocto)](https://github.com/axians/microservicebus-yocto) version 1.2.0
* Update bundle version as msb-node version now is 2.0.8
* Minor fixes

</details>

<details><summary markdown="span">September 29th, 2019</summary> 

### [microservicebus.com](https://microservicebus.com)

* Added suport for signing in Nodes anonymous. 
    * *Signing in Nodes anonymous, and later claiming the Node in the portal provides an easy provitioning process. visit [microServiceBus.docs](/provitioning-of-nodes) for more information*
* Integration with Fiware
    * *microServiceBus.com can now be integrated with Fiware Orion Context Broker to store and update entities from meters and sensors in the field. For more information about Fiware, visit https://www.fiware.org* 
* microServiceBus.API 
    * *More Flow API's for browsing Flows and Services*
* Move Nodes to other Organizations
    * *This feature no longer require the node to be online*
* Minor UI updates
    * *Some minor graphical updates and fixes has been applied on the Node page.*


### [microservicebus-core](https://github.com/axians/microservicebus-core) version 2.2.0
* Added suport for signing in Nodes anonymous. 
    * *Signing in Nodes anonymous, and later claiming the Node in the portal provides an easy provitioning process.*

* FIXED: dependencies marked with vulnerabilities 
* FIXED: Vulnerabilities scan for Snap Nodes

### [microservicebus-node](https://github.com/axians/microservicebus-node) version 2.0.10
* Updated node.js version
    * *Node.js version 12.11*
* Updated snap version to 2.0.10
    * *Logic for logging in with IMEI is moved to mSB-core*

### [meta-microservicebus-raspberrypi (Yocto)](https://github.com/axians/microservicebus-yocto) version 1.2.0
* Update bundle version as msb-node version now is 2.0.8
* Minor fixes

</details>

<details ><summary markdown="span">August 13th, 2019</summary> 

### [microservicebus.com](https://microservicebus.com)

* Updated Audit log
    * *Added Node description and fixed audit logs for snap*

* FIXED: Log file list
    * *List of log files at the Nodes page is now sorted correctly*


### [microservicebus-core](https://github.com/axians/microservicebus-core) version 2.1.0
* Add aggregated exception interval
    * Users can now set how often exceptions of same type get sent to tracking
* Added refreshSnap
    * *Refresh Snap is called from the portal or API*
* FIXED: dependencies marked with vulnerabilities 
* FIXED: Vulnerabilities scan for Snap Nodes

</details>

<details><summary markdown="span">August 8th, 2019</summary> 

### [microservicebus.com](https://microservicebus.com)

* Manage Incident policies
    * *Incident policies is part of Device Management and allow you to take actions on exceptions and alerts, such as when Nodes comes of line or custom alerts. For more info visit [docs.microservicebus.com](https://docsmicroservicebus.com/working-with-incident-policies)*
* 'SLA' (Service Level Agreement) information and 'Cost Center' now available at '/api/organizations' API.
    * *For more info visit [Swagger docs](https://microservicebus.com/swagger)*
* Update Snaps
    * *Snaps (Ubuntu) can now be updated using the Manage device environment dialog. For more info visit [docs.microservicebus.com](https://docsmicroservicebus.com/managing-firmware-and-device)*
* Run scripts
    * *Patch scripts can be remotely executed on Nodes using the Manage device environment dialog. For more info visit [docs.microservicebus.com](https://docsmicroservicebus.com/managing-firmware-and-device)*

</details>

<details><summary markdown="span">July 19st, 2019</summary> 

### [microservicebus.com](https://microservicebus.com)

* Manage firmware
    * *Firmware can now be managed through a special dialog on the Nodes page.*
* Mark partition
    * *You are now able to mark which partition to be active*

### [microservicebus-core](https://github.com/axians/microservicebus-core) version 2.0.90
* Updated Azure device SDK
    * *Updated azure-iot-sdk-node => 1.10.0*
* Update yocto firmware image
    * *Improved error handling*
* Enabled Mark partition
</details>

<details><summary markdown="span">July 7th, 2019</summary> 

### [microservicebus.com](https://microservicebus.com)

* Vulnerabilities viewer
    * *Vulnerabilities from all nodes are presented in one view, grouped by severity*
* Added CostCenter and SLA
    * *CostCenter and SLA has been added to Organization and Nodes*
* Usage API
    * *Added /api/organizations/usage to give insight to billing.*
* Price calculator
    * *To provide a better cost estimate including portal, device management and sim-cards*
* FIXED: Avoid sending empty grants grants to mSB-dam 
* FIXED: Japser provisioning
* FIXED: Github integration 
 
### [microservicebus-core](https://github.com/axians/microservicebus-core) version 2.0.80
* Updated snapcraft version
    * *Added tpm plug*
* Updated dependancies
* FIXED: vulnerabilities for Security Alerts on tar package

### [microservicebus-node](https://github.com/axians/microservicebus-node) version 2.0.7
* Vulnerabilities Scan
    * *A Vulnerability scan is performed daily and submitted to the portal*
* FIXED: Changes to Node policies should be applied immediately 
* Minor bug fixes
</details>

<details ><summary markdown="span">June 1st, 2019</summary> 

### [microservicebus.com](https://microservicebus.com)

* Clone Flow - handle target environment
    * *Optionally bind version of services*
* Add validation of HMAC signature in JasperNotification API.
    * *Incoming requests from Cisco Jasper are now validated using HMAC signature.*
* Preparation for support for new IoT Providers
    * *Plan is to support Oracle Cloud and FiWare*
* User documentation
    * *More updated user documentation on [docs.microservicebus.com](https://docs.microservicebus.com)*
 

### [microservicebus-core](https://github.com/axians/microservicebus-core) version 2.0.70
* Do retries when downloading service files
   * *To prevent failures while downloading scripts and services*
* Increased the retry interval when signing in using imei
    * *Preventing unnecessary restart of service*
* Updated AWS SDK => 2.2.1
* Azure IoT SDK stability improvements.
* FIXED: Unable to download new firmware due to full disk
   * *Clean firmware directory before downloading new image*
* FIXED: Unable to download syslogs
   * *Improved error handling for uploading syslogs + updated dbus interface*
* Support for compression
   * *Built-in support for compression of messages*
* Minor bug fixes
</details>

<details ><summary markdown="span">May 13th, 2019</summary> 

### [microservicebus.com](https://microservicebus.com)

* Integrate external ticketing system (ServiceNow)
   * *Users can now throw their own custom exceptions to ServiceNow*
* Updated all help links
   * *Linked all help pages to docs.microservicebus.com*
* Manage state from Node page
   * *Users can now set Nodes in Normal-, Maintenance- and Test mode *
* Only accept accepted pull requests
   * *When using git integration, PR's are only completed when accepted*
* Updated microServiceBus.API
   * *Update API to include FindById (ICCID, IMEI or hostname)*
* Improved error handling in Node Sign-in
   * *Making it easier to find issues related to Sign-in*
* Use Shared Secret to validate inbound calls from Jasper
   * *Shared secrets can now be used to validate inbound calls from Cisco Jasper*
* Clone Flow itinerary
   * *Users are now able to clone Flows while mapping Node names and tags*
* Download Syslog from portal
    * Users can now download syslogs from the Nodes page

</details>

<details><summary markdown="span">April 21th, 2019</summary> 

### [microservicebus.com](https://microservicebus.com)

* Maintenance and Test mode on *Nodes*
   * *Nodes can now be set in Maintenance to prevent alarms*
* Simplified authentication for Site Verification
   * *Nodes now has to be set to TEST MODE before accepting tests to run*
* Toggle Comment and file name in script window
   * *Mark text in script editor and toggle commenting the text using CTRL+/*
* Only accept accepted pull requests
   * *When using git integration, PR's are only completed when accepted*
* Stay on scripts page when switching organization
   * *Same behavior as for Nodes and Flows*
* Improved error handling in Node Sign-in
   * *Making it easier to find issues related to Sign-in*
* Use Shared Secret to validate inbound calls from Jasper
   * *Shared secrets can now be used to validate inbound calls from Cisco Jasper*
* Added QR code to test scripts
   * *Upon saving a Test Script, a QR code is presented for easier exposing the test*


### [microservicebus-core](https://github.com/axians/microservicebus-node) version 2.0.50
* Maintenance and Test mode on *Nodes*
   * *Nodes can now be set in Maintenance to prevent alarms*
* Added dbus IsActive endpoint
   * *Enabling external applications and services to check on status for mSB-core*
* More portal notifications
   * *Nodes are now notifying on firmware updates*
* Support for compression
   * *Built-in support for compression of messages*
* Minor bug fixes

</details>

<details><summary markdown="span">March 26th, 2019</summary> 

### [microservicebus.com](https://microservicebus.com)

* Improved tracking and monitoring
   * *Better and faster tracking and integration with ServiceNow*
* Manage Incident Policies allowing organizations to add custom incidents
   * *Users are now able to set up custom incidents which will be escalated to ServiceNow*
* Site verification app
   * *The site verification app can be used to run custom unit tests on Nodes at runtime*
* Added QR code to test scripts
   * *QR-code for faster access to the site verification app*
* Download and view syslogs from portal
   * *Users are now able to initiate, download and view syslogs from Nodes*
* Trigger firmware update from action menu
   * *Before this release, firmware updates could only be initiated from the API*
* Delete firmware image
   * *Users can now remove firmware images from the Node page*
* “Remove me” from organization and email tooltip of users
   * *Users can now remove themselfs from organizations*


### [microservicebus-core](https://github.com/axians/microservicebus-node) version 2.0.27
* Update Yocto firmware works with version and platform
   * *This prevents images to be downloaded installed if the device is already using the latest version*
* Site verification scripts
   * *Allowing the execution of unit tests to be executed on the Node. These scripts can be used to verify installation setup.*
* Updated Azure device SDK to 1.9.4
   * *Nodes are now being notified on disconnect*
* Support for compression
   * *Built-in support for compression of messages*
* Minor bug fixes

</details>

<details>
<summary markdown="span">February 26th, 2019</summary>

### [microServiceBus.com](https://microservicebus.com)
* Serverside performance improvements
   * *Mainly focusing on Node sign in*
* On-site test scripts
   * *Providing capabilities to let site technitians running unit test on-site to verify installation*

### [microservicebus-core](https://github.com/axians/microservicebus-node) version 2.0.14
* Enable remote unit testing
   * *To support On-site test scripts (see microServiceBus.com)
* Improved support for Yocto
   * *Extract platform and version from Yocto bundle*
* Updated Azure SDK => 1.9.3

### [microservicebus-dam](https://github.com/axians/microservicebus-dam) version 2.0.1
* Extended to support Yocto
   * *Corrected bug where DAM only worked in snap env*.


</details>




<details>
<summary markdown="span">February 1st, 2019
</summary>


### [microServiceBus.com](https://microservicebus.com)
* UI performance improvements
   * *Improvments of how scripts and styles are loaded*
* Managing ssh user account and keys
  * *Improve UX*
* Visualization of environment status
   * *Improved visualization of environment with all networks and serialport*
* Show device state (Azure- & AWS IoT hub) on Node property
   * *Users can now view and edit device twin/shadow directly in the portal*
* Updating code snippet colleciton to include new features
   * *Added snippets for **GetCurrentState**, **GetLocalTime** and **GetInstanceOf***
* FIXED: Closing flow window by clicking on the upper right corner botton doesn't work

### [microservicebus-core](https://github.com/axians/microservicebus-node) version 2.0.1
* TTLCollection available from services
   * *TTLCollection to support adding unique items*
* Add all networks and serialports to requested Environment
   * *see microServiceBus.com*
 

</details>
   
   



<details>
<summary markdown="span">December 27th, 2018
</summary>

### [microServiceBus.com](https://microservicebus.com)
* Lock microservicebus-core version on Organization
* Lock microservicebus-core version on Node
* Lock script/service version in Flow
* CTRL+S/Cmd-S short key for saving scripts
* Updated support for binary messages
* AZUREDEBUG option
* Save last latest command using CTRL+R
* Added functionality to move node between organizations
* API to apply Node template to existing nodes
* Send invites to multiple people
* Azure SDK 1.8
* TTLCollection built in to microservice.js
* FIXED: Resize “View source” window
* FIXED: Remove services from flow

### [microservicebus-node](https://github.com/axians/microservicebus-node) version 2.0.0
* Lock microservicebus-core version 

### [microservicebus-core](https://github.com/axians/microservicebus-core) version 2.0.1
* microservicebus-core is now running the latest version of Azure Device SDK, fixing issues where messages did not get delivered properly
* Updated support for binary messages

### [microservicebus-dam](https://github.com/axians/microservicebus-dam) version 1.0.0
* Manage SSH keys in portal
* microservicebus-dam snap/daemon
* Grant access to Node

### [mSB-yocto](https://github.com/axians/microservicebus-yocto) version 1.0.0
* microservicebus-node Yocto layer
* Upload firmware
* Firmware updates using RAUC (bootloader interface)
* Trigger “Update firmware” from mSB.API


</details>



<details>
<summary markdown="span"> November 30th, 2018
</summary>

### [microServiceBus.com](https://microservicebus.com)
* Grant individual logon privilages (mSb.dam)
* Lock organization to microservicebus-core version preventing forced updates
* Support for locking Flows to script/service version
* Added CTRL+S/Cmd-S short key for saving scripts
* FIXED: "Fetch from repo" working kind of funky

### [microservicebus-node](https://github.com/axians/microservicebus-node) version 1.0.27
* Support for *Device Access Manager* (mSb.dam)
* Support for custom repos of microservicebus-core and microservicebus-node
* Lock organization to microservicebus-core version preventing forced 
* Updated snap

### [microservicebus-core](https://github.com/axians/microservicebus-core) version 1.2.52
* Support for *Device Access Manager* (mSb.dam)
* Lock organization to microservicebus-core version preventing forced 
* Support for locking Flows to script/service version
* FIXED: RECONNECTING loop

### [microservicebus-dam](https://github.com/axians/microservicebus-dam) version 1.0.0
* Support for *Device Access Manager*
* Updated snap


</details>



<details>
<summary markdown="span"> November 4th, 2018
</summary> 


### [microServiceBus.com](https://microservicebus.com)
* Improve error message for Github permission error
* Added funtionality to move node between organizations
* (Yocto) Download firmware metadata
* Add under general properties in itinerary designer the service organisation location.
* FIXED: Can't right click on the service in the itinerary designer

### [microservicebus-core](https://github.com/axians/microservicebus-core) (1.2.40)
* (Yocto) nodejs RAUC D-Bus integration
* FIXED: Message context lost on SubmitResponsemessage
* FIXED: First microservicebus-core-install, with very slow connection, gets stuck (waited 30 min) #551


</details>



<details>
<summary markdown="span"> October 21st, 2018 
</summary> 


### [microServiceBus.com](https://microservicebus.com)
* Remove single whitelist entry + add confirmation to Clear list #532
* API to apply Node template to existing nodes #545
* Send invites to multiple people #553
* Enable / Disable node with CTRL+R creates multiple services on node #535

* FIXED: Changes not saved in script window if you don't close window between saves #531
* FIXED: Node keys are not renewed when changing IoT Hub provider
* FIXED: Performance improvements for handling signIn & creation of nodes. #529
* Opened in axians/microServiceBus.com


</details>



<details>
<summary markdown="span"> October 10th, 2018
</summary> <b>


### [microServiceBus.com](https://microservicebus.com)
* Remove single whitlist entry
* Enable/Disable nodes using CTRL+R
* Upload Yocto firmware image
* Download Yocto firmware image API
* Performance improvements
* Apply node templates to nodes using API
* FIXED: Cut long Flow names in list

### [microservicebus-core](https://github.com/axians/microservicebus-core) (1.2.31)
* Fixed issue restarting COM upon State gets updated


</details>



<details>

<summary markdown="span"> September 7th, 2018
</summary> 


### [microServiceBus.com](https://microservicebus.com)
* Show diff on Audit log
* (Node API) Updated (start, stop, enable) to use PUT verb
* (Node API) Creating a node returns the object
* VSTS integration to trigger on Pull Requests
* Show Script window from *Services* in *Flow*
* FIXED: duplicate services started when mltiple tags were used
* FIXED: Node name textbox should be read-only
* FIXED: createNodeFromMacAddress should not require authorization
* FIXED: Ctrl+R does not work in all pages

### [microservicebus-core](https://github.com/axians/microservicebus-core) (1.2.18)
* FIXED: Changed state should trigger all "Receive State" services

### [microservicebus-node](https://github.com/axians/microservicebus-node) (1.0.26)
* Add timeout to ensure installation of core does not hang
* Updated snap version to 1.26


</details>



<details>

<summary markdown="span"> August 11th, 2018
</summary> 


### [microServiceBus.com](https://microservicebus.com)
* Enabled *Node templates* when *Nodes* are created using Cisco Jasper integration
* Impoved Search on *Node* page 
* Added more trace events from *Nodes*
* Added "Copy machine name" to serial no
* Updated Jasper API not to depend on IMEI
* Added back audit log to history
* Added more Cisco Jasper information
* Added "Go to source script" from *Flow*
* Enable annotation for scripts (for Git commits)
* FIXED: Tags should not be case insensative
* FIXED: bug when creating nodes thorugh Jasper for the first time (no nodes exists)
* FIXED: Console not working on Edge


</details>



<details>

<summary markdown="span"> July 23rd, 2018
</summary>


### [microServiceBus.com](https://microservicebus.com)
* Added policys for Nodes.
    * Now you can set policy for nodes, you can change disconnect, reconnect and offline mode actions.
* Added node templates.
    * When creating new nodes you can choose to create them from a template with specific settings. Managing bulk creation of nodes just became easy.
* Updated API.
    * New features: Enable, Disable and Restart nodes
* Format JSON in debug console.
* Give organization ownership to Co-Admin
    * Now possible to give owner access to a Co-Admin in your organization.
* Improved node properties page.
* FIXED: Oranization delete page shows right information
 
### [microservicebus-core](https://github.com/axians/microservicebus-core)
* Implement policys. (disconnect, reconnect, offline mode)


</details>



<details>
<summary markdown="span"> June 30th, 2018
</summary> 


### [microServiceBus.com](https://microservicebus.com)
*  New Swagger based API
    * For integration with LOB system for managing your Nodes. This API will be extended for many more options in the future. 
*  Format JSON messages in console 
    * When ourputting JSON in the Debug output, you can optionally have it formated.

*  FIXED: Resizing Flow designer now works
 
### [microservicebus-core](https://github.com/axians/microservicebus-core)
*  Many more events persisted to History
*  Removed redundant packages that were part of [microservicebus-core](https://github.com/axians/microservicebus-node)
*  Disable IoT Hob connection on disabling the node.


</details>



<details>

<summary markdown="span"> June 19th, 2018
</summary> 


### [microServiceBus.com](https://microservicebus.com)
*  Saving a flow with a node-attribute set to a non-existing node in a service silently gets created
    * This behavior has now changed, and you can optionally save your *Flow* without creating the nodes
*  Auto-complete tags when writing '#' in nodes fields
    * When selecting a *Node* in the *Flow* designer, you can now select from a list of both Nodes and Tags

*  FIXED: Flow's are disabled by default 
    * Flows are nolonger disabled after saving

*  FIXED: Login redirect fires to quickly and doesn't let users edit login
    * Users that once looged in using ADFS were not able to change login

*  FIXED: Tags not working for Inbound State Services

### [microservicebus-core](https://github.com/axians/microservicebus-core)
*  Get and instance of another service from code within the same Flow
Services normaly interact through the *Service* connectors in the *Flow* diagram. But sometimes a service can only exist once, such as for accessing a serial port. In such cases you can get an instance of a specific service using:
```javascript
var srv = this.GetInstanceOf('mbuService');
srv.Process(msg, context); // or any other method
```
*  FIXED: Tags not working for Inbound State Services


</details>



<details>
<summary markdown="span"> June 5th, 2018
</summary>


### [microServiceBus.com](https://microservicebus.com)
*  New beautiful background image
[Rickard Lundqvist](https://www.instagram.com/photobyrickard/) taken this beutiful picture of Nybrokajen in Stockholm.
*  Provide Node shutdown option from portal
Nodes can now be shutdown from the [microServiceBus.com](https://microservicebus.com) portal
*  Enabled remote debug using Chrome Dev Tools
Earlier version of remote debugger has been removed and changed to Chrome Dev Tools
*  Audit log
Audit log has been made available for **Organization**, **Nodes** and **Services & Files**
*  Show full name of user
User name is now shown in the upper right corner rather than the email address
*  Script formating
You can now format scripts in the Script Editor
*  Added Privacy information
Making sure everyone understands we don't sell or use their data
*  Dell Edge 3001 Temp and humidity service
Service for the built-in sensor in Dell Edge 3001
*  Automaicly set the name of script files
Setting the name of the Service will automaticly set the name of the file in camel case.
*  Prevent Unauthenticated SignalR calls from nodes
All calls from Nodes are authenticated directly on connection rather than only using SignIn method.

*  FIXED: Disable Flow doesn't work
*  FIXED: Change "Reset" to "Wipe" on Node Action menu
*  FIXED: Don't create nodes from typing a name of a node that doesn't exist in a flow
*  FIXED: Unit tests not working
All unit tests have been refactored and moved to travis

### [microservicebus-core](https://github.com/axians/microservicebus-node)
*  GetInstanceOf method on Services
Get an instance of an other service in the same flow using a simple method call.
# Apr 22nd, 2018
### [microServiceBus.com](https://microservicebus.com)
*  New beautiful background image
[Håkan Garnefält](https://www.instagram.com/haawks/) has been kind enough to share his spring picture of Stockholm by the sea.
*  Audit log for Flows, Nodes, Organization and Scripts  
Users can access the audit log through a number of views in the portal. 
*  Full integration with Visual Studio Team Services
You can now manage your scripts and services in VSTS and push your changes to microServiceBus.com
*  Node API
External applications such as ServiceNow, can now interact with Nodes using the API
*  Download all scripts
You can now download all script files from the [Scripts page](https://microservicebus.com/Files). This feature can come handy when migrating to VSTS or GitHub.
*  Mobile console
The *Console has been extended to the mobile view

*  **FIX:** GitHub integration issues has been resolved
*  **FIX:** Default organizations is stored in session
*  **FIX:** Organizations can now change names
### [microservicebus-core](https://github.com/axians/microservicebus-node)
*  Set environment parameter at startup
*node start* now accepts **--env** such as:
```
node start -c ASDGJ -n myNode -env myorg.microservicebus.com
``` 


</details>



<details>
<summary markdown="span"> March 19th, 2018
</summary>


### [microServiceBus.com](https://microservicebus.com)
*  History log of all successful and failed transmitted messages along with related events.
From the [Node page](https://microservicebus.com/Nodes) users can now access last weeks event *Action* drop-down menu. This will provide good insight of everything happening on the node.

*  Highlighting in Console
Along with filtering users are now able to highlight events of interest. 

*  Enable console for mobile users
The *console* page was earlier hidden for mobile users as it didn't render well for smaller screens. 
*  GitHub integration
You can now synchronize **Scripts** in your *microServiceBus.com* organization with your gitHub Repo! Just follow this simple guide to [Integreate with GitHub](https://microservicebus.com/wiki/View/1046).

* Fixes:
    * Persist selected organization as default.
    * Forgot password page is now aligned with graphical profile.

### [microservicebus-core](https://github.com/axians/microservicebus-core) (1.1.40)
*  History log of all successful and failed transmitted messages.
Information about every message or event sent from the node is stored in the ./history directory and is saved for a week but limited to 10K. 
Apart from information about transmitted messages, actions such as connected and disconnected is also stored.

Aggregations of this information can be accessed from the portal.

*  Azure device sdk (azure-iot-device-*) has been updated to 1.4.0.
1.4.0 comes with many updates and improvements for handling re-connect and persistence of messages. 
 
*  Allow 'node restore' with parameter specifying customer's (private) environment uri.
When starting up the node for the first time you can now use **-env** to specify private or self hosted hubs:
```
node start -c XXXXX -n YYYYYY [-env xxx.microservicebus.com] [--beta]
``` 

### [microservicebus-core](https://github.com/axians/microservicebus-node) (1.0.15)
*  Allow 'node restore' with parameter specifying customer's (private) environment uri.
When restoring the node you can now use **-env** to specify private or self hosted hubs:
```
node restore -env xxx.microservicebus.com // Requires update of microservicebus-node
```


</details> 



<details>
<summary markdown="span"> February 23rd, 2018
</summary>


### [microservicebus-core](https://github.com/axians/microservicebus-core) (1.1.3)
*  Always persist messages on *Node* 
By setting the retention period on the *Node* greater than 
"0", all outgoing event and messages are persisted on the device until the retention period is exceeded or the available storage is less than 25%. 

*  Fixes:
    * Fixed: Improved persistence when offline 

### [microServiceBus.com](https://microservicebus.com)
*  Resend messages from *Node*
    * On the **Node** page of the *microServiceBus.com* portal you are now able to resend messages persisted on the device.

*  GitHub integration
    * You can now synchronize **Scripts** in your *microServiceBus.com* organization with your gitHub Repo! Just follow this simple guide to [Integreate with GitHub](https://microservicebus.com/wiki/View/1046).
*  Fixes:
    * Fixed: Reload organizations after accepted invite 
    * Fixed: Logging in using GitHub should now work again
    * Fixed: Nodes keep restarting when flows are disabled
    * Fixed: Loading animation for node status never finish
    * Fixed: Nodes keep restarting when flows are disabled
    * Fixed: Prevent none-Administrators from creating organizations for self- and private hosted sites
    * Fixed: Extend session variable timeout from 2h to 24h
    * Fixed: **ccp** type services won't drag 'n drop


</details>



<details>
<summary markdown="span"> February 6th, 2018
</summary>


### [microServiceBus.com](https://microservicebus.com)
*  Change org should stay on page
    * When changing organization it's annoying having to navigate back to the same page...

*  FIXED: Move static SignalR list to Redis
    * Major update in relation to Device Management communication to make it more stable.
*  FIXED: Empty itineraries causes flow list to fail 


</details>



<details>
<summary markdown="span"> January 27th, 2018
</summary>


### [microServiceBus.com](https://microservicebus.com)

*  New design on homepage
    * Winter is comming...

*  Toggle enable and disable on flow
    * You can now enalble or disable all services running in the flow from the [Flow page](https://microservicebus.com/flow).

*  Filter in console
    * Filter the output in the [Debug console](https://microservicebus.com/console)

*  Scroll to end in console
    * Stay updated with latest output in the [Debug console](https://microservicebus.com/console)

*  WIKI pages
    * Help pages are replaced with markdown [WIKI pages](https://microservicebus.com/wiki). All help will be updated.

*  FIXED: Confirmation email page is links to missing image
*  FIXED: Copy script from [Script page](https://microservicebus.com/files)

### [microservicebus-core](https://github.com/axians/microservicebus-core) (1.0.70)

*  Implement retry policy "NoRetry" for Azure IoT.

*  Migrated to 1.3.0 of for Azure device SDK.

## mSB.mbed

*  Build service script for UBLOX_EVK_ODIN_W2


</details>



<details>
<summary markdown="span"> December 7th, 2017 
</summary>


### [microServiceBus.com](https://microservicebus.com)

* Updated Jasper API
    * Updated API allows for Jasper to notify when devices comes offline
* Added Map
    * Nodes with location settings get visible on map (node page)
* Added OAuth token authentication to all API's
    * Tokens can get generated from account page
* Exceptions API - Created
    * The Exception api allows for registing external exceptions
* Enabled location updates
    * Nodes can now register location
* Added Agreement & ServiceTypes
    * Axians only
* Add funcionality to export script and properties
    * Export scriptss and services from one organization to another
* API for checking if node is online (ServiceNow)
    * Allowing ServiceNow to call to check if node is offline
* Add description mandatory dialog when creating a new script from scratch


</details>



<details>
<summary markdown="span"> November 12th, 2017
</summary>


### [microServiceBus.com](https://microservicebus.com)

*  New design
    * We hope you enjoy our new darker theme. In the future we'll add support for selecting your favorite theme
*  Device IoT Hub protocol
    * You are now able to change the device protocol. This only affects Azure IoT hubs as they support AMQP, AMQP-WS, MQTT, MQTT-WS and REST
*  FIXED: Minor UI fixes


</details>



<details>
<summary markdown="span"> October 28th, 2017
</summary> 


### [microServiceBus.com](https://microservicebus.com)

* Scheduled updates
    * Enterprise customers will be able to schedule updates, patching and other actions through the portal
* Node state
    * State of node (network. os, env npm list etc) is now available from Node page
* Resetting nodes
    * microservicebus-core is now removed upon resetting the node
* Jasper consumption data
    * SIM card consumption and status is now provided through the Node page
* FIXED: Services must now have unique names
* FIXED: Track exceptions


</details>



<details>
<summary markdown="span"> October 28th, 2017
</summary>


### [microservicebus-core](https://github.com/axians/microservicebus-core)

* New version of microServiceBus.core (1.0.20)
* Persisting limit
    * Only 1000 msg will be persisted to prevent filling disk space
* Sys logs (linux only)
    * Sys logs can be requested from the node page
* FIXED: Messages are no longer routed to disabled services


</details>



<details>
<summary markdown="span"> March 29th, 2017
</summary>


*  Scheduled updates (Beta)
    * Enterprise customers will be able to schedule updates, patching and other actions through the portal
*  New version of microServiceBus.node (2.0.19)
    * Updates to support scheduled updates
    * Fixed stability issues
    * Updated tests
*  New version of microServiceBus.core (1.0.25)
    * Changed default Azure IoT protocol to MQTT-WS
    * Fixed signin issues for AWS IoT
    * ixed issue with debug = true, not reconnecting


</details>



<details>
<summary markdown="span"> February 22th, 2017
</summary>


* Support for Amazon AWS IoT
    * Alongside Azure IoT we now support Amazon AWS IoT Hub. All features available for Azure are available for AWS as well.
    * Check out [Choose IoT provider](https://microservicebus.com/Posts/View/1022) for more information.
* Desired state
    * Desired state is a useful feature which has been available for AWS from the early beginning (_Shadows_). This has now also been implemented in Azure IoT, and is referred to as _Device-Twin._
    * we’ve added several _Services_ to the Flow toolbox to support _Desired State_ features, both to set state, and to read state.
* Notifications
    * Users will now be notified of updates and news using Notifications popups.
* Restart all nodes
    * On the Node page, users can choose to update/restart all online nodes.
* Paging list of nodes
    * With many nodes, it’s easier to use paging to quicker select and manage your nodes.


</details>



<details>
<summary markdown="span"> February 6th, 2017
</summary>


*  Tags
    * On the details page for each node, there is now a _Tags_ field. This is a field where you can provide a comma-separated list of tags. These _Tags_ can later be used in the Node setting of Inbound Services of _Flows_. This way you can configure many nodes through one single _Service_. To use _Tags_ in Services, simply use #[TAG], Eg. #building3.
*  ServiceNow integration
    * microServiceBus.com is now fully integrated with [ServiceNow](https://www.servicenow.com/), and can escalate issues and abnormalities to ServiceNow. This is an enterprise feature, and is not available for the trial edition.
*  Whitelist
    * By uploading a whitelist (Node page) containing MAC addresses and node settings, nodes can sign in using simply a “-w” flag. Eg. node start -w
    * If the “-w” flag is used, the node will provide its MAC address when making its initial call to microServiceBus.com. If the MAC address is registered, the node will be provided all other settings and continue.
*  Remote debugging
    * This feature enables you to set breakpoints and remotely control the scripts and services running on the node. Check out [Debug your nodes](https://microservicebus.com/Posts/View/1021) for more information
*  Remote Restart and Reboot
    * From the Node page your are now given a set of _Actions_ to control your node. The _Reboot_ option will re-start your node, but requires the process to run with enough privileges. The _Restart_ option restarts the Core process and will download any updated packages.
    

</details>

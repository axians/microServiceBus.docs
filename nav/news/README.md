<p>
<details open>
<summary>April 18th, 2019
</summary><br>


## [mSB-core](https://github.com/axians/microservicebus-node) version 2.0.49

* DBus Heartbeat signal
  * *A heartbeat can be sent with DBus to ensure that the agent is running*
* Improved portal notifications
  * *Improved notifications for a number of actions in the portal such as downloading new firmware*
* Download syslogs extended to yocto
  * *Fetching syslogs from portal is now possible for the Yocto platform*
* Support for Incident policies
  * *Custom errors can now be defined and sent directly to your incident handling tool like Service Now*
* Improved site verification test
  * *Nodes can now only run test when test mode is activated*
* Automatic Retries when downloading service files
  * *Retries is done automatically and otherwise previosly downloaded scripts will be run*
* Maintenance and Test mode
  * *Test mode can now be set in portal to make sure only devices that should be tested can run the test. Maintenence mode supresses incidents from the node when you for instance are testing new functionality*

</details>
</p>


<p>
<details open>
<summary>March 26th, 2019
</summary><br>

## [microservicebus.com](https://microservicebus.com)

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


## [mSB-core](https://github.com/axians/microservicebus-node) version 2.0.27
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
</p>



<p>
<details>
<summary>February 26th, 2019
</summary><br>

## [mSB.com](https://microservicebus.com)
* Serverside performance improvements
   * *Mainly focusing on Node sign in*
* On-site test scripts
   * *Providing capabilities to let site technitians running unit test on-site to verify installation*

## [mSB-core](https://github.com/axians/microservicebus-node) version 2.0.14
* Enable remote unit testing
   * *To support On-site test scripts (see mSB.com)
* Improved support for Yocto
   * *Extract platform and version from Yocto bundle*
* Updated Azure SDK => 1.9.3

## [mSB-dam](https://github.com/axians/microservicebus-dam) version 2.0.1
* Extended to support Yocto
   * *Corrected bug where DAM only worked in snap env*.

</details>
</p>


<p>
<details>
<summary>February 1th, 2019
</summary><br>

## [mSB.com](https://microservicebus.com)
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

## [mSB-core](https://github.com/axians/microservicebus-node) version 2.0.1
* TTLCollection available from services
   * *TTLCollection to support adding unique items*
* Add all networks and serialports to requested Environment
   * *see mSB.com*
   </details>
   </p>
   


<p>
<details>
<summary>December 27th, 2018
</summary><br>

## [mSB.com](https://microservicebus.com)
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

## [mSB-node](https://github.com/axians/microservicebus-node) version 2.0.0
* Lock microservicebus-core version 

## [mSB-core](https://github.com/axians/microservicebus-core) version 2.0.1
* mSB-core is now running the latest version of Azure Device SDK, fixing issues where messages did not get delivered properly
* Updated support for binary messages

## [mSB-dam](https://github.com/axians/microservicebus-dam) version 1.0.0
* Manage SSH keys in portal
* microservicebus-dam snap/daemon
* Grant access to Node

## [mSB-yocto](https://github.com/axians/microservicebus-yocto) version 1.0.0
* microservicebus-node Yocto layer
* Upload firmware
* Firmware updates using RAUC (bootloader interface)
* Trigger “Update firmware” from mSB.API

</details>
</p>

<p>
<details>
<summary> November 30th, 2018
</summary><br>

## [mSB.com](https://microservicebus.com)
* Grant individual logon privilages (mSb.dam)
* Lock organization to mSB-core version preventing forced updates
* Support for locking Flows to script/service version
* Added CTRL+S/Cmd-S short key for saving scripts
* FIXED: "Fetch from repo" working kind of funky

## [mSB-node](https://github.com/axians/microservicebus-node) version 1.0.27
* Support for *Device Access Manager* (mSb.dam)
* Support for custom repos of mSB-core and mSB-node
* Lock organization to mSB-core version preventing forced 
* Updated snap

## [mSB-core](https://github.com/axians/microservicebus-core) version 1.2.52
* Support for *Device Access Manager* (mSb.dam)
* Lock organization to mSB-core version preventing forced 
* Support for locking Flows to script/service version
* FIXED: RECONNECTING loop

## [mSB-dam](https://github.com/axians/microservicebus-dam) version 1.0.0
* Support for *Device Access Manager*
* Updated snap
</details>
</p>

<p>
<details>
<summary> November 4th, 2018
</summary> <br>
## [mSB.com](https://microservicebus.com)
* Improve error message for Github permission error
* Added funtionality to move node between organizations
* (Yocto) Download firmware metadata
* Add under general properties in itinerary designer the service organisation location.
* FIXED: Can't right click on the service in the itinerary designer

## [mSB.core](https://github.com/axians/microservicebus-core) (1.2.40)
* (Yocto) nodejs RAUC D-Bus integration
* FIXED: Message context lost on SubmitResponsemessage
* FIXED: First msb.core-install, with very slow connection, gets stuck (waited 30 min) #551
</details>
</p>

<p>
<details>
<summary> October 21th, 2018 
</summary> <b>

## [mSB.com](https://microservicebus.com)
* Remove single whitelist entry + add confirmation to Clear list #532
* API to apply Node template to existing nodes #545
* Send invites to multiple people #553
* Enable / Disable node with CTRL+R creates multiple services on node #535

* FIXED: Changes not saved in script window if you don't close window between saves #531
* FIXED: Node keys are not renewed when changing IoT Hub provider
* FIXED: Performance improvements for handling signIn & creation of nodes. #529
Opened in axians/microServiceBus.com

</details>
</p>

<p>
<details>
<summary> October 10th, 2018
</summary> <b>
## [mSB.com](https://microservicebus.com)
* Remove single whitlist entry
* Enable/Disable nodes using CTRL+R
* Upload Yocto firmware image
* Download Yocto firmware image API
* Performance improvements
* Apply node templates to nodes using API
* FIXED: Cut long Flow names in list

## [mSB.core](https://github.com/axians/microservicebus-core) (1.2.31)
* Fixed issue restarting COM upon State gets updated
</details>
</p>

<p>
<details>

<summary> September 7th, 2018
</summary> <br>
## [mSB.com](https://microservicebus.com)
* Show diff on Audit log
* (Node API) Updated (start, stop, enable) to use PUT verb
* (Node API) Creating a node returns the object
* VSTS integration to trigger on Pull Requests
* Show Script window from *Services* in *Flow*
* FIXED: duplicate services started when mltiple tags were used
* FIXED: Node name textbox should be read-only
* FIXED: createNodeFromMacAddress should not require authorization
* FIXED: Ctrl+R does not work in all pages

## [mSB.core](https://github.com/axians/microservicebus-core) (1.2.18)
* FIXED: Changed state should trigger all "Receive State" services

## [mSB.node](https://github.com/axians/microservicebus-node) (1.0.26)
* Add timeout to ensure installation of core does not hang
* Updated snap version to 1.26

</details>
</p>

<p>
<details>

<summary> August 11th, 2018
</summary> <br>

## [mSB.com](https://microservicebus.com)
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
</p>

<p>
<details>

<summary> July 23rd, 2018
</summary><br>

## [mSB.com](https://microservicebus.com)
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
 
## [mSB.core](https://github.com/axians/microservicebus-core)
* Implement policys. (disconnect, reconnect, offline mode)

</details>
</p>

<p>
<details>
<summary> June 30th, 2018
</summary> <br>

## [mSB.com](https://microservicebus.com)
*  New Swagger based API
    * For integration with LOB system for managing your Nodes. This API will be extended for many more options in the future. 
*  Format JSON messages in console 
    * When ourputting JSON in the Debug output, you can optionally have it formated.

*  FIXED: Resizing Flow designer now works
 
## [mSB.core](https://github.com/axians/microservicebus-core)
*  Many more events persisted to History
*  Removed redundant packages that were part of [mSB.core](https://github.com/axians/microservicebus-node)
*  Disable IoT Hob connection on disabling the node.

</details>
</p>

<p>
<details>

<summary> June 19th, 2018
</summary> <br>

## [mSB.com](https://microservicebus.com)
*  Saving a flow with a node-attribute set to a non-existing node in a service silently gets created
    * This behavior has now changed, and you can optionally save your *Flow* without creating the nodes
*  Auto-complete tags when writing '#' in nodes fields
    * When selecting a *Node* in the *Flow* designer, you can now select from a list of both Nodes and Tags

*  FIXED: Flow's are disabled by default 
    * Flows are nolonger disabled after saving

*  FIXED: Login redirect fires to quickly and doesn't let users edit login
    * Users that once looged in using ADFS were not able to change login

*  FIXED: Tags not working for Inbound State Services

## [mSB.core](https://github.com/axians/microservicebus-core)
*  Get and instance of another service from code within the same Flow
Services normaly interact through the *Service* connectors in the *Flow* diagram. But sometimes a service can only exist once, such as for accessing a serial port. In such cases you can get an instance of a specific service using:
```
var srv = this.GetInstanceOf('mbuService');
srv.Process(msg, context); // or any other method
```
*  FIXED: Tags not working for Inbound State Services
</details>
</p>

<p>
<details>
<summary> June 5th, 2018
</summary><br>

## [mSB.com](https://microservicebus.com)
*  New beautiful background image
[Rickard Lundqvist](https://www.instagram.com/photobyrickard/) taken this beutiful picture of Nybrokajen in Stockholm.
*  Provide Node shutdown option from portal
Nodes can now be shutdown from the [mSB.com](https://microservicebus.com) portal
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

## [mSB.core](https://github.com/axians/microservicebus-node)
*  GetInstanceOf method on Services
Get an instance of an other service in the same flow using a simple method call.
# Apr 22nd, 2018
## [mSB.com](https://microservicebus.com)
*  New beautiful background image
[Håkan Garnefält](https://www.instagram.com/haawks/) has been kind enough to share his spring picture of Stockholm by the sea.
*  Audit log for Flows, Nodes, Organization and Scripts  
Users can access the audit log through a number of views in the portal. 
*  Full integration with Visual Studio Team Services
You can now manage your scripts and services in VSTS and push your changes to microServiceBus.com
*  Node API
External applications such as ServiceNow, can now interact with Nodes using the API
*  Download all scripts
You can now download all script files from the [Scripts page](/Files). This feature can come handy when migrating to VSTS or Github.
*  Mobile console
The *Console has been extended to the mobile view

*  **FIX:** GitHub integration issues ans been resolved
*  **FIX:** Default organizations is stored in session
*  **FIX:** Organizations can now change names
## [mSB.core](https://github.com/axians/microservicebus-node)
*  Set environment parameter at startup
*node start* now accepts **--env** such as:
```
node start -c ASDGJ -n myNode -env myorg.microservicebus.com
``` 
</details>
</p>

<p>
<details>
<summary> March 19th, 2018
</summary><br>

## [mSB.com](https://microservicebus.com)
*  History log of all successful and failed transmitted messages along with related events.
From the [Node page](/Nodes) users can now access last weeks event *Action* drop-down menu. This will provide good insight of everything happening on the node.

*  Highlighting in Console
Along with filtering users are now able to highlight events of interest. 

*  Enable console for mobile users
The *console* page was earlier hidden for mobile users as it didn't render well for smaller screens. 
*  GitHub integration
You can now synchronize **Scripts** in your *microServiceBus.com* organization with your gitHub Repo! Just follow this simple guide to [Integreate with GitHub](https://microservicebus.com/wiki/View/1046).

* Fixes:
    * Persist selected organization as default.
    * Forgot password page is now aligned with graphical profile.

## [mSB.core](https://github.com/axians/microservicebus-core) (1.1.40)
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

## [mSB.core](https://github.com/axians/microservicebus-node) (1.0.15)
*  Allow 'node restore' with parameter specifying customer's (private) environment uri.
When restoring the node you can now use **-env** to specify private or self hosted hubs:
```
node restore -env xxx.microservicebus.com // Requires update of mSB.node
```
</details> 
</p>

<p>
<details>
<summary> February 23rd, 2018
</summary><br>

## [mSB.core](https://github.com/axians/microservicebus-core) (1.1.3)
*  Always persist messages on *Node* 
By setting the retention period on the *Node* greater than 
"0", all outgoing event and messages are persisted on the device until the retention period is exceeded or the available storage is less than 25%. 

*  Fixes:
    * Fixed: Improved persistence when offline 

## [mSB.com](https://microservicebus.com)
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
</p>

<p>
<details>
<summary> February 6th, 2018
</summary><br>

## [mSB.com](https://microservicebus.com)
*  Change org should stay on page
    * When changing organization it's annoying having to navigate back to the same page...

*  FIXED: Move static SignalR list to Redis
    * Major update in relation to Device Management communication to make it more stable.
*  FIXED: Empty itineraries causes flow list to fail 

</details>
</p>

<p>
<details>
<summary> January 27th, 2018
</summary><br>

## [mSB.com](https://microservicebus.com)

*  New design on homepage
    * Winter is comming...

*  Toggle enable and disable on flow
    * You can now enalble or disable all services running in the flow from the [Flow page](/flow).

*  Filter in console
    * Filter the output in the [Debug console](/console)

*  Scroll to end in console
    * Stay updated with latest output in the [Debug console](/console)

*  WIKI pages
    * Help pages are replaced with markdown [WIKI pages](/wiki). All help will be updated.

*  FIXED: Confirmation email page is links to missing image
*  FIXED: Copy script from [Script page](/files)

## [mSB.core](https://github.com/axians/microservicebus-core) (1.0.70)

*  Implement retry policy "NoRetry" for Azure IoT.

*  Migrated to 1.3.0 of for Azure device SDK.

## mSB.mbed

*  Build service script for UBLOX_EVK_ODIN_W2
</details>
</p>

<p>
<details>
<summary> December 7th, 2017 
</summary><br>

## [mSB.com](https://microservicebus.com)

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
</p>

<p>
<details>
<summary> November 12th, 2017
</summary><br>

## [mSB.com](https://microservicebus.com)

*  New design
    * We hope you enjoy our new darker theme. In the future we'll add support for selecting your favorite theme
*  Device IoT Hub protocol
    * You are now able to change the device protocol. This only affects Azure IoT hubs as they support AMQP, AMQP-WS, MQTT, MQTT-WS and REST
*  FIXED: Minor UI fixes

</details>
</p>

<p>
<details>
<summary> October 28th, 2017
</summary><br> 
## [mSB.com](https://microservicebus.com)

* Scheduled updates
    * Enterprise customers will be able to schedule updates, patching and other actions through the portal
* Node state
    * State of node (network. os, env npm list etc) is now available from Node page
* Resetting nodes
    * mSB-core is now removed upon resetting the node
* Jasper consumption data
    * SIM card consumption and status is now provided through the Node page
* FIXED: Services must now have unique names
* FIXED: Track exceptions

</details>
</p>

<p>
<details>
<summary> October 28th, 2017
</summary><br>

## [mSB.core](https://github.com/axians/microservicebus-core)

* New version of microServiceBus.core (1.0.20)
* Persisting limit
    * Only 1000 msg will be persisted to prevent filling disk space
* Sys logs (linux only)
    * Sys logs can be requested from the node page
* FIXED: Messages are no longer routed to disabled services
</details>
</p>

<p>
<details>
<summary> March 29th, 2017
</summary><br>

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
</p>

<p>
<details>
<summary> February 22th, 2017
</summary><br>
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
</p>

<p>
<details>
<summary> February 6th, 2017
</summary><br>

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
</p>
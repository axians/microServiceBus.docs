---
layout: post
title:  "Run background services"
description: "Background services can run tasks such as checking disk space and other hardware related issue"
categories: quickreference
order: 55
---

Background service is similar to an normal JavaScript or Python Services, but runs in the background independent of Flows and other services. A background service cannot interact with other services or transmit messages to the IoT Hub, but it lets you run background tasks such as checking disk space and other hardware related issues.

## Craete a Background service
1. Start by navigating to the Scripts & Services page and create a new service. Set the Service type to "Internal Service".
2. Open the script editor. The script only needs a `Start` function and you can add whatever code you'd like to do your background task.
3. Save and close the editor


## Use the Background service
You can set the Background service either through *Node Templates* or on the Node Property page. 
1. Navigate to the Node page and select *Properties* from the Action menu
2. Select the *Policies* tab, and select the new Service in the list of Background services.

## Sample service
The script below checks that the disk space is not utilized to more than 75%. 

```javascript

const fs = require('fs');
const {exec} = require('child_process');
var lastReported = 0;

var exports = module.exports = {
    Start: function () {
        self = this;

        self.Debug('Alert monitor started');


        setInterval(()=> {
            try {
                // Check storage utilizations
                exec("df | grep /data | awk '{print $2,$3}'", (error, stdout, stderr) => {
                    if (!error && !stderr && Date.now() - lastReported > 1000 * 60 * 60) {

                        const available = Number(stdout.split(' ')[0]);
                        const used = Number(stdout.split(' ')[1]);

                        const use = (used / available) * 100;

                        if (use > 75) {
                            self.ThrowError({}, '90040', `High storage utilizations!\n${use.toFixed(2)} % of the /data disk is in use.`);
                            lastReported = Date.now();
                        }
                    }
                });
            }
            catch(e) {
                self.Debug(`Error: ${e}`);
            }
        }, 10000);

    }
}
```



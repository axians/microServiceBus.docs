---
layout: post
title:  "Working with external source code providers"
description: "Although microServiceBus.com come with version control, you might consider using tools you're already familiar with such as GitHub or Azure DevOps."
categories: integration
order: 10
---
Although microServiceBus.com come with version control, you might consider using tools you're already familiar with such as GitHub or Azure DevOps.

> GitHub and Azure Devops integrations are done on *Organization* level. It might therefor be more convinient to bind the source code provider to the `ROOT` *Organization* as all *Scripts* and *Services* will then become available for all other *Organizations* 

> **Tip of the day**: Unless you want to keep your *Scripts* and *Services* in a separate repo, create a directory in your source control for all mSB files.


## Setting up version control for GitHub
### Before you begin
1. Log in to [GitHub](https://hithub.com). From your profile menu, select `Settings`. Scroll down and select `Developer settings` and `Personal access tokens`. Click `Generate new token`. Give the token a name, set preferred expiration and select the following scopes:
* repo:status 
* repo_deployment
* public_repo
* admin:repo_hook

2. Click the `Generate token` button and copy the token 

### Edit GitHub settings in microServiceBus.com
1. Open microServiceBus.com and navigate to your *Organization*. Scroll down to the "GitHub integration" feature and click the "Edit" button.
2. Provide your access token, Repo and Branch
3. If you're not using a dedicated repo you should set the `File pattern` to match which files you want to bind. E.g. "\\/SourceCode\\/mSB-files\/" will bind all files in the /SourceCode/mSB-files directory.
4. Save the settings be hitting the `SAVE` button.

This action will create GitHub Webhooks which will be available in your GitHub repo under `Settings`/`Webhooks`. 


## Setting up version control for AzureDevops
1. Log in to [Azure DevOps](https://dev.azure.com/) and select your instance and project. From the `User settings` menu (next to your profile) select `Personal Access Tokens`
2. Give the token a name and select the following scopes:
* Code - Read
3. Click "Create" and copy the token.

### Edit Azure DevOps settings in microServiceBus.com
1. Open microServiceBus.com and navigate to your *Organization*. Scroll down to the "Azure DevOps integration" feature and click the "Edit" button.
2. Provide your access token, Instance, Repo, Branch and Project.
3. If you're not using a dedicated repo you should set the `File pattern` to match which files you want to bind. E.g. "\\/SourceCode\\/mSB-files\/" will bind all files in the /SourceCode/mSB-files directory.
4. Save the settings be hitting the `SAVE` button.

This action will create *Service hooks* which will be available in your Project under `Service hooks`. 
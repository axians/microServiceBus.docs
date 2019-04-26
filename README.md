# Welcome to *microServiceBus.com* docs

## To update the documentation, please follow these steps

1. Create your own branch
2. If you are creating a new post, add it to any of the following directories under the **nav** directory (otherwise just jump to step 4):
    * _gettingstarted
    * _integration
    * _operation
    * _quickreference
3. Name your file as your topic, in lower case, replacing spaces with dashes. Eg *get-remote-access-to-your-nodes.md*
4. Add a Jekyll header:

    ```html
    ---
    layout: post
    title:  "Get remote access to your Nodes"
    description: "There are times when there is no substitute to a plain old SSH session. Learn more about how to upload public keys and grant yourself access to Nodes."
    categories: operation
    order: 50
    ---
    ```

    * **categories** : should correlate with the directory selected in step 2 (but without the underscore)
    * **order** : Used for sorting the post in the list. Try separating with at least 10 numbers.

## Working with links and references

To reverence an other post, use the *site.baseurl* property. Eg:

```markdown
 [Issue tracking systems like ServiceNow]({{site.baseurl}}/servicenow).
```

Same applies to images:

```html
<img src="{{site.baseurl}}/images/using-the-console/1.png">
```

## Working with images

Create a folder in the *Images* directory, and name it the same as you post (-'.md'), Eg "using-the-console". Common images, such as logotypes are saved directly in the *Images* folder.

## Formatting your post

Follow the instructions in the [DocsPage Template](/DocsPage-Template.md)

## Indexing and search for broken links
Go to the Crawler directory and run the Crawler.exe file. This will output any broken links and update the */assests/index.json* 
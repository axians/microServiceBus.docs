# [Describing heading]

Intro on what this page aims to answer. If the page is tutorial-like do numbering and at the end of the page link to related topics.

If you dont know Markdown try this [Cheatsheet](https://github.com/adam-p/markdown-here/blob/master/README.md)

## 1.First step

### 2.Second step

#### Best practices

* Always checkout branch before editing so no conflict happens. When you are done with your edit, create a pull request.

* Specify code language in code examples.

    ```javascript
    forEach(codeExample in docs){
        useInlining(Force);
        // ```javascript
        // [My javascript code goes here]
        // look at raw code for this markdown file to understand
        // ```
    }
    ```

* >Tip! Tips should be written like this

* Always use cursive on reserved words like *node*, *microservice*, *microServiceBus.com*, *flows*, *organization*, *tags* etc.

* Internal links are used like this:
```
[Nodes]({{site.baseurl}}/what-is-a-node)
```

* Images can be added in different ways. Depending on the use and size of the image you whant to use.

  * Standard: `![altText](/images/Logosmall.png)`

    ![altText](/images/Logosmall.png)

    *Imports the image at the original size*

  * Advanced: Use raw_html to resize and modify your image. You can use padding, width, hight etc.

    ```text
    Example: <img src="https://axians.github.io/microServiceBus.docs/images/Logo5.png" width="50">
    ```

    <img src="./images/Logo5.png" width="100">

Back to home page: [Home](/)
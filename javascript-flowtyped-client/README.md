# mantle-api@1.8.1

Mantle API

Integrate the value of blockchain into enterprise applications in days.
Mantle lets you innovate and scale seamlessly and securely.

## Using the Mantle API

Most endpoints require authentication with an API key 
You must first authenticate with your account by logging in your account on
https://www.mantleblockchain.com .
Then, you will need to navigate to the *My API Key* page in the Settings section.
You need to have the role administrator of your organization to generate an *API Key*.
Then use this *API Key* in all your requests with the following header:
`[ x-api-key: API_KEY ]`
For more information on the different product and more, you can refer to the
https://docs.mantleblockchain.com/v1.0/documentation/home knowledge base.

This JavaScript package has been generated.
See the details below.

## About the javascript-flowtyped generator
This generator creates Flow typed JavaScript client that utilizes [Fetch API](https://fetch.spec.whatwg.org/). The generated Node module can be used in the following environments:

Environment
* Node.js
* Webpack
* Browserify

Language level
* ES6

Module system
* ES6 module system

### Building

To build an compile the flow typed sources to javascript use:
```
npm install
# The dependency `babel-preset-react-app` requires that you specify `NODE_ENV` or `BABEL_ENV` environment variables
env BABEL_ENV={YOUR_ENV} npm run build
```

### Publishing

First build the package then run ```npm publish```

### Consuming

navigate to the folder of your consuming project and run one of the following commands.

_published:_

```
npm install mantle-api@1.8.1 --save
```

_unPublished (not recommended):_

```
npm install PATH_TO_GENERATED_PACKAGE --save


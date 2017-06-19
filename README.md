# SimpleHelloWorld

##Key requirements

### Seperation of console.write code from API - achieved with Web API controllers
### Configurability of destination to read and write text to - acheieved with AutoFac dependency injection

##How to execute code
### DEVELOPMENT IDE : VISUAL STUDIO 2015
### Step 1 - Set HelloWorldWebService as the start project
### Step 2 - Publish the web service using Ctrl+Shift+F5
### Step 3 - Verify that the URL http://localhost:50072/values/gethelloworldtext/10 returns 'Hello World'
### Step 4 - Set the Hello World Console as the start up project. 
### Step 5 - Make sure the key 'helloworldservice-endpoint' in appsettings.xml is the URL verified in step 3
### Step 6 - Run the console project


# Introduction 
Calculator Tests contains two automated test frameworks to test the following calculator web application. 
https://calculator-web.azurewebsites.net/

The Web UI Test Automation Framework is built using Cypress
The REST API Test Automation Framework is built using Specflow, NUnit and RestSharp 

# Getting Started
1.	Installation process 
   - Clone ADO repo https://Kiwibank@dev.azure.com/Kiwibank/BusApps/_git/CalculatorTests in Visual Studio 2019 IDE

#API Framework
1. Software dependencies 
Right click solution CalcApiTests.sln to restore the following  nuget packages
 - Microsoft.NET.Test.Sdk(16.9.4) - https://www.nuget.org/packages/Microsoft.NET.Test.SDK
 - Nunit3TestAdapter(3.17.0) - https://www.nuget.org/packages/NUnit3TestAdapter
 - SafeNuget(1.0.10) - https://www.nuget.org/packages/SafeNuGet
 - Specflow.NUnit(3.81.4) - https://www.nuget.org/packages/SpecFlow.NUnit
 - Specflow.Plus.LivingDocPlugin(3.8.35) - https://www.nuget.org/packages/SpecFlow.Plus.LivingDoc.CLI
 - System.Net.Security(4.3.2) - https://www.nuget.org/packages/System.Net.Security

2.	API references
API Endpoint: https://calculator-api.azurewebsites.net/api/Calculate

#UI Framework
1. Installation process
Remove NPM proxy:
npm config rm proxy
npm config rm https-proxy

Powershell commands:
$env:CYPRESS_INSTALL_BINARY=''
$env:CYPRESS_INSTALL_VERSION=''
$env:NODE_TLS_REJECT_UNAUTHORIZED=0
$env:HTTP_PROXY="http://username:password@kbproxy.corp.bank.nzpfs.co.nz:8080/"
$env:HTTPS_PROXY="http://username:password@kbproxy.corp.bank.nzpfs.co.nz:8080/"
npm install cypress --save-dev

2. Software dependencies
- Cypress npm module - https://www.npmjs.com/package/cypress

3. UI references
UI Endpoint: https://calculator-web.azurewebsites.net/

# Build and Test
 
#API Framework
Build: Right click solution CalcApiTests.sln to build solution
Test: Test - > Test Explorer -> Run All Tests

#UI Framework
Build: In Visual Studio code terminal, execute 'npx cypress open'
Test : Run any of the spec.js files under CalcUiTests/integration under Electron browser

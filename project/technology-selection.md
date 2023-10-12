# Technology Selection
## Implemented Languages and Frameworks:
* C# + Web with ASPNET Core
* Blazor Server - https://learn.microsoft.com/en-us/aspnet/core/blazor/?view=aspnetcore-7.0
* MudBlazor - https://mudblazor.com/
## Storage Plan
* MongoDB
## Operating Environment(s)
* Coding Environment is Visual Studio 22
* MongoDB is operating within Azure with CosmosDB - https://learn.microsoft.com/en-us/azure/cosmos-db/mongodb/introduction
* Deployment Method : TBD
## Other Software Used
* Azure Functions are serving as a serverless CRUD API for our Mongo Database - https://www.youtube.com/watch?v=amSVePPeu3U&t=541s

### Running in a local environment:
* Open Visual Studio 22 on your machine
* Under "Get Started", select the "Clone a Repository" button
* Within the text field under "Repository location", copy and paste our repository link, select a path, and click the "Clone" button
  * https://github.com/wvwa25/SWE_Team_5
* When the project is opened, click the *xxx.sln* file, then click the green arrow at the top, where it should be listed with an "http"
* If there is a warning on your browser, please bypass your browser restrictions for locally hosted sites
* Product should be working within the browser on your local machine

### The Why?
Why are we using ASPNET core? Web development is something our entire team was interested on working on and learning for this project. Since C# is a language that is commonly shared, or other languages similar to C#, we decided to go the C# route and use .NET 7.0 to build our project. Our application will be running as a Blazor Server project. Blazor server, linked above, is able to run C# code 
within the browser. With this, you can build interactive webpages, without needing to learn other languages or frameworks like JavaScript or ReactJS. This was something that our team could easily pick up and run with. For our database, we decided to go with MongoDB, which is hosted on Azure. With this, we are able to use Azure functions as a CRUD API to Create, Read, Update, and Delete our data within the database.
Our goal with this was also to help with access to our product on all devices, since it is hosted within the web. A user/customer will be able to access our product on multiple platforms, such as Windows, Mac, and Linux, as well as mobile devices.

# Implementation

## Implementation Language and FrameWorks
- For our project, we are building our product in C# with Blazor Server. Blazor Server uses a component to build Single Page Application (SPA) called Razor components.
via Microsoft's website, `` Components are implemented using a combination of C# and HTML markup in Razor component files with the .razor file extension. ``
 With Blazor Server, we are also able to use different frameworks for UI
such as MudBlazor and native CSS for our project. One of our goals as a team was to build a web application to further our knowledge about web development, and also build upon our shared skills with modern languages such as C#. Blazor is able to be a "pretty package" for C#, HTML and CSS to build scalable web applications.
- For storage, we are using a cloud hosted database called CosmosDB on Microsoft Azure. CosmosDB is based upon MongoDB, which is a popular alternative to SQL and relational databases called "NoSQL" datbases. CosmosDB has data stored as JSON like files, which is beginner-friendly for developers who have little experience with SQL or relational databases. Below is an example of a stored user data in CosmosDB.
``` json
[
  {
    "_id": "dac8bf2b-31f8-414e-8039-2ab95bf85cb0",
    "name": "admin",
    "email": "admin",
    "password": "admin"
  }
]
```
- To access our database on Azure, we are using Azure functions to act as a serverless API. With Azure functions, we are able to do HTTP requests to create, read, update, and delete information from the database. This allows us to have methods within our C# and Razor components to do GET, PUT, and POST requests from our Blazor application. 

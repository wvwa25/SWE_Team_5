## Data Storage Plan

Our data model is a MongoDB file that is hosted on Miscrosoft Azure (MongoDB uses BSON, which is a very similar file format to JSON). API calls will be made to Azure from the C# code in the .razor page files to read, write, and query the model.

The process will be as follows:
- When a page is loaded, an Azure API call will be made to load any data displayed on that page from the respective database objects; namely, the User, Order, Sales, Item, or ShippingType objects.
- If no data must be displayed on that page (e.g. Account Creation Page), no API call will be made to pull data.
- When the User clicks a link to another page, an API call will be made to save any data that has changed on the page. After the call has been made, the next page will be loaded.
- If the current page does not contain any fields meant to change the model (e.g. Log-In Page), no API call will be made to save data.

## Seed Data

The following screenshots show what seed data which will be available in the application's database upon startup.

![](/project/assets/seed-data_1.png)
![](/project/assets/seed-data_2.png)
![](/project/assets/seed-data_3.png)

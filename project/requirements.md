### Version 1

**Sprint I: User Interface Design**
  * Account and Shopping Mockup Designs – T5E-1
      * Determine Global Appearance – T5S-1
          *	Priority: Must Have
          *	Estimated Effort: 0.75 Days
          *	Non-Functional
          *	Determine site-wide appearance specifics such as typeface, menu option organization, and button appearance. Create prototypes with Blazor Server to determine how to produce realistic mockups. 
      *	Generate Login and Account Creation Page Mockups – T5S-2
          *	Priority: Must Have
          *	Estimated Effort: 0.5 Days
          *	Non-Functional
          *	Create mockups for the login page (landing page) and account creation page in Marvel. On the login page, display "Username" and "Password" text fields as well as a "Log In" and "Register New Account" button. On the account creation page, also display similar fields for username and password as well as a "Create Account" button and a "Back" button to go back to the login page.
      *	Generate Browsing and Item Page Mockups – T5S-3
          *	Priority: Must Have
          *	Estimated Effort: 0.5 Days
          *	Non-Functional
          *	Create mockups for the browsing page and item page in Marvel. For the browsing page, include a "Search Items" text field with a "Search" button and a list of several items from highest price to lowest. Display items with a small picture, item name, and price in USD (include a dollar sign, decimal, and commas as needed). For the item page, display a larger resolution image of the item as well as the item name, price, and description. Also include a "Add to Shopping Cart" button. For both pages, include a "Log Out" button and a "Checkout" button. Lastly, create a duplicate browsing page mockup with a "Sales Report" button that will only display for admins.
  * Checkout and Sales Report Designs – T5E-2
      *	Generate Checkout Page Mockups – T5S-4
          *	Priority: Must Have
          *	Estimated Effort: 0.5 Days
          *	Non-Functional
          *	Create mockups for the checkout pages in Marvel. For the checkout page, include a list of a few items from the user's shopping cart (in chronilogical order) with their respective subtotal. Include a "Remove" button next to each item, a "Continue Shopping" button, and a "Pay Now" button. Create a payment page to be displayed after "Pay Now" is clicked. This page will display text fields "Name", "Email Address", "Shipping Address", "Credit Card Number", "Expiration Date", and "CVV". Include radio buttons for three shipping speed options (3-Day for $19, Overnight for $29, and Ground for $0). Lastly, include a button "Confirm Order".
      *	Generate Order Pages Mockups – T5S-5
          *	Priority: Must Have
          *	Estimated Effort: 0.5 Days
          *	Non-Functional
          *	Create mockups for the order confirmation and receipt pages. For the order confirmation page, display the items from cart in with their respective price, subtotal, 6% sales tax, and shipping cost, and grand total. Include buttons "Continue Shopping", "Go to Shopping Cart", and "Complete Order". For the receipt page, display all itemized charges with items names and the grand total. Additionally, display the last four digits of the credit card, a shipping address, and an order number. Lastly, include a button "OK".
      *	Generate Sales Report Page Mockup – T5S-6
          *	Priority: Must Have
          *	Estimated Effort: 0.25 Days
          *	Non-Functional
          *	Create mockups for the Sales Report Page. Display a list of items with an order number, username, item name, and item price. Include a sales total at the bottom, a button "Export Sales Report", and a button "Back".

**Sprint II: Technical Design**
  * Frameworks – T5E-3
      * Describe Frameworks – T5S-7
          *	Priority: Must Have
          *	Estimated Effort: 0.25 Days
          *	Non-Functional
          *	Describe what frameworks will be used to implement the application in a markdown document. Define coding languages, tools, and services which will be used. Describe what role they will play and how they will interact with each other.
      * Entity Relationship Diagram – T5S-8
          *	Priority: Must Have
          *	Estimated Effort: 0.5 Days
          *	Non-Functional
          *	Produce an entity-relationship diagram (using Crow's Foot format) to display how the different components of the application will interact with each other, what attributes will be passed from one component to another, and what keys will be used.
      * Coding Style Guide – T5S-9
          *	Priority: Must Have
          *	Estimated Effort: 0.25 Days
          *	Non-Functional
          *	Review the language's coding style guide and define coding style instructions in a markdown document. Include commenting guidelines, naming conventions, and filename conventions that developers will abide by.
  * Services, Seed Data, and Data Storage – T5E-4
      * Define Services – T5S-10
          *	Priority: Must Have
          *	Estimated Effort: 0.5 Days
          *	Non-Functional
          *	Define the application services in a markdown document. Explain the modules, classes, and methods associated with each service and their relationship to one another.
      * Define Seed Data and Storage Plan – T5S-11
          *	Priority: Must Have
          *	Estimated Effort: 0.5 Days
          *	Non-Functional
          *	In a markdown document, describe what seed data will be initialized in the system upon startup including at least one administrator account, inventory items and photos, and any other elements. In a seperate document, describe the libraries and technologies used to store data.

**Sprint III: Account Management**
  * User Account Creation and Login – T5E-5
      *	Generate Landing Page – T5S-12
          *	Priority: Must Have
          *	Estimated Effort: 1 Day
          *	Functional
          *	Build a landing page in which either an existing user may enter a username and password to log in or a new user may click a link to go the account creation page. Add a button "Create New Account" to direct the user to an account creation page. Add a button "Log In" to ensure that the username and password the user has entered matches an account saved in the database. Notify the user if it does not.
      *	Generate Account Creation Page – T5S-13
          *	Priority: Must Have
          *	Estimated Effort: 1 Day
          *	Functional
          *	Build an account creation page in which a user may enter a username and password to create a new account. Add a button "Create Account" for the user to click to initialize an account in the database with the given username and password. Ensure the username is not already in use and notify the user if so. Ensure the password is between 6 and 14 characters and notify user if not. After the user clicks "Create Account" automatically redirect the user back to the landing page.

**Sprint IV: Browsing**
  * Browsing Pages- T5E-6
      * Generate Item Page - T5S-14
          * Priority: Must Have
          * Estimated Effort: 1.5 Days
          *	Functional
          *	Create an item page that will display the database contents of the given item including the item picture, name, price in USD, and item description. Price must be formatted with a dollar sign, decimal, and commas as needed. Ensure this page works for any item in the database. Include a "Log Out" button to sign the user out and automatically redirect them to the landing page. Include an "Add to Shopping Cart" button to add the item to the user's shopping cart.
      * Generate Browsing Page - T5S-15
          * Priority: Must Have
          * Estimated Effort: 1 Day
          *	Functional
          *	Create a page which will display all available items, sorted from highest price to lowest. Items displayed on this page will show the product picture, name, and price. Sold items must not be displayed here. As with the item page, include a "Log Out" button to sign the user out and bring them back to the landing page.
      * Link Browsing Page to Item Pages - T5S-16
          * Priority: Must Have
          * Estimated Effort: 0.25 Days
          *	Non-Functional
          * In the browsing page, add links to send the user to the respective item page when they click on either the item name or picture.
  * Search Function - T5E-7
      * Add Search Function to Browsing Page - T5S-17
          * Priority: Must Have
          * Estimated Effort: 1 Day
          *	Functional
          *	Add a search function to the browsing page to allow users to enter an index to be matched with either the item description or name. Add a text field for the user to enter an index and a button to run the search. Matched items will be listed from highest price to lowest. Unmatched items will be hidden. Ensure sold items do not display in the search.

**Sprint V: Checkout**
  * Checkout Page - T5E-8
      *	Create Checkout Page - T5S-18
          *	Priority: Must Have
          *	Estimated Effort: 1 Day
          *	Functional
          *	Create a checkout page which will display the contents of the user's shopping cart (in order from oldest added to newest), along with the subtotal of those items. Link the "Add to Shopping Cart" button on the item page to this checkout page. Include a button to remove items from the shopping cart and include a "Continue Shopping" button to bring the user back to the browsing page. If all items are removed from the cart, automatically redirect the user to the browsing screen.
      *	Integrate Checkout Page - T5S-19
          *	Priority: Must Have
          *	Estimated Effort: 0.25 Days
          *	Non-Functional
          *	Add a "Checkout" button to the browsing page and item page to send the user to the checkout screen. Ensure that users cannot view the checkout page if their shopping carts are empty.
      *	Generate Payment Page - T5S-20
          *	Priority: Must Have
          * Estimated Effort: 1 Day
          *	Functional
          *	Add a "Pay Now" button to the checkout page. This will link to the payment page in which the user will enter their payment information. Add fields to allow the user to enter their shipping address, credit card number (including expiration MM/YY and CVV), phone number, email, and select a shipping speed. Show three shipping speed options including overnight ($29), 3-day ($19), and ground ($0).
 * Order Confirmation and Receipt - T5E-9
      * Create Checkout Page - T5S-21
          * Priority: Must Have
          * Estimated Effort: 1 Day
          *	Functional
          *	Create an order confirmation page to display the items in the order along with their respective price, the order subtotal, 6% sales tax, and the shipping cost. Include all of these itemized charges in a grand total below. Add a "Confirm Order" button to the bottom of the checkout page to direct the user to the order confirmation page. Only show this button once all payment fields are filled. From the order confirmation page, allow the user to return to the checkout or browsing page, leaving their itmes in the shopping cart.
      * Create Receipt Page - T5S-22
          * Priority: Must Have
          * Estimated Effort: 1 Day
          *	Functional
          *	Generate a receipt page to process the order and show the order details. Automatically remove the purchased item(s) from stock and from the user's shopping cart. Like the confirm order page, display all itemized charges and the grand total. Additionally, display the last four digits of the credit card, a shipping address, and an automatically generated order number. Add a "Complete Order" button to the order confirmation page to link to this receipt page. As before, if the user does not click "Complete Order," leave their items in the shopping cart. Lastly, the user may click an "OK" button to exit the receipt page.

**Sprint VI: Admin Privileges**
  * Admin Access and Inventory - T5E-10
      *	Add and Grant Admin Attribute - T5S-23
          *	Priority: Must Have
          *	Estimated Effort: 0.25 Days
          *	Non-Functional
          *	Add an attribute to the user data to indicate if a user is an admin. Create a guide to instruct the admin how to grant regular users admin access.
      *	Add Stock - T5S-24
          *	Priority: Must Have
          *	Estimated Effort: 0.5 Days
          *	Functional
          *	Initialize 5 to 10 items into the inventory database. Ensure admins have the ability to add items to the database. Create a guide instructing them how to do add items, including item details such as a picture, name, price, and description.
 * Sales Report - T5E-11
      *	Generate Sales Report Page - T5S-25
          *	Priority: Must Have
          *	Estimated Effort: 1.25 Days
          *	Functional
          *	Add a "Sales Report" button to the browsing and item screens only for admin-level users. This will link to a sales report page that will display a chronological list of everything that has been purchased, along with the item details and the username/id of the user that purchased it. Ensure that regular users cannot access this page or see the "Sales Report" button. Ensure all purchases are visible in this report.
      *	Add Report Export Feature - T5S-26
          *	Priority: Must Have
          *	Estimated Effort: 0.75 Days
          *	Functional
          *	Add an "Export Sales Report" button to the sales report page so that admins can download a .csv file of the sales report.

### Version 2

**Sprint VII: Admin Features**
 * Admin UI - T5E-12
      *	Create Add Inventory Page - T5S-27
          *	Priority: Need to Have
          *	Estimated Effort: 1.5 Days
          *	Functional
          *	For an admin user, add an "Add Inventory" button to the browsing and item pages to direct the admin to a "Add Inventory" page. Create item fields to allow the admin to upload photos as well as add a price, item name, and item description. Ensure only admins are able to see this button and access this page.
      *	Add Receipt Links to Sales Report - T5S-28
          *	Priority: Want to Have
          *	Estimated Effort: 1 Day
          *	Functional
          *	Add links on the sales report page that will allow the admin to view a respective order receipt page when they click on an order number.
      *	Create Admin Access Page - T5S-29
          *	Priority: Want to Have
          *	Estimated Effort: 1 Day
          *	Functional
          *	Add an "Admin Access" button to the browsing and item pages to direct the admin to an admin access page. A list of users will be shown, including their username/id. The admin may select any of these users and click a button "Grant Admin Access" to grant the selected users admin privileges. Ensure only admins are able to see this button and access this page.

**Sprint VIII: Inventory UI and Receipts**
 * Purchases, Item Pictures, and Emails - T5E-13
      *	Generate Purchased Items Page - T5S-30
          *	Priority: Need to Have
          *	Estimated Effort: 1.5 Days
          *	Functional
          *	Create a purchases page to show the user which items they've purchased. Add a button "Purchases" at the top of the browsing and item pages to link to the purchases page. Include order number, order date, itemized charges, item details (name, picture, price), and a link to the receipt. Add a button "Back" to go back to the last page.
      *	Integrate Receipt Email Function - T5S-31
          *	Priority: Want to Have
          *	Estimated Effort: 1 Day
          *	Functional
          *	Set up an automatic email service to send emails containing the order receipt to the email address given by the respective customer in the order confirmation page. Include all order details shown on the receipt page.
      *	Enable Multiple Pictures on Item Page - T5S-32
          *	Priority: Want to Have
          *	Estimated Effort: 1.5 Days
          *	Functional
          *	Enable multiple item pictures to be stored in the database and displayed on the item page. Enable the user to scroll through the item images by clicking a right or left arrow. Display the number of the image being viewed over number of total images (e.g., if you are viewing image one of three, you will see 1/3)

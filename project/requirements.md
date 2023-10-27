### Version 1

**Sprint I: Account Management**
  * User Account Creation and Login – T5E-1
      *	Generate Landing Page – T5S-1
          *	Priority: Must Have
          *	Estimated Effort: 0.5 Days
          *	Functional
          *	Build a landing page in which either an existing user may enter a username and password to log in or a new user may click a link to go the account creation page.
      *	Generate Account Creation Page – T5S-2
          *	Priority: Must Have
          *	Estimated Effort: 0.5 Days
          *	Functional
          *	Build an account creation page in which a user may enter a username and password to create a new account. Ensure the username is not already in use and notify the user if so. Ensure the password is between 6 and 16 characters and notify user if not. After the account is created, automatically redirect the user back to the landing page.

**Sprint II: Browsing**
  * Browsing Pages- T5E-2
      * Generate Item Page - T5S-3
          * Priority: Must Have
          * Estimated Effort: 0.75 Days
          *	Functional
          *	Create an item page that will display the database contents of the given item including the item picture, name, price in USD, and item description. Price must be formatted with a dollar sign, decimal, and commas as needed. Ensure this page works for any item in the database. Include a log out button to sign the user out and redirect them to the landing page. Include an "add to shopping cart" button to add the item to the user's shopping cart.
      * Generate Browsing Page - T5S-4
          * Priority: Must Have
          * Estimated Effort: 0.75 Days
          *	Functional
          *	Create a page which will display all available items, sorted from highest price to lowest. Items displayed on this page will show the product picture, name, and price. Sold items must not be displayed here. As with the item page, include a button to sign the user out and bring them back to the landing page.
      * Link Browsing Page to Item Pages - T5S-5
          * Priority: Must Have
          * Estimated Effort: 0.25 Days
          *	Functional
          * In the browsing page, add links to send the user to the respective item page when they click on either the item name or picture.
  * Search Function - T5E-3
      * Add Search Function to Browsing Page - T5S-6
          * Priority: Must Have
          * Estimated Effort: 0.75 Days
          *	Functional
          *	Add a search function to the browsing page to allow users to enter an index to be matched with either the item description or name. Add a text field for the user to enter an index and a button to run the search. Matched items will be listed from highest price to lowest. Unmatched items will be hidden. Ensure sold items do not display in the search.

**Sprint III: Checkout**
  * Checkout Page - T5E-4
      * Create Checkout Page - T5S-7
          * Priority: Must Have
          * Estimated Effort: 0.5 Days
          *	Functional
          *	Create a checkout page which will display the contents of the user's shopping cart, along with the subtotal of those items. Link the "add to shopping cart" button on the item page to this checkout page. Include a button to remove items from the shopping cart and include a "continue shopping" button to bring the user back to the browsing page. If all items are removed from the cart, automatically redirect the user to the browsing screen.
      * Integrate Checkout Page - T5S-8
          *	Priority: Must Have
          * Estimated Effort: 0.25 Days
          *	Functional
          *	Add a "Checkout" button to the browsing page and item page to send the user to the checkout screen. Ensure that users cannot view the checkout page if their shopping carts are empty.
      *	Add Payment Features to Checkout - T5S-9
          *	Priority: Must Have
          * Estimated Effort: 0.5 Days
          *	Functional
          *	Add a "Pay Now" button to the checkout page. This will open the payment portion of the checkout page. Add payment fields to allow the user to enter their shipping address, credit card number (including expiration MM/YY and CVV), phone number, email, and select a shipping speed. Show three shipping speed options including overnight ($29), 3-day ($19), and ground ($0).
 * Order Confirmation and Receipt - T5E-5
      * Create Checkout Page - T5S-10
          * Priority: Must Have
          * Estimated Effort: 0.5 Days
          *	Functional
          *	Create an order confirmation page to display the items in the order along with their respective price, the order subtotal, 6% sales tax, and the shipping cost. Include all of these itemized charges in a grand total below. Add a "Confirm Order" button to the bottom of the checkout page to direct the user to the order confirmation page. Only show this button once all payment fields are filled. From the order confirmation page, allow the user to return to the checkout or browsing page, leaving their itmes in the shopping cart.
      * Create Receipt Page - T5S-11
          * Priority: Must Have
          * Estimated Effort: 0.5 Days
          *	Functional
          *	Generate a receipt page to process the order and show the order details. Automatically remove the purchased item(s) from stock and from the user's shopping cart. Like the confirm order page, display all itemized charges and the grand total. Additionally, display the last four digits of the credit card, a shipping address, and an automatically generated order number. Add a "Complete Order" button to the order confirmation page to link to this receipt page. As before, if the user does not click "Complete Order," leave their items in the shopping cart. Lastly, the user may click an "OK" button to exit the receipt page.
      *	Integrate Receipt Email Function - T5S-12
          *	Priority: Must Have
          * Estimated Effort: 0.25 Days
          *	Functional
          *	Use an automatic email service to send emails containing the order receipt to the email address given by the customer in the order confirmation page. Include all order details shown on the receipt page.
    	

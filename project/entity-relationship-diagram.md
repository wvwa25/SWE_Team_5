## Entity Relationship Diagram

As shown in the ER Diagram below, a User will initiate action by placing an Order containing one to many Sales, as well as one ShippingType selection.

Each Sale will contain one Item. When the Sale is confirmed, the information entered during the checkout process will be initialized into a Sale object(s) and an Order object.
All related Items will be deactivated upon purchase by setting "Salable" false.

![](/project/assets/entity-relationship-diagram.png)

## Field Descriptions

![](/project/assets/field-descriptions_1.png)
![](/project/assets/field-descriptions_2.png)

## Example Data

![](/project/assets/example-data_1.png)
![](/project/assets/example-data_2.png)

# Vendor Orders

#### Allows user to track vendors and orders. Created On: 10/2/2020, Updated Last: 10/2/2020

#### By Janet Karpenske

## Description

This program allows the user to add different vendors to a list and keep track of their orders.

## Setup/Installation Requirements

* Download or Clone project from Github repository.
* Open a terminal within Bakery.Tests folder within main project directory.
* Use command: 'dotnet restore' to install.
* After installation, navigate to Bakery folder within main project directory and use command 'dotnet run'. 
* Follow terminal prompts to see application run.

## Known Bugs

No Known Bugs

## Support and contact details

https://github.com/janetkarpenske

## Technologies Used

C#, MVCTest, and Markdown.

## Link To Active Site:
Not Applicable

## Specifications
| Description | Input | Output |
|-------------|---------------|--------|
| Project creates an instance of an order object to store order information. | let newOrder = new Order(); | newOrder |
| Project can return a description of the order. | newOrder.getInfo(); | "8 Croissants" |
| Project stores orders in a list. | List<Order> = new List<Order> | { Order, Order }; |
| Project creates an instance of a vendor object to store information. | let newVendor = new Vendor(); | newVendor |
| Project can return a description of the vendor. | newVendor.getInfo(); | "Suzie's capcakes is a cupcake shop." |
| Project stores Vendors in a list. | List<Vendor> = new List<Vendor> | { Vendor, Vendor }; |

### License

This software is licensed under the MIT license.

Copyright (c) 2016 **Janet Karpenske** _Vendor Orders_
using NorthWind.Contexts;
using NorthWind.Models;
using System;
using System.Data.Entity.Validation;

namespace NorthWind
{
    class Program
    {
        static void Main(string[] args)
        {

            Categories category1 = new Categories()
            {
                categoryName = "Graphic Cards",
                description = "Graphic cards for computers",
                picture = "https://www.gigabyte.com/FileUpload/global/news/1635/o201808201633495922.png"
            };

            Categories category2 = new Categories()
            {
                categoryName = "Memory",
                description = "RAM for pc and laptops",
                picture = "https://s3.us-east-2.amazonaws.com/cc-prd-s3-uploads/2020/2/7/4d1ee4b109c2d0cf8e917f9e712d3e17f4595e1b.jpeg"
            };


            
            Suppliers suppliers1 = new Suppliers()
            {
                companyName = "MSI",
                contactName = "MSI",
                contactTitle = "MSI",
                address = "1390 Barrydowne",
                city = "Sudbury",
                region = "Ontario",
                postalCode = "P3A 6B9",
                country = "Canada",
                fax = "-",
                homepage = "msi.com",
            };

            Suppliers suppliers2 = new Suppliers()
            {
                companyName = "Asus",
                contactName = "Asus",
                contactTitle = "Asus",
                address = "1390 Barrydowne",
                city = "Sudbury",
                region = "Ontario",
                postalCode = "P3A 6B9",
                country = "Canada",
                fax = "-",
                homepage = "asus.com",
            };

            Suppliers suppliers3 = new Suppliers()
            {
                companyName = "Evga",
                contactName = "Evga",
                contactTitle = "Evga",
                address = "1390 Barrydowne",
                city = "Sudbury",
                region = "Ontario",
                postalCode = "P3A 6B9",
                country = "Canada",
                fax = "-",
                homepage = "evga.com",
            };

            Suppliers suppliers4 = new Suppliers()
            {
                companyName = "Kingston",
                contactName = "Kingston",
                contactTitle = "Kingston",
                address = "1390 Barrydowne",
                city = "Sudbury",
                region = "Ontario",
                postalCode = "P3A 6B9",
                country = "Canada",
                fax = "-",
                homepage = "kingston.com",
            };


            Suppliers suppliers5 = new Suppliers()
            {
                companyName = "Corsair",
                contactName = "Corsair",
                contactTitle = "Corsair",
                address = "1390 Barrydowne",
                city = "Sudbury",
                region = "Ontario",
                postalCode = "P3A 6B9",
                country = "Canada",
                fax = "-",
                homepage = "corsair.com",
            };


            Products products1 = new Products()
            {
                productName = "RTX 3090",
                categories = category1,
                suppliers = suppliers1,
                quantityPerLabel = 20,
                unitPrice = 999.99F,
                unitsInStock = 50,
                unitsOnOrder = 30,
                recorderLevel = 10,
                discontinued = false,
            };


            Products products2 = new Products()
            {
                productName = "RTX 3080",
                categories = category1,
                suppliers = suppliers2,
                quantityPerLabel = 20,
                unitPrice = 699.99F,
                unitsInStock = 50,
                unitsOnOrder = 30,
                recorderLevel = 10,
                discontinued = false,
            };


            Products products3 = new Products()
            {
                productName = "RTX 3070",
                categories = category1,
                suppliers = suppliers3,
                quantityPerLabel = 20,
                unitPrice = 599.99F,
                unitsInStock = 50,
                unitsOnOrder = 30,
                recorderLevel = 10,
                discontinued = false,
            };


            Products products4 = new Products()
            {
                productName = "16 GB RAM",
                categories = category2,
                suppliers = suppliers4,
                quantityPerLabel = 20,
                unitPrice = 199.99F,
                unitsInStock = 500,
                unitsOnOrder = 50,
                recorderLevel = 10,
                discontinued = false,
            };


            Products products5 = new Products()
            {
                productName = "8 GB RAM",
                categories = category2,
                suppliers = suppliers5,
                quantityPerLabel = 20,
                unitPrice = 99.99F,
                unitsInStock = 500,
                unitsOnOrder = 50,
                recorderLevel = 10,
                discontinued = false,
            };

            Employees employees1 = new Employees()
            {
                lastName = "Doe",
                firstName = "John",
                title = "Manager",
                titleOfCourtesy = "Mr.",
                birthDate = new DateTime(2000,03,27),
                hireDate = new DateTime(2012, 03, 27),
                address = "1390 Barrydowne",
                city = "Sudbury",
                region = "Ontario",
                postalCode = "P3A 6B9",
                country = "Canada",
                homePhone = "779743912",
                extension = "356",
                photo = "johndoe.png",
                notes = "-",
                photoPath = "images/johndoe.png",
            };


            Employees employees2 = new Employees()
            {
                lastName = "Doe",
                firstName = "Sean",
                title = "Manager",
                titleOfCourtesy = "Mr.",
                birthDate = new DateTime(2000, 03, 27),
                hireDate = new DateTime(2012, 03, 27),
                address = "1390 Barrydowne",
                city = "Sudbury",
                region = "Ontario",
                postalCode = "P3A 6B9",
                country = "Canada",
                homePhone = "779743912",
                extension = "356",
                photo = "seandoe.png",
                notes = "-",
                photoPath = "images/seandoe.png",
                employees = employees1
            };


            Employees employees3 = new Employees()
            {
                lastName = "Doe",
                firstName = "John",
                title = "Sales",
                titleOfCourtesy = "Mr.",
                birthDate = new DateTime(2000, 03, 27),
                hireDate = new DateTime(2012, 03, 27),
                address = "1390 Barrydowne",
                city = "Sudbury",
                region = "Ontario",
                postalCode = "P3A 6B9",
                country = "Canada",
                homePhone = "779743912",
                extension = "356",
                photo = "johndoe.png",
                notes = "-",
                photoPath = "images/johndoe.png",
                employees = employees2
            };


            Employees employees4 = new Employees()
            {
                lastName = "Doe",
                firstName = "Jane",
                title = "Sales",
                titleOfCourtesy = "Mr.",
                birthDate = new DateTime(2000, 03, 27),
                hireDate = new DateTime(2012, 03, 27),
                address = "1390 Barrydowne",
                city = "Sudbury",
                region = "Ontario",
                postalCode = "P3A 6B9",
                country = "Canada",
                homePhone = "779743912",
                extension = "356",
                photo = "janedoe.png",
                notes = "-",
                photoPath = "images/janedoe.png",
                employees = employees2
            };


            Employees employees5 = new Employees()
            {
                lastName = "Doe",
                firstName = "Jane",
                title = "Sales",
                titleOfCourtesy = "Mr.",
                birthDate = new DateTime(2000, 03, 27),
                hireDate = new DateTime(2012, 03, 27),
                address = "1390 Barrydowne",
                city = "Sudbury",
                region = "Ontario",
                postalCode = "P3A 6B9",
                country = "Canada",
                homePhone = "779743912",
                extension = "356",
                photo = "janedoe.png",
                notes = "-",
                photoPath = "images/janedoe.png",
                employees = employees2
            };



            Customers customers1 = new Customers()
            {
                companyName = "Linus",
                contactName = "Linus",
                contactTitle = "Mr.",
                address = "1390 Barrydowne",
                city = "Sudbury",
                region = "Ontario",
                postalCode = "P3A 6B9",
                country = "Canada",
                phone = "779743912",
                fax = "-",
            };


            Customers customers2 = new Customers()
            {
                companyName = "Maruqes",
                contactName = "Marques",
                contactTitle = "Mr.",
                address = "1390 Barrydowne",
                city = "Sudbury",
                region = "Ontario",
                postalCode = "P3A 6B9",
                country = "Canada",
                phone = "779743912",
                fax = "-",
            };


            Customers customers3 = new Customers()
            {
                companyName = "Dev",
                contactName = "Dev",
                contactTitle = "Mr.",
                address = "1390 Barrydowne",
                city = "Sudbury",
                region = "Ontario",
                postalCode = "P3A 6B9",
                country = "Canada",
                phone = "779743912",
                fax = "-",
            };



            Customers customers4 = new Customers()
            {
                companyName = "Unbox Therapy",
                contactName = "Dave",
                contactTitle = "Mr.",
                address = "1390 Barrydowne",
                city = "Sudbury",
                region = "Ontario",
                postalCode = "P3A 6B9",
                country = "Canada",
                phone = "779743912",
                fax = "-",
            };


            Customers customers5 = new Customers()
            {
                companyName = "Dave",
                contactName = "Dave",
                contactTitle = "Mr.",
                address = "1390 Barrydowne",
                city = "Sudbury",
                region = "Ontario",
                postalCode = "P3A 6B9",
                country = "Canada",
                phone = "779743912",
                fax = "-",
            };

            Shippers shippers1 = new Shippers()
            {
                companyName = "DHL",
                phone = "779743912"
            };

            Shippers shippers2 = new Shippers()
            {
                companyName = "FedEX",
                phone = "77973912"
            };

            Orders orders1 = new Orders()
            {
                customers = customers1,
                employees = employees3,
                orderDate = new DateTime(2021, 03, 27),
                requriedDate = new DateTime(2021, 03, 29),
                shippedDate = new DateTime(2013, 03, 27),
                shippers = shippers1,
                freight = "2",
                shipName = "DHL",
                shipAddress = "1390",
                shipCity = "Toronto",
                shipReigon = "Ontario",
                shipPostalCode = "P3A",
                shipCountry = "Canada",
            };

            Orders orders2 = new Orders()
            {
                customers = customers2,
                employees = employees3,
                orderDate = new DateTime(2021, 03, 27),
                requriedDate = new DateTime(2021, 03, 29),
                shippedDate = new DateTime(2013, 03, 27),
                shippers = shippers1,
                freight = "2",
                shipName = "DHL",
                shipAddress = "1390",
                shipCity = "Toronto",
                shipReigon = "Ontario",
                shipPostalCode = "P3A",
                shipCountry = "Canada",
            };


            Orders orders3 = new Orders()
            {
                customers = customers3,
                employees = employees3,
                orderDate = new DateTime(2021, 03, 27),
                requriedDate = new DateTime(2021, 03, 29),
                shippedDate = new DateTime(2013, 03, 27),
                shippers = shippers1,
                freight = "2",
                shipName = "DHL",
                shipAddress = "1390",
                shipCity = "Toronto",
                shipReigon = "Ontario",
                shipPostalCode = "P3A",
                shipCountry = "Canada",
            };


            Orders orders4 = new Orders()
            {
                customers = customers4,
                employees = employees4,
                orderDate = new DateTime(2021, 03, 27),
                requriedDate = new DateTime(2021, 03, 29),
                shippedDate = new DateTime(2013, 03, 27),
                shippers = shippers2,
                freight = "2",
                shipName = "FedEx",
                shipAddress = "1390",
                shipCity = "Toronto",
                shipReigon = "Ontario",
                shipPostalCode = "P3A",
                shipCountry = "Canada",
            };


            Orders orders5 = new Orders()
            {
                customers = customers5,
                employees = employees4,
                orderDate = new DateTime(2021, 03, 27),
                requriedDate = new DateTime(2021, 03, 29),
                shippedDate = new DateTime(2013, 03, 27),
                shippers = shippers2,
                freight = "2",
                shipName = "FedEx",
                shipAddress = "1390",
                shipCity = "Toronto",
                shipReigon = "Ontario",
                shipPostalCode = "P3A",
                shipCountry = "Canada",
            };



            OrderDetails orderDetails1 = new OrderDetails()
            {
                unitPrice = 999.99F,
                quantity = 1,
                discount = 0.00f,
                products = products1,
                orders = orders1
            };

            OrderDetails orderDetails2 = new OrderDetails()
            {
                unitPrice = 999.99F,
                quantity = 1,
                discount = 0.00f,
                products = products1,
                orders = orders2
            };

            OrderDetails orderDetails3 = new OrderDetails()
            {
                unitPrice = 999.99F,
                quantity = 1,
                discount = 0.00f,
                products = products1,
                orders = orders3
            };

            OrderDetails orderDetails4 = new OrderDetails()
            {
                unitPrice = 999.99F,
                quantity = 1,
                discount = 0.00f,
                products = products1,
                orders = orders4
            };


            OrderDetails orderDetails5 = new OrderDetails()
            {
                unitPrice = 999.99F,
                quantity = 1,
                discount = 0.00f,
                products = products1,
                orders = orders5
            };


            Region region1 = new Region()
            {
                regionDescription = "Test region 1"
            };

            Region region2 = new Region()
            {
                regionDescription = "Test region 2"
            };

            Territories territories1 = new Territories()
            {
                territoryDescription = "",
                region = region1
            };

            Territories territories2 = new Territories()
            {
                territoryDescription = "",
                region = region1
            };

            EmployeeTerritories employeeTerritories1 = new EmployeeTerritories()
            {
                employees = employees1,
                territories = territories1
            };

            EmployeeTerritories employeeTerritories2 = new EmployeeTerritories()
            {
                employees = employees3,
                territories = territories2
            };


            using (NorthWindContext ctx = new NorthWindContext())
            {
                ctx.categories.Add(category1);
                ctx.categories.Add(category2);

                ctx.products.Add(products1);
                ctx.products.Add(products2);
                ctx.products.Add(products3);
                ctx.products.Add(products4);
                ctx.products.Add(products5);

                ctx.region.Add(region1);
                ctx.region.Add(region2);

                ctx.suppliers.Add(suppliers1);
                ctx.suppliers.Add(suppliers2);
                ctx.suppliers.Add(suppliers3);
                ctx.suppliers.Add(suppliers4);
                ctx.suppliers.Add(suppliers5);


                ctx.shippers.Add(shippers1);
                ctx.shippers.Add(shippers2);

                ctx.region.Add(region1);
                ctx.region.Add(region2);

                ctx.territories.Add(territories1);
                ctx.territories.Add(territories2);

                ctx.employees.Add(employees1);
                ctx.employees.Add(employees2);
                ctx.employees.Add(employees3);
                ctx.employees.Add(employees4);
                ctx.employees.Add(employees5);

                ctx.employeeteritorries.Add(employeeTerritories1);
                ctx.employeeteritorries.Add(employeeTerritories2);

                ctx.customers.Add(customers1);
                ctx.customers.Add(customers2);
                ctx.customers.Add(customers3);
                ctx.customers.Add(customers4);
                ctx.customers.Add(customers5);

                ctx.orders.Add(orders1);
                ctx.orders.Add(orders2);
                ctx.orders.Add(orders3);
                ctx.orders.Add(orders4);
                ctx.orders.Add(orders5);

                ctx.orderdetails.Add(orderDetails1);
                ctx.orderdetails.Add(orderDetails2);
                ctx.orderdetails.Add(orderDetails3);
                ctx.orderdetails.Add(orderDetails4);
                ctx.orderdetails.Add(orderDetails5);

                try
                {
                    ctx.SaveChanges();

                }
                catch (DbEntityValidationException e)
                {
                    foreach (var eve in e.EntityValidationErrors)
                    {
                        Console.WriteLine("Entity of type \"{0}\" in state \"{1}\" has the following validation errors:",
                            eve.Entry.Entity.GetType().Name, eve.Entry.State);
                        foreach (var ve in eve.ValidationErrors)
                        {
                            Console.WriteLine("- Property: \"{0}\", Error: \"{1}\"",
                                ve.PropertyName, ve.ErrorMessage);
                        }
                    }
                }
            }

        }
    }
}

namespace CFM.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        categoryID = c.Int(nullable: false, identity: true),
                        categoryName = c.String(),
                        description = c.String(),
                        picture = c.String(),
                    })
                .PrimaryKey(t => t.categoryID);
            
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        customerID = c.Int(nullable: false, identity: true),
                        companyName = c.String(),
                        contactName = c.String(),
                        contactTitle = c.String(),
                        address = c.String(),
                        city = c.String(),
                        region = c.String(),
                        postalCode = c.String(),
                        country = c.String(),
                        phone = c.String(),
                        fax = c.String(),
                    })
                .PrimaryKey(t => t.customerID);
            
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        employeeID = c.Int(nullable: false, identity: true),
                        lastName = c.String(),
                        firstName = c.String(),
                        title = c.String(),
                        titleOfCourtesy = c.String(),
                        birthDate = c.DateTime(nullable: false),
                        hireDate = c.DateTime(nullable: false),
                        address = c.String(),
                        city = c.String(),
                        region = c.String(),
                        postalCode = c.String(),
                        country = c.String(),
                        homePhone = c.String(),
                        extension = c.String(),
                        photo = c.String(),
                        notes = c.String(),
                        reportsTo = c.Int(),
                        photoPath = c.String(),
                    })
                .PrimaryKey(t => t.employeeID)
                .ForeignKey("dbo.Employees", t => t.reportsTo)
                .Index(t => t.reportsTo);
            
            CreateTable(
                "dbo.EmployeeTerritories",
                c => new
                    {
                        EmployeeTerritoryID = c.Int(nullable: false, identity: true),
                        employeeID = c.Int(nullable: false),
                        territoryID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.EmployeeTerritoryID)
                .ForeignKey("dbo.Employees", t => t.employeeID, cascadeDelete: true)
                .ForeignKey("dbo.Territories", t => t.territoryID, cascadeDelete: true)
                .Index(t => t.employeeID)
                .Index(t => t.territoryID);
            
            CreateTable(
                "dbo.Territories",
                c => new
                    {
                        territoryID = c.Int(nullable: false, identity: true),
                        regionID = c.Int(nullable: false),
                        territoryDescription = c.String(),
                    })
                .PrimaryKey(t => t.territoryID)
                .ForeignKey("dbo.Region", t => t.regionID, cascadeDelete: true)
                .Index(t => t.regionID);
            
            CreateTable(
                "dbo.Region",
                c => new
                    {
                        regionID = c.Int(nullable: false, identity: true),
                        regionDescription = c.String(),
                    })
                .PrimaryKey(t => t.regionID);
            
            CreateTable(
                "dbo.OrderDetails",
                c => new
                    {
                        orderDetailID = c.Int(nullable: false, identity: true),
                        productID = c.Int(nullable: false),
                        orderID = c.Int(nullable: false),
                        unitPrice = c.Single(nullable: false),
                        quantity = c.Int(nullable: false),
                        discount = c.Single(nullable: false),
                    })
                .PrimaryKey(t => t.orderDetailID)
                .ForeignKey("dbo.Orders", t => t.orderID, cascadeDelete: true)
                .ForeignKey("dbo.Products", t => t.productID, cascadeDelete: true)
                .Index(t => t.productID)
                .Index(t => t.orderID);
            
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        orderID = c.Int(nullable: false, identity: true),
                        customerID = c.Int(nullable: false),
                        EmployeeID = c.Int(nullable: false),
                        orderDate = c.DateTime(nullable: false),
                        requriedDate = c.DateTime(nullable: false),
                        shippedDate = c.DateTime(nullable: false),
                        shippedVia = c.Int(nullable: false),
                        freight = c.String(),
                        shipName = c.String(),
                        shipAddress = c.String(),
                        shipCity = c.String(),
                        shipReigon = c.String(),
                        shipPostalCode = c.String(),
                        shipCountry = c.String(),
                    })
                .PrimaryKey(t => t.orderID)
                .ForeignKey("dbo.Customers", t => t.customerID, cascadeDelete: true)
                .ForeignKey("dbo.Employees", t => t.EmployeeID, cascadeDelete: true)
                .ForeignKey("dbo.Shippers", t => t.shippedVia, cascadeDelete: true)
                .Index(t => t.customerID)
                .Index(t => t.EmployeeID)
                .Index(t => t.shippedVia);
            
            CreateTable(
                "dbo.Shippers",
                c => new
                    {
                        shipperID = c.Int(nullable: false, identity: true),
                        companyName = c.String(),
                        phone = c.String(),
                    })
                .PrimaryKey(t => t.shipperID);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        productID = c.Int(nullable: false, identity: true),
                        categoryID = c.Int(nullable: false),
                        supplierID = c.Int(nullable: false),
                        productName = c.String(),
                        quantityPerLabel = c.Int(nullable: false),
                        unitPrice = c.Single(nullable: false),
                        unitsInStock = c.Int(nullable: false),
                        unitsOnOrder = c.Int(nullable: false),
                        recorderLevel = c.Int(nullable: false),
                        discontinued = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.productID)
                .ForeignKey("dbo.Categories", t => t.categoryID, cascadeDelete: true)
                .ForeignKey("dbo.Suppliers", t => t.supplierID, cascadeDelete: true)
                .Index(t => t.categoryID)
                .Index(t => t.supplierID);
            
            CreateTable(
                "dbo.Suppliers",
                c => new
                    {
                        supplierID = c.Int(nullable: false, identity: true),
                        companyName = c.String(),
                        contactName = c.String(),
                        contactTitle = c.String(),
                        address = c.String(),
                        city = c.String(),
                        region = c.String(),
                        postalCode = c.String(),
                        country = c.String(),
                        fax = c.String(),
                        homepage = c.String(),
                    })
                .PrimaryKey(t => t.supplierID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.OrderDetails", "productID", "dbo.Products");
            DropForeignKey("dbo.Products", "supplierID", "dbo.Suppliers");
            DropForeignKey("dbo.Products", "categoryID", "dbo.Categories");
            DropForeignKey("dbo.OrderDetails", "orderID", "dbo.Orders");
            DropForeignKey("dbo.Orders", "shippedVia", "dbo.Shippers");
            DropForeignKey("dbo.Orders", "EmployeeID", "dbo.Employees");
            DropForeignKey("dbo.Orders", "customerID", "dbo.Customers");
            DropForeignKey("dbo.EmployeeTerritories", "territoryID", "dbo.Territories");
            DropForeignKey("dbo.Territories", "regionID", "dbo.Region");
            DropForeignKey("dbo.EmployeeTerritories", "employeeID", "dbo.Employees");
            DropForeignKey("dbo.Employees", "reportsTo", "dbo.Employees");
            DropIndex("dbo.Products", new[] { "supplierID" });
            DropIndex("dbo.Products", new[] { "categoryID" });
            DropIndex("dbo.Orders", new[] { "shippedVia" });
            DropIndex("dbo.Orders", new[] { "EmployeeID" });
            DropIndex("dbo.Orders", new[] { "customerID" });
            DropIndex("dbo.OrderDetails", new[] { "orderID" });
            DropIndex("dbo.OrderDetails", new[] { "productID" });
            DropIndex("dbo.Territories", new[] { "regionID" });
            DropIndex("dbo.EmployeeTerritories", new[] { "territoryID" });
            DropIndex("dbo.EmployeeTerritories", new[] { "employeeID" });
            DropIndex("dbo.Employees", new[] { "reportsTo" });
            DropTable("dbo.Suppliers");
            DropTable("dbo.Products");
            DropTable("dbo.Shippers");
            DropTable("dbo.Orders");
            DropTable("dbo.OrderDetails");
            DropTable("dbo.Region");
            DropTable("dbo.Territories");
            DropTable("dbo.EmployeeTerritories");
            DropTable("dbo.Employees");
            DropTable("dbo.Customers");
            DropTable("dbo.Categories");
        }
    }
}

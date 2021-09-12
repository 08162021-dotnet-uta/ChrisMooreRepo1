use WebStoreApplicationDB
go

--Creates tables for entities Customers, Products, Store, Orders, ItemizedOrders;
CREATE TABLE Customers(
CustomerId INT PRIMARY KEY IDENTITY(1,1),
FirstName varchar(50) NOT NULL,
LastName varchar(50) NOT NULL);

CREATE TABLE Products(
ProductId INT PRIMARY KEY IDENTITY(1,1),
ProductName varchar(50) NOT NULL,
ProductDescription varchar(100),
ProductPrice decimal(19,2) NOT NULL);

CREATE TABLE Store(
StoreId INT PRIMARY KEY IDENTITY(1,1),
StoreName varchar(50) NOT NULL,
StoreLocation varchar(50) NOT NULL);

CREATE TABLE Orders(
OrderId uniqueidentifier NOT NULL DEFAULT newid() PRIMARY KEY,
StoreId INT NOT NULL FOREIGN KEY REFERENCES Store(StoreId),
CustomerId INT NOT NULL FOREIGN KEY REFERENCES Customers(CustomerId),
OrderDate date NOT NULL);

CREATE TABLE ItemizedOrders(
ItemizedId uniqueidentifier NOT NULL DEFAULT newid() PRIMARY KEY,
OrderId uniqueidentifier NOT NULL FOREIGN KEY REFERENCES Orders(OrderId),
ProductId INT NOT NULL FOREIGN KEY REFERENCES Products(ProductId));


--sample insert statements for customer entries
INSERT INTO Customers
VALUES ('Chris','Moore');
INSERT INTO Customers
VALUES ('Aaron','Guilder');
INSERT INTO Customers
VALUES ('Joseph','Lock');
INSERT INTO Customers
VALUES ('Ariana','Vensquali');
INSERT INTO Customers
VALUES ('Tera','Kent');

--sample insert statements for product entries
INSERT INTO Products
VALUES ('HP450','An HP probook laptop computer',449.99);
INSERT INTO Products
VALUES ('HP OMEN','An HP gaming desktop computer',999.99);
INSERT INTO Products
VALUES ('Razor45','A razor mid-tower that comes with liquid-cooling',1499.99);
INSERT INTO Products
VALUES ('K&M Combo','A keyboard and mouse combo',39.99);
INSERT INTO Products
VALUES ('ASUS Monitor','A monitor that runs 144hz',199.99);

--sample insert statements for store entries
INSERT INTO Store
VALUES ('TechXtreme','San Bernardino');
INSERT INTO Store
VALUES ('TechX','Barstow');
INSERT INTO Store
VALUES ('TechXGamer','Victorville');

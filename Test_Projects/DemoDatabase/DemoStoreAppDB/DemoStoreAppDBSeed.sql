--Created a demo database to use for P0 completion/prep for P1
create database DemoStoreAppDB;

--Uses the master localdb
use master
go
--Uses the Demo database
use DemoStoreAppDB
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
StoreName varchar(50) NOT NULL);

CREATE TABLE Orders(
OrderId INT PRIMARY KEY IDENTITY(1,1),
StoreId INT NOT NULL FOREIGN KEY REFERENCES Store(StoreId),
CustomerId INT NOT NULL FOREIGN KEY REFERENCES Customers(CustomerId),
OrderDate date NOT NULL);

CREATE TABLE ItemizedOrders(
ItemizedId uniqueidentifier NOT NULL DEFAULT newid() PRIMARY KEY,
OrderId INT NOT NULL FOREIGN KEY REFERENCES Orders(OrderId),
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
VALUES ('San Bernardino');
INSERT INTO Store
VALUES ('Barstow');
INSERT INTO Store
VALUES ('Victorville');
INSERT INTO Store
VALUES ('Los Angeles');
INSERT INTO Store
VALUES ('Ontario');

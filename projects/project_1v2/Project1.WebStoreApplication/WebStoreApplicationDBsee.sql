use master;
create database WeBStoreApplicationDB;
go

use WeBStoreApplicationDB;
go
--Creates tables for entities Customers, Products, Store, Orders, ItemizedOrders;
CREATE TABLE Customers(
	CustomerId INT PRIMARY KEY IDENTITY(1,1),
	FirstName VARCHAR(50) NOT NULL,
	LastName VARCHAR(50) NOT NULL,
	UserName VARCHAR(25) Not NULL,
	Password VARCHAR(25) NOT NULL);

CREATE TABLE Product(
	ProductId INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	ProductName VARCHAR(50) NOT NULL,
	ProductDescription VARCHAR(50),
	ProductPrice DECIMAL(6,2) NOT NULL);

CREATE TABLE Store(
	StoreId INT PRIMARY KEY IDENTITY(1,1),
	StoreLocation varchar(50) UNIQUE NOT NULL);

CREATE TABLE Orders(
	OrderId INT PRIMARY KEY IDENTITY (1,1) NOT NULL,
	StoreId INT NOT NULL FOREIGN KEY REFERENCES Store(StoreId) ON DELETE CASCADE,
	CustomerId INT NOT NULL FOREIGN KEY REFERENCES Customers(CustomerId) ON DELETE CASCADE,
	OrderDate DATETIME NOT NULL);

CREATE TABLE ItemizedOrders(
	ItemizedId uniqueidentifier NOT NULL DEFAULT newid() PRIMARY KEY, 
	OrderId INT NOT NULL FOREIGN REFERENCES Orders(OrderId) ON DELETE CASCADE,
	ProductId INT NOT NULL FOREIGN KEY REFERENCES Product(ProductId) ON DELETE CASCADE,
	Quantity INT NOT NULL);

CREATE TABLE Inventory(
	InventoryId INT PRIMARY KEY IDENTITY (1,1) NOT NULL,
	StoreId INT NOT NULL FOREIGN KEY REFERENCES Store(StoreId) ON DELETE CASCADE,
	ProductId INT NOT NULL FOREIGN KEY REFERENCES Product(ProductId) ON DELETE CASCADE,
	QUANTITY INT NOT NULL);





--Query to verify table for Customers
select * from Customers;
--sample insert statements for customer entries
INSERT INTO Customers(FirstName, LastName, UserName, Password) 
VALUES 
	('Ventruss','Castor', 'crypticshadow', 'Password123'),
	('Aaron','Guilder','goldenshack', 'Password123'),
	('Joseph','Lock','breaknstuff', 'Password123'), 
	('Ariana','Vensquali', 'songndance', 'Password123'), 
	('Tera','Kent', 'iamarussionspy', 'Password123'),
	('Ivana','Kent', 'ivanausername', 'Password123'),
	('Idarather','Not', 'idarathernot', 'Password123');
--Query to verify table for Product
select * from Product;
--sample insert statements for product entries
INSERT INTO Product(ProductName, ProductDescription, ProductPrice)
VALUES 
	('HP450','An HP probook laptop computer', 449.99),
	('HP OMEN','An HP gaming desktop computer', 999.99),
	('Razor45','A razor mid-tower that comes with liquid-cooling', 1499.99),
	('K&M Combo','A keyboard and mouse combo', 39.99),
	('ASUS Monitor','A monitor that runs 144hz', 199.99),
	('mouse','mouse for clicking and pointing', 15.99),
	('SharkWire','new cat cable standard 150ft', 99.99),
	('PredatorGaming','gaming laptop', 699.99);

--Query to verify table for Store	
Select * from Store;
--sample insert statements for store entries
INSERT INTO Store
VALUES ('San Bernardino'),('Barstow'),('Victorville');


select * from Inventory;
--sample insert into inventory table
INSERT INTO INVENTORY(StoreId, ProductId, Quantity) 
VALUES 
(1,1,20),(1,2,5),(1,6,15),(1,7,10),(1,4,10),
(2,2,15),(2,3,10),(2,5,25),(2,4,20),(2,8,8),(3,3,15),
(3,6,10),(3,7,25),(3,2,30),(3,5,30);

SELECT * FROM Orders;
--sample insert for Order table
INSERT INTO Orders(CustomerId,StoreId,OrderDate,TotalPrice)
SELECT * FROM ItemizedOrders;
--sample insert into Itemized order table
INSERT INTO ItemizedOrders(OrderId,ProductId, Quantity)
VALUES
(1,1,5),(2,2,3),(1,6,4),(1,7,3),(1,4,6);

--ALTER TABLE Store.StoreLocation ADD CONSTRAINT StoreLocation Unique;
ALTER TABLE Orders ADD TotalPrice DECIMAL(6,2) NOT NULL;
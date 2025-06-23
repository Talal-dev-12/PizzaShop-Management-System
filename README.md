# 🍕 PizzaHut Order Management System

A C# Windows Forms application to manage PizzaHut customer orders, including pizza, salads, and drinks. Built with **MySQL** backend, **ClosedXML** for Excel exports, and organized modules for Active & Delivered customers.

---

## 📦 Features

- 📝 Admin Login
- 🛒 Add/Update/Delete Orders
- 🍕 Manage Pizzas, Sizes, Salads, and Drinks
- 📋 Order Status: Preparing → Ready → Delivered
- 📁 Export Delivered Orders to Excel
- 🗂 Archive Delivered Orders
- 📅 Filter Orders by Delivery Date
- 📊 Total Sales and Orders Summary

---

## 🛠 Tech Stack

- Language: **C# (.NET WinForms)**
- Database: **MySQL**
- Export: **ClosedXML (No Excel Interop Needed)**
- UI: **DataGridView**, **DateTimePicker**, **RadioButtons**

---
# 🍕 Pizza Order System - MySQL Database Setup

This README contains complete SQL setup for the `pizza_order_db` database. Follow the steps to create and populate your database for use with your pizza ordering application.

---

## 🔧 Step 1: Create Database & Use It
```sql
CREATE DATABASE IF NOT EXISTS pizza_order_db;
USE pizza_order_db;
```

---

## 👤 Users Table (For Admin Login)
```sql
CREATE TABLE Users (
    UserID INT AUTO_INCREMENT PRIMARY KEY,
    Username VARCHAR(50) UNIQUE NOT NULL,
    Password VARCHAR(100) NOT NULL
);

INSERT INTO Users (Username, Password) VALUES ('admin', 'admin');
```

---

## 🍕 Pizza Tables
```sql
CREATE TABLE PizzaFlavors (
    PizzaID INT AUTO_INCREMENT PRIMARY KEY,
    FlavorName VARCHAR(50) NOT NULL,
    Description VARCHAR(255),
    BasePrice DECIMAL(10,2) NOT NULL,
    TaxPercentage DECIMAL(5,2) DEFAULT 3.0
);

CREATE TABLE PizzaSizes (
    SizeID INT AUTO_INCREMENT PRIMARY KEY,
    SizeName VARCHAR(20) NOT NULL,
    SizeMultiplier DECIMAL(3,2) NOT NULL
);

CREATE TABLE PizzaPrices (
    PriceID INT AUTO_INCREMENT PRIMARY KEY,
    PizzaID INT NOT NULL,
    SizeID INT NOT NULL,
    FinalPrice DECIMAL(10,2) NOT NULL,
    FOREIGN KEY (PizzaID) REFERENCES PizzaFlavors(PizzaID),
    FOREIGN KEY (SizeID) REFERENCES PizzaSizes(SizeID)
);
```

---

## 🥤 Drink Tables
```sql
CREATE TABLE DrinkCategories (
    CategoryID INT AUTO_INCREMENT PRIMARY KEY,
    CategoryName VARCHAR(50) NOT NULL
);

CREATE TABLE DrinkItems (
    DrinkID INT AUTO_INCREMENT PRIMARY KEY,
    CategoryID INT,
    DrinkName VARCHAR(50) NOT NULL,
    BasePrice DECIMAL(10,2) NOT NULL,
    TaxPercentage DECIMAL(5,2) DEFAULT 2.0,
    FOREIGN KEY (CategoryID) REFERENCES DrinkCategories(CategoryID)
);

CREATE TABLE DrinkSizes (
    DrinkSizeID INT AUTO_INCREMENT PRIMARY KEY,
    VolumeDescription VARCHAR(20) NOT NULL,
    VolumeML INT NOT NULL,
    SizeMultiplier DECIMAL(3,2) NOT NULL,
    ContainerType VARCHAR(20) DEFAULT 'Bottle'
);

CREATE TABLE DrinkPrices (
    DrinkPriceID INT AUTO_INCREMENT PRIMARY KEY,
    DrinkID INT NOT NULL,
    DrinkSizeID INT NOT NULL,
    FinalPrice DECIMAL(10,2) NOT NULL,
    FOREIGN KEY (DrinkID) REFERENCES DrinkItems(DrinkID),
    FOREIGN KEY (DrinkSizeID) REFERENCES DrinkSizes(DrinkSizeID)
);
```

---

## 🥗 Salad Tables
```sql
CREATE TABLE Salads (
    SaladID INT AUTO_INCREMENT PRIMARY KEY,
    SaladName VARCHAR(50) NOT NULL,
    Price DECIMAL(10,2) NOT NULL,
    TaxPercentage DECIMAL(5,2) DEFAULT 3.0
);

CREATE TABLE SaladSizes (
    SizeID INT AUTO_INCREMENT PRIMARY KEY,
    SizeName VARCHAR(20) NOT NULL,
    SizeMultiplier DECIMAL(3,2) NOT NULL
);
```

---

## 📦 Orders Table
```sql
CREATE TABLE Orders (
    OID INT AUTO_INCREMENT PRIMARY KEY,
    CustomerName VARCHAR(100) NOT NULL,
    PhoneNo VARCHAR(13) NOT NULL,
    OrderDate DATETIME DEFAULT CURRENT_TIMESTAMP,
    GovtTaxPercentage DECIMAL(5,2) NOT NULL,
    TotalAmount DECIMAL(10,2) NOT NULL,
    OrderStatus VARCHAR(20) DEFAULT 'Preparing',
    DeliveredAt DATETIME NULL,
    IsArchived BOOLEAN DEFAULT 0,
    CONSTRAINT chk_phone_format CHECK (PhoneNo REGEXP '^\\+92[0-9]{10}$')
);
```

---

## 🧾 Order Item Tables
```sql
CREATE TABLE OrderPizzas (
    OrderPizzaID INT AUTO_INCREMENT PRIMARY KEY,
    OID INT NOT NULL,
    PizzaID INT NOT NULL,
    SizeID INT NOT NULL,
    Quantity INT DEFAULT 1,
    Price DECIMAL(10,2) NOT NULL,
    FOREIGN KEY (OID) REFERENCES Orders(OID),
    FOREIGN KEY (PizzaID) REFERENCES PizzaFlavors(PizzaID),
    FOREIGN KEY (SizeID) REFERENCES PizzaSizes(SizeID)
);

CREATE TABLE OrderDrinks (
    OrderDrinkID INT AUTO_INCREMENT PRIMARY KEY,
    OID INT NOT NULL,
    DrinkID INT NOT NULL,
    DrinkSizeID INT NOT NULL,
    Quantity INT DEFAULT 1,
    Price DECIMAL(10,2) NOT NULL,
    FOREIGN KEY (OID) REFERENCES Orders(OID),
    FOREIGN KEY (DrinkID) REFERENCES DrinkItems(DrinkID),
    FOREIGN KEY (DrinkSizeID) REFERENCES DrinkSizes(DrinkSizeID)
);

CREATE TABLE OrderSalads (
    OrderSaladID INT AUTO_INCREMENT PRIMARY KEY,
    OID INT NOT NULL,
    SaladID INT NOT NULL,
    SizeID INT NOT NULL,
    Quantity INT DEFAULT 1,
    Price DECIMAL(10,2) NOT NULL,
    FOREIGN KEY (OID) REFERENCES Orders(OID),
    FOREIGN KEY (SaladID) REFERENCES Salads(SaladID),
    FOREIGN KEY (SizeID) REFERENCES SaladSizes(SizeID)
);
```

---

## 📥 Sample Data Insertion
```sql
-- Pizza Sizes
INSERT INTO PizzaSizes (SizeName, SizeMultiplier) VALUES 
('Small', 0.6), ('Regular', 1.0), ('Medium', 1.2), ('Large', 1.5), ('Jumbo', 2.0);

-- Drink Sizes
INSERT INTO DrinkSizes (VolumeDescription, VolumeML, SizeMultiplier, ContainerType) VALUES
('345 ml', 345, 1.0, 'Can'), ('500 ml', 500, 1.5, 'Bottle'), ('1 Liter', 1000, 2.0, 'Bottle'),
('1.5 Liter', 1500, 2.5, 'Pitcher'), ('2.25 Liter/Jumbo', 2250, 3.0, 'Pitcher');

-- Drink Categories
INSERT INTO DrinkCategories (CategoryName) VALUES
('Cola'), ('Lemon-Lime'), ('Orange'), ('Energy Drink'), ('Local Soda');

-- Pizza Flavors
INSERT INTO PizzaFlavors (FlavorName, Description, BasePrice) VALUES
('Margherita', 'Classic tomato and mozzarella', 749),
('Pepperoni', 'Tomato sauce, mozzarella, and pepperoni', 799),
('BBQ Chicken', 'BBQ sauce, chicken, and onions', 849),
('Hawaiian', 'Ham and pineapple', 829),
('Vegetarian', 'Mixed vegetables', 799);

-- Drink Items
INSERT INTO DrinkItems (CategoryID, DrinkName, BasePrice) VALUES
(1, 'Pepsi', 80), (1, 'Coca-Cola', 80), (2, 'Sprite', 80), (2, '7Up', 80),
(3, 'Fanta Orange', 80), (3, 'Mirinda Orange', 80), (4, 'Sting', 120),
(5, 'Pakola Ice Cream Soda', 90), (5, 'Pakola Lychee', 90), (5, 'Pakola Raspberry', 90);

-- Salads
INSERT INTO Salads (SaladName, Price) VALUES
('Greek Salad', 200), ('Caesar Salad', 250), ('Green Salad', 150);

-- Salad Sizes
INSERT INTO SaladSizes (SizeName, SizeMultiplier) VALUES
('Small', 0.7), ('Medium', 1.0), ('Large', 1.3);
```

---

## 🧮 Auto Pricing
```sql
-- Pizza Prices
INSERT INTO PizzaPrices (PizzaID, SizeID, FinalPrice)
SELECT p.PizzaID, s.SizeID, ROUND(p.BasePrice * s.SizeMultiplier, 0)
FROM PizzaFlavors p
CROSS JOIN PizzaSizes s;

-- Drink Prices
INSERT INTO DrinkPrices (DrinkID, DrinkSizeID, FinalPrice)
SELECT d.DrinkID, ds.DrinkSizeID,
    CASE 
        WHEN ds.VolumeML = 345 THEN d.BasePrice
        WHEN ds.VolumeML = 500 THEN 120
        WHEN ds.VolumeML = 1000 THEN 170
        WHEN ds.VolumeML = 1500 THEN 230
        WHEN ds.VolumeML = 2250 THEN 260
    END
FROM DrinkItems d
CROSS JOIN DrinkSizes ds;
```

---

## ✅ Sample Order Generation (100 Delivered Orders)
```sql
-- Clear previous data
SET FOREIGN_KEY_CHECKS = 0;
TRUNCATE TABLE OrderDrinks;
TRUNCATE TABLE OrderSalads;
TRUNCATE TABLE OrderPizzas;
TRUNCATE TABLE Orders;
SET FOREIGN_KEY_CHECKS = 1;

-- Pakistani names
CREATE TEMPORARY TABLE PakistaniNames (
    FirstName VARCHAR(50),
    LastName VARCHAR(50)
);

INSERT INTO PakistaniNames (FirstName, LastName) VALUES
('Muhammad', 'Khan'), ('Ali', 'Ahmed'), ('Ahmed', 'Raza'), ('Usman', 'Malik'),
('Bilal', 'Hussain'), ('Omar', 'Shah'), ('Zain', 'Abbasi'), ('Haris', 'Farooq'),
('Saad', 'Sheikh'), ('Hamza', 'Iqbal'), ('Abdullah', 'Mirza'), ('Asim', 'Baig'),
('Faisal', 'Chaudhry'), ('Kamran', 'Saeed'), ('Noman', 'Rasheed'), ('Tariq', 'Khalid'),
('Waqar', 'Nawaz'), ('Yasir', 'Qureshi'), ('Adnan', 'Saleem'), ('Babar', 'Azam');

-- Insert Orders
INSERT INTO Orders (CustomerName, PhoneNo, GovtTaxPercentage, TotalAmount, OrderDate, OrderStatus, DeliveredAt)
SELECT 
    CONCAT(n.FirstName, ' ', n.LastName),
    CONCAT('+92', FLOOR(3000000000 + RAND() * 699999999)),
    5 + FLOOR(RAND() * 11),
    0,
    DATE_SUB(CURDATE(), INTERVAL FLOOR(RAND() * 180) DAY),
    'Delivered',
    DATE_SUB(CURDATE(), INTERVAL FLOOR(RAND() * 180) DAY)
FROM PakistaniNames n
ORDER BY RAND()
LIMIT 100;

-- Insert Pizza Items for 80 Orders
CREATE TEMPORARY TABLE TempRandomOrders AS
SELECT OID FROM Orders ORDER BY RAND() LIMIT 80;

INSERT INTO OrderPizzas (OID, PizzaID, SizeID, Quantity, Price)
SELECT t.OID, p.PizzaID, s.SizeID, 1, pr.FinalPrice
FROM TempRandomOrders t
JOIN (SELECT PizzaID FROM PizzaFlavors ORDER BY RAND() LIMIT 1) p
JOIN (SELECT SizeID FROM PizzaSizes ORDER BY RAND() LIMIT 1) s
JOIN PizzaPrices pr ON pr.PizzaID = p.PizzaID AND pr.SizeID = s.SizeID;

-- Drinks for 70 Orders
CREATE TEMPORARY TABLE TempRandomDrinks AS
SELECT OID FROM Orders ORDER BY RAND() LIMIT 70;

INSERT INTO OrderDrinks (OID, DrinkID, DrinkSizeID, Quantity, Price)
SELECT t.OID, d.DrinkID, s.DrinkSizeID, 1, dp.FinalPrice
FROM TempRandomDrinks t
JOIN (SELECT DrinkID FROM DrinkItems ORDER BY RAND() LIMIT 1) d
JOIN (SELECT DrinkSizeID FROM DrinkSizes ORDER BY RAND() LIMIT 1) s
JOIN DrinkPrices dp ON dp.DrinkID = d.DrinkID AND dp.DrinkSizeID = s.DrinkSizeID;

-- Salads for 50 Orders
CREATE TEMPORARY TABLE TempRandomSalads AS
SELECT OID FROM Orders ORDER BY RAND() LIMIT 50;

INSERT INTO OrderSalads (OID, SaladID, SizeID, Quantity, Price)
SELECT t.OID, sa.SaladID, sz.SizeID, 1, ROUND(sa.Price * sz.SizeMultiplier, 0)
FROM TempRandomSalads t
JOIN (SELECT SaladID, Price FROM Salads ORDER BY RAND() LIMIT 1) sa
JOIN (SELECT SizeID, SizeMultiplier FROM SaladSizes ORDER BY RAND() LIMIT 1) sz;

-- Calculate Order Totals
UPDATE Orders o
LEFT JOIN (SELECT OID, SUM(Price) AS PizzaTotal FROM OrderPizzas GROUP BY OID) p ON o.OID = p.OID
LEFT JOIN (SELECT OID, SUM(Price) AS DrinkTotal FROM OrderDrinks GROUP BY OID) d ON o.OID = d.OID
LEFT JOIN (SELECT OID, SUM(Price) AS SaladTotal FROM OrderSalads GROUP BY OID) s ON o.OID = s.OID
SET o.TotalAmount = ROUND((IFNULL(p.PizzaTotal,0) + IFNULL(d.DrinkTotal,0) + IFNULL(s.SaladTotal,0)) * (1 + o.GovtTaxPercentage / 100), 0);

-- Drop Temp Tables
DROP TEMPORARY TABLE IF EXISTS PakistaniNames;
DROP TEMPORARY TABLE IF EXISTS TempRandomOrders;
DROP TEMPORARY TABLE IF EXISTS TempRandomDrinks;
DROP TEMPORARY TABLE IF EXISTS TempRandomSalads;
```
✅ Now your database is ready with **100 sample delivered orders** including pizzas, drinks, and salads. This is ideal for testing filtering, archiving, and Excel export features in your Pizza Management System.


## 📂 Folder Structure

```plaintext
pizza/
├── Forms/
│   ├── ActiveOrders.cs
│   ├── DeliveredOrders.cs
│   └── Login.cs
├── Resources/
├── Program.cs
├── App.config
└── README.md
🗄 Database Schema (MySQL)
Users: Admin login

PizzaFlavors, PizzaSizes, PizzaPrices

DrinkItems, DrinkSizes, DrinkCategories, DrinkPrices

Salads, SaladSizes

Orders

OrderPizzas, OrderSalads, OrderDrinks

Key Columns in Orders
Column	Description
OID	Order ID
CustomerName	Name of customer
PhoneNo	Contact
GovtTaxPercentage	Tax applied
TotalAmount	Final bill
OrderStatus	Preparing / Ready / Delivered
DeliveredAt	DateTime of delivery
IsArchived	Flag if exported

🧪 Sample Admin Login
sql
Copy
Edit
INSERT INTO Users (Username, Password) VALUES ('admin', 'admin');
✅ How to Run
Import the full SQL file into MySQL

Set your connection string in App.config or DeliveredOrders.cs

Build and run the app from Visual Studio

Start from Login.cs

📤 Excel Export
Uses ClosedXML

Automatically saves to Desktop

Includes:

Title: PizzaHut - Delivered Orders Report

Filter Row

Total Orders/Sales displayed on UI

Automatically archives exported orders

🔒 Archive Logic
After export:

Orders with OrderStatus = Delivered are updated with IsArchived = 1

Archived orders don’t appear again in future exports

📅 Filtering by Date
Use DateTimePicker with checkbox enabled

Filters by DeliveredAt range

🔧 Dependencies
ClosedXML

MySql.Data (MySQL Connector)

.NET Framework (WinForms App)

🧼 Maintenance Tip
You can safely delete records from database manually or schedule cleanup on archived orders.

📌 Notes
Use Port 3307 if MySQL is installed with custom config.

App uses DeliveredOrders_{yyyy-MM-dd_HH-mm}.xlsx format.

Add company logo manually in Excel if needed.

💬 Questions?
Feel free to improve, add printing, receipts, or online order integration later.
Built with 💻 C# and ❤️ Pizza.

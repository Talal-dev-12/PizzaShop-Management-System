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
Its database:
-- Create fresh database
DROP DATABASE IF EXISTS pizza_order_db;
CREATE DATABASE pizza_order_db;
USE pizza_order_db;

-- Users table for admin login
CREATE TABLE Users (
    UserID INT AUTO_INCREMENT PRIMARY KEY,
    Username VARCHAR(50) UNIQUE NOT NULL,
    Password VARCHAR(100) NOT NULL
);

-- Pizza tables
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

-- Drink tables
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

-- Salad tables
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

-- Orders table with status tracking
CREATE TABLE Orders (
    OID INT AUTO_INCREMENT PRIMARY KEY,
    CustomerName VARCHAR(100) NOT NULL,
    PhoneNo VARCHAR(20) NOT NULL,
    OrderDate DATETIME DEFAULT CURRENT_TIMESTAMP,
    GovtTaxPercentage DECIMAL(5,2) NOT NULL,
    TotalAmount DECIMAL(10,2) NOT NULL,
    OrderStatus VARCHAR(20) DEFAULT 'Preparing',
    DeliveredAt DATETIME NULL,
    IsArchived BOOLEAN DEFAULT 0
);

-- Order items tables
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

-- Sample data insertion
INSERT INTO Users (Username, Password) VALUES ('admin', 'admin');

INSERT INTO PizzaSizes (SizeName, SizeMultiplier) VALUES 
('Small', 0.6), ('Regular', 1.0), ('Medium', 1.2), ('Large', 1.5), ('Jumbo', 2.0);

INSERT INTO DrinkSizes (VolumeDescription, VolumeML, SizeMultiplier, ContainerType) VALUES
('345 ml', 345, 1.0, 'Can'), ('500 ml', 500, 1.5, 'Bottle'), 
('1 Liter', 1000, 2.0, 'Bottle'), ('1.5 Liter', 1500, 2.5, 'Pitcher'), 
('2.25 Liter/Jumbo', 2250, 3.0, 'Pitcher');

INSERT INTO DrinkCategories (CategoryName) VALUES
('Cola'), ('Lemon-Lime'), ('Orange'), ('Energy Drink'), ('Local Soda');

INSERT INTO PizzaFlavors (FlavorName, Description, BasePrice) VALUES
('Margherita', 'Classic tomato and mozzarella', 749),
('Pepperoni', 'Tomato sauce, mozzarella, and pepperoni', 799),
('BBQ Chicken', 'BBQ sauce, chicken, and onions', 849),
('Hawaiian', 'Ham and pineapple', 829),
('Vegetarian', 'Mixed vegetables', 799);

INSERT INTO DrinkItems (CategoryID, DrinkName, BasePrice) VALUES
(1, 'Pepsi', 80), (1, 'Coca-Cola', 80), (2, 'Sprite', 80), (2, '7Up', 80),
(3, 'Fanta Orange', 80), (3, 'Mirinda Orange', 80), (4, 'Sting', 120),
(5, 'Pakola Ice Cream Soda', 90), (5, 'Pakola Lychee', 90), (5, 'Pakola Raspberry', 90);

INSERT INTO Salads (SaladName, Price) VALUES
('Greek Salad', 200), ('Caesar Salad', 250), ('Green Salad', 150);

INSERT INTO SaladSizes (SizeName, SizeMultiplier) VALUES 
('Small', 0.7), ('Medium', 1.0), ('Large', 1.3);

-- Calculate and insert prices
INSERT INTO PizzaPrices (PizzaID, SizeID, FinalPrice)
SELECT p.PizzaID, s.SizeID, ROUND(p.BasePrice * s.SizeMultiplier, 0)
FROM PizzaFlavors p CROSS JOIN PizzaSizes s;

INSERT INTO DrinkPrices (DrinkID, DrinkSizeID, FinalPrice)
SELECT d.DrinkID, ds.DrinkSizeID, 
    CASE 
        WHEN ds.VolumeML = 345 THEN d.BasePrice
        WHEN ds.VolumeML = 500 THEN 120
        WHEN ds.VolumeML = 1000 THEN 170
        WHEN ds.VolumeML = 1500 THEN 230
        WHEN ds.VolumeML = 2250 THEN 260
    END
FROM DrinkItems d CROSS JOIN DrinkSizes ds;

-- Verification queries
SELECT 'Database created successfully!' AS Message;
SELECT COUNT(*) AS PizzaFlavors FROM PizzaFlavors;
SELECT COUNT(*) AS DrinkItems FROM DrinkItems;

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

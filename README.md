# Product-Management-System-CSharp-SQL
A simple C# application connected with SQL Server to manage product data, including adding, viewing, updating, and deleting records.
# 🛒 Product Management System (C# + SQL Server)

## 📖 Project Overview
This is a **C# desktop application** connected with **SQL Server Database**.  
It allows users to **Add, View, Update, and Delete (CRUD)** product records through a user-friendly interface.

---

## ⚙️ Technologies Used
- **C# (.NET Framework / WinForms)**
- **SQL Server (Database)**
- **ADO.NET (Data Connectivity)**
- **Visual Studio**

---

## 💡 Features
- ➕ Add new products to the database  
- ✏️ Update existing product details  
- ❌ Delete products from the system  
- 🔍 View all stored products  
- 🧠 Uses parameterized queries to prevent SQL Injection  

---

## 🗄️ Database Setup
1. Open **SQL Server Management Studio (SSMS)**  
2. Create a new database named `POS` (or your project database name)  
3. Create a table named `Product` with the following columns:
   ```sql
   CREATE TABLE Product (
       Id INT PRIMARY KEY IDENTITY(1,1),
       Name NVARCHAR(100),
       Description NVARCHAR(255),
       PurchasePrice DECIMAL(10,2),
       SalePrice DECIMAL(10,2),
       Discount DECIMAL(5,2)
   );

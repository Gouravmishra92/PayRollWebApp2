# 💼 Payroll Management System

![.NET](https://img.shields.io/badge/.NET%208.0-blueviolet?style=for-the-badge)
![C#](https://img.shields.io/badge/C%23-Programming-green?style=for-the-badge)
![ASP.NET MVC](https://img.shields.io/badge/ASP.NET%20Core-MVC-blue?style=for-the-badge)
![Status](https://img.shields.io/badge/Project-Completed-success?style=for-the-badge)

---

## 📘 Project Overview

The **Payroll Management System** is a web-based application developed using **ASP.NET Core MVC**.  
It is designed to help organizations manage employee information, salary details, and payslip generation efficiently — **without using a database**.  
Instead, all records are stored locally in JSON files, making it lightweight, portable, and ideal for college submissions.

---

## 🚀 Features

- 👨‍💼 **Employee Management**
  - Add, edit, view, and delete employee records  
  - Store data locally using JSON files  

- 💰 **Payroll Management**
  - Generate salary records and payslips for employees  
  - Calculate net salary (Basic + Allowances − Deductions)  

- 🧾 **Payslip Generation**
  - Automatically generate printable payslips  
  - View salary breakdown (earnings and deductions)  

- 🖥️ **Attractive Dashboard**
  - Simple, responsive, and user-friendly interface  
  - Easy navigation between Employee and Payroll modules  

---

## 🧩 Technologies Used

| Category | Technologies |
|-----------|--------------|
| **Framework** | ASP.NET Core MVC 8.0 |
| **Language** | C# |
| **Storage** | JSON File System (No Database) |
| **Frontend** | HTML5, CSS3, Bootstrap Icons |
| **IDE / Tools** | Visual Studio 2022, .NET SDK 8.0 |

---

## ⚙️ Project Setup Guide

### ✅ Prerequisites
Before running the project, make sure you have:
- [.NET 8 SDK](https://dotnet.microsoft.com/en-us/download)
- [Visual Studio 2022](https://visualstudio.microsoft.com/) with ASP.NET and web development workload
- [Git](https://git-scm.com/) (optional for cloning)

---

### 🧭 Steps to Run the Project

1. **Clone the Repository**
   ```bash
   git clone https://github.com/YOUR_USERNAME/PayRollWebApp.git
   cd PayRollWebApp

2. **Open the Project**
    - Open the project in Visual Studio

3. **Run the Application**
    - In terminal run the code Dotnet run
    - The app will launch automatically in your default browser

---

### 📂 Data Storage

Instead of a database, this project stores all data in local JSON files: 
  ```bash
    /Data/employees.json
    /Data/salaryrecords.json
  ```

Each time an employee or payroll record is created or updated, it automatically updates the JSON file.

---

### 🧮 Payroll Calculation Logic

**Net Salary = Basic Salary + Allowances − Deductions**

This is automatically calculated and displayed on the payslip for each employee.

---

### 📊 Modules Overview

**👥 Employee Module**
  - Displays list of employees
  - Add/Edit/Delete employees
  - Shows department, designation, and salary details

**💵 Payroll Module**
  - Generate payslips for selected employees
  - View all payroll records
  - Print or download payslips

---

### 🧑‍💻 Author
  **Gourav Mishra(202303103510016)**
  - 🎓 Asha M. Tarsadia Institute of Computer Science and Technology
  - 📅 B.Tech, 5th Semester – DotNet Project

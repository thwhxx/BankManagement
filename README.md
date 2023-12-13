# BankManagement

## Overview
Welcome to the BankManagement project, a part of the Advanced Software Development course. This repository contains the setup and initial structure for the BankManagement System, a .NET-based application designed to streamline banking operations, including account management and transaction processing.

## Features
- **User Authentication**: Secure login functionality for bank management.
- **Account Management**: Interface to create and manage bank accounts.
- **Transaction Processing**: Facilitate banking transactions like deposits, withdrawals, and transfers.
- **Balance Inquiry**: Functionality to check account balances.

## Configure the Database
1. Ensure the SQL Server is running.
2. Update the connection string in the project files to point to your SQL Server instance and database.

Example of connection string:
```csharp
string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=<PathToYourDatabase>\BankDb.mdf;Integrated Security=True;Connect Timeout=30";

## Dependencies
- Visual Studio
- .NET Framework 
- SQL Server 


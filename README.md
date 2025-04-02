# DVLD System (Driving and Vehicle Licensing Department)

## Overview
The **DVLD System** is a fully developed application designed to manage driver licensing efficiently. Built using **C#, SQL Server, and ADO.NET**, the system follows a **3-tier architecture** for enhanced modularity, scalability, and maintainability.

## Key Features
✔ **License Processing** – Issue, renew, and manage driving licenses.  
✔ **Database-Driven System** – Powered by **SQL Server** for secure and efficient data handling.  
✔ **3-Tier Architecture** – Separation of **UI, Business Logic, and Data Access layers** for improved maintainability.  
✔ **ADO.NET Connectivity** – Ensures real-time data processing.  

## Technologies Used
- **Programming Language**: C# (.NET Framework)
- **Database**: Microsoft SQL Server
- **Data Access**: ADO.NET
- **Architecture**: 3-Tier (UI Layer, Business Logic Layer, Data Access Layer)

## Installation Guide
### Prerequisites
Before installing the DVLD System, ensure you have the following:
- Microsoft SQL Server (2016 or later)
- Visual Studio (2019 or later)
- .NET Framework (4.7.2 or later)
- SQL Server Management Studio (SSMS)

### Steps to Install
1. **Clone the Repository**
   ```sh
   git clone https://github.com/Yousef-Refat/DVLD_System.git
   cd dvld-system
   ```
2. **Set Up the Database**
   - Open **SQL Server Management Studio (SSMS)**.
   - Restore `DVLD_backup.bak`.
   - Configure the connection string in `appsettings.json` (depending on the project setup).

3. **Open and Build the Project**
   - Open the solution (`.sln` file) in **Visual Studio**.
   - Restore NuGet packages (if required).
   - Build the project to ensure all dependencies are installed.

4. **Run the Application**
   - Set the startup project to `DVLD.UI`.
   - Press **F5** or click **Run** in Visual Studio.

## Usage
- **Login**: Use an admin or officer account to log in.
- **License Management**: Issue, renew, and manage licenses from the dashboard.

## Folder Structure
```
DVLD-System/
│── Database/                # SQL scripts for database setup
│── DVLD.UI/                 # User Interface Layer (WPF/WinForms)
│── DVLD.BusinessLogic/      # Business logic layer
│── DVLD.DataAccess/         # Data access layer using ADO.NET
│── README.md                # Project documentation
```

## Contribution
Contributions are welcome! To contribute:
1. Fork the repository.
2. Create a feature branch (`git checkout -b feature-branch`).
3. Commit your changes (`git commit -m "Add new feature"`).
4. Push to the branch (`git push origin feature-branch`).
5. Open a Pull Request.

## License
This project is licensed under the **MIT License**.

---
Thank you for using the **DVLD System**!

# 🎓 Student Registration System

A Windows Forms desktop application built for **Almeda Maha Vidyalaya** to digitalize and streamline their student management process. This system provides an intuitive interface for administrators to register new students and view all student details securely.

![Main Screen]<img width="467" height="247" alt="Main Screen" src="https://github.com/user-attachments/assets/8f3ecd89-d625-4ee1-a217-2a078f91639e" /> *<!-- Replace with actual screenshot link -->*

## ✨ Features

-   **Student Registration**: Add new students with details like ID, First Name, Last Name, Address, Gender, Grade, and Telephone Number.
-   **View Records**: Display all registered students in a sortable and scrollable Data Grid View.
-   **Data Persistence**: All data is securely stored in a Microsoft SQL Server database.
-   **User-Friendly Interface**: Simple and intuitive navigation between forms (Home, Registration, Details).
-   **Validation & Feedback**: Includes input validation and user confirmation dialogs.

## 🛠️ Tech Stack

-   **Language**: C#
-   **Framework**: .NET Windows Forms (WinForms)
-   **Database**: SQL Server
-   **Data Access**: ADO.NET (SqlConnection, SqlCommand)

## 📸 Screenshots

| Main Form | Registration Form | Student Details |
| :---: | :---: | :---: |
| ![Main Form] <img width="467" height="247" alt="Main Screen" src="https://github.com/user-attachments/assets/8f3ecd89-d625-4ee1-a217-2a078f91639e" />
| ![Registration Form](Screenshots/Student%20Registation%20Screen.PNG) 
| ![Details Form](Screenshots/Student%20Details.PNG) |

## 🗄️ Database Schema

The application uses a single table named `MIT1469`.

| Column Name | Data Type | Description |
|-------------|-----------|-------------|
| st_id | VARCHAR/NVARCHAR | Student ID (Primary Key) |
| f_name | VARCHAR/NVARCHAR | First Name |
| l_name | VARCHAR/NVARCHAR | Last Name |
| address | VARCHAR/NVARCHAR | Address |
| gender | VARCHAR/NVARCHAR | Gender (Male/Female) |
| grade | VARCHAR/NVARCHAR | Grade Level |
| telephone_number | VARCHAR/NVARCHAR | Telephone Number |

## 🚀 Getting Started

### Prerequisites

-   Microsoft Visual Studio (2019 or later)
-   .NET Desktop Development workload in Visual Studio
-   SQL Server (Express or higher)

### Installation & Setup

1.  **Clone the repository**
    ```bash
    git clone https://github.com/your-username/student-registration-system.git
    ```

2.  **Open the Project**
    -   Open the `Student_Registation_System.sln` solution file in Visual Studio.

3.  **Database Setup**
    -   Create a database in SQL Server (e.g., `MIT1469`).
    -   Run the following SQL script to create the table:
    ```sql
    CREATE TABLE MIT1469 (
        st_id VARCHAR(10) PRIMARY KEY,
        f_name NVARCHAR(50),
        l_name NVARCHAR(50),
        address NVARCHAR(100),
        gender VARCHAR(10),
        grade VARCHAR(10),
        telephone_number VARCHAR(15)
    );
    ```

4.  **Update Connection String**
    -   In the `Student_Registation.cs` and `Student_Details.cs` files, find the `SqlConnection` initialization.
    -   Update the connection string to match your SQL Server instance:
    ```csharp
    SqlConnection con = new SqlConnection("Data Source=YOUR_SERVER_NAME;Initial Catalog=MIT1469;Integrated Security=True");
    ```

5.  **Build and Run**
    -   Build the solution in Visual Studio (Ctrl+Shift+B).
    -   Run the application (F5).

## 📁 Project Structure
Student_Registation_System/
├── mainForm.cs # Main navigation form
├── Student_Registation.cs # Student registration form
├── Student_Details.cs # Form to view all students
├── App.config # Application configuration file
├── Screenshots/ # Folder containing application screenshots
└── README.md # This file


## 🔧 Key Code Components

-   **Database Connection**: Managed using `SqlConnection` from `System.Data.SqlClient`.
-   **Data Insertion**: Uses parameterized `SqlCommand` to prevent SQL injection.
-   **Data Retrieval**: `DataGridView` is populated using a `SqlDataReader`.
-   **Navigation**: Form-to-form navigation using `Show()` and `Hide()` methods.

## 📄 License

This project is created for educational purposes.

---

**Developed for Almeda Maha Vidyalaya**

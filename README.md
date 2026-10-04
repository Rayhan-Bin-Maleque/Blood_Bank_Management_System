# Blood Bank Management System

A desktop-based **Blood Bank Management System** developed using **C# Windows Forms** and **Microsoft SQL Server**. The system is designed to manage blood donors, patients, blood stock, and blood transfer requests through a simple graphical user interface.

## 📌 Project Overview

The Blood Bank Management System helps manage the main activities of a blood bank in one application.

The system supports:

- Donor registration
- Patient registration
- Role-based login
- Donor management
- Patient management
- Blood stock management
- Blood availability checking
- Blood transfer/request management
- Donor donation status management
- Patient request status tracking

The application uses **Microsoft SQL Server** as the database and communicates with it using `Microsoft.Data.SqlClient`.

---

## 🎯 Objectives

The main objectives of this project are:

1. To create a computerized blood bank management system.
2. To store donor and patient information in a database.
3. To manage available and unavailable blood stock.
4. To allow patients to request blood.
5. To allow administrators/staff to manage donors and patients.
6. To manage blood transfer requests.
7. To provide a simple Windows-based interface for managing blood bank operations.

---

## ✨ Main Features

### 1. User Login

The application provides a login system where users can log in using:

- Login ID
- Password
- Role

The system validates the credentials against the `Login` table and opens the appropriate interface according to the selected role.

---

### 2. User Signup

New users can select their registration type from the signup page.

Available registration options include:

- Donor Registration
- Patient Registration

---

### 3. Donor Registration

Donors can register by providing information such as:

- Full Name
- Contact Number
- Address
- Gender
- Blood Group
- Password

After successful registration:

- A donor record is created.
- A login record is created.
- A Login ID is generated.
- A blood-stock record is initially created with a pending donation status.

---

### 4. Patient Registration / Blood Request

Patients can register by providing:

- Full Name
- Contact Number
- Address
- Gender
- Blood Group
- Password

After registration:

- A patient record is created.
- A login record is created.
- A Login ID is generated.
- A blood-transfer/request record is created with a `Pending` status.

---

### 5. Donor Management

The Donor Manager allows staff/admin users to manage donor records.

Available operations include:

- View donor records
- Add donor
- Update donor information
- Delete donor
- Select a donor from the data grid
- Manage donor donation status
- Add donated blood to blood stock

The system also updates the related blood-stock record when a donation becomes available.

---

### 6. Patient Management

The Patient Manager provides functionality for managing patient records.

Available operations include:

- View patient records
- Add patient
- Update patient information
- Delete patient
- Select patient records from the data grid
- Create blood transfer/request records

---

### 7. Blood Stock Management

The Blood Stock module is used to monitor blood stored in the blood bank.

The system can:

- Display blood-stock records
- Filter/check available blood
- Check blood availability by blood group
- View stock status
- Update blood status
- Remove stock records
- Track whether blood is available or unavailable

The system specifically checks for blood records with:

```text
Status = Available
```

---

### 8. Blood Transfer Management

The Blood Transfer module handles patient blood requests.

The system can:

- Display blood transfer requests
- Check available blood stock
- Match blood group requirements
- Approve a blood transfer
- Decline a blood request
- Update blood stock status
- Update patient request status

When a transfer is successfully completed, the related blood-stock and patient/request records are updated.

---

### 9. Donor Profile

Registered donors can view their profile information, including:

- Login ID
- Name
- Password
- Contact Number
- Address
- Blood Group
- Donation status

Donors can also update their donation status through the application.

---

### 10. Patient Profile

Registered patients can view their profile information and check the current status of their blood request.

The system can display statuses such as:

- Pending
- Received
- Other request-related statuses

---

## 🏗️ System Modules

| Module | Purpose |
|---|---|
| Login | User authentication and role selection |
| Signup | Select donor or patient registration |
| Donor Registration | Register new donors |
| Patient Registration | Register patients and create blood requests |
| Donor Manager | Add, update, delete and manage donors |
| Patient Manager | Add, update, delete and manage patients |
| Blood Stock | Manage blood inventory |
| Blood Transfer | Process patient blood requests |
| Donor View | Display donor profile and donation status |
| Patient View | Display patient profile and request status |

---

## 🗄️ Database

The application uses **Microsoft SQL Server / SQL Server Express**.

### Database Name

```text
C# project
```

### Main Database Tables

The source code works with the following tables:

```text
Login
Doner
Patient
BloodStock
BloodTransfer
```

### Login Table

Stores login information and user roles.

Example information:

- ID
- Password
- Role
- Fullname
- Address
- Contactnumber

### Doner Table

Stores donor information.

Example fields:

- DonerID
- FullName
- ContactNumber
- Address
- Gender
- BloodGroup
- Password
- Status

### Patient Table

Stores patient information.

Example fields:

- paitentID
- FullName
- ContactNumber
- Address
- Gender
- BloodGroup
- Password
- Status

> Note: `paitentID` and `Doner` follow the existing naming used in the project source code.

### BloodStock Table

Stores blood inventory information.

Example fields used by the application include:

- StockID
- DonerID
- BloodGroup
- Gender
- Status

### BloodTransfer Table

Stores patient blood-transfer/request information.

Example fields used by the application include:

- Transfer_ID
- patientID
- BloodGroup
- Gender
- Status

---

## 🔄 Basic System Workflow

```text
                    ┌───────────────┐
                    │     Login     │
                    └───────┬───────┘
                            │
              ┌─────────────┴─────────────┐
              │                           │
        ┌─────▼─────┐               ┌─────▼─────┐
        │   Donor   │               │  Patient  │
        └─────┬─────┘               └─────┬─────┘
              │                           │
       Registration                 Registration
              │                           │
              ▼                           ▼
        Donor Database              Patient Database
              │                           │
              ▼                           ▼
        Blood Donation              Blood Request
              │                           │
              ▼                           ▼
         Blood Stock  ◄──────────► Blood Transfer
              │
              ▼
       Available Blood
```

---

## 🛠️ Technologies Used

### Programming Language

- **C#**

### Framework

- **.NET 8**
- **Windows Forms**

### Database

- **Microsoft SQL Server**
- **SQL Server Express**

### Database Library

- `Microsoft.Data.SqlClient`

### IDE

- **Visual Studio**

---

## 📁 Project Structure

```text
c# project/
│
├── c# project/
│   ├── Form1.cs
│   ├── SignupForm.cs
│   ├── DonorRegForm.cs
│   ├── PatientReqForm.cs
│   ├── DonorManager.cs
│   ├── PatientManager.cs
│   ├── DonerView.cs
│   ├── PatientView.cs
│   ├── BloodStock.cs
│   ├── BloodTransfer3.cs
│   ├── Program.cs
│   ├── *.Designer.cs
│   ├── *.resx
│   └── c# project.csproj
│
└── c# project.sln
```

### Important Source Files

| File | Description |
|---|---|
| `Program.cs` | Application entry point |
| `Form1.cs` | Login form |
| `SignupForm.cs` | Signup selection |
| `DonorRegForm.cs` | Donor registration |
| `PatientReqForm.cs` | Patient registration/request |
| `DonorManager.cs` | Donor CRUD and management |
| `PatientManager.cs` | Patient CRUD and management |
| `BloodStock.cs` | Blood inventory management |
| `BloodTransfer3.cs` | Blood transfer/request processing |
| `DonerView.cs` | Donor profile |
| `PatientView.cs` | Patient profile |

---

## 💻 System Requirements

Before running the project, install:

- Windows 10 or later
- Visual Studio 2022 or later
- .NET 8 SDK
- SQL Server Express or SQL Server
- SQL Server Management Studio (SSMS) recommended

---

## ⚙️ Installation and Setup

### Step 1: Clone the Repository

```bash
git clone https://github.com/YOUR-USERNAME/blood-bank-management-system.git
```

Go to the project directory:

```bash
cd blood-bank-management-system
```

---

### Step 2: Open the Project

Open:

```text
c# project.sln
```

using Visual Studio.

---

### Step 3: Install the Required NuGet Package

The project uses:

```text
Microsoft.Data.SqlClient
```

The package is already referenced in the `.csproj` file:

```xml
<PackageReference Include="Microsoft.Data.SqlClient" Version="6.1.4" />
```

If necessary, restore NuGet packages from Visual Studio.

---

### Step 4: Configure SQL Server

The current source code uses a local SQL Server Express instance:

```text
localhost\SQLEXPRESS
```

and the database name:

```text
C# project
```

You need to create the database and the required tables before running the application.

The database should contain:

```text
Login
Doner
Patient
BloodStock
BloodTransfer
```

---

### Step 5: Update the Connection String

The project currently contains connection strings similar to:

```csharp
Data Source=localhost\SQLEXPRESS;
Initial Catalog="C# project";
Integrated Security=True;
TrustServerCertificate=True;
```

If your SQL Server instance or database name is different, update the connection strings in the source files.

For example:

```csharp
string connectionString =
    @"Data Source=localhost\SQLEXPRESS;
      Initial Catalog=C# project;
      Integrated Security=True;
      TrustServerCertificate=True;";
```

---

### Step 6: Build the Project

In Visual Studio:

```text
Build → Build Solution
```

or use:

```text
Ctrl + Shift + B
```

---

### Step 7: Run the Application

Press:

```text
F5
```

or:

```text
Ctrl + F5
```

The application should open with the login screen.

---

## 🔐 User Roles

The application uses role information in the `Login` table.

The source code supports role-based login and includes roles such as:

- Donor
- Patient

Administrative/staff functionality is provided through the management forms for donors, patients, blood stock, and blood transfers.

---

## 🧩 CRUD Operations

### Donor

| Operation | Supported |
|---|---|
| Create | ✅ |
| Read | ✅ |
| Update | ✅ |
| Delete | ✅ |

### Patient

| Operation | Supported |
|---|---|
| Create | ✅ |
| Read | ✅ |
| Update | ✅ |
| Delete | ✅ |

### Blood Stock

| Operation | Supported |
|---|---|
| Create/View | ✅ |
| Read | ✅ |
| Update Status | ✅ |
| Delete | ✅ |

### Blood Transfer

| Operation | Supported |
|---|---|
| Create Request | ✅ |
| View Requests | ✅ |
| Approve/Transfer | ✅ |
| Decline | ✅ |

---

## 📊 Blood Transfer Process

The general blood transfer process is:

1. Patient registers and selects a required blood group.
2. A blood-transfer request is created.
3. The request remains `Pending`.
4. Staff checks available blood stock.
5. The system searches for available blood matching the required blood group.
6. If blood is available, the transfer can be approved.
7. Blood stock status is updated.
8. The transfer request status is updated.
9. The patient's status is updated.

If matching blood is not available, the request can be declined.

---

## 🔗 Relationship Between Modules

```text
Donor
  │
  ├── Donor Registration
  │
  └── BloodStock
          │
          │ Available Blood
          ▼
     BloodTransfer
          │
          ▼
       Patient
```

The donor provides blood that enters the blood-stock system. Patient requests are processed through the blood-transfer module using available blood stock.

---

## ⚠️ Current Limitations

This project is a student/academic desktop application and has several areas that could be improved before production use.

### 1. SQL Query Security

Some queries currently use string concatenation, for example:

```csharp
"SELECT ... WHERE FullName = '" + Fullname + "'"
```

A production version should use **parameterized SQL queries** to reduce SQL injection risks.

### 2. Password Security

Passwords are currently handled directly by the application/database.

A production system should use secure password hashing such as:

- BCrypt
- PBKDF2
- Argon2

### 3. Connection String Management

Database connection strings are currently written directly in source files.

A better implementation would store configuration separately and avoid exposing sensitive database configuration in source control.

### 4. Database Script

The current project source does not include a complete SQL database creation script. A future version should include a file such as:

```text
database.sql
```

containing:

- Database creation
- Table creation
- Relationships
- Sample data
- Constraints

### 5. Input Validation

More comprehensive validation can be added for:

- Phone numbers
- Passwords
- Duplicate users
- Blood group selection
- Required fields

---

## 🚀 Future Improvements

Possible improvements include:

- Secure password hashing
- Parameterized SQL queries
- Centralized database connection management
- Complete database SQL script
- Admin authentication
- Better role and permission management
- Search and filtering
- Blood expiry-date tracking
- Blood donation history
- Blood compatibility checking
- Email/SMS notifications
- Dashboard with statistics
- Improved UI/UX
- Automatic low-stock alerts
- Audit logs
- Backup and restore functionality

---

## 📸 Screenshots

You can add screenshots of the application here after uploading them to the repository.

Example:

```markdown
## Login

![Login Screen](screenshots/login.png)

## Donor Management

![Donor Management](screenshots/donor-manager.png)

## Blood Stock

![Blood Stock](screenshots/blood-stock.png)

## Blood Transfer

![Blood Transfer](screenshots/blood-transfer.png)
```

Recommended screenshot folder:

```text
screenshots/
├── login.png
├── signup.png
├── donor-registration.png
├── patient-registration.png
├── donor-manager.png
├── patient-manager.png
├── blood-stock.png
└── blood-transfer.png
```

---

## 📌 Academic Project

This project was developed as a **C# / Windows Forms database management project** to demonstrate:

- Object-oriented programming
- Windows Forms development
- Event-driven programming
- Database connectivity
- SQL operations
- CRUD operations
- User authentication
- Data management
- Multi-module application development

---

## 👨‍💻 Author

**Rayhan Bin Maleque**

Bachelor's Student  
American International University-Bangladesh (AIUB)

---

## 📄 License

This project is intended primarily for academic and educational purposes.

You may modify and improve the project for learning purposes.

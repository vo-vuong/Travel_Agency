# TravelAgency

## Introduction

Web Asp.net MVC and EntityFramework. This project is a web about Travel.

## System Requirements

- .NET Framework(version x)
- Database(SQL Server)

To install the project, follow these steps.

### Step 1: Clone the Source Code

```bash
git clone https://github.com/vo-vuong/TravelAgency.git
```

### Step 2: Configure the Database

1. Open the `Web.config` file in folder TravelAgency and `App.config` file in folder Model.
2. Update the database connection string in the `"ConnectionStrings"` tag.

### Step 3: Run Migrate and Seed

1. Open Package Manager Console (Tools > NuGet Package Manager > Package Manager Console).
2. On Package Manager Console at Default project: select `Model`.
3. Run migrate and seed:

```bash
Update-Database
```

### Step 4: Launch the Application

1. Press F5 to run the application.

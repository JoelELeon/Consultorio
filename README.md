# Consultorio

Desktop system for managing a medical office. Built with **Visual Basic .NET (WinForms)** on **.NET Framework 4.7.2** and **SQL Server** as the database.

## Features

- **Patients:** register, search, update, and delete patients. Includes personal data, health insurance, medical plan, address (town/street/zip code), phone, and gender.
- **Doctors:** register, search, update, and delete doctors, including their specialty and working hours.
- **Appointments:** create appointments, reschedule them (change date), search, and list them. Relates patients with doctors and appointment types.
- **Vital signs:** record and view blood pressure, heart rate, weight, height, and temperature per patient and appointment.

## Technologies

- Visual Basic .NET (WinForms)
- .NET Framework 4.7.2
- SQL Server (ADO.NET / System.Data.SqlClient)
- Visual Studio 2017 or later

## Database

The application connects to a `Consultorio` database in SQL Server. The connection string is located in `Consultorio/App.config`:

```
Data Source=JOEL\JLEON;Initial Catalog=Consultorio;Integrated Security=True;TrustServerCertificate=True
```

### Main tables

- `Pacientes`
- `Doctor`
- `Citas`
- `signos_vitales`
- `Especialidades`
- `PlanesMedicos`
- `Pueblos`

> Adjust the connection string (`Data Source`) to your SQL Server name before running the application.

## Prerequisites

- Windows
- Visual Studio 2017 or later (with the ".NET desktop development" workload)
- SQL Server with the `Consultorio` database created and its tables defined

## How to run

1. Clone the repository:

   ```
   git clone https://github.com/JoelELeon/Consultorio.git
   ```

2. Open the `Consultorio.sln` solution in Visual Studio.

3. Create the `Consultorio` database in your SQL Server instance and verify/update the connection string in `Consultorio/App.config`.

4. Build and run (F5). The main window shows access to **Appointments**, **Patients**, and **Doctors**.
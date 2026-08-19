# Consultorio

Sistema de escritorio para la gestión de un consultorio médico. Desarrollado en **Visual Basic .NET (WinForms)** sobre **.NET Framework 4.7.2** con **SQL Server** como base de datos.

## Funcionalidades

- **Pacientes:** registrar, buscar, actualizar y eliminar pacientes. Incluye datos personales, seguro médico, plan médico, dirección (pueblo/calle/código postal), teléfono y género.
- **Doctores:** registrar, buscar, actualizar y eliminar doctores, con su especialidad y horario de entrada/salida.
- **Citas:** crear citas, reprogramarlas (cambiar fecha), buscarlas y listarlas. Relaciona pacientes con doctores y tipos de cita.
- **Signos vitales:** registrar y consultar presión arterial, frecuencia cardíaca, peso, altura y temperatura por paciente y cita.

## Tecnologías

- Visual Basic .NET (WinForms)
- .NET Framework 4.7.2
- SQL Server (ADO.NET / System.Data.SqlClient)
- Visual Studio 2017 o superior

## Base de datos

La aplicación se conecta a una base de datos `Consultorio` en SQL Server. La cadena de conexión se encuentra en `Consultorio/App.config`:

```
Data Source=JOEL\JLEON;Initial Catalog=Consultorio;Integrated Security=True;TrustServerCertificate=True
```

### Tablas principales

- `Pacientes`
- `Doctor`
- `Citas`
- `signos_vitales`
- `Especialidades`
- `PlanesMedicos`
- `Pueblos`

> Ajusta la cadena de conexión (`Data Source`) al nombre de tu servidor SQL antes de ejecutar la aplicación.

## Requisitos previos

- Windows
- Visual Studio 2017 o superior (con la carga de trabajo "Desarrollo de escritorio con .NET")
- SQL Server con la base de datos `Consultorio` creada y las tablas definidas

## Cómo ejecutar

1. Clona el repositorio:

   ```
   git clone https://github.com/JoelELeon/Consultorio.git
   ```

2. Abre la solución `Consultorio.sln` en Visual Studio.

3. Crea la base de datos `Consultorio` en tu instancia de SQL Server y verifica/actualiza la cadena de conexión en `Consultorio/App.config`.

4. Compila y ejecuta (F5). La ventana principal muestra los accesos a **Citas**, **Pacientes** y **Doctores**.
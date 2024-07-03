# CRUD - AVES


## Sobre mí

Me llamo Lautaro Muller y tengo 22 años, nací en Avellaneda, pero actualmente vivo en Lanús. Estoy cursando el segundo cuatrimestre de la Tecnicatura en Programación en la UTN y es mi primera vez trabajando con esta tecnología.


## Descripción del proyecto

Aplicación desarrollada en C# utilizando Windows Forms en conjunto con herencia de clases, serialización y deserialización, Task, Delegados, Eventos, Test unitarios, Intefaces, Generics y SQL Server.

La aplicación comienza con un formulario de login donde el usuario ingresa un correo y una contraseña, estos datos son validados con los del archivo ___data_usuarios.json___. Si el ingreso es correcto se le da acceso a un formulario CRUD donde va a poder ingresar, modificar y/o eliminar aves con sus respectivas características. Al cerrar el formulario las aves cargadas se guardan en un archivo XML y en una Base de Datos asociada al proyecto para una posterior recuperación.


****

#### Funcionalidades del menú:
- **Ordenar:** Permite ordena la lista de aves por nombre o edad, ascendente o descendente, e informa al usuario el criterio seleccionado.    
- **Guardar como:** Guarda la lista de aves en un archivo XML en una ubicación específica.     
- **Cargar:** Permite cargar datos desde un archivo XML o una base de datos.     
- **Historial de usuarios:** Muestra los usuarios que iniciaron sesión recientemente con la hora correspondiente.     

****

#### Permisos según el perfil del usuario:
- **Administrador:** Acceso completo (CRUD)     
- **Supervisor:** Acceso para Crear, Leer y Actualizar (CRU)     
- **Vendedor:** Solo lectura (R)     

****

## Diagrama de clases
![Diagrama de Clases](ClassDiagram1.png)



## Script de SQL Server
```sql
USE [master]
GO

/****** Object:  Database [ZoologicoDB]    Script Date: 3/7/2024 02:31:12 ******/
CREATE DATABASE [ZoologicoDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'ZoologicoDB', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\ZoologicoDB.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'ZoologicoDB_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\ZoologicoDB_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO

ALTER DATABASE [ZoologicoDB] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [ZoologicoDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO

ALTER DATABASE [ZoologicoDB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [ZoologicoDB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [ZoologicoDB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [ZoologicoDB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [ZoologicoDB] SET ARITHABORT OFF 
GO
ALTER DATABASE [ZoologicoDB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [ZoologicoDB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [ZoologicoDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [ZoologicoDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [ZoologicoDB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [ZoologicoDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [ZoologicoDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [ZoologicoDB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [ZoologicoDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [ZoologicoDB] SET  DISABLE_BROKER 
GO
ALTER DATABASE [ZoologicoDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [ZoologicoDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [ZoologicoDB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [ZoologicoDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [ZoologicoDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [ZoologicoDB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [ZoologicoDB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [ZoologicoDB] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [ZoologicoDB] SET  MULTI_USER 
GO
ALTER DATABASE [ZoologicoDB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [ZoologicoDB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [ZoologicoDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [ZoologicoDB] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [ZoologicoDB] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [ZoologicoDB] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [ZoologicoDB] SET QUERY_STORE = ON
GO
ALTER DATABASE [ZoologicoDB] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO

USE [ZoologicoDB]
GO

/****** Object:  Table [dbo].[Aves]    Script Date: 3/7/2024 02:31:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Aves](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[habitat] [varchar](50) NOT NULL,
	[edad] [nchar](10) NOT NULL,
	[peso] [nchar](10) NULL,
	[especie] [varchar](50) NULL,
	[velocidadVuelo] [nchar](10) NULL,
	[colorPlumas] [varchar](50) NULL,
	[envergadura] [nchar](10) NULL,
	[rangoCaza] [varchar](50) NULL
) ON [PRIMARY]
GO

SET IDENTITY_INSERT [dbo].[Aves] ON 
GO
INSERT [dbo].[Aves] ([id], [nombre], [habitat], [edad], [peso], [especie], [velocidadVuelo], [colorPlumas], [envergadura], [rangoCaza]) VALUES (59, N'Tomas', N'2', N'4         ', NULL, NULL, NULL, NULL, N'3         ', N'Amplio')
GO
INSERT [dbo].[Aves] ([id], [nombre], [habitat], [edad], [peso], [especie], [velocidadVuelo], [colorPlumas], [envergadura], [rangoCaza]) VALUES (56, N'Martin', N'4', N'1         ', NULL, NULL, N'30        ', N'Verde', NULL, NULL)
GO
INSERT [dbo].[Aves] ([id], [nombre], [habitat], [edad], [peso], [especie], [velocidadVuelo], [colorPlumas], [envergadura], [rangoCaza]) VALUES (57, N'Jose', N'2', N'4         ', NULL, NULL, NULL, NULL, N'2         ', N'Amplio')
GO
INSERT [dbo].[Aves] ([id], [nombre], [habitat], [edad], [peso], [especie], [velocidadVuelo], [colorPlumas], [envergadura], [rangoCaza]) VALUES (58, N'Fito', N'3', N'3         ', N'4         ', N'Magallanes', NULL, NULL, NULL, NULL)
GO
SET IDENTITY_INSERT [dbo].[Aves] OFF
GO

USE [master]
GO
ALTER DATABASE [ZoologicoDB] SET  READ_WRITE 
GO
```

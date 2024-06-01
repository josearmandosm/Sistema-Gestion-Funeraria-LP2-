# Sistema de Gestión de Funeraria

El **Sistema de Gestión de Funeraria** es una aplicación web desarrollada con .NET que ofrece funcionalidades para la reserva de salas de velatorios de forma online. La aplicación permite a los usuarios reservar salas de velatorio de diferentes categorías y obtener servicios personalizados, junto con la digitalización de la famosa hoja de firmas de velatorios usada en República Dominicana.

## Participantes 👩‍🎓👨‍🎓

<a href="https://github.com/josearmandosm/Sistema-Gestion-Funeraria-LP2-/graphs/contributors">
  <img src="https://contrib.rocks/image?repo=josearmandosm/Sistema-Gestion-Funeraria-LP2-" />
</a>

## Configuración del Entorno

### Requisitos

- C# (versión 12).
- .NET (versión 8.0).
- SQL Server (versión 2019).

### Instalación

1. Crear un directorio para el proyecto:

```sh
mkdir Proyecto
cd Proyecto
```

2. Clonar el repositorio:

```sh
git clone https://github.com/josearmandosm/Sistema-Gestion-Funeraria-LP2-.git
```

3. Navegar al directorio del proyecto:

```sh
cd 'Sistema Gestion Funeraria (LP2)'
```

4. Restaurar los paquetes NuGet si es necesario:

```sh
dotnet restore
```

5. Ejecutar el proyecto:

```sh
dotnet watch run
```

## Pendientes del Proyecto

### BackEnd

- [x] Análisis de requirimiento para la construcción de la Base de Datos.

- [ ] Creación de los Controladores de los Modelos.

### Encargados de los controladores (Nombre - Tabla)

- [ ] Jeyson - Libro de firma.
- [ ] Melany - Aributo Categoria.
- [ ] Jose Armando - Categoria.
- [ ] Angel - defunciones.
- [ ] Juan - Factura_atributo.
- [ ] Omar - Empleados.
- [ ] Carlos - Sala.
- [ ] Julian - Atributo.
- [ ] Enmanuel - Cargo.

- [ ] Implementación de los DTO de cada Modelo.

### FrontEnd

- [ ] Implementación de formularios de reserva
- [ ] Visualización de disponibilidad de salas

## Stack Tecnológico

- **C#**: Un lenguaje de programación moderno y de propósito general.
- **.NET**: Una plataforma de desarrollo gratuita y de código abierto para la creación de diferentes tipos de aplicaciones.
- **SQL Server**: Un sistema de gestión de bases de datos relacional desarrollado por Microsoft.

[![C#](https://img.shields.io/badge/C%23-12-blue)](https://dotnet.microsoft.com/en-us/languages/csharp)
[![.NET](https://img.shields.io/badge/.NET-8.0-blueviolet)](https://dotnet.microsoft.com/en-us/download/dotnet/8.0)
[![SQL Server](https://img.shields.io/badge/SQL_Server-2019-orange)](https://www.microsoft.com/en-us/sql-server/sql-server-downloads)

# Sesión 11 - Reto: Agenda de contactos con SQLite

Aplicación Windows Forms en C# con Entity Framework Core y SQLite.

## Requisitos
- Visual Studio con .NET 10 SDK
- Conexión a Internet la primera vez para restaurar NuGet

## Ejecutar
1. Abrir `Sesion11_Reto_Agenda.sln`.
2. Establecer `Reto` como proyecto de inicio.
3. Compilar y ejecutar.
4. La base `agenda.db` se crea automáticamente en la carpeta de ejecución.

## Funciones
- Grilla ordenada por nombre y contador de contactos.
- Búsqueda en vivo por nombre.
- Agregar con validación: nombre obligatorio y correo con `@`.
- Eliminar con confirmación.
- Persistencia SQLite al cerrar y abrir.
- Nivel extra: doble clic para editar y guardar cambios.

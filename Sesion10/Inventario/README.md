# Sesión 08 - Inventario por capas

Solución C# con .NET 10 organizada en cuatro proyectos:

- `Inventario.Modelos`: Producto y excepciones.
- `Inventario.Datos`: interfaz de repositorio y persistencia JSON.
- `Inventario.Servicios`: reglas del negocio.
- `Inventario.Consola`: menú de usuario.

Incluye registro, búsqueda por nombre/código, consulta de inventario, stock bajo (menos de 5), agregar stock, ventas, eliminación con confirmación, validaciones y persistencia JSON.

Abrir `Inventario/Inventario.slnx`. Si Visual Studio no selecciona el inicio automáticamente, establecer `Inventario.Consola` como proyecto de inicio.

El archivo `inventario.json` se crea junto al ejecutable en `bin/Debug/net10.0`; la ruta aparece al iniciar.

Antes de subir a GitHub, no incluir `bin`, `obj` ni `.vs`.

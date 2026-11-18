using Inventario.Datos;
using Inventario.Modelos;

namespace Inventario.Servicios;

public class ServicioInventario
{
    private readonly IRepositorioProductos _repositorio;
    public ServicioInventario(IRepositorioProductos repositorio) => _repositorio = repositorio;

    public List<Producto> Listar() => _repositorio.ObtenerTodos().OrderBy(p => p.Nombre).ToList();

    public void Agregar(Producto producto)
    {
        if (_repositorio.BuscarPorCodigo(producto.Codigo) is not null)
            throw new ArgumentException($"Ya existe un producto con el código {producto.Codigo}.");
        _repositorio.Agregar(producto);
    }

    public void AgregarStock(string codigo, int cantidad)
    {
        Producto producto = _repositorio.BuscarPorCodigo(codigo)
            ?? throw new ArgumentException($"No existe el producto {codigo}.");
        producto.AgregarStock(cantidad);
        _repositorio.Actualizar(producto);
    }

    public void Vender(string codigo, int cantidad)
    {
        Producto producto = _repositorio.BuscarPorCodigo(codigo)
            ?? throw new ArgumentException($"No existe el producto {codigo}.");
        producto.Vender(cantidad);
        _repositorio.Actualizar(producto);
    }

    public List<Producto> StockBajo() => _repositorio.ObtenerTodos()
        .Where(p => p.Stock < 5).OrderBy(p => p.Stock).ThenBy(p => p.Nombre).ToList();

    public List<Producto> BuscarPorTexto(string texto)
    {
        texto = texto.Trim();
        if (string.IsNullOrWhiteSpace(texto)) return Listar();
        return _repositorio.ObtenerTodos()
            .Where(p => p.Nombre.Contains(texto, StringComparison.OrdinalIgnoreCase)
                     || p.Codigo.Contains(texto, StringComparison.OrdinalIgnoreCase))
            .OrderBy(p => p.Nombre).ToList();
    }


    public void Actualizar(Producto producto)
    {
        if (_repositorio.BuscarPorCodigo(producto.Codigo) is null)
            throw new ArgumentException($"No existe el producto {producto.Codigo}.");
        _repositorio.Actualizar(producto);
    }

    public void Eliminar(string codigo)
    {
        if (_repositorio.BuscarPorCodigo(codigo) is null)
            throw new ArgumentException($"No existe el producto {codigo}.");
        _repositorio.Eliminar(codigo);
    }
}

using Inventario.Datos;
using Inventario.Modelos;
using Inventario.Servicios;

namespace Inventario.Escritorio;

public partial class FormPrincipal : Form
{
    private readonly ServicioInventario _servicio = new(new RepositorioEf());

    public FormPrincipal()
    {
        InitializeComponent();
        ConfigurarTabla();
        CargarCategorias();
        CargarProductos();
        ActualizarEstado();
    }

    private void ConfigurarTabla()
    {
        dgvProductos.AutoGenerateColumns = false;
    }

    private void CargarProductos(List<Producto>? productos = null)
    {
        dgvProductos.DataSource = null;
        dgvProductos.DataSource = productos ?? _servicio.Listar();
        lblValor.Text = $"Valor total del inventario: {_servicio.Listar().Sum(p => p.Precio * p.Stock):C0}";
        ActualizarEstado();
    }

    private Producto? Seleccionado() =>
        dgvProductos.CurrentRow?.DataBoundItem as Producto;

    private void CargarCategorias()
    {
        var opciones = new List<Categoria>
        {
            new Categoria { Id = 0, Nombre = "Todas" }
        };
        opciones.AddRange(_servicio.Categorias());
        cmbFiltroCategoria.DataSource = opciones;
        cmbFiltroCategoria.DisplayMember = "Nombre";
        cmbFiltroCategoria.ValueMember = "Id";
        cmbFiltroCategoria.SelectedValue = 0;
    }

    private void AplicarFiltros()
    {
        var productos = _servicio.BuscarPorTexto(txtBuscar.Text);
        if (cmbFiltroCategoria.SelectedValue is int categoriaId && categoriaId != 0)
            productos = productos.Where(p => p.CategoriaId == categoriaId).ToList();
        CargarProductos(productos);
    }

    private void txtBuscar_TextChanged(object? sender, EventArgs e) => AplicarFiltros();

    private void cmbFiltroCategoria_SelectedIndexChanged(object? sender, EventArgs e)
    {
        if (IsHandleCreated && cmbFiltroCategoria.SelectedValue is int)
            AplicarFiltros();
    }

    private void btnResumenCategoria_Click(object? sender, EventArgs e)
    {
        var resumen = _servicio.ResumenPorCategoria();
        if (resumen.Count == 0)
        {
            MessageBox.Show("Todavía no hay productos registrados.", "Resumen por categoría",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }

        string texto = string.Join(Environment.NewLine, resumen.Select(r =>
            $"{r.Categoria}: {r.CantidadProductos} producto(s) | {r.ValorInventario:C0}"));
        MessageBox.Show(texto, "Resumen por categoría",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    private void dgvProductos_DataBindingComplete(object? sender, DataGridViewBindingCompleteEventArgs e)
    {
        if (dgvProductos.Columns["CategoriaId"] is DataGridViewColumn id)
            id.Visible = false;

        foreach (DataGridViewRow fila in dgvProductos.Rows)
        {
            fila.DefaultCellStyle.BackColor = SystemColors.Window;
            if (fila.DataBoundItem is Producto p && p.Stock < 5)
                fila.DefaultCellStyle.BackColor = Color.MistyRose;
        }
    }

    private void btnAgregar_Click(object? sender, EventArgs e)
    {
        using var form = new FormProducto(_servicio.Categorias());
        if (form.ShowDialog(this) != DialogResult.OK || form.ProductoCreado is null) return;
        try
        {
            _servicio.Agregar(form.ProductoCreado);
            CargarProductos();
            MessageBox.Show("Producto registrado correctamente.", "Inventario",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        catch (ArgumentException ex)
        {
            MessageBox.Show(ex.Message, "No se pudo agregar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }

    private void btnEliminar_Click(object? sender, EventArgs e)
    {
        if (Seleccionado() is not Producto producto)
        {
            MessageBox.Show("Selecciona un producto de la tabla.", "Inventario",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }

        var respuesta = MessageBox.Show($"¿Deseas eliminar el producto {producto.Nombre}?",
            "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        if (respuesta == DialogResult.Yes)
        {
            _servicio.Eliminar(producto.Codigo);
            CargarProductos();
        }
    }

    private void btnVender_Click(object? sender, EventArgs e)
    {
        if (Seleccionado() is not Producto producto)
        {
            MessageBox.Show("Selecciona un producto de la tabla.");
            return;
        }
        try
        {
            _servicio.Vender(producto.Codigo, (int)nudCantidad.Value);
            CargarProductos();
        }
        catch (StockInsuficienteException ex)
        {
            MessageBox.Show(ex.Message, "Stock insuficiente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        catch (ArgumentException ex)
        {
            MessageBox.Show(ex.Message, "No se pudo vender", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }

    private void btnAgregarStock_Click(object? sender, EventArgs e)
    {
        if (Seleccionado() is not Producto producto)
        {
            MessageBox.Show("Selecciona un producto de la tabla.");
            return;
        }

        using var dialogo = new FormCantidad("Agregar stock", "Cantidad que deseas agregar:");
        if (dialogo.ShowDialog(this) != DialogResult.OK) return;
        try
        {
            _servicio.AgregarStock(producto.Codigo, dialogo.Cantidad);
            CargarProductos();
        }
        catch (ArgumentException ex)
        {
            MessageBox.Show(ex.Message, "No se pudo agregar stock", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }

    private void dgvProductos_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0 || dgvProductos.Rows[e.RowIndex].DataBoundItem is not Producto producto) return;
        using var form = new FormProducto(_servicio.Categorias(), producto);
        if (form.ShowDialog(this) != DialogResult.OK || form.ProductoCreado is null) return;
        try
        {
            _servicio.Actualizar(form.ProductoCreado);
            CargarProductos();
        }
        catch (ArgumentException ex)
        {
            MessageBox.Show(ex.Message, "No se pudo actualizar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }

    private void btnReportes_Click(object? sender, EventArgs e)
    {
        using var form = new FormReportes(
            _servicio.Listar().OrderByDescending(p => p.Precio * p.Stock).ToList(),
            _servicio.StockBajo());
        form.ShowDialog(this);
    }

    private void btnActualizar_Click(object? sender, EventArgs e)
    {
        txtBuscar.Clear();
        CargarProductos();
    }

    private void ActualizarEstado()
    {
        int cantidad = _servicio.Listar().Count;
        lblEstado.Text = $"Productos: {cantidad}   |   {DateTime.Now:dd/MM/yyyy HH:mm:ss}";
    }

    private void timerEstado_Tick(object? sender, EventArgs e) => ActualizarEstado();

    private void salirToolStripMenuItem_Click(object? sender, EventArgs e) => Close();

    private void acercaDeToolStripMenuItem_Click(object? sender, EventArgs e)
    {
        MessageBox.Show("Sistema de inventario de escritorio\nSesión 10 - C# Windows Forms",
            "Acerca de", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }
}

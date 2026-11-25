using Inventario.Modelos;

namespace Inventario.Escritorio;

public partial class FormProducto : Form
{
    public Producto? ProductoCreado { get; private set; }
    private readonly bool _modoEdicion;
    private readonly int _stockActual;

    public FormProducto(List<Categoria> categorias, Producto? producto = null)
    {
        InitializeComponent();

        cmbCategoria.DataSource = categorias;
        cmbCategoria.DisplayMember = "Nombre";
        cmbCategoria.ValueMember = "Id";

        if (producto is null)
        {
            _modoEdicion = false;
            return;
        }

        _modoEdicion = true;
        _stockActual = producto.Stock;
        txtCodigo.Text = producto.Codigo;
        txtCodigo.Enabled = false;
        txtNombre.Text = producto.Nombre;
        nudPrecio.Value = Math.Min(nudPrecio.Maximum, producto.Precio);
        nudStock.Value = Math.Min(nudStock.Maximum, producto.Stock);
        if (producto.CategoriaId.HasValue)
            cmbCategoria.SelectedValue = producto.CategoriaId.Value;

        Text = "Editar producto";
        lblTitulo.Text = "EDITAR PRODUCTO";
        lblStock.Visible = false;
        nudStock.Visible = false;
    }

    private void btnGuardar_Click(object? sender, EventArgs e)
    {
        errorProvider1.Clear();

        if (cmbCategoria.SelectedValue is not int categoriaId)
        {
            errorProvider1.SetError(cmbCategoria, "Selecciona una categoría.");
            return;
        }

        try
        {
            ProductoCreado = new Producto(
                txtCodigo.Text,
                txtNombre.Text,
                nudPrecio.Value,
                _modoEdicion ? _stockActual : (int)nudStock.Value);

            ProductoCreado.CambiarCategoria(categoriaId);
            DialogResult = DialogResult.OK;
        }
        catch (ArgumentException ex)
        {
            errorProvider1.SetError(btnGuardar, ex.Message);
            MessageBox.Show(ex.Message, "Datos no válidos",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }

    private void btnCancelar_Click(object? sender, EventArgs e) =>
        DialogResult = DialogResult.Cancel;
}

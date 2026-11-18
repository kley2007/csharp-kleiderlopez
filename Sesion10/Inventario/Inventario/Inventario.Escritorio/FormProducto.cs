using Inventario.Modelos;

namespace Inventario.Escritorio;

public partial class FormProducto : Form
{
    public Producto? ProductoCreado { get; private set; }
    private readonly bool _modoEdicion;
    private int _stockActual;

    public FormProducto()
    {
        InitializeComponent();
        _modoEdicion = false;
    }

    public FormProducto(Producto producto) : this()
    {
        _modoEdicion = true;
        _stockActual = producto.Stock;
        txtCodigo.Text = producto.Codigo;
        txtCodigo.Enabled = false;
        txtNombre.Text = producto.Nombre;
        nudPrecio.Value = Math.Min(nudPrecio.Maximum, producto.Precio);
        nudStock.Value = Math.Min(nudStock.Maximum, producto.Stock);
        Text = "Editar producto";
        lblTitulo.Text = "EDITAR PRODUCTO";
        lblStock.Visible = false;
        nudStock.Visible = false;
    }

    private void btnGuardar_Click(object? sender, EventArgs e)
    {
        errorProvider1.Clear();
        try
        {
            ProductoCreado = new Producto(txtCodigo.Text, txtNombre.Text, nudPrecio.Value,
                _modoEdicion ? _stockActual : (int)nudStock.Value);
            DialogResult = DialogResult.OK;
        }
        catch (ArgumentException ex)
        {
            errorProvider1.SetError(btnGuardar, ex.Message);
            MessageBox.Show(ex.Message, "Datos no válidos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }

    private void btnCancelar_Click(object? sender, EventArgs e) => DialogResult = DialogResult.Cancel;
}

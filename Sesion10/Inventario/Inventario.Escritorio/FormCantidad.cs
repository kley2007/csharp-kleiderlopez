namespace Inventario.Escritorio;

public partial class FormCantidad : Form
{
    public int Cantidad => (int)nudCantidad.Value;
    public FormCantidad(string titulo, string etiqueta)
    {
        InitializeComponent();
        Text = titulo;
        lblCantidad.Text = etiqueta;
    }
    private void btnAceptar_Click(object? sender, EventArgs e) => DialogResult = DialogResult.OK;
    private void btnCancelar_Click(object? sender, EventArgs e) => DialogResult = DialogResult.Cancel;
}

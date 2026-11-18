using Inventario.Modelos;

namespace Inventario.Escritorio;

public partial class FormReportes : Form
{
    public FormReportes(List<Producto> valiosos, List<Producto> stockBajo)
    {
        InitializeComponent();
        dgvValiosos.DataSource = valiosos;
        dgvStockBajo.DataSource = stockBajo;
        Formatear(dgvValiosos);
        Formatear(dgvStockBajo);
    }

    private static void Formatear(DataGridView tabla)
    {
        if (tabla.Columns["Precio"] is DataGridViewColumn precio) precio.DefaultCellStyle.Format = "C0";
    }

    private void btnCerrar_Click(object? sender, EventArgs e) => Close();
}

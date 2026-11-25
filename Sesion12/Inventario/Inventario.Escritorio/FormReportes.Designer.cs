namespace Inventario.Escritorio;

partial class FormReportes
{
    private System.ComponentModel.IContainer components = null;
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null)) components.Dispose();
        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        lblTitulo = new Label();
        lblValiosos = new Label();
        lblStockBajo = new Label();
        dgvValiosos = new DataGridView();
        dgvStockBajo = new DataGridView();
        btnCerrar = new Button();
        ((System.ComponentModel.ISupportInitialize)dgvValiosos).BeginInit();
        ((System.ComponentModel.ISupportInitialize)dgvStockBajo).BeginInit();
        SuspendLayout();
        lblTitulo.AutoSize = true; lblTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Bold); lblTitulo.Location = new Point(24, 18); lblTitulo.Text = "REPORTES DEL INVENTARIO";
        lblValiosos.AutoSize = true; lblValiosos.Font = new Font("Segoe UI", 11F, FontStyle.Bold); lblValiosos.Location = new Point(28, 72); lblValiosos.Text = "Productos más valiosos (precio × stock)";
        dgvValiosos.Location = new Point(28, 102); dgvValiosos.Size = new Size(850, 190); dgvValiosos.ReadOnly = true; dgvValiosos.AllowUserToAddRows = false; dgvValiosos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; dgvValiosos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        lblStockBajo.AutoSize = true; lblStockBajo.Font = new Font("Segoe UI", 11F, FontStyle.Bold); lblStockBajo.Location = new Point(28, 312); lblStockBajo.Text = "Productos con stock bajo (menos de 5 unidades)";
        dgvStockBajo.Location = new Point(28, 342); dgvStockBajo.Size = new Size(850, 190); dgvStockBajo.ReadOnly = true; dgvStockBajo.AllowUserToAddRows = false; dgvStockBajo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; dgvStockBajo.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        btnCerrar.Location = new Point(753, 550); btnCerrar.Size = new Size(125, 38); btnCerrar.Text = "Cerrar"; btnCerrar.Click += btnCerrar_Click;
        AutoScaleDimensions = new SizeF(7F, 15F); AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(910, 610); Controls.AddRange(new Control[] { lblTitulo, lblValiosos, dgvValiosos, lblStockBajo, dgvStockBajo, btnCerrar });
        Name = "FormReportes"; StartPosition = FormStartPosition.CenterParent; Text = "Reportes";
        ((System.ComponentModel.ISupportInitialize)dgvValiosos).EndInit(); ((System.ComponentModel.ISupportInitialize)dgvStockBajo).EndInit(); ResumeLayout(false); PerformLayout();
    }

    private Label lblTitulo, lblValiosos, lblStockBajo;
    private DataGridView dgvValiosos, dgvStockBajo;
    private Button btnCerrar;
}

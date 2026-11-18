namespace Inventario.Escritorio;

partial class FormProducto
{
    private System.ComponentModel.IContainer components = null;
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null)) components.Dispose();
        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        components = new System.ComponentModel.Container();
        lblTitulo = new Label();
        lblCodigo = new Label(); txtCodigo = new TextBox();
        lblNombre = new Label(); txtNombre = new TextBox();
        lblPrecio = new Label(); nudPrecio = new NumericUpDown();
        lblStock = new Label(); nudStock = new NumericUpDown();
        btnGuardar = new Button(); btnCancelar = new Button();
        errorProvider1 = new ErrorProvider(components);
        ((System.ComponentModel.ISupportInitialize)nudPrecio).BeginInit();
        ((System.ComponentModel.ISupportInitialize)nudStock).BeginInit();
        ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
        SuspendLayout();
        lblTitulo.AutoSize = true; lblTitulo.Font = new Font("Segoe UI", 17F, FontStyle.Bold); lblTitulo.Location = new Point(28, 20); lblTitulo.Text = "REGISTRAR PRODUCTO";
        lblCodigo.AutoSize = true; lblCodigo.Location = new Point(32, 82); lblCodigo.Text = "Código:";
        txtCodigo.Location = new Point(180, 78); txtCodigo.Size = new Size(270, 27); txtCodigo.Name = "txtCodigo";
        lblNombre.AutoSize = true; lblNombre.Location = new Point(32, 130); lblNombre.Text = "Nombre del producto:";
        txtNombre.Location = new Point(180, 126); txtNombre.Size = new Size(270, 27); txtNombre.Name = "txtNombre";
        lblPrecio.AutoSize = true; lblPrecio.Location = new Point(32, 178); lblPrecio.Text = "Precio:";
        nudPrecio.Location = new Point(180, 174); nudPrecio.Maximum = 100000000; nudPrecio.ThousandsSeparator = true; nudPrecio.DecimalPlaces = 2; nudPrecio.Size = new Size(270, 27); nudPrecio.Name = "nudPrecio";
        lblStock.AutoSize = true; lblStock.Location = new Point(32, 226); lblStock.Text = "Cantidad inicial:";
        nudStock.Location = new Point(180, 222); nudStock.Maximum = 1000000; nudStock.Size = new Size(270, 27); nudStock.Name = "nudStock";
        btnGuardar.Location = new Point(180, 285); btnGuardar.Size = new Size(125, 40); btnGuardar.Text = "Guardar"; btnGuardar.DialogResult = DialogResult.None; btnGuardar.Click += btnGuardar_Click;
        btnCancelar.Location = new Point(325, 285); btnCancelar.Size = new Size(125, 40); btnCancelar.Text = "Cancelar"; btnCancelar.DialogResult = DialogResult.Cancel; btnCancelar.Click += btnCancelar_Click;
        errorProvider1.ContainerControl = this;
        AcceptButton = btnGuardar; CancelButton = btnCancelar;
        AutoScaleDimensions = new SizeF(7F, 15F); AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(490, 365); Controls.AddRange(new Control[] { lblTitulo, lblCodigo, txtCodigo, lblNombre, txtNombre, lblPrecio, nudPrecio, lblStock, nudStock, btnGuardar, btnCancelar });
        FormBorderStyle = FormBorderStyle.FixedDialog; MaximizeBox = false; MinimizeBox = false;
        Name = "FormProducto"; StartPosition = FormStartPosition.CenterParent; Text = "Producto";
        ((System.ComponentModel.ISupportInitialize)nudPrecio).EndInit(); ((System.ComponentModel.ISupportInitialize)nudStock).EndInit(); ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
        ResumeLayout(false); PerformLayout();
    }

    private Label lblTitulo, lblCodigo, lblNombre, lblPrecio, lblStock;
    private TextBox txtCodigo, txtNombre;
    private NumericUpDown nudPrecio, nudStock;
    private Button btnGuardar, btnCancelar;
    private ErrorProvider errorProvider1;
}

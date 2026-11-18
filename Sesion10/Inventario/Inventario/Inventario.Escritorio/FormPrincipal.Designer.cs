namespace Inventario.Escritorio;

partial class FormPrincipal
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
        menuStrip1 = new MenuStrip();
        archivoToolStripMenuItem = new ToolStripMenuItem();
        salirToolStripMenuItem = new ToolStripMenuItem();
        ayudaToolStripMenuItem = new ToolStripMenuItem();
        acercaDeToolStripMenuItem = new ToolStripMenuItem();
        lblTitulo = new Label();
        lblBuscar = new Label();
        txtBuscar = new TextBox();
        dgvProductos = new DataGridView();
        colCodigo = new DataGridViewTextBoxColumn();
        colNombre = new DataGridViewTextBoxColumn();
        colPrecio = new DataGridViewTextBoxColumn();
        colStock = new DataGridViewTextBoxColumn();
        panelAcciones = new Panel();
        btnAgregar = new Button();
        btnAgregarStock = new Button();
        btnVender = new Button();
        btnEliminar = new Button();
        btnActualizar = new Button();
        btnReportes = new Button();
        lblCantidad = new Label();
        nudCantidad = new NumericUpDown();
        lblValor = new Label();
        statusStrip1 = new StatusStrip();
        lblEstado = new ToolStripStatusLabel();
        timerEstado = new System.Windows.Forms.Timer(components);
        menuStrip1.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
        panelAcciones.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)nudCantidad).BeginInit();
        statusStrip1.SuspendLayout();
        SuspendLayout();
        // menu
        menuStrip1.Items.AddRange(new ToolStripItem[] { archivoToolStripMenuItem, ayudaToolStripMenuItem });
        menuStrip1.Location = new Point(0, 0);
        menuStrip1.Name = "menuStrip1";
        menuStrip1.Size = new Size(1120, 24);
        archivoToolStripMenuItem.Text = "Archivo";
        archivoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { salirToolStripMenuItem });
        salirToolStripMenuItem.Text = "Salir";
        salirToolStripMenuItem.Click += salirToolStripMenuItem_Click;
        ayudaToolStripMenuItem.Text = "Ayuda";
        ayudaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { acercaDeToolStripMenuItem });
        acercaDeToolStripMenuItem.Text = "Acerca de";
        acercaDeToolStripMenuItem.Click += acercaDeToolStripMenuItem_Click;
        // title and search
        lblTitulo.AutoSize = true;
        lblTitulo.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
        lblTitulo.Location = new Point(28, 42);
        lblTitulo.Text = "SISTEMA DE INVENTARIO";
        lblBuscar.AutoSize = true;
        lblBuscar.Location = new Point(32, 100);
        lblBuscar.Text = "Buscar por código o nombre:";
        txtBuscar.Location = new Point(245, 96);
        txtBuscar.Name = "txtBuscar";
        txtBuscar.Size = new Size(430, 27);
        txtBuscar.PlaceholderText = "Escribe para filtrar productos...";
        txtBuscar.TextChanged += txtBuscar_TextChanged;
        // grid
        dgvProductos.AllowUserToAddRows = false;
        dgvProductos.AllowUserToDeleteRows = false;
        dgvProductos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        dgvProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dgvProductos.BackgroundColor = Color.White;
        dgvProductos.Location = new Point(32, 145);
        dgvProductos.MultiSelect = false;
        dgvProductos.Name = "dgvProductos";
        dgvProductos.ReadOnly = true;
        dgvProductos.RowHeadersWidth = 45;
        dgvProductos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dgvProductos.Size = new Size(1055, 390);
        dgvProductos.DataBindingComplete += dgvProductos_DataBindingComplete;
        dgvProductos.CellDoubleClick += dgvProductos_CellDoubleClick;
        // columns
        colCodigo.DataPropertyName = "Codigo"; colCodigo.HeaderText = "Código"; colCodigo.Name = "colCodigo"; colCodigo.ReadOnly = true;
        colNombre.DataPropertyName = "Nombre"; colNombre.HeaderText = "Producto"; colNombre.Name = "colNombre"; colNombre.ReadOnly = true;
        colPrecio.DataPropertyName = "Precio"; colPrecio.HeaderText = "Precio"; colPrecio.Name = "colPrecio"; colPrecio.ReadOnly = true;
        colStock.DataPropertyName = "Stock"; colStock.HeaderText = "Stock"; colStock.Name = "colStock"; colStock.ReadOnly = true;
        colPrecio.DefaultCellStyle.Format = "C0";
        // actions
        panelAcciones.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        panelAcciones.Location = new Point(32, 548);
        panelAcciones.Size = new Size(1055, 82);
        panelAcciones.Controls.AddRange(new Control[] { btnAgregar, btnAgregarStock, btnVender, btnEliminar, btnActualizar, btnReportes, lblCantidad, nudCantidad });
        btnAgregar.Location = new Point(0, 8); btnAgregar.Size = new Size(150, 38); btnAgregar.Text = "Agregar producto"; btnAgregar.Click += btnAgregar_Click;
        btnAgregarStock.Location = new Point(160, 8); btnAgregarStock.Size = new Size(145, 38); btnAgregarStock.Text = "Agregar stock"; btnAgregarStock.Click += btnAgregarStock_Click;
        btnVender.Location = new Point(315, 8); btnVender.Size = new Size(105, 38); btnVender.Text = "Vender"; btnVender.Click += btnVender_Click;
        btnEliminar.Location = new Point(430, 8); btnEliminar.Size = new Size(105, 38); btnEliminar.Text = "Eliminar"; btnEliminar.Click += btnEliminar_Click;
        btnActualizar.Location = new Point(545, 8); btnActualizar.Size = new Size(110, 38); btnActualizar.Text = "Actualizar"; btnActualizar.Click += btnActualizar_Click;
        btnReportes.Location = new Point(665, 8); btnReportes.Size = new Size(110, 38); btnReportes.Text = "Reportes"; btnReportes.Click += btnReportes_Click;
        lblCantidad.AutoSize = true; lblCantidad.Location = new Point(795, 18); lblCantidad.Text = "Cantidad a vender:";
        nudCantidad.Location = new Point(920, 14); nudCantidad.Minimum = 1; nudCantidad.Maximum = 100000; nudCantidad.Value = 1; nudCantidad.Size = new Size(100, 27);
        lblValor.AutoSize = true;
        lblValor.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
        lblValor.Location = new Point(32, 638);
        lblValor.Size = new Size(500, 25);
        lblValor.Text = "Valor total del inventario: $0";
        statusStrip1.Items.AddRange(new ToolStripItem[] { lblEstado });
        statusStrip1.Location = new Point(0, 675);
        statusStrip1.Size = new Size(1120, 22);
        lblEstado.Text = "Productos: 0";
        timerEstado.Interval = 1000;
        timerEstado.Tick += timerEstado_Tick;
        timerEstado.Start();
        // form
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1120, 697);
        Controls.Add(lblValor);
        Controls.Add(panelAcciones);
        Controls.Add(dgvProductos);
        Controls.Add(txtBuscar);
        Controls.Add(lblBuscar);
        Controls.Add(lblTitulo);
        Controls.Add(statusStrip1);
        Controls.Add(menuStrip1);
        MainMenuStrip = menuStrip1;
        MinimumSize = new Size(950, 650);
        Name = "FormPrincipal";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Inventario - Administración";
        menuStrip1.ResumeLayout(false); menuStrip1.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
        panelAcciones.ResumeLayout(false); panelAcciones.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)nudCantidad).EndInit();
        statusStrip1.ResumeLayout(false); statusStrip1.PerformLayout();
        ResumeLayout(false); PerformLayout();
    }

    private MenuStrip menuStrip1;
    private ToolStripMenuItem archivoToolStripMenuItem, salirToolStripMenuItem, ayudaToolStripMenuItem, acercaDeToolStripMenuItem;
    private Label lblTitulo, lblBuscar, lblValor, lblCantidad;
    private TextBox txtBuscar;
    private DataGridView dgvProductos;
    private DataGridViewTextBoxColumn colCodigo, colNombre, colPrecio, colStock;
    private Panel panelAcciones;
    private Button btnAgregar, btnAgregarStock, btnVender, btnEliminar, btnActualizar, btnReportes;
    private NumericUpDown nudCantidad;
    private StatusStrip statusStrip1;
    private ToolStripStatusLabel lblEstado;
    private System.Windows.Forms.Timer timerEstado;
}

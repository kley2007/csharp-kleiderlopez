namespace Reto;

partial class Form1
{
    private System.ComponentModel.IContainer? components = null;
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null)) components.Dispose();
        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        components = new System.ComponentModel.Container();
        lblTitulo = new Label();
        lblBuscar = new Label();
        txtBuscar = new TextBox();
        dgvContactos = new DataGridView();
        lblTotal = new Label();
        lblModo = new Label();
        lblNombre = new Label();
        txtNombre = new TextBox();
        lblTelefono = new Label();
        txtTelefono = new TextBox();
        lblCorreo = new Label();
        txtCorreo = new TextBox();
        btnAgregar = new Button();
        btnGuardarCambios = new Button();
        btnCancelarEdicion = new Button();
        btnEliminar = new Button();
        btnLimpiar = new Button();
        errorProvider1 = new ErrorProvider(components);
        ((System.ComponentModel.ISupportInitialize)dgvContactos).BeginInit();
        ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
        SuspendLayout();
        // 
        // lblTitulo
        // 
        lblTitulo.AutoSize = true;
        lblTitulo.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
        lblTitulo.Location = new Point(28, 20);
        lblTitulo.Text = "AGENDA DE CONTACTOS";
        // 
        // lblBuscar
        // 
        lblBuscar.AutoSize = true;
        lblBuscar.Location = new Point(32, 91);
        lblBuscar.Text = "Buscar por nombre:";
        // 
        // txtBuscar
        // 
        txtBuscar.Location = new Point(190, 87);
        txtBuscar.Size = new Size(430, 27);
        txtBuscar.TextChanged += txtBuscar_TextChanged;
        // 
        // dgvContactos
        // 
        dgvContactos.AllowUserToAddRows = false;
        dgvContactos.AllowUserToDeleteRows = false;
        dgvContactos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dgvContactos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgvContactos.Location = new Point(32, 135);
        dgvContactos.MultiSelect = false;
        dgvContactos.ReadOnly = true;
        dgvContactos.RowHeadersWidth = 51;
        dgvContactos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dgvContactos.Size = new Size(920, 300);
        dgvContactos.CellDoubleClick += dgvContactos_CellDoubleClick;
        // 
        // lblTotal
        // 
        lblTotal.AutoSize = true;
        lblTotal.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        lblTotal.Location = new Point(32, 445);
        lblTotal.Text = "0 contactos";
        // 
        // lblModo
        // 
        lblModo.AutoSize = true;
        lblModo.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
        lblModo.Location = new Point(32, 485);
        lblModo.Text = "Nuevo contacto";
        // 
        // labels + inputs
        // 
        lblNombre.AutoSize = true; lblNombre.Location = new Point(32, 520); lblNombre.Text = "Nombre:";
        txtNombre.Location = new Point(112, 516); txtNombre.Size = new Size(220, 27);
        lblTelefono.AutoSize = true; lblTelefono.Location = new Point(355, 520); lblTelefono.Text = "Teléfono:";
        txtTelefono.Location = new Point(430, 516); txtTelefono.Size = new Size(190, 27);
        lblCorreo.AutoSize = true; lblCorreo.Location = new Point(645, 520); lblCorreo.Text = "Correo:";
        txtCorreo.Location = new Point(710, 516); txtCorreo.Size = new Size(242, 27);
        // 
        // buttons
        // 
        btnAgregar.Location = new Point(32, 570); btnAgregar.Size = new Size(155, 42);
        btnAgregar.Text = "Agregar"; btnAgregar.Click += btnAgregar_Click;
        btnGuardarCambios.Location = new Point(202, 570); btnGuardarCambios.Size = new Size(165, 42);
        btnGuardarCambios.Text = "Guardar cambios"; btnGuardarCambios.Enabled = false;
        btnGuardarCambios.Click += btnGuardarCambios_Click;
        btnCancelarEdicion.Location = new Point(382, 570); btnCancelarEdicion.Size = new Size(150, 42);
        btnCancelarEdicion.Text = "Cancelar edición"; btnCancelarEdicion.Enabled = false;
        btnCancelarEdicion.Click += btnCancelarEdicion_Click;
        btnEliminar.Location = new Point(547, 570); btnEliminar.Size = new Size(130, 42);
        btnEliminar.Text = "Eliminar"; btnEliminar.Click += btnEliminar_Click;
        btnLimpiar.Location = new Point(692, 570); btnLimpiar.Size = new Size(130, 42);
        btnLimpiar.Text = "Limpiar"; btnLimpiar.Click += btnLimpiar_Click;
        // 
        // errorProvider1
        // 
        errorProvider1.ContainerControl = this;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(990, 650);
        Controls.Add(btnLimpiar);
        Controls.Add(btnEliminar);
        Controls.Add(btnCancelarEdicion);
        Controls.Add(btnGuardarCambios);
        Controls.Add(btnAgregar);
        Controls.Add(txtCorreo);
        Controls.Add(lblCorreo);
        Controls.Add(txtTelefono);
        Controls.Add(lblTelefono);
        Controls.Add(txtNombre);
        Controls.Add(lblNombre);
        Controls.Add(lblModo);
        Controls.Add(lblTotal);
        Controls.Add(dgvContactos);
        Controls.Add(txtBuscar);
        Controls.Add(lblBuscar);
        Controls.Add(lblTitulo);
        MinimumSize = new Size(1006, 689);
        Name = "Form1";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Agenda de contactos";
        ((System.ComponentModel.ISupportInitialize)dgvContactos).EndInit();
        ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    private Label lblTitulo, lblBuscar, lblTotal, lblModo, lblNombre, lblTelefono, lblCorreo;
    private TextBox txtBuscar, txtNombre, txtTelefono, txtCorreo;
    private DataGridView dgvContactos;
    private Button btnAgregar, btnGuardarCambios, btnCancelarEdicion, btnEliminar, btnLimpiar;
    private ErrorProvider errorProvider1;
}

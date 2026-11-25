namespace Inventario.Escritorio;

partial class FormCantidad
{
    private System.ComponentModel.IContainer components = null;
    protected override void Dispose(bool disposing) { if (disposing && (components != null)) components.Dispose(); base.Dispose(disposing); }
    private void InitializeComponent()
    {
        lblCantidad = new Label(); nudCantidad = new NumericUpDown(); btnAceptar = new Button(); btnCancelar = new Button();
        ((System.ComponentModel.ISupportInitialize)nudCantidad).BeginInit(); SuspendLayout();
        lblCantidad.AutoSize = true; lblCantidad.Location = new Point(24, 25); lblCantidad.Text = "Cantidad:";
        nudCantidad.Location = new Point(28, 58); nudCantidad.Minimum = 1; nudCantidad.Maximum = 1000000; nudCantidad.Value = 1; nudCantidad.Size = new Size(270, 27);
        btnAceptar.Location = new Point(28, 110); btnAceptar.Size = new Size(120, 38); btnAceptar.Text = "Aceptar"; btnAceptar.Click += btnAceptar_Click;
        btnCancelar.Location = new Point(178, 110); btnCancelar.Size = new Size(120, 38); btnCancelar.Text = "Cancelar"; btnCancelar.DialogResult = DialogResult.Cancel; btnCancelar.Click += btnCancelar_Click;
        AcceptButton = btnAceptar; CancelButton = btnCancelar; AutoScaleDimensions = new SizeF(7F, 15F); AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(330, 175); Controls.AddRange(new Control[] { lblCantidad, nudCantidad, btnAceptar, btnCancelar });
        FormBorderStyle = FormBorderStyle.FixedDialog; MaximizeBox = false; MinimizeBox = false; StartPosition = FormStartPosition.CenterParent; Text = "Cantidad";
        ((System.ComponentModel.ISupportInitialize)nudCantidad).EndInit(); ResumeLayout(false); PerformLayout();
    }
    private Label lblCantidad; private NumericUpDown nudCantidad; private Button btnAceptar, btnCancelar;
}

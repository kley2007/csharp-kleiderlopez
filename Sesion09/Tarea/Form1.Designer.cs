namespace Tarea
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            lblTitulo = new Label();
            lblValor = new Label();
            txtValor = new TextBox();
            lblOrigen = new Label();
            cmbOrigen = new ComboBox();
            lblDestino = new Label();
            cmbDestino = new ComboBox();
            btnConverir = new Button();
            lblResultado = new Label();
            lblRespuesta = new Label();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Location = new Point(307, 11);
            lblTitulo.Margin = new Padding(4, 0, 4, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(281, 30);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Conversor de temperatura";
            // 
            // lblValor
            // 
            lblValor.AutoSize = true;
            lblValor.Location = new Point(142, 72);
            lblValor.Margin = new Padding(4, 0, 4, 0);
            lblValor.Name = "lblValor";
            lblValor.Size = new Size(76, 30);
            lblValor.TabIndex = 1;
            lblValor.Text = "Valor:";
            // 
            // txtValor
            // 
            txtValor.Location = new Point(282, 72);
            txtValor.Margin = new Padding(4);
            txtValor.Name = "txtValor";
            txtValor.Size = new Size(194, 37);
            txtValor.TabIndex = 2;
            // 
            // lblOrigen
            // 
            lblOrigen.AutoSize = true;
            lblOrigen.Location = new Point(42, 155);
            lblOrigen.Margin = new Padding(4, 0, 4, 0);
            lblOrigen.Name = "lblOrigen";
            lblOrigen.Size = new Size(196, 30);
            lblOrigen.TabIndex = 3;
            lblOrigen.Text = "Unidad de origen:";
            // 
            // cmbOrigen
            // 
            cmbOrigen.FormattingEnabled = true;
            cmbOrigen.Location = new Point(282, 145);
            cmbOrigen.Margin = new Padding(4);
            cmbOrigen.Name = "cmbOrigen";
            cmbOrigen.Size = new Size(235, 38);
            cmbOrigen.TabIndex = 4;
            // 
            // lblDestino
            // 
            lblDestino.AutoSize = true;
            lblDestino.Location = new Point(42, 227);
            lblDestino.Margin = new Padding(4, 0, 4, 0);
            lblDestino.Name = "lblDestino";
            lblDestino.Size = new Size(205, 30);
            lblDestino.TabIndex = 5;
            lblDestino.Text = "Unidad de destino:";
            // 
            // cmbDestino
            // 
            cmbDestino.FormattingEnabled = true;
            cmbDestino.Location = new Point(282, 217);
            cmbDestino.Margin = new Padding(4);
            cmbDestino.Name = "cmbDestino";
            cmbDestino.Size = new Size(235, 38);
            cmbDestino.TabIndex = 6;
            // 
            // btnConverir
            // 
            btnConverir.Location = new Point(309, 304);
            btnConverir.Margin = new Padding(4);
            btnConverir.Name = "btnConverir";
            btnConverir.Size = new Size(146, 41);
            btnConverir.TabIndex = 7;
            btnConverir.Text = "Convertir";
            btnConverir.UseVisualStyleBackColor = true;
            btnConverir.UseWaitCursor = true;
            btnConverir.Click += btnConvertir_Click;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(130, 383);
            lblResultado.Margin = new Padding(4, 0, 4, 0);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(121, 30);
            lblResultado.TabIndex = 8;
            lblResultado.Text = "Resultado:";
            // 
            // lblRespuesta
            // 
            lblRespuesta.AutoSize = true;
            lblRespuesta.Location = new Point(339, 383);
            lblRespuesta.Margin = new Padding(4, 0, 4, 0);
            lblRespuesta.Name = "lblRespuesta";
            lblRespuesta.Size = new Size(116, 30);
            lblRespuesta.TabIndex = 9;
            lblRespuesta.Text = "Respuesta";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(881, 473);
            Controls.Add(lblRespuesta);
            Controls.Add(lblResultado);
            Controls.Add(btnConverir);
            Controls.Add(cmbDestino);
            Controls.Add(lblDestino);
            Controls.Add(cmbOrigen);
            Controls.Add(lblOrigen);
            Controls.Add(txtValor);
            Controls.Add(lblValor);
            Controls.Add(lblTitulo);
            Font = new Font("Segoe UI", 11F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Conversor de temperatura";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Label lblValor;
        private TextBox txtValor;
        private Label lblOrigen;
        private ComboBox cmbOrigen;
        private Label lblDestino;
        private ComboBox cmbDestino;
        private Button btnConverir;
        private Label lblResultado;
        private Label lblRespuesta;
        private ErrorProvider errorProvider1;
    }
}

namespace Reto
{
    partial class FormPin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblTitulo = new Label();
            btnIngresar = new Button();
            txtPIN = new TextBox();
            lblIntentos = new Label();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Location = new Point(338, 89);
            lblTitulo.Margin = new Padding(4, 0, 4, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(167, 30);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Ingrese su PIN:";
            // 
            // btnIngresar
            // 
            btnIngresar.Location = new Point(338, 212);
            btnIngresar.Margin = new Padding(4);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(146, 41);
            btnIngresar.TabIndex = 1;
            btnIngresar.Text = "Ingresar";
            btnIngresar.UseVisualStyleBackColor = true;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // txtPIN
            // 
            txtPIN.Location = new Point(317, 148);
            txtPIN.Margin = new Padding(4);
            txtPIN.Name = "txtPIN";
            txtPIN.PasswordChar = '*';
            txtPIN.Size = new Size(194, 37);
            txtPIN.TabIndex = 2;
            // 
            // lblIntentos
            // 
            lblIntentos.AutoSize = true;
            lblIntentos.Location = new Point(274, 277);
            lblIntentos.Margin = new Padding(4, 0, 4, 0);
            lblIntentos.Name = "lblIntentos";
            lblIntentos.Size = new Size(248, 30);
            lblIntentos.TabIndex = 3;
            lblIntentos.Text = "Intentos Disponibles: 3";
            // 
            // FormPin
            // 
            AutoScaleDimensions = new SizeF(13F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1040, 540);
            Controls.Add(lblIntentos);
            Controls.Add(txtPIN);
            Controls.Add(btnIngresar);
            Controls.Add(lblTitulo);
            Font = new Font("Segoe UI", 11F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "FormPin";
            Text = "FormPin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Button btnIngresar;
        private TextBox txtPIN;
        private Label lblIntentos;
    }
}
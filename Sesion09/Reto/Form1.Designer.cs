namespace Reto
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
            lblTitular = new Label();
            lblSaldo = new Label();
            lblMonto = new Label();
            nudMonto = new NumericUpDown();
            btnRetirar = new Button();
            btnDepositar = new Button();
            lstMovimientos = new ListBox();
            ((System.ComponentModel.ISupportInitialize)nudMonto).BeginInit();
            SuspendLayout();
            // 
            // lblTitular
            // 
            lblTitular.AutoSize = true;
            lblTitular.Location = new Point(416, 28);
            lblTitular.Margin = new Padding(4, 0, 4, 0);
            lblTitular.Name = "lblTitular";
            lblTitular.Size = new Size(89, 30);
            lblTitular.TabIndex = 0;
            lblTitular.Text = "Titular:";
            // 
            // lblSaldo
            // 
            lblSaldo.AutoSize = true;
            lblSaldo.Location = new Point(372, 104);
            lblSaldo.Margin = new Padding(4, 0, 4, 0);
            lblSaldo.Name = "lblSaldo";
            lblSaldo.Size = new Size(180, 30);
            lblSaldo.TabIndex = 1;
            lblSaldo.Text = "Saldo: $500.000";
            // 
            // lblMonto
            // 
            lblMonto.AutoSize = true;
            lblMonto.Location = new Point(203, 181);
            lblMonto.Margin = new Padding(4, 0, 4, 0);
            lblMonto.Name = "lblMonto";
            lblMonto.Size = new Size(79, 30);
            lblMonto.TabIndex = 2;
            lblMonto.Text = "Monto";
            // 
            // nudMonto
            // 
            nudMonto.Increment = new decimal(new int[] { 10000, 0, 0, 0 });
            nudMonto.Location = new Point(333, 179);
            nudMonto.Margin = new Padding(6);
            nudMonto.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            nudMonto.Minimum = new decimal(new int[] { 10000, 0, 0, 0 });
            nudMonto.Name = "nudMonto";
            nudMonto.Size = new Size(395, 37);
            nudMonto.TabIndex = 3;
            nudMonto.ThousandsSeparator = true;
            nudMonto.Value = new decimal(new int[] { 10000, 0, 0, 0 });
            // 
            // btnRetirar
            // 
            btnRetirar.Location = new Point(527, 248);
            btnRetirar.Margin = new Padding(4);
            btnRetirar.Name = "btnRetirar";
            btnRetirar.Size = new Size(146, 41);
            btnRetirar.TabIndex = 4;
            btnRetirar.Text = "Retirar";
            btnRetirar.UseVisualStyleBackColor = true;
            btnRetirar.Click += btnRetirar_Click_1;
            // 
            // btnDepositar
            // 
            btnDepositar.Location = new Point(333, 248);
            btnDepositar.Margin = new Padding(4);
            btnDepositar.Name = "btnDepositar";
            btnDepositar.Size = new Size(146, 41);
            btnDepositar.TabIndex = 5;
            btnDepositar.Text = "Depositar";
            btnDepositar.UseVisualStyleBackColor = true;
            btnDepositar.Click += btnDepositar_Click_1;
            // 
            // lstMovimientos
            // 
            lstMovimientos.FormattingEnabled = true;
            lstMovimientos.Location = new Point(333, 342);
            lstMovimientos.Margin = new Padding(4);
            lstMovimientos.Name = "lstMovimientos";
            lstMovimientos.Size = new Size(350, 154);
            lstMovimientos.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1040, 540);
            Controls.Add(lstMovimientos);
            Controls.Add(btnDepositar);
            Controls.Add(btnRetirar);
            Controls.Add(nudMonto);
            Controls.Add(lblMonto);
            Controls.Add(lblSaldo);
            Controls.Add(lblTitular);
            Font = new Font("Segoe UI", 11F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Cajero Automatico";
            ((System.ComponentModel.ISupportInitialize)nudMonto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitular;
        private Label lblSaldo;
        private Label lblMonto;
        private NumericUpDown nudMonto;
        private Button btnRetirar;
        private Button btnDepositar;
        private ListBox lstMovimientos;
    }
}

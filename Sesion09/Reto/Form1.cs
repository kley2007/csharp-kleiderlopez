using System;
using System.Windows.Forms;

namespace Reto
{
    public partial class Form1 : Form
    {
        private readonly CuentaBancaria _cuenta =
            new CuentaBancaria("Kleider Lopez", "001-123", 500000m);

        public Form1()
        {
            InitializeComponent();
            ActualizarSaldo();
        }

        private void ActualizarSaldo()
        {
            lblTitular.Text = _cuenta.Titular;
            lblSaldo.Text = $"Saldo: {_cuenta.Saldo:C0}";
        }

        private void btnDepositar_Click(object sender, EventArgs e)
        {
            try
            {
                decimal monto = nudMonto.Value;
                _cuenta.Depositar(monto);

                ActualizarSaldo();

                lstMovimientos.Items.Insert(0,
                    $"{DateTime.Now:HH:mm:ss} - Depósito: {monto:C0}");

                MessageBox.Show("Depósito realizado correctamente.",
                    "Operación exitosa",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Error en el depósito",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRetirar_Click(object sender, EventArgs e)
        {
            try
            {
                decimal monto = nudMonto.Value;
                _cuenta.Retirar(monto);

                ActualizarSaldo();

                lstMovimientos.Items.Insert(0,
                    $"{DateTime.Now:HH:mm:ss} - Retiro: {monto:C0}");

                MessageBox.Show("Retiro realizado correctamente.",
                    "Operación exitosa",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Error en el retiro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message, "Saldo insuficiente",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnDepositar_Click_1(object sender, EventArgs e)
        {
            btnDepositar_Click(sender, e);
        }

        private void btnRetirar_Click_1(object sender, EventArgs e)
        {
            btnRetirar_Click(sender, e);
        }

    }
}

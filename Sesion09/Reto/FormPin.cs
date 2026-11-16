using System;
using System.Windows.Forms;

namespace Reto
{
    public partial class FormPin : Form
    {
        private int intentos = 3;
        private const string PIN_CORRECTO = "1234";

        public FormPin()
        {
            InitializeComponent();
            lblIntentos.Text = "Intentos disponibles: 3";
            AcceptButton = btnIngresar;
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (txtPIN.Text == PIN_CORRECTO)
            {
                MessageBox.Show("PIN correcto. Bienvenido.",
                    "Acceso permitido",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                intentos--;

                if (intentos > 0)
                {
                    lblIntentos.Text = $"Intentos disponibles: {intentos}";

                    MessageBox.Show("PIN incorrecto. Inténtalo nuevamente.",
                        "Acceso denegado",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    txtPIN.Clear();
                    txtPIN.Focus();
                }
                else
                {
                    MessageBox.Show("Has agotado los 3 intentos. El cajero se cerrará.",
                        "Acceso bloqueado",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    DialogResult = DialogResult.Cancel;
                    Close();
                }
            }
        }
    }
}

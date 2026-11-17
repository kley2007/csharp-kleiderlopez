namespace Tarea
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();

            cmbOrigen.Items.AddRange(new object[] { "°C", "°F", "K" });
            cmbDestino.Items.AddRange(new object[] { "°C", "°F", "K" });

            cmbOrigen.SelectedIndex = 0;
            cmbDestino.SelectedIndex = 1;

            lblRespuesta.Text = "";
        }


        private void btnConvertir_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();

            if (!double.TryParse(txtValor.Text, out double valor))
            {
                errorProvider1.SetError(txtValor, "Escribe un número válido.");
                return;
            }

            if (cmbOrigen.SelectedItem == null)
            {
                errorProvider1.SetError(cmbOrigen, "Selecciona la unidad de origen.");
                return;
            }

            if (cmbDestino.SelectedItem == null)
            {
                errorProvider1.SetError(cmbDestino, "Selecciona la unidad de destino.");
                return;
            }

            string origen = cmbOrigen.SelectedItem.ToString()!;
            string destino = cmbDestino.SelectedItem.ToString()!;

            double resultado = ConversorTemperatura.Convertir(valor, origen, destino);

            lblRespuesta.Text = $"{resultado:N2} {destino}";
        }

    }
}

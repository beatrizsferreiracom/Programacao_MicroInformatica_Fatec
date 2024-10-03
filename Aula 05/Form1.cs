using System;
using System.Windows.Forms;

namespace CalculoImc
{
    public partial class CalculoImc : Form
    {
        public CalculoImc()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNome.Text = "";
            txtAltura.Text = "";
            txtPeso.Text = "";
            cmbSexo.Text = "";
        }

        private void btnLimparListas_Click(object sender, EventArgs e)
        {
            lstM.Items.Clear();
            lstH.Items.Clear();
        }

        private void ListH_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listM_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                string nome, categoria;
                double altura, peso, imc;
                nome = txtNome.Text;
                altura = double.Parse(txtAltura.Text);
                peso = double.Parse(txtPeso.Text);
                imc = Math.Round(peso / (altura * altura), 2);

                if (imc < 18.5) categoria = "Abaixo do peso";

                else if (imc >= 18.5 && imc < 25) categoria = "Normal";

                else if (imc >= 25 && imc < 30) categoria = "Sobrepeso";

                else categoria = "Obesidade";

                if (cmbSexo.Text == "Masculino")
                {
                    lstH.Items.Add($"{nome} - IMC: {imc} - {categoria}");
                }
                else if (cmbSexo.Text == "Feminino")
                {
                    lstM.Items.Add($"{nome} - IMC: {imc} - {categoria}");
                }
                else
                {
                    MessageBox.Show("Escolha um sexo", "IMC", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Informe os valores numéricos", "IMC", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception erro)
            {
                MessageBox.Show($"Ocorreu um erro: {erro.Message}", "IMC", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }
    }
}

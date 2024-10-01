using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrjFarmacia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            string Nome = "";
            double compra = 0;
            if (!double.TryParse(txtValor.Text, out compra))
            {
                MessageBox.Show("Informe um valor válido", "Atenção",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            double descontoFaixa = 0;
            if (rbtn1.Checked)
            {
                descontoFaixa = 0;
            }
            else if (rbtn2.Checked)
            {
                descontoFaixa = 0.05;
            }
            else if (rbtn3.Checked)
            {
                descontoFaixa = 0.07;
            }
            else
            {
                MessageBox.Show("Escolha a faixa etária", "Atenção",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            double descontoCartao = 0;
            if (chkCartao.Checked)
            {
                descontoCartao = 0.05;
            }
            double valorDescontoIdade = compra * descontoFaixa;
            double valorDescontoCartao = compra * descontoCartao;
            double valorFinal = compra - valorDescontoIdade - valorDescontoCartao;

            lblResult.Text = "Compra: R$" + compra + "\nDesc. Faixa: R$" + Math.Round(valorDescontoIdade,2) +
                "\nDesc. Cartão: R$" + Math.Round(valorDescontoCartao,2) + "\nValor a Pagar: R$" + Math.Round(valorFinal,2);
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNome.Text = "";
            txtValor.Text = "";
            lblResult.Text = "";
            rbtn1.Checked = false;
            rbtn2.Checked = false;
            rbtn3.Checked = false;
            chkCartao.Checked = false;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void chk1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}

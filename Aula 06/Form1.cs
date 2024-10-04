using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tabuada
{
    public partial class Form1 : Form
    {
        int i, n;
        public Form1()
        {
            InitializeComponent();
        }

        private void lblNome_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AcceptButton = btnVisualizar;
            CancelButton = btnLimpar;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNum.Text = "";
            lstT.Items.Clear();
        }

        private void btnVisualizar_Click(object sender, EventArgs e)
        {
            try
            {
                n = int.Parse(txtNum.Text);
                for (i = 1; i <= 10; i++)
                {
                    lstT.Items.Add($"{n} x {i} = {n*i}");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Informe o valor", "Tabuada", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception erro)
            {
                MessageBox.Show($"Ocorreu um erro: {erro.Message}", "Tabuada", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

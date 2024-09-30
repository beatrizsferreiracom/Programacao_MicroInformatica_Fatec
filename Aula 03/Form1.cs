using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaAritmetica
{
    public partial class Form1 : Form
    {
        string Nome;
        double N1, N2, N3, N4, M;

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnMedia_Click(object sender, EventArgs e)
        {
            if (txtN1.Text == "" || txtN2.Text == "" || txtN3.Text == "" || txtN4.Text == "")
            {
                MessageBox.Show("Campo não preenchido!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Nome = txtNome.Text;
                N1 = Convert.ToDouble(txtN1.Text);
                N2 = Convert.ToDouble(txtN2.Text);
                N3 = Convert.ToDouble(txtN3.Text);
                N4 = Convert.ToDouble(txtN4.Text);
                M = (N1 + N2 + N3 + N4) / 4;

                if (M >= 6)
                {
                    ListAprovados.Items.Add(Nome + " - " + M);
                    lblAprov.Text = ListAprovados.Items.Count.ToString();
                }
                else
                {
                    listReprovados.Items.Add(Nome + " - " + M);
                    lblReprov.Text = listReprovados.Items.Count.ToString();
                }
            }

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNome.Text = "";
            txtN1.Text = "";
            txtN2.Text = "";
            txtN3.Text = "";
            txtN4.Text = "";
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLimparListas_Click(object sender, EventArgs e)
        {
            ListAprovados.Items.Clear();
            listReprovados.Items.Clear ();
            lblAprov.Text = "0";
            lblReprov.Text = "0";
        }
    }
}

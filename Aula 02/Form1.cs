namespace OperacoesAritmeticas
{
    public partial class Form1 : Form
    {
        double? N1, N2, R;

        public Form1()
        {
            InitializeComponent();
        }

        private void txtNum1_TextChanged(object sender, EventArgs e)
        {
        }

        private void btnAdc_Click(object sender, EventArgs e)
        {
            if (txtNum1.Text == "" || txtNum2.Text == "")
            {
                MessageBox.Show("Campo não preenchido!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                N1 = Convert.ToDouble(txtNum1.Text);
                N2 = Convert.ToDouble(txtNum2.Text);
                R = N1 + N2;
                lblResult.Text = "Adição = " + R.ToString();
            }
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            if (txtNum1.Text == "" || txtNum2.Text == "")
            {
                MessageBox.Show("Campo não preenchido!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                N1 = Convert.ToDouble(txtNum1.Text);
                N2 = Convert.ToDouble(txtNum2.Text);
                R = N1 - N2;
                lblResult.Text = "Subtração = " + R.ToString();
            }

        }

        private void btnMulti_Click(object sender, EventArgs e)
        {
            if (txtNum1.Text == "" || txtNum2.Text == "")
            {
                MessageBox.Show("Campo não preenchido!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                N1 = Convert.ToDouble(txtNum1.Text);
                N2 = Convert.ToDouble(txtNum2.Text);
                R = N1 * N2;
                lblResult.Text = "Multiplicação = " + R.ToString();
            }
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            if (txtNum1.Text == "" || txtNum2.Text == "")
            {
                MessageBox.Show("Campo não preenchido!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                N1 = Convert.ToDouble(txtNum1.Text);
                N2 = Convert.ToDouble(txtNum2.Text);
                if (N2 == 0)
                {
                    MessageBox.Show("Não existe divisão po 0!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                R = N1 / N2;
                lblResult.Text = "Divisão = " + R.ToString();

            }
        }

        private void btnMod_Click(object sender, EventArgs e)
        {
            if (txtNum1.Text == "" || txtNum2.Text == "")
            {
                MessageBox.Show("Campo não preenchido!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                N1 = Convert.ToDouble(txtNum1.Text);
                N2 = Convert.ToDouble(txtNum2.Text);
                R = N1 % N2;
                lblResult.Text = "Resto = " + R.ToString();

            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNum1.Text = "";
            txtNum2.Text = "";
            lblResult.Text = "Resultado";
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lblResult_Click(object sender, EventArgs e)
        {

        }
    }
}

namespace OperacoesAritmeticas
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
            lblNum1 = new Label();
            txtNum1 = new TextBox();
            pictureBox1 = new PictureBox();
            btnAdc = new Button();
            lblNum2 = new Label();
            lblResult = new Label();
            btnSub = new Button();
            btnMulti = new Button();
            btnDiv = new Button();
            btnMod = new Button();
            btnLimpar = new Button();
            btnSair = new Button();
            txtNum2 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblNum1
            // 
            lblNum1.AutoSize = true;
            lblNum1.Font = new Font("Century Gothic", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNum1.Location = new Point(169, 65);
            lblNum1.Name = "lblNum1";
            lblNum1.Size = new Size(129, 40);
            lblNum1.TabIndex = 0;
            lblNum1.Text = "Valor 1";
            // 
            // txtNum1
            // 
            txtNum1.Font = new Font("Century Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNum1.Location = new Point(155, 119);
            txtNum1.Name = "txtNum1";
            txtNum1.Size = new Size(157, 44);
            txtNum1.TabIndex = 2;
            txtNum1.TextChanged += txtNum1_TextChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(7, 15, 43);
            pictureBox1.Location = new Point(-4, 313);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(713, 243);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // btnAdc
            // 
            btnAdc.FlatAppearance.BorderColor = Color.FromArgb(54, 84, 134);
            btnAdc.FlatStyle = FlatStyle.Flat;
            btnAdc.Font = new Font("Century Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAdc.Location = new Point(29, 347);
            btnAdc.Name = "btnAdc";
            btnAdc.Size = new Size(128, 79);
            btnAdc.TabIndex = 6;
            btnAdc.Text = "+";
            btnAdc.UseVisualStyleBackColor = true;
            btnAdc.Click += btnAdc_Click;
            // 
            // lblNum2
            // 
            lblNum2.AutoSize = true;
            lblNum2.Font = new Font("Century Gothic", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNum2.Location = new Point(377, 65);
            lblNum2.Name = "lblNum2";
            lblNum2.Size = new Size(129, 40);
            lblNum2.TabIndex = 1;
            lblNum2.Text = "Valor 2";
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.BorderStyle = BorderStyle.Fixed3D;
            lblResult.Font = new Font("Century Gothic", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblResult.Location = new Point(155, 215);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(182, 42);
            lblResult.TabIndex = 8;
            lblResult.Text = "Resultado";
            lblResult.Click += lblResult_Click;
            // 
            // btnSub
            // 
            btnSub.FlatAppearance.BorderColor = Color.FromArgb(54, 84, 134);
            btnSub.FlatStyle = FlatStyle.Flat;
            btnSub.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSub.Location = new Point(195, 347);
            btnSub.Name = "btnSub";
            btnSub.Size = new Size(128, 79);
            btnSub.TabIndex = 9;
            btnSub.Text = "—";
            btnSub.UseVisualStyleBackColor = true;
            btnSub.Click += btnSub_Click;
            // 
            // btnMulti
            // 
            btnMulti.FlatAppearance.BorderColor = Color.FromArgb(54, 84, 134);
            btnMulti.FlatStyle = FlatStyle.Flat;
            btnMulti.Font = new Font("Century Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMulti.Location = new Point(361, 347);
            btnMulti.Name = "btnMulti";
            btnMulti.Size = new Size(128, 79);
            btnMulti.TabIndex = 10;
            btnMulti.Text = "×";
            btnMulti.UseVisualStyleBackColor = true;
            btnMulti.Click += btnMulti_Click;
            // 
            // btnDiv
            // 
            btnDiv.FlatAppearance.BorderColor = Color.FromArgb(54, 84, 134);
            btnDiv.FlatStyle = FlatStyle.Flat;
            btnDiv.Font = new Font("Century Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDiv.Location = new Point(532, 347);
            btnDiv.Name = "btnDiv";
            btnDiv.Size = new Size(128, 79);
            btnDiv.TabIndex = 11;
            btnDiv.Text = "÷";
            btnDiv.UseVisualStyleBackColor = true;
            btnDiv.Click += btnDiv_Click;
            // 
            // btnMod
            // 
            btnMod.FlatAppearance.BorderColor = Color.FromArgb(54, 84, 134);
            btnMod.FlatStyle = FlatStyle.Flat;
            btnMod.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMod.Location = new Point(94, 443);
            btnMod.Name = "btnMod";
            btnMod.Size = new Size(128, 79);
            btnMod.TabIndex = 12;
            btnMod.Text = "MOD";
            btnMod.UseVisualStyleBackColor = true;
            btnMod.Click += btnMod_Click;
            // 
            // btnLimpar
            // 
            btnLimpar.FlatAppearance.BorderColor = Color.FromArgb(54, 84, 134);
            btnLimpar.FlatStyle = FlatStyle.Flat;
            btnLimpar.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLimpar.Location = new Point(264, 443);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(154, 79);
            btnLimpar.TabIndex = 13;
            btnLimpar.Text = "LIMPAR";
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // btnSair
            // 
            btnSair.FlatAppearance.BorderColor = Color.FromArgb(54, 84, 134);
            btnSair.FlatStyle = FlatStyle.Flat;
            btnSair.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSair.Location = new Point(465, 443);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(154, 79);
            btnSair.TabIndex = 14;
            btnSair.Text = "SAIR";
            btnSair.UseVisualStyleBackColor = true;
            btnSair.Click += btnSair_Click;
            // 
            // txtNum2
            // 
            txtNum2.Font = new Font("Century Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNum2.Location = new Point(366, 119);
            txtNum2.Name = "txtNum2";
            txtNum2.Size = new Size(157, 44);
            txtNum2.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(127, 199, 217);
            ClientSize = new Size(704, 555);
            Controls.Add(btnSair);
            Controls.Add(btnLimpar);
            Controls.Add(btnMod);
            Controls.Add(btnDiv);
            Controls.Add(btnMulti);
            Controls.Add(btnSub);
            Controls.Add(lblResult);
            Controls.Add(btnAdc);
            Controls.Add(pictureBox1);
            Controls.Add(txtNum2);
            Controls.Add(txtNum1);
            Controls.Add(lblNum2);
            Controls.Add(lblNum1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculadora";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNum1;
        private TextBox txtNum1;
        private PictureBox pictureBox1;
        private Button btnAdc;
        private Label lblNum2;
        private Label lblResult;
        private Button btnSub;
        private Button btnMulti;
        private Button btnDiv;
        private Button btnMod;
        private Button btnLimpar;
        private Button btnSair;
        private TextBox txtNum2;
    }
}

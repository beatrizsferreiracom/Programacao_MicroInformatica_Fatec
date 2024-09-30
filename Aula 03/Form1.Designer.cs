namespace MediaAritmetica
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblN1 = new System.Windows.Forms.Label();
            this.txtN1 = new System.Windows.Forms.TextBox();
            this.lblN2 = new System.Windows.Forms.Label();
            this.txtN2 = new System.Windows.Forms.TextBox();
            this.lblN3 = new System.Windows.Forms.Label();
            this.txtN3 = new System.Windows.Forms.TextBox();
            this.lblN4 = new System.Windows.Forms.Label();
            this.txtN4 = new System.Windows.Forms.TextBox();
            this.ListAprovados = new System.Windows.Forms.ListBox();
            this.listReprovados = new System.Windows.Forms.ListBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblAprovado = new System.Windows.Forms.Label();
            this.lblReprovado = new System.Windows.Forms.Label();
            this.btnLimparListas = new System.Windows.Forms.Button();
            this.btnMedia = new System.Windows.Forms.Button();
            this.lblAprov = new System.Windows.Forms.Label();
            this.lblReprov = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(134, 34);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(136, 32);
            this.txtNome.TabIndex = 0;
            this.txtNome.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(15)))), ((int)(((byte)(43)))));
            this.lblNome.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.ForeColor = System.Drawing.Color.White;
            this.lblNome.Location = new System.Drawing.Point(43, 37);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(76, 23);
            this.lblNome.TabIndex = 1;
            this.lblNome.Text = "Nome:";
            this.lblNome.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblN1
            // 
            this.lblN1.AutoSize = true;
            this.lblN1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(15)))), ((int)(((byte)(43)))));
            this.lblN1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblN1.ForeColor = System.Drawing.Color.White;
            this.lblN1.Location = new System.Drawing.Point(43, 95);
            this.lblN1.Name = "lblN1";
            this.lblN1.Size = new System.Drawing.Size(80, 23);
            this.lblN1.TabIndex = 3;
            this.lblN1.Text = "Nota 1:";
            // 
            // txtN1
            // 
            this.txtN1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtN1.Location = new System.Drawing.Point(134, 92);
            this.txtN1.Name = "txtN1";
            this.txtN1.Size = new System.Drawing.Size(136, 32);
            this.txtN1.TabIndex = 2;
            // 
            // lblN2
            // 
            this.lblN2.AutoSize = true;
            this.lblN2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(15)))), ((int)(((byte)(43)))));
            this.lblN2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblN2.ForeColor = System.Drawing.Color.White;
            this.lblN2.Location = new System.Drawing.Point(44, 149);
            this.lblN2.Name = "lblN2";
            this.lblN2.Size = new System.Drawing.Size(80, 23);
            this.lblN2.TabIndex = 5;
            this.lblN2.Text = "Nota 2:";
            // 
            // txtN2
            // 
            this.txtN2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtN2.Location = new System.Drawing.Point(134, 146);
            this.txtN2.Name = "txtN2";
            this.txtN2.Size = new System.Drawing.Size(136, 32);
            this.txtN2.TabIndex = 4;
            // 
            // lblN3
            // 
            this.lblN3.AutoSize = true;
            this.lblN3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(15)))), ((int)(((byte)(43)))));
            this.lblN3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblN3.ForeColor = System.Drawing.Color.White;
            this.lblN3.Location = new System.Drawing.Point(44, 201);
            this.lblN3.Name = "lblN3";
            this.lblN3.Size = new System.Drawing.Size(80, 23);
            this.lblN3.TabIndex = 7;
            this.lblN3.Text = "Nota 3:";
            // 
            // txtN3
            // 
            this.txtN3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtN3.Location = new System.Drawing.Point(134, 198);
            this.txtN3.Name = "txtN3";
            this.txtN3.Size = new System.Drawing.Size(136, 32);
            this.txtN3.TabIndex = 6;
            // 
            // lblN4
            // 
            this.lblN4.AutoSize = true;
            this.lblN4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(15)))), ((int)(((byte)(43)))));
            this.lblN4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblN4.ForeColor = System.Drawing.Color.White;
            this.lblN4.Location = new System.Drawing.Point(44, 254);
            this.lblN4.Name = "lblN4";
            this.lblN4.Size = new System.Drawing.Size(80, 23);
            this.lblN4.TabIndex = 9;
            this.lblN4.Text = "Nota 4:";
            // 
            // txtN4
            // 
            this.txtN4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtN4.Location = new System.Drawing.Point(134, 251);
            this.txtN4.Name = "txtN4";
            this.txtN4.Size = new System.Drawing.Size(136, 32);
            this.txtN4.TabIndex = 8;
            // 
            // ListAprovados
            // 
            this.ListAprovados.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListAprovados.FormattingEnabled = true;
            this.ListAprovados.ItemHeight = 21;
            this.ListAprovados.Location = new System.Drawing.Point(390, 61);
            this.ListAprovados.Name = "ListAprovados";
            this.ListAprovados.Size = new System.Drawing.Size(162, 298);
            this.ListAprovados.TabIndex = 10;
            // 
            // listReprovados
            // 
            this.listReprovados.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listReprovados.FormattingEnabled = true;
            this.listReprovados.ItemHeight = 21;
            this.listReprovados.Location = new System.Drawing.Point(591, 61);
            this.listReprovados.Name = "listReprovados";
            this.listReprovados.Size = new System.Drawing.Size(162, 298);
            this.listReprovados.TabIndex = 11;
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(191, 323);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(99, 48);
            this.btnLimpar.TabIndex = 13;
            this.btnLimpar.Text = "LIMPAR";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(113, 377);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(99, 48);
            this.btnSair.TabIndex = 14;
            this.btnSair.Text = "SAIR";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(15)))), ((int)(((byte)(43)))));
            this.pictureBox1.Location = new System.Drawing.Point(-1, -6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(328, 458);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // lblAprovado
            // 
            this.lblAprovado.AutoSize = true;
            this.lblAprovado.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAprovado.Location = new System.Drawing.Point(401, 29);
            this.lblAprovado.Name = "lblAprovado";
            this.lblAprovado.Size = new System.Drawing.Size(135, 23);
            this.lblAprovado.TabIndex = 16;
            this.lblAprovado.Text = "APROVADOS";
            // 
            // lblReprovado
            // 
            this.lblReprovado.AutoSize = true;
            this.lblReprovado.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReprovado.Location = new System.Drawing.Point(600, 29);
            this.lblReprovado.Name = "lblReprovado";
            this.lblReprovado.Size = new System.Drawing.Size(142, 23);
            this.lblReprovado.TabIndex = 17;
            this.lblReprovado.Text = "REPROVADOS";
            // 
            // btnLimparListas
            // 
            this.btnLimparListas.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnLimparListas.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnLimparListas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimparListas.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimparListas.Location = new System.Drawing.Point(507, 402);
            this.btnLimparListas.Name = "btnLimparListas";
            this.btnLimparListas.Size = new System.Drawing.Size(136, 37);
            this.btnLimparListas.TabIndex = 18;
            this.btnLimparListas.Text = "LIMPAR LISTAS";
            this.btnLimparListas.UseVisualStyleBackColor = false;
            this.btnLimparListas.Click += new System.EventHandler(this.btnLimparListas_Click);
            // 
            // btnMedia
            // 
            this.btnMedia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnMedia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMedia.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMedia.Location = new System.Drawing.Point(32, 323);
            this.btnMedia.Name = "btnMedia";
            this.btnMedia.Size = new System.Drawing.Size(99, 48);
            this.btnMedia.TabIndex = 12;
            this.btnMedia.Text = "MÉDIA";
            this.btnMedia.UseVisualStyleBackColor = false;
            this.btnMedia.Click += new System.EventHandler(this.btnMedia_Click);
            // 
            // lblAprov
            // 
            this.lblAprov.AutoSize = true;
            this.lblAprov.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAprov.Location = new System.Drawing.Point(454, 361);
            this.lblAprov.Name = "lblAprov";
            this.lblAprov.Size = new System.Drawing.Size(19, 21);
            this.lblAprov.TabIndex = 19;
            this.lblAprov.Text = "0";
            // 
            // lblReprov
            // 
            this.lblReprov.AutoSize = true;
            this.lblReprov.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReprov.Location = new System.Drawing.Point(662, 361);
            this.lblReprov.Name = "lblReprov";
            this.lblReprov.Size = new System.Drawing.Size(19, 21);
            this.lblReprov.TabIndex = 20;
            this.lblReprov.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(199)))), ((int)(((byte)(217)))));
            this.ClientSize = new System.Drawing.Size(805, 451);
            this.Controls.Add(this.lblReprov);
            this.Controls.Add(this.lblAprov);
            this.Controls.Add(this.btnLimparListas);
            this.Controls.Add(this.lblReprovado);
            this.Controls.Add(this.lblAprovado);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnMedia);
            this.Controls.Add(this.listReprovados);
            this.Controls.Add(this.ListAprovados);
            this.Controls.Add(this.lblN4);
            this.Controls.Add(this.txtN4);
            this.Controls.Add(this.lblN3);
            this.Controls.Add(this.txtN3);
            this.Controls.Add(this.lblN2);
            this.Controls.Add(this.txtN2);
            this.Controls.Add(this.lblN1);
            this.Controls.Add(this.txtN1);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MÉDIA DOS ALUNOS";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblN1;
        private System.Windows.Forms.TextBox txtN1;
        private System.Windows.Forms.Label lblN2;
        private System.Windows.Forms.TextBox txtN2;
        private System.Windows.Forms.Label lblN3;
        private System.Windows.Forms.TextBox txtN3;
        private System.Windows.Forms.Label lblN4;
        private System.Windows.Forms.TextBox txtN4;
        private System.Windows.Forms.ListBox ListAprovados;
        private System.Windows.Forms.ListBox listReprovados;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblAprovado;
        private System.Windows.Forms.Label lblReprovado;
        private System.Windows.Forms.Button btnLimparListas;
        private System.Windows.Forms.Button btnMedia;
        private System.Windows.Forms.Label lblAprov;
        private System.Windows.Forms.Label lblReprov;
    }
}


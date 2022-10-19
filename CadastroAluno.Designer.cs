
namespace Estudio
{
    partial class CadastroAluno
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
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.gbxDados = new System.Windows.Forms.GroupBox();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtComplemento = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.mtxTelefone = new System.Windows.Forms.MaskedTextBox();
            this.mtxCEP = new System.Windows.Forms.MaskedTextBox();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.mtxCPF = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnFoto = new System.Windows.Forms.Button();
            this.gbxDados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(69, 62);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(372, 20);
            this.txtNome.TabIndex = 0;
            // 
            // txtEndereco
            // 
            this.txtEndereco.Location = new System.Drawing.Point(69, 94);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(263, 20);
            this.txtEndereco.TabIndex = 1;
            // 
            // gbxDados
            // 
            this.gbxDados.Controls.Add(this.txtCidade);
            this.gbxDados.Controls.Add(this.label10);
            this.gbxDados.Controls.Add(this.btnCadastrar);
            this.gbxDados.Controls.Add(this.txtEmail);
            this.gbxDados.Controls.Add(this.label11);
            this.gbxDados.Controls.Add(this.txtEstado);
            this.gbxDados.Controls.Add(this.label9);
            this.gbxDados.Controls.Add(this.txtComplemento);
            this.gbxDados.Controls.Add(this.label8);
            this.gbxDados.Controls.Add(this.txtNum);
            this.gbxDados.Controls.Add(this.label7);
            this.gbxDados.Controls.Add(this.label6);
            this.gbxDados.Controls.Add(this.label5);
            this.gbxDados.Controls.Add(this.mtxTelefone);
            this.gbxDados.Controls.Add(this.mtxCEP);
            this.gbxDados.Controls.Add(this.txtBairro);
            this.gbxDados.Controls.Add(this.label4);
            this.gbxDados.Controls.Add(this.mtxCPF);
            this.gbxDados.Controls.Add(this.label3);
            this.gbxDados.Controls.Add(this.label2);
            this.gbxDados.Controls.Add(this.label1);
            this.gbxDados.Controls.Add(this.txtNome);
            this.gbxDados.Controls.Add(this.txtEndereco);
            this.gbxDados.Location = new System.Drawing.Point(12, 12);
            this.gbxDados.Name = "gbxDados";
            this.gbxDados.Size = new System.Drawing.Size(457, 298);
            this.gbxDados.TabIndex = 2;
            this.gbxDados.TabStop = false;
            this.gbxDados.Text = "Dados Cadastrais";
            this.gbxDados.Enter += new System.EventHandler(this.gbxDados_Enter);
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(69, 156);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(371, 20);
            this.txtCidade.TabIndex = 23;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 159);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "Cidade:";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(26, 269);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(415, 23);
            this.btnCadastrar.TabIndex = 21;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(230, 225);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(210, 20);
            this.txtEmail.TabIndex = 20;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(186, 231);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(38, 13);
            this.label11.TabIndex = 19;
            this.label11.Text = "E-mail:";
            // 
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(69, 191);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(226, 20);
            this.txtEstado.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 198);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Estado:";
            // 
            // txtComplemento
            // 
            this.txtComplemento.Location = new System.Drawing.Point(338, 126);
            this.txtComplemento.Name = "txtComplemento";
            this.txtComplemento.Size = new System.Drawing.Size(103, 20);
            this.txtComplemento.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(258, 133);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Complemento:";
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(368, 94);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(72, 20);
            this.txtNum.TabIndex = 13;
            this.txtNum.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(342, 97);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(20, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "nº:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 235);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Telefone:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(301, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "CEP:";
            // 
            // mtxTelefone
            // 
            this.mtxTelefone.Location = new System.Drawing.Point(69, 228);
            this.mtxTelefone.Mask = "(99)99999-9999";
            this.mtxTelefone.Name = "mtxTelefone";
            this.mtxTelefone.Size = new System.Drawing.Size(100, 20);
            this.mtxTelefone.TabIndex = 9;
            // 
            // mtxCEP
            // 
            this.mtxCEP.Location = new System.Drawing.Point(340, 191);
            this.mtxCEP.Mask = "00.000.000";
            this.mtxCEP.Name = "mtxCEP";
            this.mtxCEP.Size = new System.Drawing.Size(100, 20);
            this.mtxCEP.TabIndex = 8;
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(69, 126);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(183, 20);
            this.txtBairro.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Bairro:";
            // 
            // mtxCPF
            // 
            this.mtxCPF.Location = new System.Drawing.Point(69, 30);
            this.mtxCPF.Name = "mtxCPF";
            this.mtxCPF.Size = new System.Drawing.Size(100, 20);
            this.mtxCPF.TabIndex = 5;
            this.mtxCPF.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mtxCPF_MaskInputRejected);
            this.mtxCPF.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mtxCPF_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Endereço:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nome:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "CPF:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(496, 42);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(116, 161);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // btnFoto
            // 
            this.btnFoto.Location = new System.Drawing.Point(496, 219);
            this.btnFoto.Name = "btnFoto";
            this.btnFoto.Size = new System.Drawing.Size(116, 23);
            this.btnFoto.TabIndex = 4;
            this.btnFoto.Text = "Escolher Foto";
            this.btnFoto.UseVisualStyleBackColor = true;
            // 
            // CadastroAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 322);
            this.Controls.Add(this.btnFoto);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.gbxDados);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "CadastroAluno";
            this.Text = "Cadastrar Aluno";
            this.Load += new System.EventHandler(this.CadastroAluno_Load);
            this.gbxDados.ResumeLayout(false);
            this.gbxDados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.GroupBox gbxDados;
        private System.Windows.Forms.MaskedTextBox mtxCPF;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtComplemento;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox mtxTelefone;
        private System.Windows.Forms.MaskedTextBox mtxCEP;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnFoto;
    }
}
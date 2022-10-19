using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;

namespace Estudio
{
    public partial class CadastroAluno : Form
    {
        public CadastroAluno()
        {
            InitializeComponent();
        }

        private void gbxDados_Enter(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void CadastroAluno_Load(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            //byte[] foto = ConverterFotoParaByteArray();
            Aluno aluno = new Aluno(mtxCPF.Text, txtNome.Text, txtEndereco.Text, txtNum.Text, txtBairro.Text, txtComplemento.Text, mtxCEP.Text, txtCidade.Text, txtEstado.Text,  mtxTelefone.Text, txtEmail.Text, 0);
            if (aluno.cadastrarAluno())
                MessageBox.Show("Cadastro realizado com sucesso");
            else
                MessageBox.Show("Erro no cadastro");

            txtNome.Text = String.Empty;
            txtEndereco.Text = String.Empty;
            txtNum.Text = String.Empty;
            txtBairro.Text = String.Empty;
            txtComplemento.Text = String.Empty;
            txtCidade.Text = String.Empty;
            txtEstado.Text = String.Empty;
            txtEmail.Text = String.Empty;

        }

        private void mtxCPF_KeyPress(object sender, KeyPressEventArgs e)
        {
            Aluno aluno = new Aluno(mtxCPF.Text);
            if(e.KeyChar == 13)
            {
                if (aluno.consultarAluno())
                {
                    MessageBox.Show("Aluno já cadastrado");
                }
                else
                {
                    txtNome.Focus();
                }
            }
        }

        private void mtxCPF_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}

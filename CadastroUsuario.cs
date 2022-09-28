using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estudio
{
    public partial class CadastroUsuario : Form
    {
        public CadastroUsuario()
        {
            InitializeComponent();
        }

        private void cboTipo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            int tipo = 0;
           if(cboTipo.SelectedIndex == 0)
            {
                tipo = 1;
            }
           else if (cboTipo.SelectedIndex == 1)
            {
                tipo = 2;
            }
           if (DAO_Conexao.CadLogin(txtUsuario.Text, txtSenha.Text, tipo))
            {
                MessageBox.Show("Cadastro realizado com sucesso!");
            }
            else
            {
                MessageBox.Show("Erro no cadastro!");
            }

        }
    }
}

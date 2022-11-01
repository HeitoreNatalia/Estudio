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
    public partial class Cad_Modalidade : Form
    {
        public Cad_Modalidade()
        {
            InitializeComponent();
        }

        private void txtPreco_TextChanged(object sender, EventArgs e)
        {
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Modalidade modalidade = new Modalidade(txtDescricao.Text, float.Parse(txtPreco.Text), Convert.ToInt16(txtQtdAlunos.Text), Convert.ToInt16(txtQtdAulas.Text));
            if (modalidade.cadastrarModalidade())
                MessageBox.Show("Cadastro realizado com sucesso");
            else
                MessageBox.Show("Erro no cadastro");
        }
    }
}

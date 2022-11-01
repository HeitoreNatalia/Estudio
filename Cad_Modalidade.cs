using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
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
            Modalidade modalidade = new Modalidade(txtDescricao.Text, (float)Convert.ToDecimal(txtPreco.Text), int.Parse(txtQtdAlunos.Text), int.Parse(txtQtdAulas.Text));
         
            if (modalidade.cadastrarModalidade())
            {
                Console.WriteLine("\n STRING: " + txtPreco.Text);
                Console.WriteLine("\n (FLOAT)Convert.todecimal: " + (float)Convert.ToDecimal(txtPreco.Text));
                MessageBox.Show("Cadastro realizado com sucesso");
            }
            else
                MessageBox.Show("Erro no cadastro");
                

        }
    }
}

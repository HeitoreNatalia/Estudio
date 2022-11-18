using MySql.Data.MySqlClient;
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
    public partial class ExclusaoModalidade : Form
    {
        public ExclusaoModalidade()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;

            Modalidade cad = new Modalidade();
            MySqlDataReader r = cad.consultarTodasModalidades();
            while (r.Read())
            {
                cbo_descricao.Items.Add(r["descricao"].ToString());
            }
            DAO_Conexao.con.Close();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
        }

        private void Exclusao_Modalidade_Load(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            Modalidade modalidade = new Modalidade(Convert.ToString(cbo_descricao.SelectedItem));
            if (modalidade.excluirModalidade())
                MessageBox.Show("Excluído com sucesso");
            else
                MessageBox.Show("Ocorreu um erro!");

        }
    }
}

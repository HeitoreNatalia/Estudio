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
    public partial class TurmaForms : Form
    {
        public TurmaForms()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
            //--------------------------------------
            Modalidade con_mod = new Modalidade();
            MySqlDataReader r = con_mod.consultarTodasModalidades();
            while(r.Read())
            {
                dataGridView1.Rows.Add(r["descricao"].ToString());
                
            }
            DAO_Conexao.con.Close();
            //--------------------------------------
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void TurmaForms_Load(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtModalidade.Text = dataGridView1.CurrentCell.Value.ToString();
            
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Modalidade modalidade = new Modalidade(dataGridView1.CurrentCell.Value.ToString());
            Turma turma = new Turma(txtProfessor.Text, txtDiaSemana.Text, mskHora.Text, modalidade.selectId());
        }
    }
}

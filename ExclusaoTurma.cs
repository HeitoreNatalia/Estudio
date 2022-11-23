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
    public partial class ExclusaoTurma : Form
    {
        public ExclusaoTurma()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;

            Turma turma = new Turma();
            MySqlDataReader reader = turma.tdsTurmas();


            while (reader.Read())
            {
                cboModalidade.Items.Add(reader["descricao"].ToString());
            }
            DAO_Conexao.con.Close();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void ExclusaoTurma_Load(object sender, EventArgs e)
        {

        }

        private void cboModalidade_SelectedIndexChanged(object sender, EventArgs e)
        {
         
            Modalidade modalidade = new Modalidade(cboModalidade.SelectedItem.ToString());
            MySqlDataReader reader = modalidade.consultarModalidade();
            int idmodalidade = -1;
            while (reader.Read())
            {
                idmodalidade = int.Parse(reader["idEstudio_Modalidade"].ToString());
            }
            DAO_Conexao.con.Close();
            Turma turma = new Turma(idmodalidade);
            reader = turma.consultarTurma();
            cboDiaSemana.Items.Clear();
            cboHora.Items.Clear();
            while(reader.Read())
            {
                cboDiaSemana.Items.Add(reader["diasemanaTurma"].ToString());
                cboHora.Items.Add(reader["horaTurma"].ToString());
                cboDiaSemana.SelectedItem = cboDiaSemana.Items[0];
                cboHora.SelectedItem = cboHora.Items[0];
                btnExcluir.Enabled = true;
            }
            DAO_Conexao.con.Close();

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Modalidade modalidade = new Modalidade(cboModalidade.SelectedItem.ToString());
            MySqlDataReader reader = modalidade.consultarModalidade();
            string professor = "";
            string diasemana = "";
            string hora = "";
            int idmodalidade = -1;
            while (reader.Read())
            {
                idmodalidade = int.Parse(reader["idEstudio_Modalidade"].ToString());
            }
            DAO_Conexao.con.Close();
            Turma turma = new Turma(idmodalidade);
            reader = turma.consultarTurma();
            while (reader.Read())
            {
                professor = reader["professorTurma"].ToString();
                diasemana = reader["diasemanaTurma"].ToString();
                hora = reader["horaTurma"].ToString();
            }
            DAO_Conexao.con.Close();
            Turma outraturma = new Turma(professor, diasemana, hora, idmodalidade);
            outraturma.excluirTurma();

            cboDiaSemana.Text = String.Empty;
            cboModalidade.Text = String.Empty;
            cboHora.Text = String.Empty;

            cboModalidade.Items.Clear();

            Turma adicionar = new Turma();
            reader = adicionar.tdsTurmas();

            while (reader.Read())
            {
                cboModalidade.Items.Add(reader["descricao"].ToString());
            }
            DAO_Conexao.con.Close();
            btnExcluir.Enabled = false;
        }
    }
}

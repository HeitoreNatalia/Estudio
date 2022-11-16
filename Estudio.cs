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
    public partial class Estudio : Form
    {
        public Estudio()
        {
            InitializeComponent();

            if (DAO_Conexao.getConexao("143.106.241.3", "cl201306", "cl201306", "cl*06052005"))
                Console.WriteLine("Conectado");
            else
                Console.WriteLine("Erro de conexão");
        }

        private void Estudio_Load(object sender, EventArgs e)
        {

        }

        private void btnLogar_Click(object sender, EventArgs e)
        {
            int tipo = DAO_Conexao.login(txtLogin.Text, txtSenha.Text);
            if (tipo == 0)
                MessageBox.Show("Usuário e/ou senha inválidos");
            if (tipo == 1)
            {
                MessageBox.Show("Usuário ADM");
                groupBox1.Visible = false;
                menuStrip1.Enabled = true;
            }
            if (tipo == 2)
            {
                MessageBox.Show("Usuário Restrito");
                groupBox1.Visible = false;
                menuStrip1.Enabled = true;
                cadastrarLoginToolStripMenuItem.Enabled = false;
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void sAirToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void arquivoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cadastrarAlunoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<CadastroAluno>().Count() == 0)
            {
                CadastroAluno cad_aluno = new CadastroAluno();
                cad_aluno.MdiParent = this;
                cad_aluno.Show();
            }
                
        }

        private void cadastrarLoginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<CadastroUsuario>().Count() == 0)
            {
                CadastroUsuario cad_login = new CadastroUsuario();
                cad_login.MdiParent = this;
                cad_login.Show();
            }
                
        }

        private void excluirAlunoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<Exclusao>().Count() == 0)
            {
                Exclusao exclusao = new Exclusao();
                exclusao.MdiParent = this;
                exclusao.Show();
            }
                
        }

        private void cadastrarModalidadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<Cad_Modalidade>().Count() == 0)
            {
                Cad_Modalidade cad_modalidade = new Cad_Modalidade();
                cad_modalidade.MdiParent = this;
                cad_modalidade.Show();
            }
            
        }

        private void consultarModalidadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<Consulta_Modalidade>().Count() == 0)
            {
                Consulta_Modalidade consulta_modalidade = new Consulta_Modalidade();
                consulta_modalidade.MdiParent = this;
                consulta_modalidade.Show();
            }
                
        }

        private void excluirModalidadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<Exclusao_Modalidade>().Count() == 0)
            {
                Exclusao_Modalidade exclusao_modalidade = new Exclusao_Modalidade();
                exclusao_modalidade.MdiParent = this;
                exclusao_modalidade.Show();
            }                
        }

        private void cadastroDeTurmaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TurmaForms turmaForms = new TurmaForms();
            turmaForms.MdiParent = this;
            turmaForms.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}

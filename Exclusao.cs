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
    public partial class Exclusao : Form
    {


        public Exclusao()
        {
            InitializeComponent();
        }

        private void mtxCPF_KeyPress(object sender, KeyPressEventArgs e)
        {
            Aluno aluno = new Aluno(mtxCPF.Text);
            if (e.KeyChar == 13)
            {
                if (aluno.consultarAluno())
                {
                    if(aluno.excluirAluno())
                    {
                        MessageBox.Show("Aluno Excluído");
                    }
                }
                else
                {
                    MessageBox.Show("Aluno não encontrado.");
                }
                mtxCPF.Text = String.Empty;
            }
        }

        private void mtxCPF_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void Exclusao_Load(object sender, EventArgs e)
        {

        }
    }
}

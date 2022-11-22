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

            turma.tdsNomesModalidades();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void ExclusaoTurma_Load(object sender, EventArgs e)
        {

        }
    }
}

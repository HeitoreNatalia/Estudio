﻿using MySql.Data.MySqlClient;
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
    public partial class Consulta_Modalidade : Form
    {
        public Consulta_Modalidade()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;

            Modalidade cad = new Modalidade();
            MySqlDataReader r = cad.consultarTodasModalidades();
            while(r.Read())
            {
                cboDescricao.Items.Add(r["descricao"].ToString());
            }
            DAO_Conexao.con.Close();
        }

        private void cboDescricao_SelectedIndexChanged(object sender, EventArgs e)
        {
            Modalidade modalidade = new Modalidade(Convert.ToString(cboDescricao.SelectedItem));
            MySqlDataReader r = modalidade.consultarModalidade();
            if(r.Read())
            {
                txtPreco.Text = r["preco"].ToString();
                txtQtdAlunos.Text = r["qtd_alunos"].ToString();
                txtQtdAulas.Text = r["qtd_aulas"].ToString();
            }
            DAO_Conexao.con.Close();
        }

        private void Consulta_Modalidade_Load(object sender, EventArgs e)
        {

        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            Modalidade modalidade = new Modalidade(Convert.ToString(cboDescricao.SelectedItem), float.Parse(txtPreco.Text), int.Parse(txtQtdAlunos.Text), int.Parse(txtQtdAulas.Text));

            if(modalidade.atualizarModalidade())
            {
                MessageBox.Show("Atualizado com sucesso!");
                txtPreco.Enabled = false;
                txtQtdAlunos.Enabled = false;
                txtQtdAulas.Enabled = false;
                btnAtualizar.Enabled = false;
            }
            else
            {
                MessageBox.Show("Ocorreu um erro");
            }
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtPreco.Enabled = true;
            txtQtdAlunos.Enabled = true;
            txtQtdAulas.Enabled = true;
            btnAtualizar.Enabled = true;
        }
    }
}

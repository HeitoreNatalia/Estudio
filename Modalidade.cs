using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudio
{
    internal class Modalidade
    {
        //atributos
        private String descricao;
        private float preco;
        private int qtd_alunos, qtd_aulas;

        //getters e seters
        public string Descricao { get => descricao; set => descricao = value; }
        public float Preco { get => preco; set => preco = value; }    
        public int Qtd_alunos { get => qtd_alunos; set => qtd_alunos = value; }
        public int Qtd_aulas { get => qtd_aulas; set => qtd_aulas = value; }

        //construtores
        public Modalidade(string descricao, float preco, int qtd_alunos, int qtd_aulas)
        {
            Descricao = descricao;
            Preco = preco;
            Qtd_alunos = qtd_alunos;
            Qtd_aulas = qtd_aulas;
        }

        public Modalidade(string descricao)
        {
            Descricao = descricao;
        }

        public Modalidade()
        {
        }

        //métodos
        public bool cadastrarModalidade()
        {
            //metodo de inserção de registros no banco
            return false;
        }

        public MySqlDataReader consultarModalidade()
        {
            //medoto de consulta aum registro da classe modalidade dada uma descricao
        }
            
        public MySqlDataReader consultarTodasModalidade()
        {
            //metodo de consulta a todos os registros de modalidade
        }

        public bool atualizarModalidade()
        {
            //metodo de atualizacao de registro
            return false;
        }
            
        public bool excluirModalidade()
        {
            //metodo de exclusao de registro
            return false;
        }

    }
}

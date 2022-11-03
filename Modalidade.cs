using System;
using MySql.Data.MySqlClient;
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

        private string consertaFloat(float floatquebrado)
        {
            string lalala = floatquebrado.ToString();
            string novofloat = "";
            foreach (char c in lalala)
            {
                if (c == ',')
                {
                    novofloat += ".";
                }
                else
                {
                    novofloat += c.ToString();
                }
            }
            return novofloat;
        }

        //métodos
        public bool cadastrarModalidade()
        {
            //metodo de inserção de registros no banco
            bool cad = false;
            try
            {
                DAO_Conexao.con.Open();
                Console.WriteLine(consertaFloat(preco));
                MySqlCommand insere = new MySqlCommand("INSERT INTO Estudio_Modalidade(descricao, preco, qtd_alunos, qtd_aulas) VALUES ('" + descricao + "', '" +  consertaFloat
                    (preco)  + "' , " + qtd_alunos + " , " + qtd_aulas + " )", DAO_Conexao.con);
                //insere.Parameters.Add

                insere.ExecuteNonQuery();
                cad = true;
            }
            catch (Exception exept)
            {
                Console.WriteLine(exept.ToString());
            }
            finally
            {
                DAO_Conexao.con.Close();
            }
            return cad;
        }

        public MySqlDataReader consultarModalidade()
        {
            MySqlDataReader resultado = null;
            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand consulta = new MySqlCommand("SELECT * FROM Estudio_Modalidade " + "WHERE descricao='" + descricao + "'", DAO_Conexao.con);
                resultado = consulta.ExecuteReader();
                return resultado;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return resultado;
            //medoto de consulta aum registro da classe modalidade dada uma descricao
        }

        //Não sei se o retorno está certo
        public MySqlDataReader consultarTodasModalidades()
        {
            MySqlDataReader resultado = null;
            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand consulta = new MySqlCommand("SELECT * FROM Estudio_Modalidade WHERE ativa = 0 ORDER BY descricao" , DAO_Conexao.con);
                resultado = consulta.ExecuteReader();
                return resultado;
            }
            catch(Exception ex)
            {
                Console.WriteLine (ex.ToString());
            }
            
            return resultado;
            //metodo de consulta a todos os registros de modalidade
        }

        public bool atualizarModalidade()
        {
            bool alterou = false;
            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand alteracao = new MySqlCommand("UPDATE Estudio_Modalidade SET preco=" + 
                    preco + " , qtd_alunos= " + qtd_alunos + " , qtd_aulas= " + qtd_aulas + " WHERE descricao = '" + descricao + "'", DAO_Conexao.con);
                alteracao.ExecuteNonQuery();
                alterou = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                DAO_Conexao.con.Close();
            }
            //metodo de atualizacao de registro
            return alterou;
        }
            
        public bool excluirModalidade()
        {
            bool excluiu = false;
            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand exclusao = new MySqlCommand("UPDATE table SET ativo = 1 WHERE descricao = '" + descricao + "'", DAO_Conexao.con);
                exclusao.ExecuteNonQuery();
                excluiu = true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            finally
            {
                DAO_Conexao.con.Close();
            }
            return excluiu;
            //metodo de exclusao de registro
        }

    }
}

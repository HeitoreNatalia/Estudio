using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudio
{
    class Turma
    {
        private string professor, dia_semana, hora;
        private int modalidade;

        public string Professor { get => professor; set => professor = value; }
        public string Dia_semana { get => dia_semana; set => dia_semana = value; }
        public string Hora { get => hora; set => hora = value; }
        public int Modalidade { get => modalidade; set => modalidade = value; }

        public Turma(string professor, string dia_semana, string hora, int modalidade)
        {
            Professor = professor;
            Dia_semana = dia_semana;
            Hora = hora;
            Modalidade = modalidade;
        }

        public Turma(int modalidade)
        {
            Modalidade = modalidade;
        }

        public Turma(string dia_semana, int modalidade)
        {
            Dia_semana = dia_semana;
            Modalidade = modalidade;
        }

        public Turma()
        {
        }

        //métodos



        public bool cadastrarTurma()
        {
            //metodo de inserção de registros no banco
            bool cad = false;
            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand insere = new MySqlCommand("INSERT INTO Estudio_Turma(id_Modalidade, professorTurma, diasemanaTurma, horaTurma, nalunosmatriculadosTurma) VALUES ('" + modalidade + "', '" + professor +
                    "' , '" + dia_semana + "' , '" + hora + "' , '" + 10 + "')", DAO_Conexao.con);
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

        public bool excluirTurma()
        {
            bool confirmacao = false;
            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand exclui = new MySqlCommand("DELETE FROM Estudio_Turma WHERE id_modalidade=" + modalidade + " AND diasemanaTurma like '" + dia_semana + "' AND horaTurma like '" + hora + "'", DAO_Conexao.con);
                exclui.ExecuteNonQuery();
                confirmacao = true;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                DAO_Conexao.con.Close();
            }
            return confirmacao;
        }

        public MySqlDataReader consultarTurma()
        {
            MySqlDataReader resultado = null;
            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand consulta = new MySqlCommand("SELECT * FROM `Estudio_Turma` WHERE id_Modalidade ='" + Modalidade + "'", DAO_Conexao.con);
                resultado = consulta.ExecuteReader();
                return resultado;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return resultado;
        }


        //public MySqlDataReader consultarTurma01();

        public MySqlDataReader tdsTurmas()
        {

            MySqlDataReader resultado = null;
            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand consulta = new MySqlCommand("SELECT descricao FROM `Estudio_Modalidade` where  idEstudio_Modalidade IN (SELECT id_Modalidade from `Estudio_Turma`)", DAO_Conexao.con);
                resultado = consulta.ExecuteReader();
                return resultado;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            return resultado;
        }

        /*public List<string> tdsNomesModalidades()
        {
            List<int> ids = new List<int>();
            MySqlDataReader reader = tdsIdsTurmas();
            DAO_Conexao.con.Close();


            while(reader.Read())
            {
                ids.Add(int.Parse(reader["id_Modalidade"].ToString()));
            }

            for (int i = 0; i < ids.Count; i++)
            {
                Console.WriteLine("=========== ID " + i + " ==========");
                Console.WriteLine(ids[i]);
            }

            return tdsNomesModalidades();*/
    }
}

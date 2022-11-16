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

        //métodos

        public bool cadastrarTurma()
        {
            //metodo de inserção de registros no banco
            bool cad = false;
            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand insere = new MySqlCommand("INSERT INTO Estudio_Turma(id_Modalidade, professorTurma, diasemanaTurma, horaTurma, nalunosmatriculadosTurma) VALUES ('" + modalidade + "', '" + professor +
                    "' , '" + dia_semana + "' , '" + hora + "' )", DAO_Conexao.con);
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

        //public bool excluirTurma();

        //public MySqlDataReader consultarTurma();


        //public MySqlDataReader consultarTurma01();


    }
}

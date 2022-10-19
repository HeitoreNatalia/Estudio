using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudio
{
    class Aluno
    {
        private string CPF;
        private string Nome;
        private string Rua;
        private string Numero;
        private string Bairro;
        private string Complemento;
        private string CEP;
        private string Cidade;
        private string Estado;
        private string Telefone;
        private string Email;
        private byte[] Foto;
        private int Ativo;

        public Aluno(string cPF, string nome, string rua, string numero, string bairro, string complemento, string cEP, string cidade, string estado, string telefone, string email, int ativo)
        {
            CPF = cPF;
            Nome = nome;
            Rua = rua;
            Numero = numero;
            Bairro = bairro;
            Complemento = complemento;
            CEP = cEP;
            Cidade = cidade;
            Estado = estado;
            Telefone = telefone;
            Email = email;
            Ativo = ativo;
        }

        public Aluno(string cpf)
        {
            setCPF(cpf);
        }
        
        public Aluno()
        {

        }

        public bool cadastrarAluno()
        {
            bool cad = false;
            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand insere = new MySqlCommand("INSERT INTO Estudio_Aluno(CPFAluno, nomeAluno, ruaAluno, numeroAluno, bairroAluno, complementoAluno, CEPAluno, cidadeAluno, estadoAluno, telefoneAluno, emailAluno) VALUES ('" + CPF + "','" + Nome + "','" + Rua + "','" + Numero + "','" + Bairro + "','" + Complemento + "','" + CEP + "','" + Cidade + "','" + Estado + "','" + Telefone + "','" + Email + "')", DAO_Conexao.con);
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

        public bool consultarAluno()
        {
            bool existe = false;
            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand consulta = new MySqlCommand("SELECT * FROM Estudio_Aluno " + "WHERE CPFAluno='" + CPF + "'", DAO_Conexao.con);
                MySqlDataReader resultado = consulta.ExecuteReader();
                if (resultado.Read())
                    existe = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                DAO_Conexao.con.Close();
            }

            return existe;
        }  

        public bool excluirAluno()
        {
            bool exc = false;

            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand exclui = new MySqlCommand("UPDATE Estudio_Aluno set ativo = 1 WHERE CPFAluno = '" + CPF + "'", DAO_Conexao.con);
                exclui.ExecuteNonQuery();
                exc = true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            finally
            {
                DAO_Conexao.con.Close();
            }
            return exc;
        }

            //public bool verificaCPF() //string CPF - sem parametros;

            public void setCPF(string cPF)
        {
            this.CPF = cPF;
        }
        public void setNome(string nome)
        {
            this.Nome = nome;
        }
        public void setRua(string rua)
        {
            this.Rua = rua;
        }
        public void setNumero(string numero)
        {
            this.Numero = numero;
        }
        public void setBairro(string bairro)
        {
            this.Bairro = bairro;
        }
        public void setComplemento(string complemento)
        {
            this.Complemento = complemento;
        }
        public void setCEP(string cEP)
        {
            this.CEP = cEP;
        }
        public void setCidade(string cidade)
        {
            this.Cidade = cidade;
        }
        public void setEstado(string estado)
        {
            this.Estado = estado;
        }
        public void setTelefone(string telefone)
        {
            this.Telefone = telefone;
        }
        public void setEmail(string email)
        {
            this.Email = email;
        }
        //public void setFoto(byte foto)
        //{
        //    this.Foto = foto;
        //}
        public void setAtivo(int ativo)
        {
            this.Ativo = ativo;
        }

        public string getCPF()
        {
            return CPF;
        }
        public string getNome()
        {
            return Nome;
        }
        public string getRua()
        {
            return Rua;
        }
        public string getNumero()
        {
            return Numero;
        }
        public string getBairro()
        {
            return Bairro;
        }
        public string getComplemento()
        {
            return Complemento;
        }
        public string getCEP()
        {
            return CEP;
        }
        public string getCidade()
        {
            return Cidade;
        }
        public string getEstado()
        {
            return Estado;
        }
        public string getTelefone()
        {
            return Telefone;
        }
        public string getEmail()
        {
            return Email;
        }
        public int getAtivo()
        {
            return Ativo;
        }
    }
}

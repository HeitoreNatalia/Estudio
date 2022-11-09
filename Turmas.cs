using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudio
{
    class Turmas
    {

        private int id_turma;
        private int id_modalidade;
        private string professor;
        private string dia_semana;
        private string horas;
        private int alunos_matriculas;

        public Turmas(int id_turma, int id_modalidade, string professor, string dia_semana, string horas, int alunos_matriculas)
        {
            this.id_turma = id_turma;
            this.id_modalidade = id_modalidade;
            this.professor = professor;
            this.dia_semana = dia_semana;
            this.horas = horas;
            this.alunos_matriculas = alunos_matriculas;
        }

        public int Id_turma { get => id_turma; set => id_turma = value; }
        public int Id_modalidade { get => id_modalidade; set => id_modalidade = value; }
        public string Professor { get => professor; set => professor = value; }
        public string Dia_semana { get => dia_semana; set => dia_semana = value; }
        public string Horas { get => horas; set => horas = value; }
        public int Alunos_matriculas { get => alunos_matriculas; set => alunos_matriculas = value; }
    }
}

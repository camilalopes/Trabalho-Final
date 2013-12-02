using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialSis
{
    class Aluno:Cliente
    {
        private string horario;
        private string periodo;
        private string curso;

        public Aluno() { }

        /* public Aluno(string nome, ulong cpf, string rg, string email, ulong tel, string endereco, DateTime prevPagamento,
             DateTime dataNasc, string horario, string periodo, string curso)
             : base(nome, cpf, rg, email, tel, endereco, prevPagamento, dataNasc)
         {
             Horario = horario;
             Periodo = periodo;
             Curso = curso;
         }*/

        public string Horario
        {
            get { return horario; }
            set { horario = value; }
        }

        public string Periodo
        {
            get { return periodo; }
            set { periodo = value; }
        }

        public string Curso
        {
            get { return curso; }
            set { curso = value; }
        }
    }
}

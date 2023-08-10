using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade12PRJ
{
    public class Correntistas
    {

        public int ID { get; set; }
        public string Nome { get; set; }
        public int Cpf { get; set;}
        public DateTime DataDeNascimento { get; set;}
        public int RendaMensal { get; set;}


        public Correntistas(int id, string nome, int cpf,DateTime datadenascimento, int rendamensal)
        {
            
            this.ID = id;
            this.Nome = nome;
            this.Cpf = cpf;
            this.DataDeNascimento = datadenascimento;
            this.RendaMensal = rendamensal;

        }


    }
}

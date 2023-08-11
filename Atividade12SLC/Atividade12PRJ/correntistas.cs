using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;


namespace Atividade12PRJ
{
    public class Correntistas
    {

        public int? IDcorrentista { get; set; }
        public string Nome { get; set;}
        public int Cpf { get; set; }
        public DateTime DataDeNascimento { get; set; }
        public double RendaMensal { get; set; }

        
        
        public Correntistas(int v, string text)
        {
            int idade;
            IDcorrentista = IDcorrentista ++;
            idade = Convert.ToInt32(DateTime.Now - DataDeNascimento);
        }
                
        public Correntistas(int idcorrentista, string nome, int cpf, DateTime datadenascimento, double rendamensal)
        {

            this.IDcorrentista = idcorrentista;
            this.Nome = nome;
            this.Cpf = cpf;
            this.DataDeNascimento = datadenascimento;
            this.RendaMensal = rendamensal;

        }


         public bool Ehmaior()
        {
            DateTime dataatual = DateTime.Now;


            int idade = dataatual.Year - this.DataDeNascimento.Year;

            if (idade > 0)



            return
        }











    }
    
}

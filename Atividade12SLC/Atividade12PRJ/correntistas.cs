using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.AccessControl;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;


namespace Atividade12PRJ
{
    public class Correntistas
    {
        private double renda;

        public int? IDcorrentista 
        { 
            get 
            {

                return IDcorrentista;
            
            } 
            set 
            {
            
            
            } 
        }
        public string Nome { get; set;}
        public string Cpf { get; set; }
        public DateTime DataDeNascimento { get; set; }
        public double RendaMensal { get; set; }



        public Correntistas(int v, string text)
        {
            int idade;
            IDcorrentista = IDcorrentista ++;
            idade = Convert.ToInt32(DateTime.Now - DataDeNascimento);
        }
         
        

        public Correntistas(int idcorrentista, string nome, string cpf, DateTime datadenascimento, double rendamensal )
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

            if (dataatual.Month < this.DataDeNascimento.Month ||
                (dataatual.Month == DataDeNascimento.Month && dataatual.Day < DataDeNascimento.Day))
            {

                idade = idade - 1;

            }

            if (idade >= 18)
            {

                return true;

            }
            else
            {
                return false;
            }

         }




         public string mostrarRank() 
         {
 
                if (RendaMensal <= 3000)
                {

                    return "Rank: Silver";

                }
                else if (RendaMensal > 3000 && RendaMensal <= 5000)
                {

                    return "Rank: Gold";

                }
                else if (RendaMensal > 5000 && RendaMensal <= 10000)
                {

                    return "Rank: Diamond";

                }
                else
                {

                    return "Rank: Black";

                }
                
         }

         public string mensagendebemvindo()
         {


            return $"olá {Nome}\nbem vindo ao banco\nNivel de cliente: {mostrarRank()}";



         }









    }
    
}

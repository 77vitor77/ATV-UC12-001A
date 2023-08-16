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
        private double _RendaMensal;
        private string _Nome;
        private DateTime _Datadenascimento;



        public int? IDcorrentista { get; set;  }
        public string Nome 
        {
            get
            {

                return _Nome; 
            
            }
            set
            {
                if  (value == string.Empty ) 
                {

                    MessageBox.Show("caixa de nome não pode ficar vazio");
                
                }


            }    
                
        }
        public string Cpf { get; set; }
        public DateTime DataDeNascimento
        {
            get
            {

                return _Datadenascimento;

            }
            set
            {
                if (value > DateTime.Now)
                {

                    MessageBox.Show("Data de nascimento não pode ser maio que a data de hoje ");

                }
                else
                {

                    this._Datadenascimento = value;

                }

            }

        }
        public double RendaMensal { get; set; }
        public int Totaldeclientes { get; set; }


        public Correntistas(int v, string text)
        {
            int idade;
            IDcorrentista = IDcorrentista ++;
            idade = Convert.ToInt32(DateTime.Now - DataDeNascimento);
        }



        public Correntistas(string nome, string cpf, DateTime datadenascimento, double rendamensal)
        {
            this.Totaldeclientes = Totaldeclientes + 1;
            this.IDcorrentista = Totaldeclientes ;
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


            return $"olá {Nome}\nbem vindo ao banco\nNivel de cliente: {mostrarRank()}\nID de usuario ={IDcorrentista}";



         }

         public string doiscorrentistas()
         {          



         }








    }
    
}

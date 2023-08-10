using System;
using System.Collections.Generic;
using System.Linq;
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
        public int RendaMensal { get; set; }

        
        
        public Correntistas()
        {
            int idade;
            IDcorrentista = IDcorrentista ++;
            idade = Convert.ToInt32(DateTime.Now - DataDeNascimento);
        }
                
        public Correntistas(int idcorrentista, string nome, int cpf, DateTime datadenascimento, int rendamensal)
        {

            this.IDcorrentista = idcorrentista;
            this.Nome = nome;
            this.Cpf = cpf;
            this.DataDeNascimento = datadenascimento;
            this.RendaMensal = rendamensal;

        }


        public int VerificaçãoDeIdade(int idade)
        {

            if (idade < 18)
            {
                throw new Exception("Idade menor que 18 anos");
            }
            else
            {
                return idade;
            }
            
        }


    }
    
}

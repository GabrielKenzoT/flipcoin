using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace flipcoin.Models
{
    public class Coin
    {
        private string Lado { get; set; }
        private string LadoEscolhido { get; set; }

        public Coin()
        {

        }

        public string Jogar()
        {   


            string resultado = new Random.Next(2) ;
           
        }

    }
}

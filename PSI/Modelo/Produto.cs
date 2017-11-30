using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PSI.Modelo
{
    public class Produto
    {
        public int codigo { get; set; }
        public string nome { get; set; }

        public Produto()
        {
            this.codigo = 0;
            this.nome = "";
        }

        public Produto(int acodigo, string anome)
        {
            this.codigo = acodigo;
            this.nome = anome;
        }
    }
}
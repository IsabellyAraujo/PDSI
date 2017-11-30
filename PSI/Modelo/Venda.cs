using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PSI.Modelo
{
    public class Venda
    {
        public int codigo { get; set;}
        public DateTime horaVenda { get; set; }
        public float desconto { get; set; }
        public float valorTotal { get; set; }

        public Venda()
        {
            this.codigo = 0;
            this.desconto = 0;
            this.valorTotal = 0;
        }

        public Venda(int acodigo, float adesconto, float avalorTotal)
        {
            this.codigo = acodigo;
            this.desconto = adesconto;
            this.valorTotal = avalorTotal;
        }
        public Venda(int acodigo, DateTime ahoraVenda, float adesconto, float avalorTotal)
        {
            this.codigo = acodigo;
            this.horaVenda = ahoraVenda;
            this.desconto = adesconto;
            this.valorTotal = avalorTotal;
        }
    }
}
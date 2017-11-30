using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PSI.Modelo
{
    public class Compra
    {
        public int codigo { get; set;}
        public DateTime horaCompra { get; set; }
        public float desconto { get; set; }
        public float valorTotal { get; set; }

        public Compra()
        {
            this.codigo = 0;
            this.desconto = 0;
            this.valorTotal = 0;
        }

        public Compra(int acodigo, float adesconto, float avalorTotal)
        {
            this.codigo = acodigo;
            this.desconto = adesconto;
            this.valorTotal = avalorTotal;
        }
        public Compra(int acodigo, DateTime ahoraCompra, float adesconto, float avalorTotal)
        {
            this.codigo = acodigo;
            this.horaCompra = ahoraCompra;
            this.desconto = adesconto;
            this.valorTotal = avalorTotal;
        }
    }
}
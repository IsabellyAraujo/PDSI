using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PSI.Modelo
{
    public class Funcionario
    {
        public int codigo { get; set;}
        public string nome { get; set; }
        public string rg { get; set; }
        public string clt { get; set; }
        public float salario { get; set; }
        public bool motorista { get; set; }
        public bool tecnico { get; set; }
        public string observacao { get; set; }

        public Funcionario()
        {
            this.codigo = 0;
            this.nome = "";
            this.rg = "";
            this.clt = "";
            this.salario = 0;
            this.motorista = false;
            this.tecnico = false;
            this.observacao = "";
        }

        public Funcionario(int acodigo, string anome, string arg, string aclt, float asalario, bool amotorista, bool atecnico, string aobservacao)
        {
            this.codigo = acodigo;
            this.nome = anome;
            this.rg = arg;
            this.clt = aclt;
            this.salario = asalario;
            this.motorista = amotorista;
            this.tecnico = atecnico;
            this.observacao = aobservacao;
        }
    }
}
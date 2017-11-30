using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PSI.Modelo
{
    public class Cliente
    {
        public int codigo { get; set;}
        public string nome { get; set; }
        public string cpf { get; set; }
        public string cidade { get; set; }
        public string estado { get; set; }
        public string email { get; set; }
        public string endereco { get; set; }
        public string telefone { get; set; }

        public Cliente()
        {
            this.codigo = 0;
            this.nome = "";
            this.cpf = "";
            this.cidade = "";
            this.estado = "";
            this.email = "";
            this.endereco = "";
            this.telefone = "";
        }

        public Cliente(int acodigo, string anome, string acpf, string acidade, string aestado, string aemail, string aendereco, string atelefone)
        {
            this.codigo = acodigo;
            this.nome = anome;
            this.cpf = acpf;
            this.cidade = acidade;
            this.estado = aestado;
            this.email = aemail;
            this.endereco = aendereco;
            this.telefone = atelefone;
        }
        public Cliente(string anome, string acpf, string acidade, string aestado, string aemail, string aendereco, string atelefone)
        {
            this.nome = anome;
            this.cpf = acpf;
            this.cidade = acidade;
            this.estado = aestado;
            this.email = aemail;
            this.endereco = aendereco;
            this.telefone = atelefone;
        }
       
        public Cliente(string anome, string acpf, string aemail)
        {
            this.nome = anome;
            this.cpf = acpf;
            this.email = aemail;
        }
        public Cliente(int acodigo)
        {
            this.codigo = acodigo;
        }
    }
}
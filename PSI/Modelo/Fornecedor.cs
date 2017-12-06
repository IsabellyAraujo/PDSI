using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PSI.Modelo
{
    public class Fornecedor
    {
        
        public int codigo { get; set;}
        public string nome { get; set; }
        public string cpf { get; set; }
        public string cidade { get; set; }
        public string estado { get; set; }
        public string email { get; set; }
        public string telefone { get; set; }

        public Fornecedor()
        {
            this.codigo = 0;
            this.nome = "";
            this.cpf = "";
            this.cidade = "";
            this.estado = "";
            this.email = "";
            this.telefone = "";
        }

        public Fornecedor(int acodigo, string anome, string acpf, string acidade, string aestado, string aemail, string atelefone)
        {
            this.codigo = acodigo;
            this.nome = anome;
            this.cpf = acpf;
            this.cidade = acidade;
            this.estado = aestado;
            this.email = aemail;
            this.telefone = atelefone;
        }
        public Fornecedor(string anome, string acpf, string acidade, string aestado, string aemail, string atelefone)
        {
            this.nome = anome;
            this.cpf = acpf;
            this.cidade = acidade;
            this.estado = aestado;
            this.email = aemail;
            this.telefone = atelefone;
        }
        public Fornecedor(string anome, string acpf, string aemail)
        {
            this.nome = anome;
            this.cpf = acpf;
            this.email = aemail;
        }
    }
}
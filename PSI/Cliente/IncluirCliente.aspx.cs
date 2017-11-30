using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PSI.Cliente
{
    public partial class IncluirCliente : System.Web.UI.Page
    {
    
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            DAL.DALCliente DALCliente = new DAL.DALCliente();
            Modelo.Cliente cliente = new Modelo.Cliente(TextBoxNome.Text, TextBoxCPF.Text, TextBoxCidade.Text, TextBoxEstado.Text, TextBoxEmail.Text, TextBoxEndereco.Text, TextBoxTelefone.Text);
            DALCliente.Insert(cliente);

            Response.Redirect("~\\CadastroCliente.aspx");
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PSI.Fornecedor
{
    public partial class IncluirFornecedor : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            DAL.DALFornecedor DALFornecedor = new DAL.DALFornecedor();
            Modelo.Fornecedor fornecedor = new Modelo.Fornecedor(TextBoxNome.Text, TextBoxCPF.Text, TextBoxCidade.Text, TextBoxEstado.Text, TextBoxEmail.Text, TextBoxTelefone.Text);
            DALFornecedor.Insert(fornecedor);
            Response.Redirect("~/Cliente/Cadastro_Fornecedor.aspx");
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PSI
{
    public partial class Cadastro_Fornecedor : System.Web.UI.Page
    {
        int fornecedor_id;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void LinkButton2_PreRender(object sender, EventArgs e)
        {
            (sender as LinkButton).CommandName = fornecedor_id.ToString();
        }

        protected void LinkButton2_Click(object sender, EventArgs e)
        {
            DAL.DALFornecedor DALFornecedor = new DAL.DALFornecedor();
            Modelo.Fornecedor fornecedor = new Modelo.Fornecedor(int.Parse((sender as LinkButton).CommandName));
            DALFornecedor.Delete(fornecedor);
            Response.Redirect("~/AnotacaoETarefa.aspx");
        }

       

        
    }
}
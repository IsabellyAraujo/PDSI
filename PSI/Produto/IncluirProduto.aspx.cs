using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PSI.Produto
{
    public partial class IncluirProduto : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            DAL.DALProduto DALProduto = new DAL.DALProduto();
            Modelo.Produto produto = new Modelo.Produto(TextBoxNome.Text);
            DALProduto.Insert(produto);

            Response.Redirect("~\\Produto\\CadastroProduto.aspx");
        }
    }
}
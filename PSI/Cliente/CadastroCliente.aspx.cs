using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PSI
{
    public partial class Cadastro_Cliente : System.Web.UI.Page
    {
       int cliente_id;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void LinkButton2_Click(object sender, EventArgs e)
        {
           DAL.DALCliente DALCliente = new DAL.DALCliente();
           Modelo.Cliente cliente = new Modelo.Cliente(int.Parse((sender as LinkButton).CommandName));
           /*DALCliente.Delete(cliente);*/
            Response.Redirect("~\\Cliente\\CadastroCliente.aspx");
        }

        protected void LinkButton2_PreRender(object sender, EventArgs e)
        {
            (sender as LinkButton).CommandName = cliente_id;
        }

       
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class paginas_Colecionador : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        /*
        if (Session["usr_nome"] == null || Session["tpu_tipo_usuario"] == null)
        {
            Response.Redirect("pg/Erro.aspx");
        }
        else
        {
            ltlEmail.Text = Session["usr_nome"].ToString();
        }
        */
    }

    protected void btnSair_Click(object sender, EventArgs e)
    {
        /*
        Session.Remove("usr_nome");
        Response.Redirect("home.aspx");
        */
    }
}
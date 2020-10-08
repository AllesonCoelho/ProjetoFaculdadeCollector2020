using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class paginas_admin_tabelas_CarregarUsuario : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        DataSet ds = UsuarioDB.SelectAll();
        int usr = ds.Tables[0].Rows.Count;

        if (usr > 0)
        {
            grvUsuario.DataSource = ds.Tables[0].DefaultView;
            grvUsuario.DataBind();
            grvUsuario.Visible = true;
            ltlqtdUsuario.Text = "Foram encontrados " + usr + " registros";
        }
        else
        {
            grvUsuario.Visible = false;
            ltlqtdUsuario.Text = "Não foram encontrados registros";
        }

    }
}
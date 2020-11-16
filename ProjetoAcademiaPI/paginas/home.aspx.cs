using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data;

public partial class paginas_home : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
    }

    protected void btn_Click(object sender, EventArgs e)
    {
        DataSet ds = UsuarioDB.SelectLOGIN(txbEmail.Text, txbSenha.Text);
        if (ds.Tables[0].Rows.Count == 1)
        {
            Session["usr_nome"] = ds.Tables[0].Rows[0]["usr_nome"].ToString();
            Session["tpu_tipo_usuario"] = ds.Tables[0].Rows[0]["tpu_pk"].ToString();
            int tpu = Convert.ToInt32(Session["tpu_tipo_usuario"]);
            if (tpu == 1)
            {

                Response.Redirect("admin/tabelas/CarregarUsuario.aspx");
            }
            if (tpu == 2)
            {
                Response.Redirect("Colecionador.aspx");
            }
        }
        else
        {
            Response.Redirect("Erro.aspx");
        }
    }
}
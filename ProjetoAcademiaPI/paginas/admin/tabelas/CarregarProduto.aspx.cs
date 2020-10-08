using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class paginas_admin_tabelas_CarregarProduto : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        DataSet ds = ProdutoDB.SelectAll();
        DataSet dsm = MidiaDB.SelectAll();
        int pdt = ds.Tables[0].Rows.Count;
        int midia = dsm.Tables[0].Rows.Count;

        if (pdt > 0)
        {
            grvProduto.DataSource = ds.Tables[0].DefaultView;
            grvProduto.DataBind();
            grvProduto.Visible = true;

            ltlqtdProduto.Text = "Foram encontrados " + pdt + " registros";
        }
        else
        {
            grvProduto.Visible = false;
            ltlqtdProduto.Text = "Não foram encontrados registros";
        }

    }
}
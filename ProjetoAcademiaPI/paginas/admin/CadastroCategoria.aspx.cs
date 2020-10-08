using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class paginas_admin_CadastroCategoria : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btn_Click(object sender, EventArgs e)
    {
        Categoria ctg = new Categoria();
        ctg.Ctg_tipo = txbTipo.Text;
        ctg.Ctg_info = txbInfo.Text;

        switch (CategoriaDB.Insert(ctg))
        {
            case 0:
                ltlMSG.Text = "<div class='alert alert-success btn-block'> >>>> OK <<<< </div>";
                txbTipo.Text = "";
                break;
            case -2:
                ltlMSG.Text = "<div class='alert alert-danger form-control'> >>>> ERRO <<<< </div>";
                txbTipo.Text = "";
                break;
        }

    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class paginas_admin_CadastroTpu : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btn_Click(object sender, EventArgs e)
    {
        Tpu tpu = new Tpu();
        tpu.Tpu_descricao = txbTpu.Text;

        switch (TpuDB.Insert(tpu))
        {
            case 0:
                ltlMSG.Text = "<div class='alert alert-success btn-block'> >>>> OK <<<< </div>";
                txbTpu.Text = "";
                break;
            case -2:
                ltlMSG.Text = "<div class='alert alert-danger form-control'> >>>> ERRO <<<< </div>";
                txbTpu.Text = "";
                break;
        }
    }
}
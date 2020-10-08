using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.IO;

public partial class paginas_CadastrarItem : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        if (!IsPostBack)
        {
            CarregarDDL();
        }

    }

    public void CarregarDDL()
    {
        DataSet ds = CategoriaDB.SelectAll();

        ddlCtg.DataSource = ds;
        ddlCtg.DataTextField = "ctg_tipo";
        ddlCtg.DataValueField = "ctg_pk";
        ddlCtg.DataBind();
    }


    protected void btnCadastrar_Click(object sender, EventArgs e)
    {
        Produto pdt = new Produto();

        pdt.Pdt_nome = txbNome.Text;
        pdt.Pdt_categoria = ddlCtg.Text;
        pdt.Pdt_preco = Convert.ToDouble(txbPreco.Text);
        pdt.Pdt_maiores = ddlMaiores.Text;
        pdt.Pdt_status = ddlStatus.Text;
        pdt.Pdt_descricao = txbDescricao.Text;
        pdt.Usr_pk = new Usuario();
        pdt.Usr_pk.Usr_pk = 1; // depois colocar usuário logado   Session["Usu_id"]
        pdt.Pdt_pk= ProdutoDB.Insert(pdt);
        if (pdt.Pdt_pk > 0)
        {
            Midia midia = new Midia();
            midia.Pdt_pk = pdt;
            midia.Tmd_pk = new Tmd();
            midia.Tmd_pk.Tmd_pk = 1;
            midia.Mid_descricao = imgArquivo.ImageUrl;

            MidiaDB.Insert(midia);
        }
        else
        {
            //Não funcionou insert
        }
        


    }



    protected void btnVisualizar_Click(object sender, EventArgs e)
    {
        string path = Path.Combine(Request.PhysicalApplicationPath, "Upload");
        if (fileArquivo.HasFile)
        {
            string extensao = System.IO.Path.GetExtension(fileArquivo.FileName).ToLower();
            string[] extensoesPermitidas = { ".gif", ".png", ".jpeg", ".jpg" };
            if (extensoesPermitidas.Contains(extensao))
            {
                try
                {
                    string fileName = fileArquivo.FileName;
                    string caminhoUpload = Path.Combine(path, fileName);
                    if (File.Exists(caminhoUpload))
                    {
                        fileName = DateTime.Now.TimeOfDay.TotalMilliseconds + fileArquivo.FileName;
                        caminhoUpload = Path.Combine(path, fileName);
                    }
                    fileArquivo.PostedFile.SaveAs(caminhoUpload);

                    string imagemRelativePath = Path.Combine("Upload", fileName);
                    string urlImage = Page.ResolveUrl(imagemRelativePath);

                    imgArquivo.ImageUrl = urlImage;

                    lblMsg.Text = "Arquivo: " + fileName;
                    lblMsg.Text += " postado em: " + caminhoUpload;
                }
                catch (Exception ex)
                {
                    lblMsg.Text = "Erro arquivo:" + ex.Message;
                }
            }
            else
                lblMsg.Text = "Arquivo com extensão não permitida!";
        }
    }
}
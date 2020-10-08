using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class paginas_CadastrarUsuario : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnCadastrar_Click(object sender, EventArgs e)
    {
        Usuario usr = new Usuario();

        usr.Usr_nome = txbNome.Text;
        usr.Usr_email = txbEmail.Text;
        usr.Usr_rg = txbRg.Text;
        usr.Usr_cpf = txbCpf.Text;
        usr.Usr_endereco = txbEndereco.Text;
        usr.Usr_numero = txbNumero.Text;
        usr.Usr_bairro = txbBairro.Text;
        usr.Usr_cep = txbCep.Text;
        usr.Usr_cidade = ddlCidade.Text;
        usr.Usr_estado = ddlUf.Text;
        usr.Usr_telefone = txbTelefone.Text;
        usr.Usr_senha = txbSenha.Text;


        switch (UsuarioDB.Insert(usr))
        {
            case 0:
                ltlMsg.Text = "<div class='alert alert-success btn-block'> >>>> OK <<<< </div>";
                Limpar();
                break;
            case -2:
                ltlMsg.Text = "<div class='alert alert-danger form-control'> >>>> ERRO <<<< </div>";
                Limpar();
                break;
        }

    }

    void Limpar()
    {
        txbNome.Text = "";
        txbEmail.Text = "";
        txbRg.Text = "";
        txbCpf.Text = "";
        txbEndereco.Text = "";
        txbNumero.Text = "";
        txbBairro.Text = "";
        txbCep.Text = "";
        ddlCidade.Text = "";
        ddlUf.Text = "";
        txbTelefone.Text = "";
    }
}
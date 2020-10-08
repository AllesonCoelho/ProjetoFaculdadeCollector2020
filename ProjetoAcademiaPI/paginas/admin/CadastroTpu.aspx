<%@ Page Title="" Language="C#" MasterPageFile="~/MasterAdministracao.master" AutoEventWireup="true" CodeFile="CadastroTpu.aspx.cs" Inherits="paginas_admin_CadastroTpu" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="container">
        <div class="row">
            <div class="col-12 text-center mt-5">
                <h2>Cadastro de Perfil</h2>
            </div>
            <div class="col-12 mt-5">
                <label>Usuario</label>
                <asp:TextBox runat="server" ID="txbTpu" CssClass="form-control" required="required" placeholder="Usuario..."></asp:TextBox>
            </div>
            <div class="col-12 mt-5">
                <asp:Button runat="server" ID="btn" Text="Salvar" CssClass="btn btn-primary" OnClick="btn_Click" />
            </div>
            <div class="col-12 m-5 p-5">
                <asp:Literal runat="server" ID="ltlMSG"></asp:Literal>
            </div>
        </div>
    </div>    
</asp:Content>


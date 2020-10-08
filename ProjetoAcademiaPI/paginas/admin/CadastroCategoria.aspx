<%@ Page Title="" Language="C#" MasterPageFile="~/MasterAdministracao.master" AutoEventWireup="true" CodeFile="CadastroCategoria.aspx.cs" Inherits="paginas_admin_CadastroCategoria" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="container">
        <div class="row">
            <div class="col-12 text-center mt-5">
                <h2>Cadastro de categoria</h2>
            </div>
            <div class="col-12 mt-5">
                <label>Adcione aqui nova Categoria</label>
                <asp:TextBox runat="server" ID="txbTipo" CssClass="form-control" required="required" placeholder="Categoria..."></asp:TextBox>
                <label>Adcione aqui informação adicional</label>
                <asp:TextBox runat="server" ID="txbInfo" CssClass="form-control" required="required" placeholder="Categoria..."></asp:TextBox>
            </div>
            <div class="col-12 mt-5">
                <asp:Button runat="server" ID="btn" Text="Salvar" CssClass="btn btn-primary" Onclick="btn_Click" />
            </div>
            <div class="col-12 m-5 p-5">
                <asp:Literal runat="server" ID="ltlMSG"></asp:Literal>
            </div>
        </div>
    </div>    
</asp:Content>


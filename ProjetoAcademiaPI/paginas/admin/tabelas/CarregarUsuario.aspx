<%@ Page Title="" Language="C#" MasterPageFile="~/MasterTabelas.master" AutoEventWireup="true" CodeFile="CarregarUsuario.aspx.cs" Inherits="paginas_admin_tabelas_CarregarUsuario" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
     <div class="col-md-12">
        <h2>Carregar Grid</h2>
    </div>
    <div class="col-md-12">
        <asp:GridView ID="grvUsuario" runat="server" CssClass="table table-responsive table-hover" AutoGenerateColumns="true">
            <Columns>
                <asp:BoundField DataField="usr_pk" HeaderText="Id" />
                <asp:BoundField DataField="usr_nome" HeaderText="Nome" />
                <asp:BoundField DataField="usr_email" HeaderText="Email" />
                <asp:BoundField DataField="usr_rg" HeaderText="RG" />
                <asp:BoundField DataField="usr_cpf" HeaderText="CPF" />
                <asp:BoundField DataField="usr_endereco" HeaderText="Endereco" />
                <asp:BoundField DataField="usr_numero" HeaderText="Numero" />
                <asp:BoundField DataField="usr_bairro" HeaderText="Bairro" />
                <asp:BoundField DataField="usr_cep" HeaderText="CEP" />
                <asp:BoundField DataField="usr_cidade" HeaderText="Cidade" />
                <asp:BoundField DataField="usr_estado" HeaderText="Estado" />
                <asp:BoundField DataField="usr_telefone" HeaderText="Telefone" />
                <asp:BoundField DataField="usr_senha" HeaderText="Senha" />
            </Columns>
        </asp:GridView>
        <asp:Literal runat="server" ID="ltlqtdUsuario"></asp:Literal>
        
    </div>
</asp:Content>


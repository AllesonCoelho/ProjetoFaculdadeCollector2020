<%@ Page Title="" Language="C#" MasterPageFile="~/MasterTabelas.master" AutoEventWireup="true" CodeFile="CarregarProduto.aspx.cs" Inherits="paginas_admin_tabelas_CarregarProduto" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="col-md-12">
        <h2>Carregar Grid</h2>
    </div>
    <div class="col-md-12">
        <asp:GridView ID="grvProduto" runat="server" CssClass="table table-responsive table-hover" AutoGenerateColumns="true">
            <Columns>
                <asp:BoundField DataField="pdt_pk" HeaderText="Id" />
                <asp:BoundField DataField="pdt_nome" HeaderText="Nome" />
                <asp:BoundField DataField="pdt_categoria" HeaderText="Categoria" />
                <asp:BoundField DataField="pdt_descricao" HeaderText="Descricao" />
                <asp:BoundField DataField="pdt_preco" HeaderText="Preco" />
                <asp:BoundField DataField="pdt_maiores" HeaderText="Para maiores" />
                <asp:BoundField DataField="pdt_status" HeaderText="Status" />
                <asp:BoundField DataField="usr_pk" HeaderText="User ID" />
                <asp:BoundField DataField="mid_pk" HeaderText="Midia ID" />
                <asp:BoundField DataField="mid_descricao" HeaderText="Midia Path"/>

                <asp:TemplateField>
                    <ItemTemplate>
                        <img runat="server" ID="image"/>
                    </ItemTemplate>
                </asp:TemplateField>

          
            </Columns>
        </asp:GridView>
        <asp:Literal runat="server" ID="ltlqtdProduto"></asp:Literal>
        
    </div>
</asp:Content>


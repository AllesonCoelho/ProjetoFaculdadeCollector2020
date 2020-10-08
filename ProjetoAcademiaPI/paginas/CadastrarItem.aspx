<%@ Page Title="" Language="C#" MasterPageFile="~/CadastrarItem.master" AutoEventWireup="true" CodeFile="CadastrarItem.aspx.cs" Inherits="paginas_CadastrarItem" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="container">
        <%-- <h1 class="text-center">INFORMAÇÕES PESSOAIS</h1>--%>

        <div class="col-12">
                <h1 class="display-4 text-center">Cadastrar produto</h1>
            </div>
            <hr>
        <div class="row">
        <form class="form-group margem-formulario">
            
                <div class="col-md-6 col-lg-6">
                    <div class="form-group">
                    <label class="">Nome: </label>
                    <asp:TextBox ID="txbNome" runat="server" CssClass="form-control" placeholder="Digite seu nome completo"></asp:TextBox>
                    </div>

                    <div class="form-group">
                    <label class="espaco-label">Categoria:</label>
                    <asp:DropDownList runat="server" ID="ddlCtg" CssClass="form-control"></asp:DropDownList>
                    </div>
                
                <div class="form-group">
                    <label class="">Preco: </label>
                    <asp:TextBox ID="txbPreco" type="number" runat="server" CssClass="form-control" placeholder="Preco"></asp:TextBox>
                    </div>
                <div class="form-group">
                    <label class="">Para maiores de 18 anos?</label>
                    <asp:DropDownList ID="ddlMaiores" runat="server" CssClass="form-control">
                        <asp:ListItem Value="0">Selecione a opção</asp:ListItem>
                        <asp:ListItem>Sim</asp:ListItem>
                        <asp:ListItem>Não</asp:ListItem>
                    </asp:DropDownList>
                </div>
                </div>

           


                <div class="col-md-6 col-lg-6 col-sm-6">
                    <div class="form-group">
                    <label class="">Status: </label>
                    <asp:DropDownList ID="ddlStatus" runat="server" CssClass="form-control">
                        <asp:ListItem Value="0">Selecione o status do produto</asp:ListItem>
                        <asp:ListItem>Apenas venda</asp:ListItem>
                        <asp:ListItem>Apenas troca</asp:ListItem>
                        <asp:ListItem>Venda e troca</asp:ListItem>
                        <asp:ListItem>Venda ou troca</asp:ListItem>
                        <asp:ListItem>Apenas para exibição</asp:ListItem>
                    </asp:DropDownList>
                    </div>
                    <div class="form-group">
                    <label class="">Descrição: </label>
                    <asp:TextBox ID="txbDescricao" runat="server" TextMode="MultiLine" CssClass="form-control" placeholder="Coloque a descrição"></asp:TextBox>
                </div>
                </div>

                <div class="row">
                    <<asp:FileUpload ID="fileArquivo" runat="server" Width="100%" /><br />
                    <br />
                    <asp:Button ID="btnVisualizar" runat="server" Text="Visualizar" OnClick="btnVisualizar_Click" /><br />
                    <br />
                    <asp:Label class="espaco-label col-lg-1" ID="lblMsg" runat="server">Foto: </asp:Label><br />
                    <br />
                    <asp:Image ID="imgArquivo" runat="server" />

                    <br />

                    <br />

                </div>

                <asp:Button runat="server" ID="btnCadastrar" Text="Cadastrar" CssClass="btn btn btn-primary btn-sucess" OnClick="btnCadastrar_Click" />


            


        </form>
        </div>
    </div>
</asp:Content>


<%@ Page Title="" Language="C#" MasterPageFile="~/CadastrarItem.master" AutoEventWireup="true" CodeFile="CadastrarUsuario.aspx.cs" Inherits="paginas_CadastrarUsuario" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <div class="container">
        <%-- <h1 class="text-center">INFORMAÇÕES PESSOAIS</h1>--%>

        <div class="col-12">
                <h1 class="display-4 text-center">Cadastro</h1>
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
                    <label class="">RG: </label>
                    <asp:TextBox ID="txbRg" type="number" runat="server" CssClass="form-control" placeholder="Seu RG"></asp:TextBox>
                    </div>

                    <div class="form-group">
                    <label class="">CEP: </label>
                    <asp:TextBox ID="txbCep" runat="server" CssClass="form-control" placeholder="Coloque o seu CEP"></asp:TextBox>
                </div>

                <div class="form-group">
                    <label class="">Endereço: </label>
                    <asp:TextBox ID="txbEndereco" runat="server" CssClass="form-control" placeholder="Seu Endereço"></asp:TextBox>
                    
                </div>

                <div class="form-group">
                    <label class="">Numero: </label>
                    <asp:TextBox ID="txbNumero" runat="server" CssClass="form-control" placeholder="Digite seu número"></asp:TextBox>
                    
                </div>

                    <div class="form-group">
                    <label class="">Bairro: </label>
                    <asp:TextBox ID="txbBairro" runat="server" CssClass="form-control" placeholder="Seu bairro"></asp:TextBox>
                    
                </div>
                </div>

           


                <div class="col-md-6 col-lg-6 col-sm-6">
                    <div class="form-group">
                    <label class="espaco-label">Email: </label>
                    <asp:TextBox ID="txbEmail" runat="server" CssClass="form-control" placeholder="Digite seu email"></asp:TextBox>
                    </div>

                    <div class="form-group">
                    <label class="">CPF: </label>
                    <asp:TextBox ID="txbCpf" runat="server" CssClass="form-control" placeholder="Coloque o seu CPF"></asp:TextBox>
                </div>

                    

                     <div class="form-group">
                    <label class="">Estado: </label>
                    <asp:DropDownList ID="ddlUf" runat="server" CssClass="form-control">
                        <asp:ListItem Value="0">Selecione a opção</asp:ListItem>
                        <asp:ListItem>Rio de Janero</asp:ListItem>
                        <asp:ListItem>São Paulo</asp:ListItem>
                        <asp:ListItem>Minas Gerais</asp:ListItem>
                        <asp:ListItem>Espirito Santo</asp:ListItem>
                    </asp:DropDownList>
                </div>
                    <div class="form-group">
                    <label class="">Telefone: </label>
                    <asp:TextBox ID="txbTelefone" runat="server" CssClass="form-control" type="number" placeholder="Telefone"></asp:TextBox>
                </div>

                    <div class="form-group">
                    <label class="">Cidade: </label>
                    <asp:DropDownList ID="ddlCidade" runat="server" CssClass="form-control">
                        <asp:ListItem Value="0">Selecione a opção</asp:ListItem>
                        <asp:ListItem>Guaratinguetá</asp:ListItem>
                        <asp:ListItem>Cachoeira Paulista</asp:ListItem>
                        <asp:ListItem>Lorena</asp:ListItem>
                        <asp:ListItem>Cruzeiro</asp:ListItem>
                    </asp:DropDownList>
                </div>

                    
                    <div class="form-group">
                    <label class="">Senha: </label>
                    <asp:TextBox ID="txbSenha" runat="server" CssClass="form-control" type="Password" placeholder="Digite a senha"></asp:TextBox>
                </div>
                </div>

               

            


        </form>
        </div>

        <div class="row">
               <div class="col-lg-12 burron">
                   <asp:Button runat="server" ID="btnCadastrar" Text="Cadastrar" CssClass="btn btn-primary btn-block" OnClick="btnCadastrar_Click" />
                   <br />
                   <asp:Literal runat="server" ID="ltlMsg"></asp:Literal>

               </div>
               </div>
                   
    </div>


</asp:Content>


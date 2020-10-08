<%@ Page Language="C#" AutoEventWireup="true" CodeFile="home.aspx.cs" Inherits="paginas_home" %>

<!DOCTYPE html>


<html>
<head runat="server">
    <link href="../Content/bootstrap.min.css" rel="stylesheet" />
    <script src="../Scripts/jquery-3.0.0.min.js"></script>
    <script src="../Scripts/bootstrap.min.js"></script>
    <script src="../Scripts/popper.js"></script>
    <link href="../fontawesome-free-5.11.2-web/css/all.min.css" rel="stylesheet" />
    <link href="../Css/style.css" rel="stylesheet" />

    <title>Collector - Home</title>
</head>
<body>
    <nav class="navbar navbar-expand-md navbar-light bg-light sticky-top">
        <div class="container-fluid">
            <a class="navbar-brand" href="#">
                <img src="../Imagens/logo.png" /></a>
            <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarResponsive">
                <span class="navbar-toggler-icon"></span>
            </button>
            <div class="collpse navbar-collapse" id="navbarResponsive">
                <ul class="navbar-nav ml-auto">
                    <li class="nav-item active">
                        <a class="nav-link" href="#">Home</a>
                    </li>
                    <li class="nav-item">
                        <a class="nav-link" href="#">Sobre</a>
                    </li>
                    <li class="nav-item">
                        <a class="nav-link" href="Cadastro.aspx">Cadastro</a>
                    </li>
                    <li class="nav-item">
                        <a class="nav-link" href="#">Dúvidas</a>
                    </li>
                    <li class="nav-item">
                        <a class="nav-link" href="#">Contato</a>
                    </li>
                </ul>
            </div>

        </div>
    </nav>

    <div ID="slides" class="carousel slide" data-ride="carousel">
        <ul class="carousel-indicators">
            <li data-target="#slides" data-slide-to="0" class="active"></li>
            <li data-target="#slides" data-slide-to="1"></li>
            <li data-target="#slides" data-slide-to="2"></li>
        </ul>

        <div class="carousel-inner">
            <div class="carousel-item active">
                <img src="../Imagens/background.png" />
                <div class="carousel-caption">
                    <h1 class="display-2">Teste</h1>
                    <h3>Site Em Operação</h3>
                    <button type="button" class="btn btn-outline-light btn-lg" data-toggle="modal" data-target="#loginModal">Login</button>
                    <button type="button" class="btn btn-primary btn-lg">Cadastro</button>
                </div>
                <div class="modal fade" role="dialog" ID="loginModal">
                    <div class="modal-dialog">
                        <div class="modal-content">
                            <div class="modal-header">
                                <div class="text-center">
                                <h3 class="modal-title">Modal Login Form</h3>
                                </div>
                                <div>
                                <button type="button" class="close center-block" data-dismiss="modal">&times;</button>
                                </div>
                               

                            </div>
                            <form runat="server">
                            <div class="modal-body">
                                <div class="form-group" runat="server">
                                    <asp:TextBox ID="txbEmail" runat="server" CssClass="form-control" type="email" placeholder="Seu email">Email</asp:TextBox>
                              
                                </div>

                                <div class="form-group" runat="server">
                                <asp:TextBox ID="txbSenha" runat="server" type="password" CssClass="form-control" placeholder="Senha">Senha</asp:TextBox>
                                </div>

                            </div>
                            <div class="modal-footer">
                                <asp:Button ID="btn" runat="server" CssClass="btn btn-success" Text="Logar" OnClick="btn_Click"/>

                            </div>
                            </form>
                        </div>

                    </div>

                </div>
            </div>
            <div class="carousel-item">
                <img src="../Imagens/background2.png" />
            </div>
            <div class="carousel-item">
                <img src="../Imagens/background3.png" />
            </div>



        </div>

    </div>
    

    <div class="container-fluid">
        <div class=" row jumbotron">
            <div class="col-x2-12 col-sm-12 col-md-9 col-lg-9 col-xl-10">
                <p class="lead">
                    Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. 
                </p>
            </div>
            <div class="col-xs-12 col-sm-12 col-md-3 col-lg-3 col-xl-2">
                <a href="#">
                    <button type="button" class="btn btn-outline-secondary btn-lg">Web</button>
                </a>

            </div>
        </div>
    </div>

    <div class="container-fluid padding">
        <div class="row welcome text-center">
            <div class="col-12">
                <h1 class="display-4">Objetivo do Collector</h1>
            </div>
            <hr>
            <div class="col-12">
                <p class="lead">O Collector tem como princípio desenvolver um sistema Web e-commerce para compra, venda e troca de itens colecionáveis, usando um sistema único para que colecionadores possam se reunir entorno de uma plataforma para ampla divulgação. Tudo por meio de comércio eletrônico. </p>

            </div>


        </div>

    </div>
    

    <div class="container-fluid">
        <div class="row padding">
            <div class="col-lg-6">
                <h2>Problemetização</h2>
                <p>O problema é a falta de um sistema único para reunir a mais diversidades comunidades de colecionadores em uma específico para seu comércio e divulgação de itens colecionáveis. Pois a maioria dos colecionadores estão espalhados pelas mais diversas redes sociais, e-commerces e market places, que acabam gerando desinformação, preços inflacionados, difícil acesso a um certo item ou pouca procura por determinado item já que não possui divulgação necessária.</p>
                <br />
                <a href="#" class="btn btn-primary">Sobre</a>
            </div>

            <div class="col-lg-6">
                <img src="../Imagens/desk.png" class="img-fluid" />
            </div>

        </div>

    </div>

    <hr class="my-4" />

    

   

    <div class="container-fluid">
        <div class="row welcome text-center">
            <div class="col-12">
                <h1 class="display-4">Anunciando o seus itens</h1>

            </div>

            <hr />

        </div>

    </div>

    <div class="container-fluid">
        <div class="row padding">
            <div class="col-md-4">
                <div class="card">
                    <img class="card-img-top" src="../Imagens/team1.png" />
                    <div class="card-body">
                        <h4 class="card-title">Compre</h4>
                        <p class="card-text">Veja os itens que você pode comprar!</p>
                        

                    </div>

                </div>
            </div>
            <div class="col-md-4">
                <div class="card">
                    <img class="card-img-top" src="../Imagens/team2.png" />
                    <div class="card-body">
                        <h4 class="card-title">Venda</h4>
                        <p class="card-text">Venda os seus itens!</p>
                       

                    </div>

                </div>
            </div>
            <div class="col-md-4">
                <div class="card">
                    <img class="card-img-top" src="../Imagens/team3.png" />
                    <div class="card-body">
                        <h4 class="card-title">Troque</h4>
                        <p class="card-text">Troque seus itens com outros colecionadores!</p>


                    </div>

                </div>
            </div>



            <hr />

        </div>

    </div>

    <div class="container-fluid">
        <div class="row padding">
            <div class="col-lg-6">
                <h2>Exiba sua Coleção</h2>
                <p>O Collector tem como objetivo criar uma sistema de venda de objetos e itens colecionáveis através de um sistema e-commerce, como itens colecionáveis tanto como físicos e digitais, para que colecionadores consigam divulgar seu item para outros que possuam interesse, pois o mercado de colecionáveis não possui uma plataforma única e objetiva de divulgação de produtos para itens de colecionador.</p>

            </div>

            <div class="col-lg-6">
                <img src="../Imagens/bootstrap2.png" class="img-fluid" />
            </div>
            <hr class="my-4" />
        </div>

    </div>

    <div class="container-fluid padding">
        <div class="row text-center padding">
            <div class="col-12">
                <h2>Connect</h2>

            </div>

            <div class="col-12 social padding">
                <a href="#"><i class="fab fa-facebook"></i></a>
                <a href="#"><i class="fab fa-twitter"></i></a>
                <a href="#"><i class="fab fa-google-plus-g"></i></a>
                <a href="#"><i class="fab fa-instagram"></i></a>
                <a href="#"><i class="fab fa-youtube"></i></a>
            </div>

        </div>

    </div>

    <footer>
        <div class="container-fluid padding">
            <div class="row text-center">
                <div class="col-md-4">
                    <img src="../Imagens/w3newbie.png" />
                    <hr class="light" />
                    <p>777-777-777</p>
                    <p>alleson_henrique@hotmail.com</p>
                    <p>rua tal de tal</p>
                    <p>guara</p>

                </div>

                <div class="col-md-4">
                    <hr class="light" />
                    <h5>---------------</h5>
                    <hr class="light" />
                    <p>Segunda</p>
                    <p>Sabado</p>
                    <p>Domingo</p>
                </div>

                <div class="col-md-4">
                    <hr class="light" />
                    <h5>----------------</h5>
                    <hr class="light" />
                    <p>----------------</p>
                    <p>----------------</p>
                    <p>----------------</p>

                </div>

                <div class="col-12">
                    <hr class="light" />
                    <h5>---------------</h5>

                </div>

            </div>

        </div>

    </footer>




</body>
</html>

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Editar.aspx.cs" Inherits="PA_V.Editar" %>


<!DOCTYPE html>

<link href="//maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css" rel="stylesheet" id="bootstrap-css">
<script src="//maxcdn.bootstrapcdn.com/bootstrap/4.0.0/js/bootstrap.min.js"></script>
<script src="//code.jquery.com/jquery-1.11.1.min.js"></script>
<link href="Content/bootstrap.min.css" rel="stylesheet" />
<script src="Scripts/jquery-3.0.0.min.js"></script>

<!------ Include the above in your HEAD tag ---------->
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
</head>
<body>
    <div class="sidenav">
        <div class="login-main-text">
            <h2><strong style="color: #daa520">Sua Agenda Pessoal</strong></h2>
            <h3>Editar Evento</h3>
        </div>
    </div>
    <div class="main">
        <div class="col-md-6 col-sm-12">
            <div class="login-form">
                <form id="form1" runat="server" method="post">
                    <div class="form-group">
                        <label>Título</label>
                        <input type="text" runat="server" class="form-control" name="Nome" id="Nome" placeholder="Título do comprimisso" required="">
                    </div>
                    <div class="form-group">
                        <label>Data</label>
                        <input type="date" class="form-control" name="Data" id="Data">
                    </div>
                    <div class="form-group">
                        <label>Descrição</label>
                        <input type="text" class="form-control" name="Descricao" id="Descricao" placeholder="Descreva" required="">
                    </div>
                    <div class="form-group">
                        <label>Importância</label>
                        <asp:DropDownList runat="server" ID="ddlimportancia">
                            <asp:ListItem Value="0">-</asp:ListItem>
                            <asp:ListItem Value="1">Regular</asp:ListItem>
                            <asp:ListItem Value="2">Intermediária</asp:ListItem>
                            <asp:ListItem Value="3">SUPREMA</asp:ListItem>
                        </asp:DropDownList>
                    </div>
                    <asp:Button runat="server" ID="salvar" type="submit" OnClick="salvar_Click" class="btn btn-black" Text="Salvar" />
                    <a href="home.aspx" type="button" class="btn btn-black">Voltar</a>
                </form>
            </div>
        </div>
        <br />
        <footer class="main-footer">
            <b>Versão AC2 - </b>
            <strong>Copyright &copy; 2020 Sua Agenda Pessoal.</strong> Todos os direitos reservados.
        </footer>
    </div>
    <script>

    </script>
</body>



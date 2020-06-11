<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="PA_V.Login" %>

<!DOCTYPE html>

<link href="//maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css" rel="stylesheet" id="bootstrap-css">
<script src="//maxcdn.bootstrapcdn.com/bootstrap/4.0.0/js/bootstrap.min.js"></script>
<script src="//code.jquery.com/jquery-1.11.1.min.js"></script>
<link href="Content/bootstrap.min.css" rel="stylesheet" />
<script src="Scripts/jquery-3.0.0.min.js"></script>

<!------ Include the above in your HEAD tag ---------->
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
<div class="sidenav">
         <div class="login-main-text">
            <h2><strong style="color:#daa520">Sua Agenda Pessoal</strong></h2><h3>Tela de login</h3>
            <p>Entre ou se registre agora.</p>
         </div>
      </div>
      <div class="main">
         <div class="col-md-6 col-sm-12">
            <div class="login-form">
               <form id="form1" runat="server">
                  <div class="form-group">
                     <label>Nome</label>
                     <input type="text" class="form-control" name="Nome" id="Nome" placeholder="User Name">
                      
                  </div>
                  <div class="form-group">
                     <label>Senha</label>
                     <input type="password" class="form-control" name="Senha" id="Senha" placeholder="Password">
                  </div>
                  <asp:Button runat="server" ID="login" type="submit" Onclick="login_Click" class="btn btn-black" Text="Login" />
                  <asp:Button runat="server" ID="register" OnClick="register_Click" type="submit" class="btn btn-black" Text="Register" /> 
               </form>
            </div>
         </div>
          <br /><br /><br /><br /><br /><br />
        <footer class="main-footer">
            <b>Versão AC2 - </b>
            <strong>Copyright &copy; 2020 Sua Agenda Pessoal.</strong> Todos os direitos reservados.
        </footer>
      </div>
    </body>

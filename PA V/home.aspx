<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="home.aspx.cs" Inherits="PA_V.home" %>

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
            <h3>Veja seus compromissos</h3>
            <p>
                Com organização e tempo, acha-se o segredo de fazer tudo e bem feito.
                <br />
                <small>↑</small>
            </p>
        </div>
    </div>
    <div class="main">
        <div class="col-md-6 col-sm-12">
            <div class="login-form">
                <form id="form1" runat="server">
                    <div class="box-header">
                        <h3 class="box-title">Compromissos</h3>
                    </div>
                    <asp:Repeater runat="server" ID="RptTarefa" OnItemCommand="RptTarefa_ItemCommand" OnItemDataBound="RptTarefa_ItemDataBound" EnableViewState="True">
                        <HeaderTemplate>
                            <table id="example" class="table table-bordered table-striped" style="width: 600px">
                                <thead>
                                    <tr style="width: 100%; background-color: darkgray;">
                                        <th class="text-center">Ação</th>
                                        <th class="text-center">Data</th>
                                        <th class="text-center">Nome</th>
                                        <th class="text-center">Descrição</th>
                                    </tr>
                                </thead>
                        </HeaderTemplate>
                        <ItemTemplate>
                            <tr id="styT" runat="server" class="table table-hover" style="width: 100%;">
                                <td style="text-align: center;">
                                    <asp:LinkButton runat="server" ID="lnkApagar" CommandName="Apagar" Style="color: red" OnClick="lnkApagar_Click" CommandArgument='<%# Eval("ID_Tarefas") %>' CssClass="btn btn-red" ToolTip="Apagar tarefa">✖</asp:LinkButton>
                                    <asp:LinkButton runat="server" ID="lnkEditar" CommandName="Editar" CommandArgument='<%# Eval("ID_Tarefas") %>' CssClass="btn btn-red" ToolTip="Editar Tarefa">✍</asp:LinkButton>
                                    <asp:HiddenField ID="hidID_Tarefa" runat="server" Value='<%# Eval("ID_Tarefas") %>' />
                                    <asp:HiddenField ID="hidImportancia" runat="server" Value='<%# Eval("Importancia") %>' />
                                </td>
                                <td style="text-align: center">
                                    <asp:Label runat="server" ID="DT_Status" Text='<%# Convert.ToDateTime(Eval("Data")).ToShortDateString() %>'></asp:Label></td>

                                <td style="text-align: center">
                                    <asp:Label runat="server" ID="DC_Artigo" Text='<%# Eval("Tarefa_Nome") %>'></asp:Label></td>
                                <td style="text-align: center">
                                    <asp:Label runat="server" ID="DC_Status" Text='<%# Eval("Tarefa_Descrição") %>'></asp:Label></span></td>
                            </tr>
                        </ItemTemplate>
                        <FooterTemplate>
                          
                            </table>
                        </FooterTemplate>
                    </asp:Repeater>
                        <div class="box">
                            <table class="table table-striped";>
                                <tr>
                                    <td>Legenda de importancia:</td>
                                    <td style="background-color:lightgreen;"><b>NORMAL</b></td>
                                    <td style="background-color:khaki;"><b>IMPORTANTE</b></td>
                                    <td style="background-color:salmon;"><b>URGÊNCIA</b></td>
                                </tr>
                             </table>
                        </div>
                    <asp:Button runat="server" ID="NewEvent" type="submit" OnClick="NewEvent_Click" class="btn btn-black" Text="Novo Evento" />
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


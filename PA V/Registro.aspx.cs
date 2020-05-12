using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PA_V
{
    public partial class RegistroForm1 : System.Web.UI.Page
    {
        Conexao con = new Conexao();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Btn_reg_Click(object sender, EventArgs e)
        {
            string sql;
            MySqlCommand cmd = null;
            string Nome = Request["nome"].ToString();
            string Senha = Request["password"].ToString();
            string ConfirmaS = Request["confirm"].ToString();

            string senha1 = Senha.Trim();
            string senha2 = ConfirmaS.Trim();

            if (String.Equals(senha1, senha2))
            {
                con.abrircon();
                sql = "INSERT INTO login (Nome, Senha) VALUES (@Nome, @Senha)";
                cmd = new MySqlCommand(sql, con.con);
                try
                {
                    cmd.Parameters.AddWithValue("@Nome", Nome);
                    cmd.Parameters.AddWithValue("@Senha", Senha);

                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {

                }
                finally
                {
                    con.fecharcon();
                    Response.Redirect("Login.aspx", false);
                }
            }
            else
            {
                Response.Write("<script>alert('Erro:\\nSenhas Diferentes!');</script>");
            }
        }
    }
}
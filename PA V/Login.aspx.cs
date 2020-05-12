using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PA_V
{
    public partial class Login : System.Web.UI.Page
    {
        Conexao con = new Conexao();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void login_Click(object sender, EventArgs e)
        {
            string sql;
            MySqlCommand cmd;
            string Nome = Request["Nome"].ToString();
            string Senha = Request["Senha"].ToString();

            con.abrircon();

            sql = "SELECT * FROM login WHERE Nome = '" + Nome + "'AND Senha = '" + Senha + "'";
            try
            {
                cmd = new MySqlCommand(sql, con.con);

                MySqlDataReader reader = null;
                reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    int ID_User = Convert.ToInt32(reader["ID_User"]);
                    Session.Add("user", ID_User);
                    Response.Redirect("home.aspx", false);
                }
                else
                {
                    Response.Write("<script>alert('Erro:\\nUsuário ou Senha Inválidos!');</script>");
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                con.fecharcon();
            }
        }

        protected void register_Click(object sender, EventArgs e)
        {
            Response.Redirect("Registro.aspx", false);
        }
    }
}
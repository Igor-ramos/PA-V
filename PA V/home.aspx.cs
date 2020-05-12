using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PA_V
{
    public partial class home : System.Web.UI.Page
    {
        Conexao con = new Conexao();
        public string conect = @"SERVER=localhost; DATABASE=pa v; UID=root; PWD=; PORT=;";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                PopularRomaneios();
            }
        }

        void PopularRomaneios()
        {
            PopularRomaneios(null);
        }

        void PopularRomaneios(int? pageIndex)
        {
            int ID_User =Convert.ToInt32(Session["user"]);
            using (MySqlConnection con = new MySqlConnection(conect))
            {
                using(MySqlCommand cmd = new MySqlCommand("SELECT * FROM tarefas WHERE ID_User = " + ID_User, con))
                {
                    cmd.CommandType = CommandType.Text;
                    using(MySqlDataAdapter sda = new MySqlDataAdapter(cmd))
                    {
                        using (DataTable dt = new DataTable())
                        {
                            {
                                sda.Fill(dt);
                                RptTarefa.DataSource = dt;
                                RptTarefa.DataBind();
                            }
                        }
                    }
                }
            }            
        }

        protected void NewEvent_Click(object sender, EventArgs e)
        {
            Response.Redirect("NewEvent.aspx", false);
        }

        protected void DeleteEvento_Click(object sender, EventArgs e)
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

        protected void RptTarefa_ItemCommand(object source, RepeaterCommandEventArgs e)
        {

        }

        protected void RptTarefa_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {

        }

        protected void lnkApagar_Click(object sender, EventArgs e)
        {
            string sql;
            MySqlCommand cmd;

            con.abrircon();

            sql = "DELETE FROM login WHERE ID_Tarefa = ";
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
    }
}
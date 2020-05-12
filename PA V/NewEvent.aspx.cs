using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PA_V
{
    public partial class NewEvent : System.Web.UI.Page
    {
        Conexao con = new Conexao();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void voltar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Home.aspx", false);
        }

        protected void Adiciona_Click(object sender, EventArgs e)
        {
            string sql;
            MySqlCommand cmd = null;
            string Tarefa_Nome = Request["nome"].ToString();
            DateTime? Data = Convert.ToDateTime(Request["Data"]);
            string Tarefa_Descrição = Request["Descricao"].ToString();
            int ID_User = Convert.ToInt32(Session["user"]);



            con.abrircon();
            sql = "INSERT INTO tarefas (ID_User, Tarefa_Nome, Data, Tarefa_Descrição) VALUES (@ID_User, @Tarefa_Nome, @Data, @Tarefa_Descrição)";
            cmd = new MySqlCommand(sql, con.con);
            int i = 0;
            try
            {
                cmd.Parameters.AddWithValue("@ID_User", ID_User);
                cmd.Parameters.AddWithValue("@Tarefa_Nome", Tarefa_Nome);
                cmd.Parameters.AddWithValue("@Data", Convert.ToDateTime(Data));
                cmd.Parameters.AddWithValue("@Tarefa_Descrição", Tarefa_Descrição);

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                i++;              
            }
            finally
            {
                con.fecharcon();                
            }
            if (i < 0)
            {
                Response.Redirect("NewEvent.aspx", false);
            }
            else
            {
                Response.Redirect("Home.aspx", false);
            }
        }
    }
}
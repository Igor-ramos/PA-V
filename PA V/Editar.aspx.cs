using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;

namespace PA_V
{
    public partial class Editar : System.Web.UI.Page
    {
        Conexao con = new Conexao();
        string ID_User = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request["id_tarefa"] != null)
            {
                ID_User = Request["id_tarefa"];
            }
        }

        protected void salvar_Click(object sender, EventArgs e)
        {
            int i = 0;
            string sql;
            MySqlCommand cmd = null;
            string Tarefa_Nome = Request["nome"].ToString();
            object Data = Convert.ToDateTime(Request["Data"]);
            string Tarefa_Descrição = Request["Descricao"].ToString();
            int Importancia = Convert.ToInt32(ddlimportancia.SelectedValue);

            con.abrircon();
            sql = " UPDATE tarefas ";
            sql += " SET Tarefa_Nome = @Tarefa_Nome, Data = @Data, Tarefa_Descrição = @Tarefa_Descrição, Importancia = @Importancia ";
            sql += " WHERE ID_Tarefas = '" + ID_User + "'";

            try
            {
                cmd = new MySqlCommand(sql, con.con);

                cmd.Parameters.AddWithValue("@Tarefa_Nome", Tarefa_Nome);
                cmd.Parameters.AddWithValue("@Data", Convert.ToDateTime(Data));
                cmd.Parameters.AddWithValue("@Tarefa_Descrição", Tarefa_Descrição);
                cmd.Parameters.AddWithValue("@Importancia", Importancia);

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
            if (i == 0)
            {
                Response.Redirect("Home.aspx");
            }
        }
    }
}
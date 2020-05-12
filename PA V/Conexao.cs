using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PA_V
{
    public class Conexao
    {
        public string conect = "SERVER=localhost; DATABASE=pa v; UID=root; PWD=; PORT=;";
        
        public MySqlConnection con = null;

        public void abrircon()
        {
            try
            {
                con = new MySqlConnection(conect);
                con.Open();
            }
            catch(Exception ex)
            {

                HttpContext.Current.Response.Write("Erro ao conectar " + ex);
            }
        }
        public void fecharcon()
        {
            try
            {
                con = new MySqlConnection(conect);
                con.Close();
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}
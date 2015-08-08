using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Sql;
using System.Data.SqlClient;

namespace AmiNew.RecetasDoc
{
    public partial class Recetas : System.Web.UI.Page
    {
        SqlConnection ConeccionBase = new SqlConnection(@"user id=Cando;password=1234;server=CANDO-SATELITE;database=AMI;connection timeout=30");
        
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                ConeccionBase.Open();
                SqlCommand LecturaDatos = new SqlCommand("select Usuario from Paciente", ConeccionBase);
                SqlDataReader Respuesta = LecturaDatos.ExecuteReader();

                List<string> Usu = new List<string>();

                while (Respuesta.Read())
                {
                    Usu.Add(Respuesta["Usuario"].ToString());
                }

                ConeccionBase.Close();

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.ToString());
            }
        }
    }
}
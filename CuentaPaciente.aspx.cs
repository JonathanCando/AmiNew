using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Sql;
using System.Data.SqlClient;

namespace AmiNew
{
    public partial class CuentaPaciente : System.Web.UI.Page
    {
        SqlConnection ConeccionBase = new SqlConnection(@"user id=Cando;password=1234;server=CANDO-SATELITE;database=AMI;connection timeout=30");

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Enter_Click(object sender, EventArgs e)
        {
            try
            {
                ConeccionBase.Open();
                SqlCommand LecturaDatos = new SqlCommand("select Pass from Paciente where Usuario = '" + Usuario.Text + "'", ConeccionBase);
                SqlDataReader Respuesta = LecturaDatos.ExecuteReader();

                string pass = "";
               // string token = ""; elimidao por la compu

                while (Respuesta.Read())
                {
                    pass = Respuesta[0].ToString(); //es la pocision 1 en este caso la columna Pass de la BD
                }

                ConeccionBase.Close();

                if (Contrasena.Text == pass && Contrasena.Text!="")
                {
                    //   mbox("Success");
                    Session["Usuario1"] = Usuario.Text;
                    Response.Redirect("FormPaciente.aspx");
                }
                else
                {
                    Response.Write("Por favor, vuelve a introducir tu contraseña.");                }

            }
            catch (Exception ex)
            {
                Response.Write("Tiene algun parametro incorrecto por favor, vuelve a introducir tu contraseña.");
                Console.WriteLine(ex.ToString());
            }

        }
    }
}
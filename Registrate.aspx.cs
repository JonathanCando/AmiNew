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
    public partial class Registrate : System.Web.UI.Page
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
                if (PContrasena.Text==PCContrasena.Text && PContrasena.Text!=null)
                {
                    SqlCommand EscritorDatos = new SqlCommand("insert into Paciente(Nombre,Apellido,Usuario,Edad,TipoSangre,Telefono,Pass,Sexo) values('" + PNombre.Text + "','" + PApellido.Text + "','" + PUsuario.Text + "','" + PAno.Text + "-" + PMes.Text + "-" + PDia.Text + "','" + PSangre.Text + "'," + PTelefono.Text + ",'" + PContrasena.Text + "'," + PSexo.Text + ")", ConeccionBase);
                      EscritorDatos.ExecuteNonQuery();

                      Response.Redirect("FormPaciente.aspx"); //pasa a la pagina del paciente cuando coloca los datos  
                }
                // colocar opciones como si el asuario ya existe o llenar mas datos etc..
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.ToString());
            }
        }
    }
}
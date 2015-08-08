using System;
using System.Collections.Generic;
using System.Linq;
using System.Web; 
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Configuration;

namespace AmiNew
{
    public partial class CuentaDoctor : System.Web.UI.Page
    {
        SqlConnection ConeccionBase = new SqlConnection(@"user id=Cando;password=1234;server=CANDO-SATELITE;database=AMI;connection timeout=30");

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Enter_Click(object sender, EventArgs e)
        {
            int NumeroRan; //variable donde colocamos el numero random
            Random NumeroAlea = new Random(); //numero random
            NumeroRan = NumeroAlea.Next(1, 30);
            // Listo.Text = Solo.ToString();
            try
            {
                ConeccionBase.Open();
                SqlCommand LecturaDatos = new SqlCommand("select Pas from DoctorNew where usuario = '"+Usuario.Text + "'", ConeccionBase);
                SqlDataReader Respuesta = LecturaDatos.ExecuteReader();

                string pass = "";
                string UsuarioTarjeta = "";

                while (Respuesta.Read())
                {
                    pass = Respuesta[0].ToString(); // es cero porque solo hay una variable (Pass) y elegimos esa variable
                }

                ConeccionBase.Close();

                if (Contrasena.Text == pass && Contrasena.Text!="")
                {
                 //   mbox("Success"); 
                    Session["Usuario"] = Usuario.Text; //se crea la variable que pasa de paginas con el usuario del medico
                    Session["NumeroRandom"] = NumeroRan.ToString();

                    //estraere los datos de la tabla DoctorTarjeta para averiguar si el medico ya tiene una tarjeta asignada
                    ConeccionBase.Open();
                    SqlCommand LecturaUsuario = new SqlCommand("SELECT DoctorNew.Usuario FROM DoctorTarjeta JOIN DoctorNew ON DoctorNew.Doc_Id=DoctorTarjeta.Doc_Id where DoctorNew.Usuario='" + Usuario.Text + "'", ConeccionBase);
                    SqlDataReader RespuestaUsu = LecturaUsuario.ExecuteReader();
                    while (RespuestaUsu.Read())
                    {
                        UsuarioTarjeta = RespuestaUsu[0].ToString(); // es cero porque solo hay una variable (Pass) y elegimos esa variable
                    }
                    ConeccionBase.Close();

                    if (UsuarioTarjeta==Usuario.Text)
                    {
                        Response.Redirect("CuentaDocToken.aspx");
                    }
                    
                    else Response.Redirect("DoctorNoToken.aspx");
                }
                else
                {
                  //  Response.Redirect("CuentaDoctor.aspx");
                    Response.Write("Por favor, vuelve a introducir tu contraseña.");
                //    MessageBox.show("Contrasena mal");                   
                }

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.ToString());
            }
        }

        private void mbox(string p)
        {
            throw new NotImplementedException();
        }
    }
}
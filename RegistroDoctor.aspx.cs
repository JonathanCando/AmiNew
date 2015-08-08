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
    public partial class RegistroDoctor : System.Web.UI.Page
    {
        SqlConnection ConeccionBase = new SqlConnection(@"user id=Cando;password=1234;server=CANDO-SATELITE;database=AMI;connection timeout=30");
        protected void Page_Load(object sender, EventArgs e)
        {
        }


        protected void Enter_Click1(object sender, EventArgs e)
        {
            try
            {
                //  ConeccionBase.Open();
                  if (DContrasena.Text == DCContrasena.Text && DNombre.Text != "" && DApellido.Text != "" && DUsuario.Text != "" && DTelefono.Text != "" && DContrasena.Text != "" && DSexo.Text != "" && DExequatur.Text != "")
                  {
                      ConeccionBase.Open();
                      //leemos la base de datos de los doctores que tienen su licencia Exequatur
                      SqlCommand LecturaUsuario = new SqlCommand("SELECT ExequaturRegis.Nombre,ExequaturRegis.Apellido,ExequaturRegis.Exequatur FROM DocProRegis JOIN ExequaturRegis ON DocProRegis.Doc_Id=ExequaturRegis.Doc_Id JOIN ProfesionRegis on ProfesionRegis.Pro_Id=DocProRegis.Pro_Id where ExequaturRegis.Exequatur='"+DExequatur.Text+"'", ConeccionBase);
                      SqlDataReader RespuestaUsu = LecturaUsuario.ExecuteReader();

                      String DBNombre = "";
                      String DBApellido = "";
                      String DBExequatur = "";
                      //colocamos en estos string las variables extraidas de la base de datos
                      while (RespuestaUsu.Read())
                      {
                          DBNombre = RespuestaUsu[0].ToString();
                          Console.WriteLine(DBNombre.ToUpper());//convertimos a Mayuscula el string del DB
                          DBApellido = RespuestaUsu[1].ToString();
                          Console.WriteLine(DBApellido.ToUpper());//convertimos a Mayuscula el string del DB
                          DBExequatur = RespuestaUsu[2].ToString();                          
                      }
                      ConeccionBase.Close();

                      if (DBNombre == DNombre.Text && DBApellido == DApellido.Text && DBExequatur == DExequatur.Text)
                      {
                          ConeccionBase.Open();
                          SqlCommand EscritorDatos = new SqlCommand("insert into DoctorNew(Nombre,Apellido,Usuario,Telefono,Pas,Sexo,Exequatur) values('" + DNombre.Text + "','" + DApellido.Text + "','" + DUsuario.Text + "'," + DTelefono.Text + ",'" + DContrasena.Text + "'," + DSexo.Text + ",'" + DExequatur.Text + "')", ConeccionBase);
                          EscritorDatos.ExecuteNonQuery();
                          ConeccionBase.Close();
                          Response.Redirect("FormDoctor.aspx");//pasa a la pagina del medico cuando coloca los datos                         
                      }
                      else { 
                          Prueba.Text = "No existe este registro de medico";
                          ExisteUsuario.Text = DBNombre;
                          ExisteExequ.Text = DBApellido;
                          Label1.Text = DBExequatur;
                          Label2.Text = DNombre.Text;
                          Label3.Text = DApellido.Text;
                          Label4.Text = DExequatur.Text;
                      
                      }
                  
                  }
                  else
                  {
                      Prueba.Text = "Algun parametro esta incompleto por favor verificar de nuevo";
                      ExisteUsuario.Text = "";
                      ExisteExequ.Text = "";
                  }

                 // ConeccionBase.Close();
                // colocar opciones como si el asuario ya existe o llenar mas datos etc..
            }
            catch (Exception ex)
            {
                ConeccionBase.Close();
                string UsuarioDB = "";
                string ExeDB = "";
                Prueba.Text = "";
                ExisteUsuario.Text = "";
                ExisteExequ.Text = "";

                ConeccionBase.Open();
                // buscamos toda la columna de Usuarios de la tabla DoctorNewen la DB 
                SqlCommand LecturaUsuario = new SqlCommand("select Usuario from DoctorNew", ConeccionBase);
                SqlDataReader RespuestaUsu = LecturaUsuario.ExecuteReader();

                while (RespuestaUsu.Read())
                {
                    UsuarioDB = RespuestaUsu[0].ToString(); 

                   if (UsuarioDB == DUsuario.Text) // compara el usuario que ingresa el medico
                   {                                //con la base de datos para ver si exite
                       ExisteUsuario.Text = "No puede utilizar este usuario";
                       break;
                   }
                }
                ConeccionBase.Close();

                ConeccionBase.Open();
                // buscamos toda la columna de Exequatur de la tabla DoctorNewen la DB 
                SqlCommand LecturaExequ = new SqlCommand("select Exequatur from DoctorNew", ConeccionBase);
                SqlDataReader RespuestaExe = LecturaExequ.ExecuteReader();

                while (RespuestaExe.Read())
                {
                    ExeDB = RespuestaExe[0].ToString();

                    if (ExeDB == DExequatur.Text) // compara el usuario que ingresa el medico
                    {                                //con la base de datos para ver si exite
                        ExisteExequ.Text = "Esta licencia ya existe";
                        break;
                    }
                }
                ConeccionBase.Close();
                Console.WriteLine(ex.ToString());
            }
        }

    }
}
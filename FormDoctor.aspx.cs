using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Sql;
using System.Data.SqlClient;
 
namespace AmiNew
{

              
    public partial class FormDoctor : System.Web.UI.Page
    {
        SqlConnection ConeccionBase = new SqlConnection(@"user id=Cando;password=1234;server=CANDO-SATELITE;database=AMI;connection timeout=30");
        SqlConnection Coneccion2 = new SqlConnection(@"user id=Cando;password=1234;server=CANDO-SATELITE;database=AMI;connection timeout=30");
        string Paciente_ID = ""; // variable pa insertar el ID del paciente de la tabla Paciente
        string Doctor_ID = ""; //variable pa insertar el ID del doctor de la tabla DoctorNew
        string PacienteDB_ID = ""; // variable pa insertar el ID del paciente de la tabla DoctorPaciente
        string DoctorDB_ID = ""; // variable pa insertar el ID del doctor de la tabla DoctorPaciente
        

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Usuario"] != null)
            {
                LabelUsuario.Text = Session["Usuario"].ToString();
            }
            else 
            { 
                Response.Redirect("CuentaDoctor.aspx"); 
            } // se va a la pagina de registro del doctor porque no tiene usuario            
        }

        protected void BotonSalir_Click(object sender, EventArgs e) //boton para salir y resetea a NULL la variable que
        {                                                              //pasa a diferentes paginas
            Session["Usuario"] = null;                              
            Response.Redirect("Inicio.aspx"); // vuelve a la pagina de inicio
        }

        protected void BotonAgregar_Click(object sender, EventArgs e)
        {

            try
            {
                //-----------------------------------------
                ConeccionBase.Open();
                SqlCommand LecturaDatos = new SqlCommand("select ID from Paciente where Usuario = '" + TextPaciente.Text + "'", ConeccionBase);
                SqlDataReader Respuesta = LecturaDatos.ExecuteReader();
                while (Respuesta.Read())
                {
                    Paciente_ID = Respuesta[0].ToString(); // se guarda la columna usuario de la base de datos de la tabla paciente
                }
                ConeccionBase.Close();
                //-----------------------------------------------
                ConeccionBase.Open();
                SqlCommand LecturaDatos1 = new SqlCommand("select Doc_Id from DoctorNew where Usuario = '" + LabelUsuario.Text + "'", ConeccionBase);
                SqlDataReader Respuesta1 = LecturaDatos1.ExecuteReader();
                while (Respuesta1.Read())
                {
                    Doctor_ID = Respuesta1[0].ToString(); // se guarda la columna usuario de la base de datos de la tabla paciente
                }
                ConeccionBase.Close();
                //---------------------------------------------------
                ConeccionBase.Open();
                //leemos la base de datos de los doctores que tienen su licencia Exequatur
                SqlCommand LecturaDoctorPaciente = new SqlCommand("SELECT DoctorPaciente.Doc_Id,DoctorPaciente.ID FROM DoctorPaciente JOIN DoctorNew ON DoctorNew.Doc_Id=DoctorPaciente.Doc_Id JOIN Paciente on Paciente.ID=DoctorPaciente.ID where DoctorNew.Usuario='" + LabelUsuario.Text + "' and Paciente.Usuario = '" + TextPaciente.Text + "'", ConeccionBase);
                SqlDataReader RespuestaDocPa = LecturaDoctorPaciente.ExecuteReader();
                while (RespuestaDocPa.Read())
                {
                    DoctorDB_ID = RespuestaDocPa[0].ToString();
                    PacienteDB_ID = RespuestaDocPa[1].ToString();
                }
                ConeccionBase.Close();

                if (Paciente_ID != "")
                {
                    if (DoctorDB_ID != "" && PacienteDB_ID != "")
                    {
                        LabelSiUsuario.Text = "Este paciente ya existe en su lista";
                        LabelNoUsuario.Text = "";
                    }
                    else
                    {
                        ConeccionBase.Open();
                        //INSERTAMOS LA RELACION DEL PACIENTE CON EL MEDICO EN LA BASES DE DATOS
                        SqlCommand EscritorDatos = new SqlCommand("insert into DoctorPaciente (Doc_Id,ID) values('" + Doctor_ID + "','" + Paciente_ID + "')", ConeccionBase);
                        EscritorDatos.ExecuteNonQuery();
                        ConeccionBase.Close();
                        LabelSiUsuario.Text = "Paciente agregado a su lista";
                        LabelNoUsuario.Text = "";
                        LabelUsuario.Text = "";
                    }
                }
                else
                {
                    LabelSiUsuario.Text = "Usuario no existe";
                    LabelNoUsuario.Text = "";
                }


            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.ToString());
            }

           // Session["Usuario"] = null;
           // Response.Redirect("FormPaciente.aspx");
         /*   try
            {
                ConeccionBase.Open();
                SqlCommand LecturaDatos = new SqlCommand("select Usuario,Nombre,Apellido,Telefono,TipoSangre,Edad,Sexo from Paciente where Usuario = '" + TextPaciente.Text + "'", ConeccionBase);
                SqlDataReader Respuesta = LecturaDatos.ExecuteReader();

                //variables donde se almacenan los datos datos del paciente

                while (Respuesta.Read())
                {
                    UsuariBaDatos = Respuesta[0].ToString(); // se guarda la columna usuario de la base de datos de la tabla paciente
                    NombreBD = Respuesta[1].ToString(); // se guarda la columna Nombre de la base de datos de la tabla paciente
                    ApellidoBD = Respuesta[2].ToString(); // se guarda la columna Apellido de la base de datos de la tabla paciente
                    TelefonoBD = Respuesta[3].ToString(); // se guarda la columna Telefono de la base de datos de la tabla paciente
                    TipoSangreBD = Respuesta[4].ToString(); // se guarda la columna TipoSangre de la base de datos de la tabla paciente
                    EdadBD = Respuesta[5].ToString(); // se guarda la columna Edad la base de datos de la tabla paciente
                    SexoBD = Respuesta[6].ToString(); // se guarda la columna Sexo de la base de datos de la tabla paciente
                }
                ConeccionBase.Close();          
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.ToString());
            }
            try 
            {
                Coneccion2.Open();
                if (TextPaciente.Text == UsuariBaDatos)
                {
                    SqlCommand EscritorDatos = new SqlCommand("insert into " + Session["Usuario"].ToString() + "(Usuario,Nombre,Apellido,Telefono,TipoSangre,Sexo) values('" + UsuariBaDatos + "','" + NombreBD + "','" + ApellidoBD + "','" + TelefonoBD + "','" + TipoSangreBD + "','" + SexoBD + "')", Coneccion2);
                    EscritorDatos.ExecuteNonQuery();
                    LabelSiUsuario.Text = "Paciente agregado a su lista";
                    LabelNoUsuario.Text = "";
                }
                else
                {
                    LabelNoUsuario.Text = "";
                    LabelSiUsuario.Text = "Usuario no existe";
                }
                Coneccion2.Close();
            }
            catch (Exception ex)
            {
                LabelNoUsuario.Text = "";
                LabelSiUsuario.Text = "No puede agregar el mismo usuario a la lista";
                Console.WriteLine(ex.ToString());
            }*/

        }

        protected void BotonEliminar_Click(object sender, EventArgs e)
        {
            try
            {
              /*  ConeccionBase.Open();
                SqlCommand LecturaDatos = new SqlCommand("Delete from " + LabelUsuario.Text + " where (Usuario) = '" + TextEliminar.Text + "'", ConeccionBase);
                SqlDataReader Respuesta = LecturaDatos.ExecuteReader();
                ConeccionBase.Close();*/

                ConeccionBase.Open();
                //leemos la base de datos de los doctores que tienen su licencia Exequatur
                SqlCommand LecturaDoctorPaciente = new SqlCommand("SELECT DoctorPaciente.Doc_Id,DoctorPaciente.ID FROM DoctorPaciente JOIN DoctorNew ON DoctorNew.Doc_Id=DoctorPaciente.Doc_Id JOIN Paciente on Paciente.ID=DoctorPaciente.ID where DoctorNew.Usuario='" + LabelUsuario.Text + "' and Paciente.Usuario = '" + TextEliminar.Text + "'", ConeccionBase);
                SqlDataReader RespuestaDocPa = LecturaDoctorPaciente.ExecuteReader();
                while (RespuestaDocPa.Read())
                {
                    DoctorDB_ID = RespuestaDocPa[0].ToString();
                    PacienteDB_ID = RespuestaDocPa[1].ToString();
                }
                ConeccionBase.Close();

                if (DoctorDB_ID != "" && PacienteDB_ID != "")
                {
                    ConeccionBase.Open();
                    SqlCommand LecturaDatos = new SqlCommand("Delete from DoctorPaciente where (Doc_Id) = '" + DoctorDB_ID + "' and (ID) = '" + PacienteDB_ID + "'", ConeccionBase);
                    SqlDataReader Respuesta = LecturaDatos.ExecuteReader();
                    ConeccionBase.Close();

                    LabelSiUsuario.Text = "";
                    LabelNoUsuario.Text = "Usuario eliminado";
                }
                else
                {
                    LabelSiUsuario.Text = "";
                    LabelNoUsuario.Text = "Usuario no existe en su lista, por favor verifique la lista";
                }

                
            }
            catch (Exception ex)
            {
                
                Console.WriteLine(ex.ToString());
            }
        }

        protected void TextPaciente_TextChanged(object sender, EventArgs e) // si quito esto da error, no quitar
        {

        }

    }
}
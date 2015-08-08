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
    public partial class Administrador : System.Web.UI.Page
    {
        SqlConnection ConeccionBase = new SqlConnection(@"user id=Cando;password=1234;server=CANDO-SATELITE;database=AMI;connection timeout=30");

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Salir_Click(object sender, EventArgs e)
        {
            try
            {
                string UsuarioDoc = "";
                string TarjetaId = "";
                string PasAdminis = "";
                string Doc_Id = "";
              //  string DocRegistrado = "";

                ConeccionBase.Open();
                SqlCommand LecturaDatos = new SqlCommand("select * from DoctorNew where Usuario = '" + Usuario.Text + "'", ConeccionBase);
                SqlDataReader Respuesta = LecturaDatos.ExecuteReader();
                while (Respuesta.Read())
                {
                    Doc_Id = Respuesta[0].ToString(); // colocamos todos los (Id doctores) de la bases de datos
                    UsuarioDoc = Respuesta[1].ToString(); // colocamos todos los (usuarios) de la bases de datos                    
                }
                ConeccionBase.Close();

                ConeccionBase.Open();
                SqlCommand LecturaDatos2 = new SqlCommand("select Tarjeta_Id from TarjetaCodigo where Tarjeta_Id = '" + Tarjeta_Id.Text + "'", ConeccionBase);
                SqlDataReader Respuesta2 = LecturaDatos2.ExecuteReader();
                while (Respuesta2.Read())
                {
                    TarjetaId = Respuesta2[0].ToString(); // colocamos todos los IDde las tarjetas de la bases de datos
                }
                ConeccionBase.Close();

                ConeccionBase.Open();
                SqlCommand LecturaDatos3 = new SqlCommand("select Pas from AdministradorDatos where Pas = '" + Pas.Text + "'", ConeccionBase);
                SqlDataReader Respuesta3 = LecturaDatos3.ExecuteReader();
                while (Respuesta3.Read())
                {
                    PasAdminis = Respuesta3[0].ToString(); // colocamos todos las contrase;as las tarjetas de la bases de datos
                }
                
                 ConeccionBase.Close();
                //Esto esta inabilitado porque tiene errores..
              /*  ConeccionBase.Open();
                SqlCommand LecturaDatos4 = new SqlCommand("select Doc_Id from DoctorTarjeta where Doc_Id = '" + Doc_Id + "'", ConeccionBase);
                SqlDataReader Respuesta4 = LecturaDatos4.ExecuteReader();
                while (Respuesta4.Read())
                {
                    DocRegistrado = Respuesta4[0].ToString(); // colocamos el id del medico para saber si ya tiene una tarjeta registrado                
                }
                ConeccionBase.Close(); */


                //Label2.Text = TarjetaId;    esto era para probar
               // Label1.Text = Doc_Id;     esto era para probar


                if (Usuario.Text != "" && Tarjeta_Id.Text != "" && Pas.Text != "")
                {
                    if (UsuarioDoc == Usuario.Text)
                    {
                        if (TarjetaId == Tarjeta_Id.Text)
                        {
                            if (PasAdminis == Pas.Text)
                            {
                              /*  if (DocRegistrado == Doc_Id) //resolver aqui que tieme problemas sirbe para ver si ya tiene el medico una tarjeata asignada
                                {
                                    ConeccionBase.Open();
                                    //nota la varible (Name) de la bases de datos es el usuario del doctor
                                    SqlCommand EscritorDatos = new SqlCommand("insert into DoctorTarjeta(Tarjeta_Id,Doc_Id) values('" + Tarjeta_Id.Text + "','" + Doc_Id + "')", ConeccionBase);
                                    EscritorDatos.ExecuteNonQuery();
                                    ConeccionBase.Close();
                                    Response.Redirect("CuentaDocToken.aspx");
                                }
                                else Response.Write("Este Usuario ya tiene una tarjeta registrada");  */ //Escribe en la pantalla   


                                ConeccionBase.Open();
                                //nota la varible (Name) de la bases de datos es el usuario del doctor
                                SqlCommand EscritorDatos = new SqlCommand("insert into DoctorTarjeta(Tarjeta_Id,Doc_Id) values('" + Tarjeta_Id.Text + "','" + Doc_Id + "')", ConeccionBase);
                                EscritorDatos.ExecuteNonQuery();
                                ConeccionBase.Close();
                                Response.Write("La tarjeta fue agragada a su médico");  //Escribe en la pantalla 
                                Usuario.Text = "";          //coloca los texbos en blanco
                                Tarjeta_Id.Text = "";
                                Pas.Text = "";
                                //Response.Redirect("CuentaDocToken.aspx");
                            }
                            else Response.Write("Contraseña del administrador es incorrecto");  //Escribe en la pantalla 
                        }
                        else  Response.Write("No existe ese numero de tarjeta");   //Escribe en la pantalla 
                    }
                    else Response.Write("El usuario es incorrecto");   //Escribe en la pantalla  
                }
                else  Response.Write("Los datos estan incompletos");  //Escribe en la pantalla    
            }

            catch (Exception ex)
            {

                Label2.Text = "El numero del Token no existe";
                Console.WriteLine(ex.ToString());
            }

        }

        protected void SalirNew_Click(object sender, EventArgs e)
        {
            Response.Redirect("Inicio.aspx");
        }
    }
}
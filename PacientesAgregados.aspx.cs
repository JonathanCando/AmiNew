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
    public partial class PacientesAgregados : System.Web.UI.Page
    {
        SqlConnection ConeccionBase = new SqlConnection(@"user id=Cando;password=1234;server=CANDO-SATELITE;database=AMI;connection timeout=30");
        SqlConnection Coneccion2 = new SqlConnection(@"user id=Cando;password=1234;server=CANDO-SATELITE;database=AMI;connection timeout=30");
        string doctor="";

        protected void Page_Load(object sender, EventArgs e)
        {
               if (Session["Usuario"] != null)
                {
                    doctor = Session["Usuario"].ToString(); //coloca al medico que ingreso a la variable doctor
                    LabelUsuDoc.Text = Session["Usuario"].ToString();

                }
                else
                {
                    Response.Redirect("CuentaDoctor.aspx");
                } // se va a la pagina de registro del doctor porque no tiene usuario  ('" + LabelUsuDoc.Text + "')


            try
            {
             /*   ConeccionBase.Open();

                SqlCommand LecturaDatos = new SqlCommand("select Usuario,Nombre,Apellido,Telefono,TipoSangre from "+doctor+" ", ConeccionBase);
                SqlDataReader Respuesta = LecturaDatos.ExecuteReader();*/

                ConeccionBase.Open();
                //leemos la base de datos de los doctores que tienen su licencia Exequatur
                SqlCommand LecturaDatos = new SqlCommand("SELECT Paciente.Usuario,Paciente.Nombre,Paciente.Apellido,Paciente.Telefono,Paciente.TipoSangre FROM DoctorPaciente JOIN Paciente ON Paciente.ID=DoctorPaciente.ID  JOIN DoctorNew ON DoctorNew.Doc_Id=DoctorPaciente.Doc_Id where DoctorNew.Usuario='" + LabelUsuDoc.Text + "'", ConeccionBase);
                SqlDataReader Respuesta = LecturaDatos.ExecuteReader();



                int count = 0;

                while (Respuesta.Read())
                {
                    if (count == 0)
                    {
                        LabelNick1.Text = Respuesta[0].ToString();
                        LabelNombre1.Text = Respuesta[1].ToString();
                        LabelApellido1.Text = Respuesta[2].ToString();
                        LabelTel1.Text = Respuesta[3].ToString();
                        LabelSan1.Text = Respuesta[4].ToString();
                    }
                    else if (count == 1)
                    {
                        LabelNick2.Text = Respuesta[0].ToString();
                        LabelNombre2.Text = Respuesta[1].ToString();
                        LabelApellido2.Text = Respuesta[2].ToString();
                        LabelTel2.Text = Respuesta[3].ToString();
                        LabelSan2.Text = Respuesta[4].ToString();
                    }
                    else if (count == 2)
                    {
                        LabelNick3.Text = Respuesta[0].ToString();
                        LabelNombre3.Text = Respuesta[1].ToString();
                        LabelApellido3.Text = Respuesta[2].ToString();
                        LabelTel3.Text = Respuesta[3].ToString();
                        LabelSan3.Text = Respuesta[4].ToString();
                    }
                    else if (count == 3)
                    {
                        LabelNick4.Text = Respuesta[0].ToString();
                        LabelNombre4.Text = Respuesta[1].ToString();
                        LabelApellido4.Text = Respuesta[2].ToString();
                        LabelTel4.Text = Respuesta[3].ToString();
                        LabelSan4.Text = Respuesta[4].ToString();
                    }
                    else if (count == 4)
                    {
                        LabelNick5.Text = Respuesta[0].ToString();
                        LabelNombre5.Text = Respuesta[1].ToString();
                        LabelApellido5.Text = Respuesta[2].ToString();
                        LabelTel5.Text = Respuesta[3].ToString();
                        LabelSan5.Text = Respuesta[4].ToString();
                    }
                    else if (count == 5)
                    {
                        LabelNick6.Text = Respuesta[0].ToString();
                        LabelNombre6.Text = Respuesta[1].ToString();
                        LabelApellido6.Text = Respuesta[2].ToString();
                        LabelTel6.Text = Respuesta[3].ToString();
                        LabelSan6.Text = Respuesta[4].ToString();
                    }
                    else if (count == 6)
                    {
                        LabelNick7.Text = Respuesta[0].ToString();
                        LabelNombre7.Text = Respuesta[1].ToString();
                        LabelApellido7.Text = Respuesta[2].ToString();
                        LabelTel7.Text = Respuesta[3].ToString();
                        LabelSan7.Text = Respuesta[4].ToString();
                    }
                    else if (count == 7)
                    {
                        LabelNick8.Text = Respuesta[0].ToString();
                        LabelNombre8.Text = Respuesta[1].ToString();
                        LabelApellido8.Text = Respuesta[2].ToString();
                        LabelTel8.Text = Respuesta[3].ToString();
                        LabelSan8.Text = Respuesta[4].ToString();
                    }
                    else if (count == 8)
                    {
                        LabelNick9.Text = Respuesta[0].ToString();
                        LabelNombre9.Text = Respuesta[1].ToString();
                        LabelApellido9.Text = Respuesta[2].ToString();
                        LabelTel9.Text = Respuesta[3].ToString();
                        LabelSan9.Text = Respuesta[4].ToString();
                    }
                    else if (count == 9)
                    {
                        LabelNick10.Text = Respuesta[0].ToString();
                        LabelNombre10.Text = Respuesta[1].ToString();
                        LabelApellido10.Text = Respuesta[2].ToString();
                        LabelTel10.Text = Respuesta[3].ToString();
                        LabelSan10.Text = Respuesta[4].ToString();
                    }

                    count = count + 1;

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
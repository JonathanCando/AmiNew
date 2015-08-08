using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Sql;
using System.Data;
using System.Data.SqlClient;

namespace AmiNew
{
    public partial class RecetaRecibida : System.Web.UI.Page
    {
        SqlConnection ConeccionBase = new SqlConnection(@"user id=Cando;password=1234;server=CANDO-SATELITE;database=AMI;connection timeout=30");
        

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Usuario1"] != null)
            {
                LabelPacienteUsuario.Text = Session["Usuario1"].ToString(); // obtengo el nombre del usuario del doctor
            }
            else
            {
                Response.Redirect("CuentaPaciente.aspx");
            }


            

            if (LabelUsuarioDoctor.Text == "")
            {
                ConeccionBase.Open();
                //leemos en la base de datos todos los usuarios que tiene el pasiente logeado NOTA cambien el join le puse al otro lado
                SqlCommand LecturaDatos = new SqlCommand("SELECT * FROM DoctorPaciente JOIN DoctorNew ON DoctorNew.Doc_Id=DoctorPaciente.Doc_Id JOIN Paciente ON Paciente.ID=DoctorPaciente.ID where Paciente.Usuario='" + LabelPacienteUsuario.Text + "'", ConeccionBase);
                SqlDataReader Respuesta = LecturaDatos.ExecuteReader();

                DropDownList1.DataSource = Respuesta;
                DropDownList1.DataTextField = "Usuario";
                DropDownList1.DataBind();

                ConeccionBase.Close();               
            }
        }

        protected void ButtonBuscar_Click(object sender, EventArgs e)
        {
            long number2 = 0;//verifica que el numero que el paciente que ingreso esta en el rango de recetas en existencia
            bool canConvert2 = long.TryParse(TextBoxReceta.Text, out number2);

            long number3 = 0;//verifica que el numero que el paciente que ingreso esta en el rango de recetas en existencia
            bool canConvert3 = long.TryParse(LabelCantidadRecetas.Text, out number3);

            if (number2 != 0 && number2 <= number3)
            {
                string DoctorId = "";
                string PacienteId = "";
                //*******************************************************************************************
                ConeccionBase.Open();  //cogemos el Id del medico del que seleccionemos en el dropdownlist
                SqlCommand LecturaDatos1 = new SqlCommand("SELECT Doc_Id FROM DoctorNew where Usuario='" + LabelUsuarioDoctor.Text + "'", ConeccionBase);
                SqlDataReader Respuesta1 = LecturaDatos1.ExecuteReader();
                while (Respuesta1.Read())
                {
                    DoctorId = Respuesta1[0].ToString();
                }
                ConeccionBase.Close();
                //**********************************************************************************************
                ConeccionBase.Open(); //cogemos el Id del paciente 
                SqlCommand LecturaDatos2 = new SqlCommand("SELECT ID FROM Paciente where Usuario='" + LabelPacienteUsuario.Text + "'", ConeccionBase);
                SqlDataReader Respuesta2 = LecturaDatos2.ExecuteReader();
                while (Respuesta2.Read())
                {
                    PacienteId = Respuesta2[0].ToString();
                }
                ConeccionBase.Close();

                ConeccionBase.Open();
                SqlCommand LecturaDatos = new SqlCommand("SELECT Receta.Med1,Receta.Med2,Receta.Med3,Receta.Med4,Receta.Med5,Receta.Nota,RecetaTiempo.Time1,RecetaTiempo.Time2,RecetaTiempo.Time3,RecetaTiempo.Time4,RecetaTiempo.Time5,RecetaCiclo.Cic1,RecetaCiclo.Cic2,RecetaCiclo.Cic3,RecetaCiclo.Cic4,RecetaCiclo.Cic5 FROM Receta JOIN RecetaTiempo ON Receta.Receta_Id=RecetaTiempo.Rece_Id JOIN RecetaCiclo on RecetaCiclo.Rece_Id=RecetaTiempo.Rece_Id where RecetaCiclo.Doc_Id=" + DoctorId + " and Pac_Id=" + PacienteId + ";", ConeccionBase);
                SqlDataReader Respuesta = LecturaDatos.ExecuteReader();
              
                int i = 1;
              //  while (Respuesta.Read())
                while(Respuesta.Read())
                {
                    if ((number2) == i)
                    {
                    LabelMed1.Text = Respuesta[0].ToString();
                    LabelMed2.Text = Respuesta[1].ToString();
                    LabelMed3.Text = Respuesta[2].ToString();
                    LabelMed4.Text = Respuesta[3].ToString();
                    LabelMed5.Text = Respuesta[4].ToString();
                    LabelNota.Text = Respuesta[5].ToString();
                    LabelTime1.Text = Respuesta[6].ToString();
                    LabelTime2.Text = Respuesta[7].ToString();
                    LabelTime3.Text = Respuesta[8].ToString();
                    LabelTime4.Text = Respuesta[9].ToString();
                    LabelTime5.Text = Respuesta[10].ToString();
                    LabelCic1.Text = Respuesta[11].ToString();
                    LabelCic2.Text = Respuesta[12].ToString();
                    LabelCic3.Text = Respuesta[13].ToString();
                    LabelCic4.Text = Respuesta[14].ToString();
                    LabelCic5.Text = Respuesta[15].ToString();

                    }
                    i = (i + 1);
                }

                ConeccionBase.Close();
                LabelInicio.Text = i.ToString();
            }
            else
            {
                LabelMed2.Text = "que maaaaalllll";
            }
        }

        protected void ButtonVolver_Click(object sender, EventArgs e)
        {
            Response.Redirect("FormPaciente.aspx");
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            LabelUsuarioDoctor.Text = DropDownList1.SelectedItem.Text;
            if (LabelUsuarioDoctor.Text != "")
            {
                string DoctorId = "";
                string PacienteId = "";
                //*******************************************************************************************
                ConeccionBase.Open();  //cogemos el Id del medico del que seleccionemos en el dropdownlist
                SqlCommand LecturaDatos1 = new SqlCommand("SELECT Doc_Id FROM DoctorNew where Usuario='" + LabelUsuarioDoctor.Text + "'", ConeccionBase);
                SqlDataReader Respuesta1 = LecturaDatos1.ExecuteReader();
                while (Respuesta1.Read())
                {
                    DoctorId = Respuesta1[0].ToString();
                }
                ConeccionBase.Close();
                //**********************************************************************************************
                ConeccionBase.Open(); //cogemos el Id del paciente 
                SqlCommand LecturaDatos2 = new SqlCommand("SELECT ID FROM Paciente where Usuario='" + LabelPacienteUsuario.Text + "'", ConeccionBase);
                SqlDataReader Respuesta2 = LecturaDatos2.ExecuteReader();
                while (Respuesta2.Read())
                {
                    PacienteId = Respuesta2[0].ToString();
                }
                ConeccionBase.Close();
                //SELECT COUNT(Doc_Id) AS doctorUsu FROM Receta WHERE Doc_Id=57;
                ConeccionBase.Open();
                SqlCommand LecturaDatos = new SqlCommand("SELECT COUNT(Doc_Id) AS CantidadRecetas FROM Receta WHERE Doc_Id='" + DoctorId + "' and Pac_Id=" + PacienteId + "", ConeccionBase);
                SqlDataReader Respuesta = LecturaDatos.ExecuteReader();
                while (Respuesta.Read())
                {
                    LabelCantidadRecetas.Text = Respuesta[0].ToString();
                }
                ConeccionBase.Close();

            }
            else
            {
                LabelCantidadRecetas.Text = "nada pasa";
            }
        }
    }
}
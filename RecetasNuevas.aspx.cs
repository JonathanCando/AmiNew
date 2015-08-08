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
    public partial class RecetasNuevas : System.Web.UI.Page
    {
        SqlConnection ConeccionBase = new SqlConnection(@"user id=Cando;password=1234;server=CANDO-SATELITE;database=AMI;connection timeout=30");

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Usuario"] != null)
            {
                LabelIDDoctor.Text = Session["Usuario"].ToString(); // obtengo el nombre del usuario del doctor
            }
            else
            {
                Response.Redirect("CuentaDoctor.aspx");
            } // se va a la pagina de registro del doctor porque no tiene usuario   

            // este codigo que esta escrito es para coger una columna de la lectura de la bases de datos que deseeo
            //borre el dropdownlist por eso puede dar error
           /* ConeccionBase.Open();
            SqlCommand LecturaUsuario = new SqlCommand("SELECT * FROM Paciente ", ConeccionBase);
            SqlDataReader Paciente = LecturaUsuario.ExecuteReader();

            DropDownList1.DataSource = Paciente;
            DropDownList1.DataTextField = "Pass";
            DropDownList1.DataBind();

            ConeccionBase.Close();*/

            if (Label12.Text == "")
            {
                ConeccionBase.Open();
                //leemos en la base de datos todos los usuarios que tiene el doctor logeado
                SqlCommand LecturaDatos = new SqlCommand("SELECT * FROM DoctorPaciente JOIN Paciente ON Paciente.ID=DoctorPaciente.ID  JOIN DoctorNew ON DoctorNew.Doc_Id=DoctorPaciente.Doc_Id where DoctorNew.Usuario='" + LabelIDDoctor.Text + "'", ConeccionBase);
                SqlDataReader Respuesta = LecturaDatos.ExecuteReader();

                DropDownList2.DataSource = Respuesta;
                DropDownList2.DataTextField = "Usuario";
                DropDownList2.DataBind();

                ConeccionBase.Close();
            }
            
        }

        protected void BotonVolver_Click(object sender, EventArgs e)
        {
            Response.Redirect("FormDoctor.aspx");
        }

        protected void BotonEnviar_Click(object sender, EventArgs e)
        {
            //variable para habilitar lo que esta listo
            int fila1 = 0, fila2 = 0, fila3 = 0, fila4 = 0, fila5 = 0;

           // verifica que todos los texbos de horas y ciclos sean numeros
            long number2 = 0, number3 = 0, number4 = 0, number5 = 0, number6 = 0, number7 = 0, number8 = 0, number9 = 0, number10 = 0, number11 = 0;
            bool canConvert2 = long.TryParse(TextBox2.Text, out number2);

            bool canConvert3 = long.TryParse(TextBox3.Text, out number3);

            bool canConvert4 = long.TryParse(TextBox4.Text, out number4);

            bool canConvert5 = long.TryParse(TextBox5.Text, out number5);

            bool canConvert6 = long.TryParse(TextBox6.Text, out number6);

            bool canConvert7 = long.TryParse(TextBox7.Text, out number7);

            bool canConvert8 = long.TryParse(TextBox8.Text, out number8);

            bool canConvert9 = long.TryParse(TextBox9.Text, out number9);

            bool canConvert10 = long.TryParse(TextBox10.Text, out number10);

            bool canConvert11 = long.TryParse(TextBox11.Text, out number11);

            //empieso a tirar codigo para enviar la receta a la bases de datos

            if ((TextMed1.Text != "" || TextMed2.Text != "" || TextMed3.Text != "" || TextMed4.Text != "" || TextMed5.Text != "") && Label12.Text != "")
            {
                fila1 = 1;
                fila2 = 1;
                fila3 = 1;
                fila4 = 1;
                fila5 = 1;

                if (TextMed1.Text != "")
                {
                    if (number2 > 0 && number7 > 0) Label18.Text = "";
                    else
                    {
                        Label18.Text = "Esta fila esta incompleta o tiene datos inconrrectos";
                        fila1 = 0; // esto significa que escribio una medicina pero no la hora y el ciclo
                    }
                }
                else
                {
                    number2 = 0; // esto es para que los datos que no tengan medicamento vaya con o tiempo y ciclo
                    number7 = 0;
                    Label18.Text = "";
                } 
                if (TextMed2.Text != "")
                {
                    if (number3 > 0 && number8 > 0) Label19.Text = "";
                    else
                    {
                        Label19.Text = "Esta fila esta incompleta o tiene datos inconrrectos";
                        fila2 = 0; // esto significa que escribio una medicina pero no la hora y el ciclo
                    }
                }
                else
                {
                    number3 = 0;
                    number8 = 0;
                    Label19.Text = "";
                } 
                if (TextMed3.Text != "")
                {
                    if (number4 > 0 && number9 > 0) Label20.Text = "";
                    else
                    {
                        Label20.Text = "Esta fila esta incompleta o tiene datos inconrrectos";
                        fila3 = 0; // esto significa que escribio una medicina pero no la hora y el ciclo
                    }
                }
                else
                {
                    number4 = 0;
                    number9 = 0;
                    Label20.Text = "";
                } 
                if (TextMed4.Text != "")
                {
                    if (number5 > 0 && number10 > 0) Label21.Text = "";
                    else
                    {
                        Label21.Text = "Esta fila esta incompleta o tiene datos inconrrectos";
                        fila4 = 0; // esto significa que escribio una medicina pero no la hora y el ciclo
                    }
                }
                else
                {
                    number5 = 0;
                    number10 = 0;
                    Label21.Text = "";
                } 
                if (TextMed5.Text != "")
                {
                    if (number6 > 0 && number11 > 0) Label22.Text = "";
                    else
                    {
                        Label22.Text = "Esta fila esta incompleta o tiene datos inconrrectos";
                        fila5 = 0; // esto significa que escribio una medicina pero no la hora y el ciclo
                    }
                }
                else
                {
                    number6 = 0;
                    number11 = 0;
                    Label22.Text = "";
                } 
                LabelRevisarPaciente.Text = "";
            }
            // ya cumplio con todos los requisitos ya puede ir a la base de datos
            if(fila1==1 && fila2==1 && fila3==1 && fila4==1 && fila5==1)
            {

                string DoctorId = "";
                string PacienteId = "";
                string Receta_Id = "";

                ConeccionBase.Open();  //cogemos el Id del medico del que se logeo
                SqlCommand LecturaDatos1 = new SqlCommand("SELECT Doc_Id FROM DoctorNew where Usuario='" + LabelIDDoctor.Text + "'", ConeccionBase);
                SqlDataReader Respuesta1 = LecturaDatos1.ExecuteReader();
                while (Respuesta1.Read())
                {
                    DoctorId = Respuesta1[0].ToString(); 
                }
                ConeccionBase.Close();
                //-------------------------------------------------
                ConeccionBase.Open(); //cogemos el Id del paciente del que seleccionemos en el dropdownlist
                SqlCommand LecturaDatos2 = new SqlCommand("SELECT ID FROM Paciente where Usuario='" + Label12.Text + "'", ConeccionBase);
                SqlDataReader Respuesta2 = LecturaDatos2.ExecuteReader();
                while (Respuesta2.Read())
                {
                    PacienteId = Respuesta2[0].ToString();
                }
                ConeccionBase.Close();
                //---------------------------------------------------------
                ConeccionBase.Open();
                SqlCommand EscritorDatos = new SqlCommand("insert into Receta (Doc_Id,Pac_Id,Med1,Med2,Med3,Med4,Med5,Nota) values('" + DoctorId + "','" + PacienteId + "','" + TextMed1.Text + "','" + TextMed2.Text + " ','" + TextMed3.Text + "','" + TextMed4.Text + " ','" + TextMed5.Text + "','" + TextBox1.Text + "')", ConeccionBase);
                EscritorDatos.ExecuteNonQuery();
                ConeccionBase.Close();
                //***********************************************************
                ConeccionBase.Open();
                SqlCommand LecturaDatos3 = new SqlCommand("SELECT COUNT(Doc_Id) AS doctorUsu FROM Receta where Doc_Id='" + DoctorId + "'", ConeccionBase);
                SqlDataReader Respuesta3 = LecturaDatos3.ExecuteReader();
                while (Respuesta3.Read())
                {
                    Receta_Id = Respuesta3[0].ToString(); // colocamos todos las contrase;as las tarjetas de la bases de datos
                }
                ConeccionBase.Close();
                //*****************************************************************
                ConeccionBase.Open();
                SqlCommand EscritorDatos1 = new SqlCommand("insert into RecetaTiempo (Receta_Id,Time1,Time2,Time3,Time4,Time5,Doc_Id) values('" + Receta_Id + "','" + number2 + "','" + number3 + "','" + number4 + "','" + number5 + "','" + number6+ "','"+DoctorId+"')", ConeccionBase);
                EscritorDatos1.ExecuteNonQuery();
                ConeccionBase.Close();
                //*****************************************************************
                ConeccionBase.Open();
                SqlCommand EscritorDatos2 = new SqlCommand("insert into RecetaCiclo (Receta_Id,Cic1,Cic2,Cic3,Cic4,Cic5,Doc_Id) values('" + Receta_Id + "','" + number7 + "','" + number8 + "','" + number9 + "','" + number10 + "','" + number11 + "','" + DoctorId + "')", ConeccionBase);
                EscritorDatos2.ExecuteNonQuery();
                ConeccionBase.Close();
                //*****************************************************************
                LabelRevisarPaciente.Text = "Su receta fue enviada";
                TextMed1.Text = TextMed2.Text = TextMed3.Text = TextMed4.Text = TextMed5.Text = "";
                TextBox1.Text = TextBox2.Text = TextBox3.Text = TextBox4.Text = TextBox5.Text = TextBox6.Text = TextBox7.Text = TextBox8.Text = TextBox9.Text = TextBox10.Text = TextBox11.Text = "";

            }
            else // todavia no esta cumpliendo con los requisitos
            {
                LabelRevisarPaciente.Text = "No esta escrita en nada o tiene problemas una fila";
            }

        }

        protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Label12.Text = DropDownList2.SelectedItem.Text;
        }
    }
}
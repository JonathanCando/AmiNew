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
    public partial class CuentaDocToken : System.Web.UI.Page
    {

        SqlConnection ConeccionBase = new SqlConnection(@"user id=Cando;password=1234;server=CANDO-SATELITE;database=AMI;connection timeout=30");
        

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["NumeroRandom"] != null && Session["Usuario"] != null)
            {
                LabelNumeroRan.Text = Session["NumeroRandom"].ToString();
                LabelUser.Text = Session["Usuario"].ToString();
            }
               
            else Response.Redirect("CuentaDoctor.aspx"); 
        }

        protected void BotonEnter_Click(object sender, EventArgs e)
        {
            int NumeroRan; //variable donde se va a almacenar el numero random que genero el form (CuentaDoctor.aspx)
            NumeroRan = Convert.ToInt32(LabelNumeroRan.Text);// paso el numero ramdom que esta en el label
            try
            {
            /*    ConeccionBase.Open();
                SqlCommand LecturaDatos = new SqlCommand("select * from TarjetaCodigo where Usuario = '" + LabelUser.Text + "'", ConeccionBase);
                SqlDataReader Respuesta = LecturaDatos.ExecuteReader();*/

                ConeccionBase.Open();
                SqlCommand LecturaDatos = new SqlCommand("SELECT TarjetaCodigo.* FROM DoctorTarjeta JOIN DoctorNew ON DoctorNew.Doc_Id=DoctorTarjeta.Doc_Id JOIN TarjetaCodigo on TarjetaCodigo.Tarjeta_Id=DoctorTarjeta.Tarjeta_Id where DoctorNew.Usuario='" + LabelUser.Text + "'", ConeccionBase);
                SqlDataReader Respuesta = LecturaDatos.ExecuteReader();

                string CodigoNewTar = "";

              //  NumeroRan = Convert.ToInt32(LabelNumeroRan.Text);// paso el numero ramdom que esta en el label

                while (Respuesta.Read())
                {

                    CodigoNewTar = Respuesta[NumeroRan-1].ToString(); // aqui cogo el numero de la columna ejemplo si es 1 = Cod1
                }

                ConeccionBase.Close();

               

                if (TextBoxCodigo.Text == CodigoNewTar) //Compara si el codigo que insertado por el cliente estqa bien
                {
                    Response.Redirect("FormDoctor.aspx");
                }
                else
                {
                    Response.Write("Por favor, vuelve a introducir tu Codigo.");
                    Session["NumeroRandom"] = null;
                  //  int NumeroRan; //variable donde colocamos el numero random
                    Random NumeroAlea = new Random(); //numero random
                    NumeroRan = NumeroAlea.Next(1, 30);
                    Session["NumeroRandom"] = NumeroRan.ToString();
                    LabelNumeroRan.Text = Session["NumeroRandom"].ToString();  //coloca el nuevo valor ramdon en el label


                 //   Label1.Text = Session["NumeroRandom"].ToString(); Lo use de prueba
                   // Label2.Text = CodigoNewTar;   lo use de prueba
                }

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.ToString());
            }

        }
    }
}
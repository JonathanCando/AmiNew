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
    public partial class FormPaciente : System.Web.UI.Page
    {
        SqlConnection ConeccionBase = new SqlConnection(@"user id=Cando;password=1234;server=CANDO-SATELITE;database=AMI;connection timeout=30");
 
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Usuario1"] != null)
            {
                LabelPaciente.Text = Session["Usuario1"].ToString();
            }
            else
            {
                Response.Redirect("CuentaPaciente.aspx");
            } // se va a la pagina de registro del doctor porque no tiene usuario  
        }

        protected void ButtonSalir_Click(object sender, EventArgs e)
        {
            Session["Usuario1"] = null;
            Response.Redirect("Inicio.aspx"); // vuelve a la pagina de inicio
        }

    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace demo2c_chard
{
    public partial class primerapracticac_ : System.Web.UI.Page
    {
        public string Nombre = "";
        public string Apellido = "";
        public string Apellido2 = "";
        public DateTime FechaNacimiento;
        public string Email = "";
        public string mensaje="";
        protected void Page_Load(object sender, EventArgs e)
        {
            //request o peticiones de tipo get
            Nombre = HttpContext.Current.Request.QueryString["nombre"];
            Nombre = HttpContext.Current.Request.QueryString[0];
            //peticiones POst
            Nombre = HttpContext.Current.Request.Params["nombre"];
            Nombre = HttpContext.Current.Request.Params["apellido1"];
            Nombre = HttpContext.Current.Request.Params["apellido2"];
            Nombre = HttpContext.Current.Request.Params["email"];
            FechaNacimiento =
                Convert.ToDateTime(HttpContext.Current.Request.Params["fechanacimient"]);

            try
            {
                Nombre = HttpContext.Current.Request.QueryString["nombre"];
                Nombre = HttpContext.Current.Request.QueryString[0];
                //peticiones POst
                Nombre = HttpContext.Current.Request.Params["nombre"];
                Nombre = HttpContext.Current.Request.Params["apellido1"];
                Nombre = HttpContext.Current.Request.Params["apellido2"];
                Nombre = HttpContext.Current.Request.Params["email"];
                FechaNacimiento =
                    Convert.ToDateTime(HttpContext.Current.Request.Params["fechanacimient"]);
                mensaje = "Ficha registrada correctamente"
            }
            catch (Exception ex)
            {
                mensaje = "Error:" + ex.Message;
               
            }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ejemplo2.API
{
    /// <summary>
    /// Summary description for Suma
    /// </summary>
    public class Suma : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            int numero1 = Convert.ToInt32(context.Request.Params["n1"]);
            int numero2 = Convert.ToInt32(context.Request.Params["n2"]);
            int res = numero1 + numero2;
            context.Response.ContentType = "text/plain";
            context.Response.Write(res);
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}
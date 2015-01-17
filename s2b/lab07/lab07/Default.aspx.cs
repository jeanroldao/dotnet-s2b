using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace lab07
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<int> listaGenerica = new List<int>();
            listaGenerica.Add(1);
            listaGenerica.Add(2);
            listaGenerica.Add(3);

            Response.Write("Lista Generica <br/>");
            Response.Write("Capacidade: " + listaGenerica.Capacity + " <br/>");
            Response.Write("Contagem: " + listaGenerica.Count + " <br/>");
            int i = listaGenerica[1];
            Response.Write("listaGenerica[1]: " + i + " <br/>");

            listaGenerica.InsertRange(1, new int[] {4,5,6});

            foreach (int item in listaGenerica)
            {
                Response.Write(item + "<br />");
            }

            Dictionary<int, string> paises = new Dictionary<int, string>();

            paises[44] = "Reino Unido";
            paises[33] = "França";
            paises[55] = "Brasil";

            Response.Write("<br/>O código 55 é: " + paises[55]);

            foreach (KeyValuePair<int, string> item in paises)
            {
                int codigo = item.Key;
                string pais = item.Value;
                Response.Write("<br/> Código: " + codigo + " = " + pais);
            }

            Dictionary<string, int> codpaises = new Dictionary<string, int>();
            codpaises["Reino Unido"] = 44;
            codpaises["França"] = 33;
            codpaises["Brasil"] = 55;

            /*jetbeans*/
        }
    }
}
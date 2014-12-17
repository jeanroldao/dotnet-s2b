using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace lab05
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            IEstadoBinario[] lista = new IEstadoBinario[2];
            lista[0] = new Lampada(110, 60);
            lista[0].Ligar();
            lista[1] = new TermometroEletrico();
            foreach (IEstadoBinario obj in lista)
            {
                Response.Write(obj.Estado + "<br/>");
            }
        }
    }
}
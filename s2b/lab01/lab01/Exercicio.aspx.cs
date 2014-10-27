using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing;

namespace lab01
{
    public partial class Exercicio : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblResultado.Text = "";
        }

        protected void btnValidar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == String.Empty || txtSenha.Text == String.Empty)
            {
                lblResultado.ForeColor = Color.Red;
                lblResultado.Text = "Inválido";
            }
            else
            {
                lblResultado.ForeColor = Color.Blue;
                lblResultado.Text = "Válido";
            }
        }
    }
}
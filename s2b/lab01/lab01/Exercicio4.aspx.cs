using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing;

namespace lab01
{
    public partial class Exercicio4 : System.Web.UI.Page
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
                string url = "";
                switch (txtUsuario.Text)
                {
                    case "Eduardo":
                        if (txtSenha.Text == "1")
                        {
                            url = "Gerentes.aspx";
                        }
                        break;
                    case "Julia":
                        if (txtSenha.Text == "2")
                        {
                            url = "Formularios.aspx";
                        }
                        break;
                    case "Gustavo":
                        if (txtSenha.Text == "3")
                        {
                            url = "Formularios.aspx";
                        }
                        break;
                    case "Joce":
                        if (txtSenha.Text == "4")
                        {
                            url = "Formularios.aspx";
                        }
                        break;
                }
                if (url == "")
                {
                    lblResultado.ForeColor = Color.Red;
                    lblResultado.Text = "Verifique usuario e senha";
                }
                else
                {
                    Response.Redirect(url);
                }
            }
        }
    }
}
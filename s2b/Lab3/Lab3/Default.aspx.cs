using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Lab3.ClassLibrary;

namespace Lab3
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ContaCorrente minhaConta = new ContaCorrente2("Gerson");
            Response.Write("Movimentações conta: " + minhaConta.Nome + " criada em " + minhaConta.DataCriacao.ToShortDateString() + "<br/>");
            Response.Write(minhaConta.Saldo + " - " + minhaConta.DataUltimoMovimento.ToShortDateString() + "<br/>");
            minhaConta.Depositar(100);
            Response.Write(minhaConta.Saldo + " - " + minhaConta.DataUltimoMovimento.ToShortDateString() + "<br/>");
            minhaConta.Sacar(50);
            Response.Write(minhaConta.Saldo + " - " + minhaConta.DataUltimoMovimento.ToShortDateString() + "<br/>");

        }
    }
}
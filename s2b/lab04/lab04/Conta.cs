using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace lab04
{
    public abstract class Conta
    {
        private decimal saldo;
        private string titular;

        public decimal Saldo { get { return saldo; } }
        public string Titular { get { return titular; } }

        public Conta(string t)
        {
            titular = t;
        }

        public abstract string Id {get;}

        public virtual void Depositar(decimal valor)
        {
            saldo += valor;
        }

        public virtual void Sacar(decimal valor)
        {
            if (valor <= saldo)
            {
                saldo -= valor;
            }
        }
    }

}
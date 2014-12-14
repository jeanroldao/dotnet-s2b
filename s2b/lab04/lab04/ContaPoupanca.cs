﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace lab04
{
    public class ContaPoupanca : Conta
    {
        private decimal taxaJuros;
        private DateTime dataAniversario;

        public decimal TaxaJuros { 
            get { return taxaJuros; }
            set { taxaJuros = value; } 
        }
        public DateTime DataAniversario { 
            get { return dataAniversario; } 
        }

        public override string Id { 
            get { return Titular + " (CP)"; } 
        }

        public ContaPoupanca(decimal j, DateTime d, string t)
            :base(t)
        {
            taxaJuros = j;
            dataAniversario = d;
        }

        public void AdicionarRendimento()
        {
            if (DateTime.Now.Equals(dataAniversario))
            {
                decimal rendimento = Saldo * taxaJuros;
                Depositar(rendimento);
            }
        }


    }
}
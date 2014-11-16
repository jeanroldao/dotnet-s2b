using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab3.ClassLibrary
{
    public class ContaCorrente
    {
        private string nome;
        private decimal saldo;
        private DateTime dataCriacao;
        private DateTime dataUltimoMovimento;

        public string Nome
        {
            get { return nome; }
        }

        public decimal Saldo
        {
            get { return saldo; }
        }

        public DateTime DataCriacao { get { return dataCriacao; } }
        public DateTime DataUltimoMovimento { get { return dataUltimoMovimento; } }

        public ContaCorrente(string nome) : this(nome, 0M)
        {
        }

        public ContaCorrente(string nome, decimal saldoInicial)
        {

            dataCriacao = DateTime.Now;
            dataUltimoMovimento = DateTime.Now;

            this.nome = nome;
            this.saldo = saldoInicial;
        }

        public void Depositar(decimal val)
        {
            dataUltimoMovimento = DateTime.Now;
            saldo = saldo + val;
        }

        public virtual void Sacar(decimal val)
        {
            dataUltimoMovimento = DateTime.Now;
            if (val <= saldo)
                saldo = saldo - val;
        }


    }

    public class ContaCorrente2 : ContaCorrente 
    {
        public ContaCorrente2(string nome) : base(nome)
        {
            
        }
        public ContaCorrente2(string nome, decimal v) : base(nome, v)
        {
            
        }
        public override void Sacar(decimal val)
        {
            throw new Exception("não implementado");
        }
    }
}

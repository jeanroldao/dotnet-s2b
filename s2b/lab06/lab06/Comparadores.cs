using System;
using System.Collections.Generic;
using System.Collections;

namespace lab06
{

    public class ComparadorNomePessoa : IComparer
    {
        public int Compare(object x, object y)
        {
            Pessoa p1 = (Pessoa)x;
            Pessoa p2 = (Pessoa)y;
            return p1.Nome.CompareTo(p2.Nome);
        }
    }

    public class ComparadorIdadePessoa : IComparer
    {
        public int Compare(object x, object y)
        {
            Pessoa p1 = (Pessoa)x;
            Pessoa p2 = (Pessoa)y;
            return p1.Idade - p2.Idade;
        }
    }
}

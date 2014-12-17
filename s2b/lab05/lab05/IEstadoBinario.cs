using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lab05
{
    public enum EstadoBinario {Ligado,Desligado}

    public interface IEstadoBinario
    {
        void Ligar();
        void Desligar();
        EstadoBinario Estado { get; }
    }
}

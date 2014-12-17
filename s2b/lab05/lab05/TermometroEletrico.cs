﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace lab05
{
    public class TermometroEletrico : Termometro, IEstadoBinario
    {
        private EstadoBinario estado = EstadoBinario.Desligado;
        public void Ligar()
        {
            estado = EstadoBinario.Ligado;
        }
        public void Desligar()
        {
            estado = EstadoBinario.Desligado;
        }
        public EstadoBinario Estado
        {
            get { return estado; }
        }
    }

}
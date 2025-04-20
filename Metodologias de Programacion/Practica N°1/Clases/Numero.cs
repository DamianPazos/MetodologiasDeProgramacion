﻿using Practica_N_1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_N_1.Clases
{
    // Ejercicio N°2 - Practica N°1
    public class Numero : Comparable
    {
        private int valor;

        public Numero(int valor)
        {
            this.valor = valor;
        }

        public bool sosIgual(Comparable c)
        {
            return this.valor == ((Numero)c).valor;
        }

        public bool sosMayor(Comparable c)
        {
            return this.valor > ((Numero)c).valor;
        }

        public bool sosMenor(Comparable c)
        {
            return this.valor < ((Numero)c).valor;
        }
    }
}

using Practica_N_1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_N_1.Clases
{
    // Ejercicio N°8 - Practica N°1
    public class ColeccionMultiple
    {
        Pila pila;
        Cola cola;

        public ColeccionMultiple(Pila pila, Cola cola)
        {
            this.pila = pila;
            this.cola = cola;
        }

        public int cuantos()
        {
            return pila.cuantos() + cola.cuantos();
        }

        public Comparable minimo()
        {
            Coleccionable minimos = new Pila();
            minimos.agregar(pila.minimo());
            minimos.agregar(cola.minimo());
            return minimos.minimo();
        }

        public Comparable maximo()
        {
            Coleccionable maximos = new Pila();
            maximos.agregar(pila.maximo());
            maximos.agregar(cola.maximo());
            return maximos.maximo();
        }

        public void agregar(Comparable c)
        {
            // Metodo sin accion
        }

        public bool contiene(Comparable c)
        {
            return pila.contiene(c) || cola.contiene(c);
        }
    }
}

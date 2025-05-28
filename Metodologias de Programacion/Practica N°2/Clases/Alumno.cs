using Practica_N_2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_N_2.Clases
{
    // Ejercicio N°12 - Practica N°1
    public class Alumno : Persona
    {
        private int legajo;
        private float promedio;
        private EstrategiaComparar _estrategiaComparar;

        public Alumno(string nombre, int dni, int legajo, float promedio) : base(nombre, dni)
        {
            this.legajo = legajo;
            this.promedio = promedio;
            // Ejercicio N°1 - Practica N°2
            this._estrategiaComparar = new EstrategiaCompararLegajo();
        }

        public int getLegajo()
        {
            return legajo;
        }

        public float getPromedio()
        {
            return promedio;
        }

        // Ejercicio N°1 - Practica N°2
        public void setEstrategia(EstrategiaComparar estrategia)
        {
            _estrategiaComparar = estrategia;
        }

        // Ejercicio N°15 - Practica N°1
        // Ejercicio N°1 - Practica N°2
        public bool sosIgual(Comparable c)
        {
            return _estrategiaComparar.sosIgual(this, c);
        }

        public bool sosMayor(Comparable c)
        {
            return _estrategiaComparar.sosMayor(this, c);
        }

        public bool sosMenor(Comparable c)
        {
            return _estrategiaComparar.sosMenor(this, c);
        }
    }
}

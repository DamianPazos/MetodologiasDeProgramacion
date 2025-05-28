using Practica_N_2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_N_2.Clases
{
    // Ejercicio N°1 - Practica N°2
    public class EstrategiaCompararNombre : EstrategiaComparar
    {
        public bool sosIgual(Comparable c1, Comparable c2)
        {
            return ((Alumno)c1).getNombre() == ((Alumno)c2).getNombre();
        }

        public bool sosMayor(Comparable c1, Comparable c2)
        {
            return string.Compare(((Alumno)c1).getNombre(), ((Alumno)c2).getNombre()) > 0;
        }

        public bool sosMenor(Comparable c1, Comparable c2)
        {
            return string.Compare(((Alumno)c1).getNombre(), ((Alumno)c2).getNombre()) < 0;
        }
    }
}

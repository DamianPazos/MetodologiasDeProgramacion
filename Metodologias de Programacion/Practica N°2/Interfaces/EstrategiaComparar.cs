using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_N_2.Interfaces
{
    // Ejercicio N°1 - Practica N°2
    public interface EstrategiaComparar
    {
        bool sosIgual(Comparable c1, Comparable c2);
        bool sosMayor(Comparable c1, Comparable c2);
        bool sosMenor(Comparable c1, Comparable c2);    
    }
}

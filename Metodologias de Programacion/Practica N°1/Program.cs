using Practica_N_1.Clases;
using Practica_N_1.Interfaces;

namespace MetodologiasDeProgramacion;
// Ejercicio N°5 - Practica N°1
public class Program
{
    static void Main(string[] args)
    {
        // codigo programa
    }

    public static void llenar(Coleccionable c)
    {
        Random random = new Random();
        for (int contador = 1; contador < 21; contador++)
        {
            Comparable numero = new Numero(random.Next(1, 100));
            c.agregar(numero);
        }
    }
}

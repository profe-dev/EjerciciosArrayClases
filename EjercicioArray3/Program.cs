using System;

namespace EjercicioArray3
{
    class Program
    {
        static void Main(string[] args)
        {
            Matriz ma = new Matriz();
            ma.Cargar();
            ma.CalcularSumaSueldos();
            ma.ImprimirTotalPagado();
            ma.EmpleadoMayorSueldo();
            Console.ReadKey();
        }
    }
}

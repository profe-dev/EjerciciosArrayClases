using System;
using System.Collections.Generic;
using System.Text;

namespace EjerciciosArray
{
    class Array
    {
        string[] nombre;
        string[] apellidoPaterno;
        string[] apellidoMaterno;
        int[] edad;

        public void Cargar()
        {
            nombre = new string[5];
            apellidoPaterno = new string[5];
            apellidoMaterno = new string[5];
            edad = new int[5];


            for (int i = 0; i < nombre.Length; i++)
            {
                string e;
                bool esNum;

                Console.WriteLine("DATOS PERSONA {0}", i+1);
                Console.WriteLine("-------------------------------");
                Console.Write("Nombre: ");
                nombre[i] = Console.ReadLine();
                Console.Write("Apellido Paterno: ");
                apellidoPaterno[i] = Console.ReadLine();
                Console.Write("Apellido Materno: ");
                apellidoMaterno[i] = Console.ReadLine();

                //Validación ingreso número
                do
                {
                    Console.Write("Edad: ");
                    e = Console.ReadLine();
                    esNum = int.TryParse(e, out edad[i]);
                    Console.WriteLine("¡Ingrese un dato válido!");
                } while (!esNum);

                Console.Clear();
            }
        }

        public void MayoresEdad()
        {
            Console.WriteLine("Personas Mayores de edad");
            Console.WriteLine("-------------------------");
            for (int i = 0; i < nombre.Length; i++)
            {
                if (edad[i] >=18)
                {
                    Console.WriteLine(nombre[i] + " " + apellidoPaterno[i] + " " + apellidoMaterno [i]);
                }
            }

            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace EjercicioArray2
{
    class Array2
    {
        //Definición de los array
        string[] nombre;
        string[] apellidoPaterno;
        string[] apellidoMaterno;
        int[] sueldo;

        //Métodos
        public void Cargar()
        {
            //Instanciamos los array asignando un largo
            nombre = new string[5];
            apellidoPaterno = new string[5];
            apellidoMaterno = new string[5];
            sueldo = new int[5];

            //LLenado de los array
            for (int i = 0; i < nombre.Length; i++)
            {
                //Variables auxiliares para controlar el ingreso de un número válido
                string s;
                bool esNum;

                Console.WriteLine("INGRESO DE DATOS TRABAJADOR {0}", i + 1);
                Console.WriteLine("------------------------------------");
                Console.WriteLine("\n");
                Console.Write("Nombre: ");
                nombre[i] = Console.ReadLine();
                Console.Write("Apellido Paterno: ");
                apellidoPaterno[i] = Console.ReadLine();
                Console.Write("Apellido Materno: ");
                apellidoMaterno[i] = Console.ReadLine();

                //Validación ingreso número válido
                do
                {
                    Console.Write("Sueldo: ");
                    s = Console.ReadLine();
                    esNum = int.TryParse(s, out sueldo[i]);
                    Console.WriteLine("¡Ingrese un dato válido!");
                } while (!esNum);

                Console.Clear();
            }
        }

        public void MayorSueldo()
        {
            //Definimos las variables locales del método
            int mayor, pos;
            mayor = sueldo[0];
            pos = 0;

            for (int i = 1; i < nombre.Length; i++)
            {
                if (sueldo[i] > mayor)
                {
                    mayor = sueldo[i];
                    pos = i;
                }
            }

            Console.WriteLine("El trabajador con sueldo mayor es " + nombre[pos]);
            Console.WriteLine("Tiene un sueldo de " + mayor);
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace PruebasDesarrollo
{
    class Array
    {
        public void rotarElementos()
        {
            int[] listaNumeros = { 75, 82, 11, 56 };
            int[] listaNumerosAux = new int[listaNumeros.Length];
            var tamaño = listaNumeros.Length;
            int m = 0;

            Console.WriteLine($"El arreglo actual es: " + string.Join(", ", listaNumeros));
            try
            {
                Console.Write($"Introduzca el numero de veces que quiere correr el arreglo: ");
                m = Int32.Parse(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine($"WARNING: Dato invalido, solo se permiten numeros enteros, intetelo de nuevo");
                Environment.Exit(0);
            }
            var movientosEfectivos = m % listaNumeros.Length;
            if (m == 0 || movientosEfectivos == 0)
            {
                Console.WriteLine($"El arreglo toma su posicion original:" + string.Join(", ", listaNumeros));
                Environment.Exit(0);
            }
            Console.Write($"El nuevo arreglo es: ");
            for (int i = 0; i <= listaNumeros.Length - 1; i++)
            {
                var nuevoIndice = i + movientosEfectivos;
                if (nuevoIndice >= listaNumeros.Length)
                {
                    nuevoIndice = nuevoIndice - tamaño;
                }
                listaNumerosAux[nuevoIndice] = listaNumeros[i];
            }
            Console.WriteLine(string.Join(", ", listaNumerosAux));
        }
    }
}

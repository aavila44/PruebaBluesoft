using System;
using System.Collections.Generic;
using System.Text;

namespace PruebaBluesoft
{
    class ArrayService
    {
        public void rotarElementos()
        {
            int[] listaNumeros = { 75, 82, 11, 56 };
            int longitudArreglo = listaNumeros.Length;
            int movimientosSolicitados = 0;
            int movientosEfectivos = 0;

            Console.WriteLine($"El arreglo actual es: " + string.Join(", ", listaNumeros));
            try
            {
                Console.Write($"Introduzca el numero de veces que quiere correr el arreglo: ");
                movimientosSolicitados = Int32.Parse(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine($"WARNING: Dato invalido, solo se permiten numeros enteros, intetelo de nuevo");
                Environment.Exit(0);
            }
            movientosEfectivos = this.calcularMovimientosEfectivos(movimientosSolicitados, longitudArreglo);

            Console.Write($"El nuevo arreglo es: ");
            Console.WriteLine(string.Join(", ", rotarArreglo(movientosEfectivos, listaNumeros)));
        }
        private int calcularMovimientosEfectivos(int movimientosSolicitados, int longitudArreglo)
        {
            int movientosEfectivos = movimientosSolicitados % longitudArreglo;
            return movientosEfectivos;
        }
        private int[] rotarArreglo(int movientosEfectivos, int[] listaNumeros)
        {
            int[] listaNumerosAux = new int[listaNumeros.Length];
            if (movientosEfectivos == 0)
            {
                return listaNumeros;
            }
            for (int i = 0; i <= listaNumeros.Length - 1; i++)
            {
                var nuevoIndice = i + movientosEfectivos;
                if (nuevoIndice >= listaNumeros.Length)
                {
                    nuevoIndice = nuevoIndice - listaNumeros.Length;
                }
                listaNumerosAux[nuevoIndice] = listaNumeros[i];
            }
            return listaNumerosAux;
        }
    }
}
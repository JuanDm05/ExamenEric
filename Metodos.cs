using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ExamenEric
{
    internal class Metodos
    {
        public void EstudiantesGrupo()
        {
            //Random random = new Random();
            //random.Next(0,100);
            //int[] arreglo = {random.Next()};

            int[] arreglo = { 10, 12, 13, 7, 9, 5,1,2,3,4,5,6,22,21,23,24,25,26,27,29,30,32,31,111,1112,124,90,9,71,72,73,77,75};
            Console.WriteLine("Los Numeros des ordenados son");
            for (int i = 0; i < arreglo.Length; i++)
            {
                Console.WriteLine(arreglo[i]);
            }
            int menor = 0;
            int posicion = 0;
            int cambio = 0;
            for (int i = 0;i < arreglo.Length; i++)
            {
                menor = arreglo[i];
                posicion = i;
                for (int j = i+1; j < arreglo.Length; j++)
                {
                    if (arreglo[j] < menor)
                    {
                        menor = arreglo[j];
                        posicion = j;
                    }
                }
                if (arreglo[i]!= i)
                {
                    cambio = arreglo[i];
                    arreglo[i] = arreglo[posicion];
                    arreglo[posicion] = cambio;

                }
                
        }
            Console.WriteLine("Decendentes");
            for (int i = arreglo.Length-1; i>=0; i--)
            {
                Console.WriteLine(arreglo[i]);
            }
            int izquierda = 0;
            int derecha = arreglo.Length - 1;
            bool econtrado = false;
            int valor = 75;

            while (izquierda <= derecha)
            {
                int medio = (izquierda + derecha) / 2;
                if (arreglo[medio] == valor)
                {
                    Console.WriteLine($"El valor esta en la posicion {medio}  leido de abajo hacia arriba");
                    econtrado = true;
                    break;
                }
                else if (arreglo[medio] < valor)
                {
                    izquierda = medio - 1;
                }
                else if (arreglo[medio] > valor)
                {
                    derecha = medio + 1;
                }
            }

        }
        public void Vendedores()
        {
            int[,] arreglo = new int[2, 4] { { 100, 150, 50, 200 }, { 200, 250, 50, 300 } };
            int vendedor1 = 0;

            Console.Write(arreglo[0, 0] + "");
            Console.Write(" " + arreglo[0, 1] + "");
            Console.Write(" " + arreglo[0, 2] + "");

            Console.WriteLine();
            Console.Write(arreglo[1, 0] + " ");
            Console.Write(arreglo[1, 1] + " ");
            Console.Write(arreglo[1, 2] + " ");
            Console.WriteLine();

            Console.WriteLine("Ganancia de vendedores");
            int ventaTotalVendedor1 = arreglo[0, 1] + arreglo[0,2];
            int ventaTotalVendedor2 = arreglo[1, 1] + arreglo[1, 2];



            for (int i = 0; i < arreglo.GetLongLength(0); i++)
            {
                for (int j = i+3; j < arreglo.GetLongLength(1); j++)
                {
                    Console.WriteLine();
                    Console.WriteLine($"La ganancia total del vendedor {i+1} es de {ventaTotalVendedor1}");
                    Console.WriteLine($"La ganancia total del vendedor {j} es de {ventaTotalVendedor2}");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("Para el vendedor 1");
                    Console.WriteLine($"El vendedor {i + 1} tuvo una ganancia de por su primer producto de {arreglo[0, 1]}");
                    Console.WriteLine($"El vendedor {i + 1} La ganancia total del vendedor de  por todos los productos fue de {ventaTotalVendedor1}");
                    Console.WriteLine();
                    Console.WriteLine("Para el vendedor 2");
                    Console.WriteLine($"La ganancia total del vendedor {j} es de {ventaTotalVendedor2}");
                    Console.WriteLine($"El vendedor {j} tuvo una ganancia de por su primer producto de {arreglo[1, 1]}");


                  

                }

            }
            
        }
        public void fechas()
        {
            char[] curp = new char[18];
            Console.WriteLine("Ingresa primer digito de curp");
          
        }
        

    }
   
}


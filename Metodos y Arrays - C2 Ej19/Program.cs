using System;

namespace Metodos_y_Arrays___C2_Ej19
{
    class ArraysAleatoriosPrimos
    {
        public void Rellenarvalores(int[] argarray, int min, int max)
        {
            int valor;
            ArraysAleatoriosPrimos aleato = new ArraysAleatoriosPrimos();
            for (int i = 0; i < argarray.Length; i++)
            {
                do
                {
                    valor = aleato.aleatorio(min, max);
                } while (!aleato.esPrimo(valor));
                argarray[i] = valor;
            }
        }
        public void MostrarvaloresyElMayor(int[] argarray)
        {
            int mayor = 0;
            for (int i = 0; i < argarray.Length; i++)
            {
                Console.WriteLine(argarray[i]);
                if(mayor < argarray[i])
                {
                    mayor = argarray[i];
                }   
            }
            Console.WriteLine("El numero mayor es: {0}", mayor);
        }

        public Boolean esPrimo(int numeroprimo)
        {
            Boolean posibleprimo = true;
            int i = numeroprimo;

            while ((i > 2) & (posibleprimo))
            {
                i = i - 1;
                if (numeroprimo % i == 0)
                {
                    posibleprimo = false;
                }
            } 

            return posibleprimo;
        }

        private int aleatorio(int min, int max)
        {
            Random numeroaleatorio = new Random();
            return numeroaleatorio.Next(min, max);
        }
        static void Main(string[] args)
        {
            int[] nuevoarray;
            int max, min;
            int longitud;
            ArraysAleatoriosPrimos miarray = new ArraysAleatoriosPrimos();
            Console.WriteLine("Introduce la longitud del array:");
            longitud = Convert.ToInt32(Console.ReadLine());

            nuevoarray = new int[longitud];

            Console.WriteLine("Introduce el valor mínimo:");
            min = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduce el valor máximo:");
            max = Convert.ToInt32(Console.ReadLine());

            miarray.Rellenarvalores(nuevoarray, min, max);
            miarray.MostrarvaloresyElMayor(nuevoarray);

        }
    }
}

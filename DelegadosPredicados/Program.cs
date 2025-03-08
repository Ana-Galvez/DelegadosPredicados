using System;
using System.Collections.Generic;

namespace DelegadosPredicados
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numeros = new List<int>( new int[] {1,2,3,4,5,6,7,8,9,10});
            Predicate<int> PredicadoPares = new Predicate<int>(MostrarPares);
            List<int> numerosPares = numeros.FindAll( PredicadoPares );
            foreach (var item in numerosPares) Console.WriteLine(item);
        }

        static bool MostrarPares(int numero)
        {
            if (numero % 2 == 0) return true;
            else return false;
        }
    }
}

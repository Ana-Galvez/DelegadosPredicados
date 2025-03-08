using System;
using System.Collections.Generic;

namespace DelegadosPredicados
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //List<int> numeros = new List<int>( new int[] {1,2,3,4,5,6,7,8,9,10});
            //Predicate<int> PredicadoPares = new Predicate<int>(MostrarPares);
            //List<int> numerosPares = numeros.FindAll( PredicadoPares );
            //foreach (var item in numerosPares) Console.WriteLine(item);


            // Filtrar Personas 
            List<Personas> personas = new List<Personas>();
            Personas persona1= new Personas();
            persona1.Nombre = "juan";
            persona1.Edad = 20;
            Personas persona2= new Personas();
            persona2.Nombre = "Ana";
            persona2.Edad = 43;
            Personas persona3 = new Personas();
            persona3.Nombre = "Mateo";
            persona3.Edad = 50;
            personas.AddRange( new Personas[] {persona1,persona2,persona3});
            Predicate<Personas> EncontrarPersona = new Predicate<Personas>(FiltroNombre);
            bool PersonaExiste = personas.Exists(EncontrarPersona);
            Console.WriteLine(PersonaExiste);

        }

        static bool MostrarPares(int numero)
        {
            if (numero % 2 == 0) return true;
            else return false;
        }

        //Filtrar personas
        static bool FiltroNombre(Personas persona)
        {
            if (persona.Nombre == "juan") return true;
            else return false;

        }
    }

    class Personas
    {
        private string nombre;
        private int edad;

        public string Nombre { get => nombre; set => nombre = value; }
        public int Edad { get => edad; set => edad = value; }
    }
}

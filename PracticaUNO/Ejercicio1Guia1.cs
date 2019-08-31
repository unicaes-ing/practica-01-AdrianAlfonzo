using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaUNO
{
    //------------------UNICAES------------------
    //---Facultad de Ingenería y Arquitectura---
    //--INGENIERÍA EN DESARROLLO DE SOFTWARE--
    //-Última fecha de modificación: 13.08.19
    //-------Luis Adrián Alfonzo Morán-------


    class Ejercicio1Guia1
    {
        static void Main(string[] args)
        {
            //Base
            string razaPet;
            int edadDog;
            string nombrePet;

            //Consulta
            Console.WriteLine("¿Qué tipo de mascota tienes?");
            razaPet = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("¿Cuál es el nombre de tu " + razaPet + "?");
            nombrePet = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("¿Cuántos años tiene tu mascota?");
            edadDog = Convert.ToInt32(Console.ReadLine());

            //Mostrar
            Console.Clear();
            Console.WriteLine("///////////////////////////////////////////////////////////////////////////////////////////////////////////////////");
            Console.WriteLine("------->");
            Console.WriteLine("        Tu mascota es un " + razaPet + " y se llama " + nombrePet + ". Tiene " + edadDog + " años de edad.");
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaUNO

//------------------UNICAES------------------
//---Facultad de Ingenería y Arquitectura---
//--INGENIERÍA EN DESARROLLO DE SOFTWARE--
//-Última fecha de modificación: 27.08.19
//-------Luis Adrián Alfonzo Morán-------

{
    class Ejercicio4Guia1
    {
        static void Main(string[] args)
        {
            //Base
            double numberIngres;

            //Consulta
            Console.Write("Por favor, digite un número entero positivo: ");
            numberIngres = Convert.ToInt32(Console.ReadLine());

            //Proceso
            Console.WriteLine("La raíz cuadrada de su numero es: {0}\n", Math.Sqrt(numberIngres));
            Console.ReadKey();
        }
    }
}
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


    class Ejercicio2Guia1
    {
        static void Main(string[] args)
        {
            //Base
            string name;
            string lastName;
            string charge;
            string email;
            int age;
            int day;
            int month;
            int year;
            int money;

            //Consulta
            Console.WriteLine("¿Cuál es el nombre del empleado?");
            name = Console.ReadLine();
            Console.WriteLine();
                //Apellido
                Console.WriteLine("¿Apellido?");
                lastName = Console.ReadLine();
                Console.WriteLine();
                //Edad
                Console.WriteLine("¿Edad?");
                age = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                //Cargo
                Console.WriteLine("¿Cuál es el cargo del empleado?");
                charge = Console.ReadLine();
                Console.WriteLine();
                //E-Mail
                Console.WriteLine("¿Cuál es el e-mail del empleado?");
                email = Console.ReadLine();
                Console.WriteLine();
                //Fecha
                Console.WriteLine("Escriba su fecha de contratación exacta");
                Console.Write("Dia: ");
                day = Convert.ToInt32(Console.ReadLine());
                Console.Write("Mes: ");
                month = Convert.ToInt32(Console.ReadLine());
                Console.Write("Año: ");
                year = Convert.ToInt32(Console.ReadLine());
                //Sueldo
                Console.WriteLine();
                Console.WriteLine("¿Cuánto gana mensualmente?");
                money = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("\nPresione cualquier tecla para visualizar los datos...");
                Console.ReadKey();
            Console.Clear();

            //Mostrar
            Console.WriteLine("---->Información de los trabajadores<----");
            Console.WriteLine("Nombre: {0}", name);
            Console.WriteLine("Apellido: {0}", lastName);
            Console.WriteLine("Cargo: {0}", charge);
            Console.WriteLine("Edad: {0}", age);
            Console.WriteLine("E-mail: {0}", email);
            Console.WriteLine("Fecha de contratación: {0}/{1}/{2}", day, month, year);
            Console.WriteLine("Ingreso mensual: ${0}", money);
            Console.WriteLine("");
            Console.WriteLine("<-----PRESIONE CUALQUIER TECLA PARA SALIR----->");
            Console.ReadLine();
        }
    }
}

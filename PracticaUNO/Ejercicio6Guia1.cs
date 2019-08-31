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
    //-Última fecha de modificación: 27.08.19
    //-------Luis Adrián Alfonzo Morán-------

    class Ejercicio6Guia1
    {
        static void Main(string[] args)
        {
            //Variables y arreglos
            string name;
            string last;
            int money;
            int afp;
            int isss;

            //Constantes
            const double AFP = 13.74;
            const double ISSS = 33.32;

            //Consulta
            Console.Write("Nombre del trabajador: ");
            name = Console.ReadLine();
            Console.Write("Apellido del trabajador: ");
            last = Console.ReadLine();
            Console.Write("Sueldo Mensual: ");
            money = Convert.ToInt32(Console.ReadLine());

            //Procesos
            if (money >= 526)
            {
                //AFP
                afp = Convert.ToInt32(money/AFP);
                //ISSS
                isss = Convert.ToInt32(money/ISSS);

                Console.Clear();
                Console.WriteLine("Información:");
                Console.WriteLine("Nombre Completo: {0} {1}", name, last);
                Console.WriteLine("Sueldo Mensual: ${0}", money);
                Console.WriteLine("Descuento AFP:${0}", afp);
                Console.WriteLine("Descuento ISSS:${0}", isss);
                Console.WriteLine("Sueldo afectado por descuentos de ISSS y AFP: ${0}\n", (afp - isss)+ money);
                Console.WriteLine("Presiona [SPACE] para salir");
                Console.ReadKey();

            }
            if (money <= 525)
            {
                //AFP
                afp = Convert.ToInt32(money/AFP);
                //ISSS
                isss = Convert.ToInt32(money/ISSS);

                //Mostrar
                Console.Clear();
                Console.WriteLine("Información:");
                Console.WriteLine("Nombre Completo: {0} {1}", name, last);
                Console.WriteLine("Sueldo Mensual: ${0}", money);
                Console.WriteLine("Descuento AFP:${0}", afp);
                Console.WriteLine("Descuento ISSS:${0}", isss);
                Console.WriteLine("Sueldo afectado por descuentos de ISSS y AFP: ${0}\n", (afp - isss) + money);
                Console.WriteLine("Presiona [SPACE] para salir");
                Console.ReadKey();
            }
        }
    }
}

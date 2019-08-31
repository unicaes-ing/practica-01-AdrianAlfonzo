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

    class Ejercicio5Guia1
    {
        static void Main(string[] args) {
            //Base 
            int opc;
                       
            //Meses del año
            int[] month;
            month = new int[13];

            //Promedio de ingresos
            int[] prom;
            prom = new int[5];

            //Resultado
            int[] show;
            show = new int[5];

            //Mostrar
            do
            {
                Console.Clear();
                Console.WriteLine("¿A que trimestre desea ingresar datos?\n");
                Console.WriteLine("[1] Trimestre I");
                Console.WriteLine("[2] Trimestre II ");
                Console.WriteLine("[3] Trimestre III ");
                Console.WriteLine("[4] Trimestre IV ");
                Console.WriteLine("[5] Visualizar promedio en ventas");
                Console.WriteLine("[6] SALIDA");
                Console.WriteLine("");
                opc = Convert.ToInt32(Console.ReadLine());
                
                if (opc == 1)
                {
                    Console.Clear();
                    Console.WriteLine("Escriba el total de ventas (Primer mes/primer trimestre)");
                    month[1] = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Escriba el total de ventas (Segundo mes/primer trimestre)");
                    month[2] = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Escriba el total de ventas (Tercer mes/primer trimestre)");
                    month[3] = Convert.ToInt32(Console.ReadLine());

                    //PromedioUNO
                    prom[1] = month[1] + month[2] + month[3];
                    show[1] = prom[1] / 3;
                    Console.WriteLine("Promedio: {0}\n", show[1]);
                    Console.WriteLine("Escriba [7] para volver al menu");
                    opc = Convert.ToInt32(Console.ReadLine());
                }
                
                if (opc == 2)
                {
                    Console.Clear();
                    Console.WriteLine("Escriba el total de ventas (Primer mes/segundo trimestre)");
                    month[4] = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Escriba el total de ventas (Segundo mes/segundo trimestre)");
                    month[5] = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Escriba el total de ventas (Tercer mes/segundo trimestre)");
                    month[6] = Convert.ToInt32(Console.ReadLine());

                    //PromedioDOS
                    prom[2] = month[4] + month[5] + month[6];
                    show[2] = prom[2] / 3;
                    Console.WriteLine("Promedio: {0}", show[2]);
                    Console.WriteLine("Escriba [7] para volver al menu");
                    opc = Convert.ToInt32(Console.ReadLine());  
                }

                if (opc == 3)
                {
                    Console.Clear();
                    Console.WriteLine("Escriba el total de ventas (Primer mes/tercer trimestre)");
                    month[7] = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Escriba el total de ventas (Segundo mes/tercer trimestre)");
                    month[8] = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Escriba el total de ventas (Tercer mes/tercer trimestre)");
                    month[9] = Convert.ToInt32(Console.ReadLine());

                    //PromedioTRES
                    prom[3] = month[7] + month[8] + month[9];
                    show[3] = prom[3] / 3;
                    Console.WriteLine("Promedio: {0}", show[3]);
                    Console.WriteLine("Escriba [7] para volver al menu");
                    opc = Convert.ToInt32(Console.ReadLine());
                }

                if (opc == 4)
                {
                    Console.Clear();
                    Console.WriteLine("Escriba el total de ventas (Primer mes/tercer trimestre)");
                    month[10] = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Escriba el total de ventas (Segundo mes/tercer trimestre)");
                    month[11] = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Escriba el total de ventas (Tercer mes/tercer trimestre)");
                    month[12] = Convert.ToInt32(Console.ReadLine());

                    //PromedioTRES
                    prom[4] = month[10] + month[11] + month[12];
                    show[4] = prom[4] / 3;
                    Console.WriteLine("Promedio: {0}", show[4]);
                    Console.WriteLine("Escriba [7] para regresar al menu principal");
                    opc = Convert.ToInt32(Console.ReadLine());
                }

                if (opc == 5)
                {
                    Console.Clear();
                    Console.WriteLine("Total de ventas correspondiente a cada trimestre del año pasado");
                    Console.WriteLine("---------------------------------------------------------------");
                    Console.WriteLine("[Primer Trimestre]: {0}", show[1]);
                    Console.WriteLine("[Segundo Trimestre]: {0}", show[2]);
                    Console.WriteLine("[Tercer Trimestre]: {0}", show[3]);
                    Console.WriteLine("[Cuarto Trimestre]: {0}\n", show[4]);
                    Console.WriteLine("*Si algún dato aparece con 0 probablemente sea porque no ha registrado cambios*");
                    Console.WriteLine("Escriba [7] para volver al menu");
                    opc = Convert.ToInt32(Console.ReadLine());
                }

                if (opc == 6)
                {
                    Environment.Exit(-1);
                }


            } while (opc > 6);
        }
    }
}

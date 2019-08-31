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
    class Ejercicio3Guia1
    {
        static void Main(string[] args)
        {

            //Base 
            string numAgregado = "Numero agregado: ";
            decimal num1;
            decimal num2;
            decimal answerSuma;
            decimal answerResta;
            decimal answerMultiplicacion;
            decimal answerDivision;

            //Consulta
            Console.Write("Escriba el primer numero: ");
            num1 = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("{0} {1}\n", numAgregado, num1);
            Console.Write("Escriba el segundo numero: ");
            num2 = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("{0} {1}", numAgregado, num2);
            Console.WriteLine("");
            Console.WriteLine("Presione [SPACE] para continuar");
            Console.ReadKey();


            //Procesos
            answerSuma = num1 + num2;
            answerResta = num1 - num2;
            answerMultiplicacion = num1 * num2;
            answerDivision = num1 / num2;


            //Mostrar
            Console.Clear();
            Console.WriteLine("La suma de los numeros anteriores es: {0}\n", Math.Round(answerSuma, 1));
            Console.WriteLine("La resta de ambos numeros anteriores es: {0}\n", Math.Round(answerResta, 1));
            Console.WriteLine("La multiplicacion de ambos numeros es: {0}\n", Math.Round(answerMultiplicacion, 1));
            Console.WriteLine("La division de ambos numeros es: {0}\n", Math.Round(answerDivision, 1));
            Console.ReadKey();
        }
    }
}

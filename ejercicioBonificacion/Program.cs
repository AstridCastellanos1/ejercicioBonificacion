using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioBonificacion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ///Pruebas Astrid

            Console.WriteLine("Ingrese años Laborales: ");
            double anios = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese salario: ");
            double salario = double.Parse(Console.ReadLine());
            double salarioTotal = 0;
            double slarioPromedio = 0;
            if ( anios >=1 && anios < 2)
            {
                salarioTotal = salario + (salario *0.15);
            }
            else if ( anios >=2  && anios <= 5)
            {
                salarioTotal = salario + (salario *0.20);
            }else if (anios > 5 ) 
            {
                salarioTotal = salario + (salario * 1.25);
            }
            Console.WriteLine("salario total es de : {0}", salarioTotal);
            Console.WriteLine("Esto es un mensaje de pruebas ");
            Console.WriteLine("Esto es un mensaje de pruebas de Astrid");
        }
    }
}

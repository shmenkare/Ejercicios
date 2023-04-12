using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////Practicas 1 INTRODUCCION

            //Console.WriteLine("Hola mundo");
            //Console.WriteLine();

            ////Practicas 2


            //Console.WriteLine("Hola");
            //Console.WriteLine("Orion");
            //Console.WriteLine();

            ////Practicas 3

            //Console.WriteLine("¿Como te llamas?");
            //string x = Console.ReadLine();

            //Console.WriteLine("Encantado de conocerte " + x);
            //Console.WriteLine();

            ////Practicas 4 TIPOS DE DATOS A

            //double pi = 3.1416;
            //double radio = 60;
            //double superficie = 4 * pi * Math.Pow(radio, 2);
            //double volumen = 4 / 3 * pi * Math.Pow(radio, 3);


            //Console.WriteLine("Superficie: " + superficie);

            //Console.WriteLine("Volumen: " + volumen);
            //Console.WriteLine();

            ////Practicas 5

            //char uno = Convert.ToChar(Console.ReadLine());
            //char dos = Convert.ToChar(Console.ReadLine());
            //char tres = Convert.ToChar(Console.ReadLine());

            //Console.WriteLine(tres + " " + dos + " " + uno);
            //Console.WriteLine();


            //Practicas 6


            //double c =Convert.ToDouble(Console.ReadLine());

            //double k = c + 273;
            //double f = c * 18 / 10 + 32;


            //Console.WriteLine($"Kelvin={k}");
            //Console.WriteLine($"Fahrenheit={f}");
            //Console.WriteLine();

            //Practicasd 7

            //Console.WriteLine("Ingrese el ancho x:");
            //int x=Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Ingrese el alto y:");
            //int y = Convert.ToInt32(Console.ReadLine());

            //double perimetro = x * 2 + y * 2;
            //double area = x * y;
            //double diag =Math.Sqrt( Math.Pow(x, 2) + Math.Pow(y, 2));

            //Console.WriteLine("Perimetro: " + perimetro);
            //Console.WriteLine("Area: "+ area);
            //Console.WriteLine("Diagonal: "+ diag);

            //Console.WriteLine();

            //Practica 8

            //Console.WriteLine("Ingrese la distancia en metros:");
            //double d = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Ingrese el tiempo en horas:");
            //double h = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Ingrese el tiempo en minutos:");
            //double m = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Ingrese el tiempo en segundos:");
            //double s = Convert.ToInt32(Console.ReadLine());

            //double ms = d/((h*3600)+(m*60)+s);
            //double kh = ((d / 1000) /(h + (1*m / 60) + (s*1/3600)));
            //double mh = ((d / 1609) /( h + (1 * m / 60) + (s * 1 / 3600)));


            //Console.WriteLine("La velocidad en metros/seg es: " + ms +"m/s");
            //Console.WriteLine("La velocidad en Km/h es: " + kh+"k/h");
            //Console.WriteLine("La velocidad en millas/h es: " + mh+"m/h");

            //Console.WriteLine();

            //PRACTICA 9

            //Console.WriteLine("Ingrese un numero:");
            //int num = Convert.ToInt32(Console.ReadLine());

            //for (int i = 1; i <= 10; i++)
            //{

            //    Console.WriteLine(num+"x"+i+"="+ num*i);
            //    Console.WriteLine();

            //}
            //Console.WriteLine();


            //PRACTICA 10

            //int num = 1;

            for (int i = 1; i <= 3; i++)
            {
                for (int x = 1; x <= 8; x++)
                {
                    Console.Write(x);

                }

                Console.WriteLine();

            }


            //PRACTICA 11






            Console.ReadKey();

        }
    }
}

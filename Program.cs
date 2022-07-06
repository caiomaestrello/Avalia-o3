using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avaliação3
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Escolha uma forma geométrica para calcular: \n\n1 - TRIÂNGULO \n2 - CIRCULO \n3 - TRAPÉZIO");
            int forma = Convert.ToInt32(Console.ReadLine());

            if (forma < 0 || forma > 3)
            {
                Console.WriteLine("Digite um valor válido, tente novamente!");
                Console.ReadKey();
            }
            else
            {
                Console.Clear();
                switch (forma)
                {
                    case 1:
                        double b, h, A;
                        Console.Write("Digite a altura do triângulo: ");
                        h = Convert.ToDouble(Console.ReadLine());
                        if (h < 0)
                        {
                            Console.WriteLine("A altura do triângulo não pode ser negativa.");
                            Console.ReadKey();
                        }
                        Console.Write("Digite a base do triângulo: ");
                        b = Convert.ToDouble(Console.ReadLine());
                        A = (b * h) / 2;
                        Console.Write("Área total do triângulo: " + A + " cm");
                        break;
                    case 2:

                        double raio, pi = 3.14159265358979323846, a;
                        Console.Write("Digite o valor do raio do circulo: ");
                        raio = Convert.ToDouble(Console.ReadLine());
                        if (raio < 0)
                        {
                            Console.WriteLine("Digite um valor positivo.");
                        }
                        else
                        {
                            a = pi * (raio * raio);
                            Console.Write("Área total do circulo: " + a);
                        }
                        break;
                    case 3:
                        double area, basem, baseM, alt;
                        Console.Write("Digite a base menor do trapézio: ");
                        basem = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Digite a base maior do trapézio: ");
                        baseM = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Digite a altura do trapézio: ");
                        alt = Convert.ToDouble(Console.ReadLine());
                        if (basem < 0 || baseM < 0 || alt < 0)
                        {
                            Console.WriteLine("Digite um valor positivo para todas as posições.");
                        }
                        else
                        {
                            area = ((basem + baseM) * alt) / 2;
                            Console.Write("Área total do trapézio: " + area);
                        }
                        break;


                }
                Console.ReadKey();
            }

            Console.ReadKey();


        }
    }
}
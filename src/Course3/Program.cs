using System;

namespace Course3
{
    class Program
    {
        static void Main(string[] args)
        {
            //bool c1 = 2 > 3 || 4 != 5; // true
            //bool c2 = !(2 > 3) && 4 != 5; // true
            //Console.WriteLine(c1);
            //Console.WriteLine(c2);
            //Console.WriteLine("--------------");
            //bool c3 = 10 < 5; // false
            //bool c4 = c1 || c2 && c3; // true
            //Console.WriteLine(c3);
            //Console.WriteLine(c4);

            //___________________________________________________________//

            //Console.WriteLine("Entre com um número inteiro:");
            //int x = int.Parse(Console.ReadLine());

            //if (x % 2 == 0)
            //{
            //    Console.WriteLine("Par");
            //}
            //else
            //{
            //    Console.WriteLine("Ímpar");
            //}

            //___________________________________________________________//

            //Console.WriteLine("Qual a hora atual?");
            //int hora = int.Parse(Console.ReadLine());

            //if (hora < 12)
            //{
            //    Console.WriteLine("Bom dia!");
            //}
            //else if (hora >= 12 && hora <= 18)
            //{
            //    Console.WriteLine("Boa tarde");
            //}
            //else
            //{
            //    Console.WriteLine("Boa noite");
            //}

            //___________________________________________________________//

            Console.WriteLine("Digite três números:");
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());

            double resultado = maior(n1, n2, n3);

            Console.WriteLine($"Maior = {resultado}");
            
            Console.ReadKey();

        }

        static int maior(int a, int b, int c)
        {
            int m;

            if (a>b && a >c)
            {
                m = a;
            }
            else if (b>c)
            {
                m = b;
            }
            else
            {
                m = c;
            }

            return m;            

        }



    }
}

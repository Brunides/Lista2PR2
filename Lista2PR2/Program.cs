using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista2PR2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //exercicio 1 

            //double x, y;

            //Console.WriteLine("digite a quantidade de laranjas desejadas: ");
            //x = double.Parse(Console.ReadLine());
            //if (x < 12)
            //    y = x * 0.35;
            //else
            //y = x * 0.28;

            //Console.WriteLine("o valor total é igual a: " + y);


            //exercicio 2 

            //int ano, resposta;

            //Console.WriteLine("em que ano você nasceu: ");
            //ano = int.Parse(Console.ReadLine());
            //resposta = 2023 - ano;

            //if( resposta < 16)
            //{
            //    Console.WriteLine("você não tem direito ao voto:");
            //}
            //else
            //{
            //    Console.WriteLine("você tem direito ao voto");
            //}



            //exercicio 3 


            //double a, b, c;

            //Console.WriteLine("digite o valor do lado do triangulo:");
            //a = double.Parse(Console.ReadLine());
            // Console.WriteLine("digite o valor do lado do triangulo:");
            //b = double.Parse(Console.ReadLine());
            // Console.WriteLine("digite o valor do lado do triangulo:");
            //c = double.Parse(Console.ReadLine());

            //if (a == b && b == c)
            //{
            //    Console.WriteLine("o triangulo é equilatero");

            //}
            //else if (a == b && b != c || a != b && b == c)
            //{
            //    Console.WriteLine("o triangulo e isoceles");
            //}
            //else 
            //{
            //    Console.WriteLine("o triangulo é escaleno");
            //        };


            //exercicio 4 

            //double a, b, c, d, e, f;

            //Console.WriteLine("digite o valor do lado do triangulo:");
            //a = double.Parse(Console.ReadLine());
            // Console.WriteLine("digite o valor do lado do triangulo:");
            //b = double.Parse(Console.ReadLine());
            // Console.WriteLine("digite o valor do lado do triangulo:");
            //c = double.Parse(Console.ReadLine());

            //d = (b * b) - 4 * (a * c);
            //e = b * -1 + d / d / 2 * a;
            //f = c - d / d / 2 * a;


            //exercicio 5 


            //int a, b, c;

            //Console.WriteLine("digite o numero :");
            //a = int.Parse(Console.ReadLine());
            //if( a % 3 == 0)
            //{
            //    Console.WriteLine("o numero é divisivel por 3");
            //}
            //else
            //{ 
            //    Console.WriteLine("o numero nao é divisivel por 3 ");
            //} 
            //if( a % 5 == 0)
            //{
            //    Console.WriteLine("o numero é divisivel por 5");
            //}
            //else
            //{ 
            //    Console.WriteLine("o numero nao é divisivel por 5 ");
            //}

            //if (a % 3 == 0 && a % 5 == 0)
            //{
            //    Console.WriteLine("o numero é divisivel por 3 e por 5 ");

            //}
            //else { Console.WriteLine("o numero nao é divisivel por 3 nem por 5 "); }


            //exercicio 6 


            //double a, b, c;

            //Console.WriteLine("digite o valor do angulo do triangulo:");
            //a = double.Parse(Console.ReadLine());
            // Console.WriteLine("digite o valor do angulo do triangulo:");
            //b = double.Parse(Console.ReadLine());
            // Console.WriteLine("digite o valor do angulo do triangulo:");
            //c = double.Parse(Console.ReadLine());

            //if (a == 60 && b == 60 && c == 60)
            //{
            //    Console.WriteLine("o triangulo é um acutangulo");

            //}
            //else if (a == 90 || b == 90 || c == 90)
            //{
            //    Console.WriteLine("o triangulo possui um angulo reto ");
            //}
            //else if (a > 90 || b > 90 || c > 90)
            //{
            //    Console.WriteLine("o triangulo possui um angulo obtuso ");
            //        };


            //exercicio 7

            //int a, b, c;

            //Console.WriteLine("qual o valor do numero ");
            //a = int.Parse(Console.ReadLine());
            //Console.WriteLine("qual o valor do numero ");
            //b = int.Parse(Console.ReadLine());
            //Console.WriteLine("qual o valor do numero ");
            //c = int.Parse(Console.ReadLine());

            //if (a < b && b < c) 
            //Console.WriteLine(a +" "+ b+" " + c);

            //else if (a < b  && b > c)
            //    Console.WriteLine(a + " " + c + " "+b);
            //else if (b < a  && a < c)
            //    Console.WriteLine(b + " " + a + " "+c);
            //else if (b < a  && a > c)
            //    Console.WriteLine(b + " " + c + " "+a);
            //else if (c < a  && a < b)
            //    Console.WriteLine(c + " " + a + " "+b);
            //else if (c < a  && a > c)
            //    Console.WriteLine(c + " " + b + " "+a);


            //exercicio 8

            //int ano;

            //Console.WriteLine("digite o ano desejado:");
            //ano= int.Parse(Console.ReadLine());


            //if (ano % 4 == 0)
            //    Console.WriteLine("o ano é bissexto");
            //else
            //    Console.WriteLine("o ano nao é bissexto");


            //exercicio 9

            //double a, b, d;
            //char car;

            //Console.WriteLine("digite o numero:");
            //a = double.Parse(Console.ReadLine());
            //Console.WriteLine("digite o numero:");
            //b = double.Parse(Console.ReadLine());
            //Console.WriteLine("digite a operação:");
            //car = char.Parse(Console.ReadLine());

            //if (car == '+' )
            //{
            //    d = a + b;
            //    Console.WriteLine(d);

            //        }
            //else if (car == '-')
            //{
            //    d = a - b;
            //    Console.WriteLine(d);
            //}
            //else if (car == '*')
            //{
            //    d = a * b;
            //    Console.WriteLine(d);
            //}
            //else if (car == '/')
            //{
            //    d = a / b;
            //    Console.WriteLine(d);
            //}















            //exercicio 10


            //            Na linguagem C#, existem diferentes maneiras de gerar números aleatórios, tanto inteiros quanto reais.

            //Para gerar um número inteiro aleatório, podemos usar a classe Random do C#.
            //Para isso, devemos criar uma instância dessa classe e chamar o método Next() para gerar um número aleatório.
            //Podemos especificar o intervalo em que queremos gerar o número passando dois argumentos para o método Next(),
            //representando o valor mínimo e máximo do intervalo (o valor máximo não é incluído no intervalo). Por exemplo,
            //para gerar um número aleatório entre 1 e 100, podemos usar o seguinte código:

            //Random random = new Random();
            //int numeroAleatorio = random.Next(1, 101);

            //Para gerar um número real aleatório, podemos usar a mesma classe Random,
            //mas dessa vez chamando o método NextDouble().Esse método retorna um número aleatório entre 0 e 1.
            //Para gerar um número aleatório em um intervalo específico,
            //podemos multiplicar o resultado por um valor que represente a amplitude do intervalo e depois somar com o valor mínimo do intervalo.Por exemplo,
            //para gerar um número aleatório entre 0 e 10, podemos usar o seguinte código:


            //Random random = new Random();
            //double numeroAleatorio = random.NextDouble() * 10;






        }
    }
}
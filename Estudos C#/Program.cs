using System;

namespace FirstLesson
{
    class Project
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("Hello World");     // Printar em C#
            Console.Beep();                      // beep
            */

            //////////////////////////////////////////////////////////

            // Variáveis
            /*
            int x; // Declaração
            x = 101; // Atribuição

            int y = 102; // Declaração + Atribuição

            int z = x + y; // Operação

            int idade = 20; // int = inteiro

            double altura = 1.75; // double = decimal

            bool vivo = true; // bool = true / false

            char inicial = 'E'; // char = 1 caracterer

            String nome = "Erick"; // string = texto

            String username = nome + idade + "." + inicial;

            Console.WriteLine("A soma de x e y é: " + z); // Concatenação
            Console.WriteLine("Você têm " + idade + " anos");
            Console.WriteLine("Você tem " + altura + "m");
            Console.WriteLine("Você está vivo? " + vivo);
            Console.WriteLine("Sua inicial é: " + inicial);
            Console.WriteLine("Seu nome é: " + nome);
            Console.WriteLine("Seu nome de usuário é: " + username);
            */

            ///////////////////////////////////////////////////////////

            // Constantes = variáveis que não mudam
            /*
            const double pi = 3.14;
            */

            ///////////////////////////////////////////////////////////

            // Conversão de Tipo
            /*
            double a = 3.85;
            int b = Convert.ToInt32(a);         // converte um double pra int
            Console.WriteLine(b);

            int c = 555;
            double d = Convert.ToDouble(c) + 0.1;    // converte um int pra double
            Console.WriteLine(d);

            int e = 8528585;
            string f = Convert.ToString(e) + 555;    // converte um int pra string
            Console.WriteLine(f);

            string g = "A";
            char h = Convert.ToChar(g);             // converte uma string pra char    
            Console.WriteLine(h);

            string i = "true";
            bool j = Convert.ToBoolean(i);          // converte uma string pra bool 
            Console.WriteLine(j.GetType());
            */

            ///////////////////////////////////////////////////////////
           
            // User Input
            /*
            Console.WriteLine("Digite seu nome");
            String nome = Console.ReadLine();
           
            Console.WriteLine("Digite sua idade");
            int idade = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Olá " + nome + ", você tem " + idade + " anos."); 
            */

            ///////////////////////////////////////////////////////////
           
            // Operadores Aritméticos
            /*
            double x = 10;
            
            // x += 5;           // Adição
             
            // x -= 3;         // Subtração 

            // x *= 2;       // Multiplicação 

            // x /= 2;     // Divisão  

            // x %= 3;   // Módulo  

            // x++;    // Incremento

            //  x--; // Decremento    

            Console.WriteLine(x);
            */

            ///////////////////////////////////////////////////////////
            
            // Math
            /*
            double x = 3.88;
            double y = 5;
            double z = -6;

            double a = Math.Pow(x, 2);       // Potência
            double b = Math.Sqrt(y);        // Raiz Quadrada
            double c = Math.Abs(z);        // Valor Absoluto
            double d = Math.Round(x);     // Valor arredondado para o inteiro mais próximo
            double e = Math.Ceiling(x);  // Valor arredondado para cima
            double f = Math.Floor(x);   // Valor arredondado para baixo
            double g = Math.Max(x, y); // Maior valor

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(d);
            Console.WriteLine(e);
            Console.WriteLine(f);
            Console.WriteLine(g);
            */

            ///////////////////////////////////////////////////////////
            
            // Números Aleatórios
            /*
            Random aleatorio = new Random();

            int num = aleatorio.Next(1, 11);       // Número inteiro aleatório entre 1 e 10
            double num2 = aleatorio.NextDouble(); // Número decimal aleatório entre 0 e 1

            Console.WriteLine(num);
            Console.WriteLine(num2.ToString("F2"));
            */

            ///////////////////////////////////////////////////////////
            
            // Calculadora de Hipotenusa


            //////////////////////////////////////////////////////////
            Console.ReadKey(); // Espera o usuário pressionar uma tecla para fechar o console
        }
    }
}

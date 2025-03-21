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
            /*
            Console.WriteLine("Digite o lado A");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o lado B");
            double b = Convert.ToDouble(Console.ReadLine());

            double resultado = Math.Sqrt((a * a) + (b * b));

            Console.WriteLine("o resultado da Hipotenusa é: "+ resultado.ToString("F2"));
            */

            ///////////////////////////////////////////////////////////

            // Métodos Strings
            /*
            String nome = "Erick";
            String nome_completo = "Erick Lima";
            String tel = "123.456.789.0";


            nome = nome.ToUpper(); // Tudo maiúsculo
            nome = nome.ToLower(); // Tudo minúsculo
            Console.WriteLine(nome);

            tel = tel.Replace(".", "-"); // Substituir  
            Console.WriteLine(tel);

            String usuario = nome.Insert(0, "@"); // Inserir
            Console.WriteLine(usuario);

            Console.WriteLine(nome_completo.Length); // Tamanho  

            String primeiro_nome = nome_completo.Substring(0, 5); // Corta a string com o index inicial desejável e depois quantas "casas" serão puladas no total
            String ultimo_nome = nome_completo.Substring(6, 4); // ou (6) já que é até o último index
            Console.WriteLine(primeiro_nome);
            Console.WriteLine(ultimo_nome);
            */

            ///////////////////////////////////////////////////////////

            // if
            /*
            Console.WriteLine("Digite sua idade: ");
            int idade = Convert.ToInt32(Console.ReadLine());

            if (idade >= 18 && idade <= 69){
                Console.WriteLine("Você é um adulto!");
            }
            else if(idade > 70){
                Console.WriteLine("Você é um idoso!");
            }
            else if (idade < 0){
                Console.WriteLine("Você ainda não nasceu!");
            }
            else
            {
                Console.WriteLine("Você é menor de idade!");
            }
            

            Console.WriteLine("Digite seu nome: ");
            String nome = Console.ReadLine();

            if (nome != ""){
                Console.WriteLine("Olá " + nome);
            }
            
            else{
                Console.WriteLine("Você não digitou seu nome!");
            }
            */

            ///////////////////////////////////////////////////////////

            // Switches
            /*
            Console.WriteLine("Digite o dia da semana: ");
            String dia = Console.ReadLine();
            switch(dia){
                case "segunda":
                    Console.WriteLine("Hoje é Segunda-Feira");
                    break;
                case "terça":
                    Console.WriteLine("Hoje é Terça-Feira");
                    break;
                case "quarta":
                    Console.WriteLine("HOje é Quarta-Feira");
                    break;
                case "quinta":
                    Console.WriteLine("Hoje é Quinta-Feira");
                    break;
                case "sexta":
                    Console.WriteLine("Hoje é Sexta-Feira");
                    break;
                case "sábado":
                    Console.WriteLine("Hoje é Sábado");
                    break;
                case "domingo":
                    Console.WriteLine("Hoje é Domingo");
                    break;
                default:
                    Console.WriteLine("Digite um dia válido");
                    break;
            }
            */

            ///////////////////////////////////////////////////////////
            // Operadores Lógicos

            // && = AND checa se as duas condições são verdadeiras caso 1 seja falsa é falso
            // || = OR checa se uma ou outra condição é verdadeira caso 1 seja verdadeira é verdadeiro
            /*
            Console.WriteLine("Digite a temperatura: ");
            int temp = Convert.ToInt32(Console.ReadLine());

            if (temp >= 10 && temp <= 38)
            {
                Console.WriteLine("A temperatura está normal");
            }
            else if (temp < 10 || temp >= 40)
            {
                Console.WriteLine("A temperatura está anormal");    
            }
            else
            {
                { Console.WriteLine("Digite uma temperatura válida"); }
            }
            */

            /////////////////////////////////////////////////////////// 

            // While Loop

            /*
            String nome = "";

            while (nome == "")
            {
                Console.Write("Digite o seu nome:  ");
                nome = Console.ReadLine();
            }

            Console.WriteLine("Olá " + nome);
            */

            ///////////////////////////////////////////////////////////

            // For Loop

            /*
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }
            */

            ///////////////////////////////////////////////////////////

            // Loops Aninhados

            /*
            Console.WriteLine("Quantas linhas: ");
            int linhas = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Quantas colunas: ");
            int colunas = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Qual simbolo: ");
            char simbolo = Convert.ToChar(Console.ReadLine());

            for (int i = 0; i < linhas; i++)
            {
                for (int j = 0; j < colunas; j++)
                {
                    Console.Write(simbolo);
                }
                Console.WriteLine();
            }
            */

            ///////////////////////////////////////////////////////////

            //////////////////////////////////////////////////////////
            Console.ReadKey(); // Espera o usuário pressionar uma tecla para fechar o console
        }
    }
}

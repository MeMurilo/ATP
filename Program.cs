using System;

class Program
{
    static void Main(string[] args)
    {
        // Menu de seleção dos exercícios
        Console.WriteLine("Qual exercício deseja acessar?");
        Console.WriteLine("1 - Ex01");
        Console.WriteLine("2 - Ex02");
        Console.WriteLine("3 - Ex03");
        Console.WriteLine("4 - Ex04");
        Console.WriteLine("5 - Ex05");
        Console.WriteLine("6 - Ex06");
        Console.WriteLine("7 - Ex07");
        Console.WriteLine("8 - Ex08");
        Console.WriteLine("9 - Ex09");
        Console.WriteLine("10 - Ex10");

        // Leitura da escolha do usuário
        int res = int.Parse(Console.ReadLine());

        // Seleção do exercício correspondente
        switch (res)
        {
            case 1:
                Ex01();
                break;
            case 2:
                Ex02();
                break;
            case 3:
                Ex03();
                break;
            case 4:
                Ex04();
                break;
            case 5:
                Ex05();
                break;
            case 6:
                Ex06();
                break;
            case 7:
                Ex07();
                break;
            case 8:
                Ex08();
                break;
            case 9:
                Ex09();
                break;
            case 10:
                Ex10();
                break;
            default:
                Console.WriteLine("Escreva entre os números 1 a 10!");
                break;
        }
    }

    
    static void Ex01()
    {
        // Função para calcular a média aritmética
        static double MediaA(int a, int b, int c)
        {
            int soma = a + b + c;
            return (double)soma / 3;
        }

        // Função para calcular a média ponderada
        static double MediaP(int a, int b, int c)
        {
            return (double)(a * 5 + b * 3 + c * 2) / 10;
        }

        // Função principal do exercício 1
        Console.WriteLine("Quantos alunos deseja calcular as médias?");
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Aluno: " + (i + 1));

            // Leitura das notas dos alunos
            Console.WriteLine("Digite a nota:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a nota:");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a nota:");
            int c = int.Parse(Console.ReadLine());

            // Escolha entre média aritmética ou ponderada
            Console.WriteLine("Digite a opção desejada: \nA - Média aritmética\nP - Média ponderada");
            char op = char.Parse(Console.ReadLine());

            if (op == 'A' || op == 'a')
            {
                double media = MediaA(a, b, c);
                Console.WriteLine("A média aritmética é: " + media);
            }
            else if (op == 'P' || op == 'p')
            {
                double media = MediaP(a, b, c);
                Console.WriteLine("A média ponderada é: " + media);
            }
        }
    }

    
    static void Ex02()
    {
        // Função para calcular a média de filhos
        static double CalcularFilhos(int numFilhos, int i)
        {
            return (double)numFilhos / i;
        }

        // Função para calcular a média de salários
        static double CalcularSalario(int salario, int i)
        {
            return (double)salario / i;
        }

        // Função para coletar dados de salários e número de filhos
        static void Coleta(ref int salario, ref int numFilhos, ref int i)
        {
            char sair;
            do
            {
                Console.WriteLine("Para parar digite 'N':");
                Console.WriteLine("Ou digite qualquer tecla para continuar:");
                sair = char.Parse(Console.ReadLine());
                if (sair != 'N')
                {
                    Console.WriteLine("Informe o Salário:");
                    salario += int.Parse(Console.ReadLine());

                    Console.WriteLine("Quantos filhos possui:");
                    numFilhos += int.Parse(Console.ReadLine());

                    i++; // Incrementa o contador para a média
                }

                Console.Clear();
            } while (sair != 'N');
        }

        // Função principal do exercício 2
        char resInicial;
        int numFilhos = 0, salario = 0;
        int i = 0;

        do
        {
            Console.WriteLine("Deseja fazer o procedimento? \nDigite: 'S' (sim) ou 'N' (não)");
            resInicial = char.Parse(Console.ReadLine());
            if (resInicial == 'S')
            {
                Coleta(ref salario, ref numFilhos, ref i);
                double mediaSalario = CalcularSalario(salario, i);
                double mediaFilhos = CalcularFilhos(numFilhos, i);
                Console.Clear();

                // Exibe os resultados das médias
                Console.WriteLine("A média dos salários é: " + mediaSalario);
                Console.WriteLine("A média de filhos é: " + mediaFilhos);
            }
            else if (resInicial == 'N')
            {
                Console.Clear();
                Console.WriteLine("Procedimento cancelado!");
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Digite corretamente!");
            }
        } while (resInicial != 'S' && resInicial != 'N');
    }

    
    static void Ex03()
    {
        static void procedimentoDois() //Segundo procedimento
        {
            int res = 0;
            Console.WriteLine("Digite quantos valores de 3 números serão feitos:"); //Quantos conjuntos de 3 valores serão feitos
            res = int.Parse(Console.ReadLine());
            for (int i = 1; i <= res; i++) //for para parar apenas quando fazer todos os procedimentos determinados pelo o usuário
            {

                int p = 0;
                int s = 0;
                int t = 0;

                Console.WriteLine("Escreva o 1º número:");
                int a = int.Parse(Console.ReadLine());
                Console.WriteLine("Escreva o 2º número:");
                int b = int.Parse(Console.ReadLine());
                Console.WriteLine("Escreva o 3º número:");
                int c = int.Parse(Console.ReadLine());

                if (a > b && a > c) //if organizar crescetemente os números
                {
                    p = a;
                    if (b > c)
                    {
                        s = b;
                        t = c;
                    }
                    else
                    {
                        s = c;
                        t = b;
                    }
                }
                else if (b > a && b > c)
                {
                    p = b;
                    if (a > c)
                    {
                        s = a;
                        t = c;
                    }
                    else
                    {
                        s = c;
                        t = a;
                    }
                }
                else if (c > a && c > b)
                {
                    p = c;
                    if (a > b)
                    {
                        s = a;
                        t = b;
                    }
                    else
                    {
                        s = b;
                        t = a;
                    }

                }

                Console.WriteLine("Ordem crescente dos números do " + i + "º conjunto: {0}, {1}, {2}", t, s, p);

            }


        }

        static void procedimentoUm() 
        {
            int a, b, c = 0;
            int p = 0;
            int s = 0;
            int t = 0;

            Console.WriteLine("Escreva o 1º número:");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Escreva o 2º número:");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Escreva o 3º número:");
            c = int.Parse(Console.ReadLine());

            if (a > b && a > c) 
            {
                p = a;
                if (b > c)
                {
                    s = b;
                    t = c;
                }
                else
                {
                    s = c;
                    t = b;
                }
            }
            else if (b > a && b > c)
            {
                p = b;
                if (a > c)
                {
                    s = a;
                    t = c;
                }
                else
                {
                    s = c;
                    t = a;
                }
            }
            else if (c > a && c > b)
            {
                p = c;
                if (a > b)
                {
                    s = a;
                    t = b;
                }
                else
                {
                    s = b;
                    t = a;
                }
            }
            Console.Clear();
            Console.WriteLine("Ordem crescente dos números: {0}, {1}, {2}", t, s, p); //Resultado com os números crescentes
        }

        static void menu() //Aqui o usuário escolhe à qual procedimento fazer
        {
            int resp;

            Console.WriteLine("Qual procedimento deseja fazer?");
            Console.WriteLine("1 - Ordem crescente:");
            Console.WriteLine("2 - Ordem crescente de inderteminados números:");
        }

        
        
            int resp;
            menu();
            resp = int.Parse(Console.ReadLine());
            if (resp == 1)
            {
                procedimentoUm();
            }
            else if (resp == 2)
            {
                procedimentoDois();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Escreva o número 1 ou 2");
                
            }
        }
    

    static void Ex04()
    {
        static void procedimentoDois() 
        {
            Console.WriteLine("Quantos triângulos serão lidos?");
            int num = int.Parse(Console.ReadLine());

            for (int i = 1; i <= num; i++)
            { //Repete a operação dependendo de quantas vezes o usuário pedir
                Console.WriteLine("Digite os valores do " + i + "º triângulo:");
                verificacao();
            }
        }


        static void procedimentoUm() 
        {
            verificacao();
        }

        static void verificacao()
        { //Verifica se um lado do triângulo não é maior que a soma de outros dois lados 

            Console.WriteLine("Digite o valor do lado X");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor do lado Y");
            int y = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor do lado Z");
            int z = int.Parse(Console.ReadLine());

            if (x > (y + z) || y > (x + z) || z > (x + y))
            {
                Console.WriteLine("Um comprimento não pode ser maior que a soma dos outros lados!");
            }
            else
            {
                tipoTriangulo(x, y, z);
            }

        }

        static void tipoTriangulo(int x, int y, int z)
        { //Determina o tipo do triângulo

            if (x == y && x == z)
            {
                Console.WriteLine("Triângulo Equilátero");
            }
            else if (x == y || x == z || z == y)
            {
                Console.WriteLine("Triângulo Isóceles");
            }
            else
            {
                Console.WriteLine("Triângulo Escaleno");
            }

        }

        static void menu() //Aqui o usuário escolhe à qual procedimento fazer
        {

            Console.WriteLine("Qual procedimento deseja fazer?");
            Console.WriteLine("1 - Verificar qual trìângulo é:");
            Console.WriteLine("2 - Verificar qual trìângulo é, de inderteminadas vezes:");
        }

       

            menu();
            int resp = int.Parse(Console.ReadLine());
            if (resp == 1)
            {
                procedimentoUm();
            }
            else if (resp == 2)
            {
                procedimentoDois();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Escreva o número 1 ou 2");
               
            }
        
    }

    static void Ex05()
    {
       
            Console.Write("Digite o primeiro número: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Digite o segundo número: ");
            int num2 = int.Parse(Console.ReadLine());

            int mdc = CalcularMDC(num1, num2); //Pega os valores do parametro CalcularMDC
            Console.WriteLine($"O MDC de {num1} e {num2} é {mdc}");//Resultado
        

        static int CalcularMDC(int a, int b)//Calcula o MDC
        {
            while (b != 0) //Vai para quando o b ser igual a zero concluindo a operação
            {
                int temp = b;
                b = a % b;
                a = temp;
                Console.WriteLine(temp);
                Console.WriteLine(a);
                Console.WriteLine(b);
            }
            return a; //Retorna o valor de a
        }
    }

    static void Ex06()
    {
        static void procedimentoDois() //Procedimento 2
        {
            Console.WriteLine("Quantas vezes serão realizados o procedimento?");
            int num = int.Parse(Console.ReadLine());

            for (int i = 1; i <= num; i++) //For para repetir a quantidade de vezes que pediu
            {
                Console.WriteLine("Procedimento " + i + ":");
                Oper();
            }

        }

         static void procedimentoUm() //Procedimento 1
        {
            Oper();
        }

         static void Oper() // Operação aonde ocorre as fuuncionalidade do código
        {
            int x;
            Console.WriteLine("Escreva um número inteiro:");
            x = int.Parse(Console.ReadLine());

            bool resu = Verificar(x);

            // if para dar o resultado de true e false
            if (resu)
            {
                Console.WriteLine(resu);
            }
            else
            {
                Console.WriteLine(resu);
            }
        }

         static bool Verificar(int x) // Caso seja false retornará false, o mesmo para true
        {
            return x > 0;
        }

         static void menu() //Menu 
        {
            Console.WriteLine("Escolha uma opção:");
            Console.WriteLine("1 - Procedimento 1");
            Console.WriteLine("2 - Procedimento 2");
        }

        
            int res;
            menu(); //Leva ao menu para escolher o procedimento
            res = int.Parse(Console.ReadLine());//lê o que o usuário escolheu

            // if para levar em cada procedimento
            if (res == 1)
            {
                procedimentoUm();
            }
            else if (res == 2)
            {
                procedimentoDois();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Digite entre os números 1 ou 2!");                
            }
        
    }

    static void Ex07()
    {
        static void procedimentoDois() 
        {
            Console.WriteLine("Quantas notas de alunos serão efetuadas?");
            int n = int.Parse(Console.ReadLine());

            int[] vet = new int[n]; 

            for (int i = 0; i < vet.Length; i++)// Repete até que bata o valor de comprimento do vetor
            {
                Console.WriteLine("Nota");
                vet[i] = int.Parse(Console.ReadLine());
                If(vet[i]);
            }
        }

        static void procedimentoUm() 
        {
            int num = 0;
            Console.WriteLine("Digite a nota média final do aluno:");
            num = int.Parse(Console.ReadLine());
            If(num);
        }

        static void If(int x) // o tratamento do conceito da nota
        {
            if (x <= 39)
            {
                Console.WriteLine("Conceito F");
            }
            else if (x >= 40 && x <= 59)
            {
                Console.WriteLine("Conceito E");
            }
            else if (x >= 60 && x <= 69)
            {
                Console.WriteLine("Conceito D");
            }
            else if (x >= 70 && x <= 79)
            {
                Console.WriteLine("Conceito C");
            }
            else if (x >= 80 && x <= 89)
            {
                Console.WriteLine("Conceito B");
            }
            else if (x >= 90)
            {
                Console.WriteLine("Conceito A");
            }
        }


        static void menu() //Menu 
        {
            Console.WriteLine("Escolha uma opção:");
            Console.WriteLine("1 - Ler a média de um aluno:");
            Console.WriteLine("2 - Ler média de determinado alunos:");
        }

        
            int res;
            menu(); //Leva ao menu para escolher o procedimento
            res = int.Parse(Console.ReadLine());//lê o que o usuário escolheu

            // if para levar em cada procedimento
            if (res == 1)
            {
                procedimentoUm();
            }
            else if (res == 2)
            {
                procedimentoDois();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Digite entre os números 1 ou 2!");
            }
        
    }

    static void Ex08()
    {
        static double CalcularS(int n) 
        {
            double sum = 0.0;

            for (int i = 1; i <= n; i++)
            {
                double term = (Math.Pow(i, 2) + 1) / (i + 3);
                sum += term;
            }

            return sum; 
        }

        
            Console.WriteLine("Digite um valor inteiro positivo:");
            int num = int.Parse(Console.ReadLine()); //Lê o número digitado

            if (num > 0) 
            {
                double resultado = CalcularS(num);
                Console.WriteLine($"O valor de S para N = {num} é: {resultado}");
                //Resultado
            }
            else
            {
                Console.WriteLine("Digite um número positivo!");
            }
        
    }

    static void Ex09()
    {
        static void aluno(double a, int b) //Dados do aluno e sua média
        {
            Console.WriteLine("O aluno " + b + " teve a media de: " + a);
        }

        static void Results(double media) //Diz o resultado
        {

            if (media >= 6)
            {
                Console.WriteLine("Aprovado");
            }
            else
            {
                Console.WriteLine("Reprovado");
            }
        }

        static double Media(int a, int b) // Faz a média
        {
            double media = (double)a / b;
            return media;
        }

        static void Notas(int[] alunos, int n)
        {

            for (int i = 1; i <= alunos.Length; i++) // repetir até que bata o número de alunos
            {
                int s = 0;

                Console.WriteLine("Digite quantas notas o aluno " + i + " Colocará:");
                int not = int.Parse(Console.ReadLine());

                for (int j = 1; j <= not; j++) // Repete até que todas as notas sejam colocadas
                {
                    Console.WriteLine("Digite a " + j + "º nota:");
                    s += int.Parse(Console.ReadLine());    // soma todas as notas para a média            
                }

                double media = Media(s, not); 

                Results(media); 

                aluno(media, i); 
            }
        }

        
            Console.WriteLine("Quantos alunos terão as notas inseridas?");
            int n = int.Parse(Console.ReadLine());

            int[] alunos = new int[n];

            Notas(alunos, n);
        
    }

    static void Ex10()
    {
        static void Category(int a, ref char b, ref bool c)
        {
            

            if (a >= 18)
            {
                b = 'A';
            }
            else if (a >= 16 && a <= 17)
            {
                b = 'B';
            }
            else if (a >= 14 && a <= 15)
            {
                b = 'C';
            }
            else if (a >= 11 && a <= 13)
            {
                b = 'D';
            }
            else if (a >= 8 && a <= 10)
            {
                b = 'E';
            }
            else if (a >= 5 && a <= 7)
            {
                b = 'F';
            }
            else
            {
                //Caso não tenha idade o suficiente o char será falso para impedir que imprima os "dados finais"
                Console.WriteLine("Idade muito baixa!");
                c = false;
            }
        }
        static int Age()
        {
            Console.WriteLine("Digite a sua idade:");
            int age = int.Parse(Console.ReadLine());
            return age;
        }
        
            int idade = Age();//Leva para a seção de idade

            char categoria = default;

            bool verification = true;

            Category(idade, ref categoria, ref verification);//Leva para Category

            if (verification) // Dados finais
            {
                Console.WriteLine("Está na categoria: " + categoria);
                Console.WriteLine("O nadador tem " + idade + " anos e está na categoria: " + categoria);
            }
            else
            {
                Console.WriteLine("Tente novamente daqui alguns anos.");
            }
        
    }
}
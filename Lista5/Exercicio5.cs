using System;

 class Ex05
{
    // Função para sortear 3 números entre 10 e 50 e retorná-los em um vetor
    public static int[] SortearNumeros()
    {
        Random random = new Random();
        int[] numerosSorteados = new int[3];

        for (int i = 0; i < 3; i++)
        {
            numerosSorteados[i] = random.Next(10, 51); // Gera números de 10 a 50
        }

        return numerosSorteados;
    }

  public static void LerTentativas(int[] numerosSorteados)
    {
        int tentativa;
        bool acertou = false;

        Console.WriteLine("Tente adivinhar um dos números sorteados (entre 10 e 50):");

        while (!acertou)
        {
            // Lê a tentativa do usuário
            Console.Write("Digite um número: ");
            tentativa = int.Parse(Console.ReadLine());

            // Verifica se a tentativa está entre os números sorteados
            foreach (int numero in numerosSorteados)
            {
                if (tentativa == numero)
                {
                    Console.WriteLine($"Parabéns! Você acertou o número {numero}!");
                    acertou = true;
                    break;
                }
            }

            if (!acertou)
            {
                Console.WriteLine("Tente novamente.");
            }
        }
    }

    public static void Main()
    {
        int[] numerosSorteados = SortearNumeros();
        LerTentativas(numerosSorteados);
    }
}






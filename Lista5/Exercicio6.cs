using System;
class exercicio06
{
    static void Main(string[] args)
    {
        int[] temp = new int[31]; // Vetor para armazenar as temperaturas dos 31 dias
        tempDias(temp); // Chama o procedimento para receber as temperaturas
    }

    static void tempDias(int[] x) // Procedimento para armazenar as temperaturas diárias
    {
        int maior = 0; // Variável para armazenar a maior temperatura
        int menor = 100; // Variável para armazenar a menor temperatura
        double media = 0; // Variável para armazenar a média das temperaturas

        for (int i = 1; i <= x.Length; i++) // Loop para preencher o vetor com as temperaturas do mês
        {
            Console.WriteLine("Digite a temperatura do dia {0}:", i);
            x[i] = int.Parse(Console.ReadLine());

            if (x[i] >= 15 && x[i] <= 40) // Verifica se a temperatura está entre 15 e 40 graus
            {
                if (maior < x[i])
                    maior = x[i]; // Atualiza a maior temperatura encontrada
                if (menor > x[i])
                    menor = x[i]; // Atualiza a menor temperatura encontrada
                media += x[i]; // Soma para calcular a média das temperaturas válidas
            }
            else // Caso a temperatura não esteja entre 15 e 40 graus
            {
                Console.WriteLine($"{x[i]} não é uma temperatura válida. Tente novamente!");
                i--; // Decrementa o índice para permitir nova tentativa para o mesmo dia
            }
        }

        media = media / x.Length; // Calcula a média das temperaturas válidas
        Console.WriteLine($"A menor temperatura registrada foi: {menor} graus");
        Console.WriteLine($"A temperatura média foi: {media} graus");
        Console.WriteLine($"A maior temperatura registrada foi: {maior} graus");
    }
}

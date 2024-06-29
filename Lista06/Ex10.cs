using System;
using System.IO;

class ex10
{
    static void Main()
    {
        string arquivo = "numeros.txt"; // nome do arquivo com os números em ponto flutuante

        // Variáveis para guardar os valores
        double valorMaximo = double.MinValue;
        double valorMinimo = double.MaxValue;
        double soma = 0.0;
        int contador = 0;

        // Verificar se o arquivo existe
        if (File.Exists(arquivo))
        {
            // Abrir o arquivo para leitura
            using (StreamReader sr = new StreamReader(arquivo))
            {
                string linha;
                while ((linha = sr.ReadLine()) != null)
                {
                    // Converter a linha para número em ponto flutuante
                    if (double.TryParse(linha, out double numero))
                    {
                        // Atualizar o valor máximo e mínimo
                        if (numero > valorMaximo)
                            valorMaximo = numero;
                        if (numero < valorMinimo)
                            valorMinimo = numero;

                        // Somar para calcular a média
                        soma += numero;
                        contador++;
                    }
                    else
                    {
                        Console.WriteLine($"Erro ao converter linha: {linha}. Ignorando esta linha.");
                    }
                }
            }

            // Verificar se houve números válidos no arquivo
            if (contador > 0)
            {
                // Calcular a média
                double media = soma / contador;

                // Imprimir os resultados
                Console.WriteLine($"Valor Máximo: {valorMaximo}");
                Console.WriteLine($"Valor Mínimo: {valorMinimo}");
                Console.WriteLine($"Média: {media}");
            }
            else
            {
                Console.WriteLine("Não foram encontrados números válidos no arquivo.");
            }
        }
        else
        {
            Console.WriteLine($"Arquivo '{arquivo}' não encontrado.");
        }
    }
}

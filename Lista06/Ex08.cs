using System;
using System.IO;

class ex08
{
    static void Main()
    {
        Console.Write("Informe a quantidade de veículos da locadora: ");
        int veiculos = int.Parse(Console.ReadLine());

        Console.Write("Informe o valor do aluguel por veículo: ");
        double valorAluguel = double.Parse(Console.ReadLine());

        // Faturamento mensal
        double faturamentoMensal = (veiculos * valorAluguel) / 3;

        // Faturamento anual
        double faturamentoAnual = faturamentoMensal * 12;

        // Valor ganho com multas no mês
        double multa = (faturamentoMensal / 10) * 0.2;

        // Valor gasto com manutenção anual
        double valorManutencaoAnual = (veiculos * 0.02) * 600;

        // Exibição dos resultados
        Console.WriteLine($"Faturamento anual da locadora: R$ {faturamentoAnual:F2}");
        Console.WriteLine($"Valor ganho com multas no mês: R$ {multa:F2}");
        Console.WriteLine($"Valor gasto com manutenção anual: R$ {valorManutencaoAnual:F2}");

        // Gravação dos resultados em um arquivo
        string nomeArquivo = "resultado.txt";
        using (StreamWriter writer = new StreamWriter(nomeArquivo))
        {
            writer.WriteLine($"Faturamento anual da locadora: R$ {faturamentoAnual:F2}");
            writer.WriteLine($"Valor ganho com multas no mês: R$ {multa:F2}");
            writer.WriteLine($"Valor gasto com manutenção anual: R$ {valorManutencaoAnual:F2}");
        }

        Console.WriteLine($"Resultados gravados no arquivo '{nomeArquivo}'.");

        Console.ReadLine(); // Aguarda o usuário pressionar Enter para encerrar o programa
    }
}

class ex07{
     static void Main()
    {
        Console.Write("Informe a quantidade de letras (N): ");
        int n = int.Parse(Console.ReadLine());

        if (n <= 0)
        {
            Console.WriteLine("Quantidade inválida. Encerrando o programa.");
            return;
        }

        Console.WriteLine($"Digite {n} letras separadas por espaço:");
        string input = Console.ReadLine();

        // Escreve as letras no arquivo
        string nomeArquivo = "letras.txt";
        File.WriteAllText(nomeArquivo, input);

        // Lê o conteúdo do arquivo e conta as vogais
        string conteudo = File.ReadAllText(nomeArquivo);
        int vogais = ContarVogais(conteudo);

        Console.WriteLine($"Quantidade de vogais (a, e, i, o, u) no arquivo: {vogais}");
    }

    static int ContarVogais(string texto)
    {
        string vogais = "aeiou";
        int count = 0;

        foreach (char c in texto.ToLower())
        {
            if (vogais.Contains(c))
            {
                count++;
            }
        }

        return count;
    }
}






class ex06{



  static void Main()
    {
        
        Console.Write("Digite um número inteiro positivo: ");
        int num = int.Parse(Console.ReadLine());

        
        Console.WriteLine($"Divisores de {num}:");
        int somaDivisores = 0;

        for (int i = 1; i <= num; i++)
        {
            if (num % i == 0)
            {
                Console.WriteLine(i); 
                somaDivisores += i;   
            }
        }

        
        string ex6txt = "soma_divisores.txt";
        SalvarSomaEmArquivo(ex6txt, somaDivisores);

        Console.WriteLine($"\nSoma total dos divisores foi salva em {ex6txt}.");

        Console.ReadLine(); 
    }


    


static void SalvarSomaEmArquivo(string ex6txt, int soma)
    {
        using (StreamWriter sw = new StreamWriter(ex6txt))
        {
            sw.WriteLine($"Soma total dos divisores: {soma}");
        }
    }








}
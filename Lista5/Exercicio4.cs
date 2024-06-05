class Exercicio5
{
    static void PreencherVetores(out int[] X, out int[] Y)
    {
        X = new int[10];
        Y = new int[10];

        // Preencher o vetor X com valores de 0 a 9
        for (int i = 0; i < X.Length; i++)
        {
            X[i] = i;
        }

        // Preencher o vetor Y com valores de 10 a 19
        for (int i = 0; i < Y.Length; i++)
        {
            Y[i] = i + 10;
        }
    }

    static int[] IntercalarVetores(int[] vetor1, int[] vetor2)
    {
        int[] intercalado = new int[vetor1.Length + vetor2.Length];

        for (int i = 0, j = 0; i < intercalado.Length; i += 2, j++)
        {
            intercalado[i] = vetor1[j]; // Elementos do primeiro vetor nas posições ímpares
            intercalado[i + 1] = vetor2[j]; // Elementos do segundo vetor nas posições pares
        }

        return intercalado;
    }

    static void ExibirVetor(int[] vetor)
    {
        foreach (int elemento in vetor)
        {
            Console.Write(elemento + " ");
        }
        Console.WriteLine();
    }

    static void Main(string[] args)
    {
        int[] X, Y;
        PreencherVetores(out X, out Y);

        Console.WriteLine("Vetor X:");
        ExibirVetor(X);

        Console.WriteLine("Vetor Y:");
        ExibirVetor(Y);

        int[] vetorIntercalado = IntercalarVetores(X, Y);
        Console.WriteLine("Vetor Intercalado:");
        ExibirVetor(vetorIntercalado);
    }
}

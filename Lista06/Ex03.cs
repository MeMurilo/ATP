class ex03{



  static void Main()
    {
        Console.WriteLine("Digite sua mensagem");

        string mensagemOriginal = Console.ReadLine();
        string mensagemCriptografada = EncryptCesar(mensagemOriginal, 3);
        
        
        Console.WriteLine($"Frase criptografada: {mensagemCriptografada}");
    }

    static string EncryptCesar(string input, int shift)
    {
        // Vamos armazenar o resultado da criptografia aqui
        char[] output = new char[input.Length];

        for (int i = 0; i < input.Length; i++)
        {
            char character = input[i];

            // Verifica se é uma letra minúscula
            if (char.IsLower(character))
            {
                // Faz a criptografia considerando o deslocamento
                char encrypted = (char)('a' + (character - 'a' + shift) % 26);
                output[i] = encrypted;
            }
            // Verifica se é uma letra maiúscula
            else if (char.IsUpper(character))
            {
                // Faz a criptografia considerando o deslocamento
                char encrypted = (char)('A' + (character - 'A' + shift) % 26);
                output[i] = encrypted;
            }
            else
            {
                // Caracteres que não são letras permanecem inalterados
                output[i] = character;
            }
        }

        return new string(output);
    }






}
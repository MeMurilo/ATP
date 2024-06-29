using System;
using System.IO;
using System.Collections.Generic;

class ex09
{
    static void Main()
    {
        List<Aluno> alunos = new List<Aluno>();

        Console.WriteLine("### Cadastro de Alunos ###");

        // Receber dados dos alunos
        while (true)
        {
            Console.Write("Digite a matrícula do aluno (ou 'sair' para finalizar): ");
            string matricula = Console.ReadLine().Trim();

            if (matricula.ToLower() == "sair")
                break;

            Console.Write("Digite o telefone do aluno: ");
            string telefone = Console.ReadLine().Trim();

            alunos.Add(new Aluno(matricula, telefone));
            Console.WriteLine("Aluno cadastrado com sucesso!\n");
        }

        // Salvar dados em um arquivo
        SalvarAlunosEmArquivo(alunos);

        Console.WriteLine("\nDados dos alunos foram salvos no arquivo 'alunos.txt'.\n");

        // Ler dados de um arquivo
        Console.WriteLine("### Leitura de Dados de Alunos ###");
        List<Aluno> alunosLidos = LerAlunosDeArquivo();

        if (alunosLidos.Count > 0)
        {
            Console.WriteLine("Alunos lidos do arquivo:");
            foreach (var aluno in alunosLidos)
            {
                Console.WriteLine($"Matrícula: {aluno.Matricula}, Telefone: {aluno.Telefone}");
            }
        }
        else
        {
            Console.WriteLine("Nenhum aluno foi encontrado no arquivo.");
        }
    }

    static void SalvarAlunosEmArquivo(List<Aluno> alunos)
    {
        string nomeArquivo = "alunos.txt";

        try
        {
            using (StreamWriter writer = new StreamWriter(nomeArquivo))
            {
                foreach (Aluno aluno in alunos)
                {
                    writer.WriteLine($"{aluno.Matricula},{aluno.Telefone}");
                }
            }
        }
        catch (IOException e)
        {
            Console.WriteLine($"Ocorreu um erro ao tentar escrever o arquivo: {e.Message}");
        }
    }

    static List<Aluno> LerAlunosDeArquivo()
    {
        List<Aluno> alunos = new List<Aluno>();
        string nomeArquivo = "alunos.txt";

        try
        {
            using (StreamReader reader = new StreamReader(nomeArquivo))
            {
                string linha;
                while ((linha = reader.ReadLine()) != null)
                {
                    string[] dados = linha.Split(',');

                    if (dados.Length == 2)
                    {
                        string matricula = dados[0];
                        string telefone = dados[1];
                        alunos.Add(new Aluno(matricula, telefone));
                    }
                }
            }
        }
        catch (IOException e)
        {
            Console.WriteLine($"Ocorreu um erro ao tentar ler o arquivo: {e.Message}");
        }

        return alunos;
    }
}

class Aluno
{
    public string Matricula { get; set; }
    public string Telefone { get; set; }

    public Aluno(string matricula, string telefone)
    {
        Matricula = matricula;
        Telefone = telefone;
    }
}

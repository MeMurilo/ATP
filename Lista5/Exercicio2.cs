using System.Diagnostics.CodeAnalysis;

class Exercicio2{
static void Main(){
    //declarar vetor
   int [] notas= new int[10];
    //chamar procedimento
ColocarNotas(notas);
CalcularMedia(notas);

} 

static void ColocarNotas(int[] notas){
//colocar notas no vetor
for(int i=0; i < notas.Length; i++){
    Console.WriteLine($"Digite as notas dos Alunos");
     Console.Write($"Aluno[{i+1}]:  ");
     notas[i]=int.Parse(Console.ReadLine());
}

}
static void CalcularMedia(int[] notas){
    // criar metodo para soma das notas (Foreach para somar todo o conjunto)
    int soma=0;
    foreach(int nota in notas){
        soma +=nota;
    }

    // agora para contagem de quantos alunos ficaram acima da média
    int media=soma/notas.Length;
    int acima=0;
    foreach(int nota in notas){
        if(media>nota){
            acima++;
        }
    }

  Console.WriteLine($"A media da turma foi de: {media}");
    Console.WriteLine($"O número de alunos acimada media foi de {acima}");
    
}

}
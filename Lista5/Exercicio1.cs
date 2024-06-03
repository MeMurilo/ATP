class Exercicio1
{
    static void Main(string[] args)
    {
      //Declarando vetor
    int[] N = new int[20];
   
   //Preenchendo vetor com os números
   for(int i = 0; i < N.Length; i++){
    Console.WriteLine($"Digite o número desejado: [{i+1}]");
    N[i]= int.Parse(Console.ReadLine());

   }
  // Informar menor número e sua posição 
  
  int menor= N[0];
  int p=0;

  for(int i= 1; i < N.Length; i++){
  if(N[i] < menor){
    menor = N[i];
    p=i;
  }
  }
Console.WriteLine($"O menor número é {menor} e está na posição {p + 1}");



}
}

class ex01
{
   static void Main(){
  Console.WriteLine("Digite sua frase");
  string frase= Console.ReadLine();
  Contador(frase);

  
   }  
  
static void Contador(string frase){
    int brancos=0;
    foreach(char c in frase){
        if(char.IsWhiteSpace(c)){
            brancos++;
        }
    }
     Console.WriteLine($"Números de espaços em branco é de: {brancos}");
}









}
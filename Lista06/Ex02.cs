class ex02
{
   static void Main(){
  Console.WriteLine("Digite sua frase");
  string frase = Console.ReadLine();
  string notvogais= Separador(frase);

Console.WriteLine($"A frase sem vogais é {notvogais}");
   }  
  
  static string Separador(string frase){
   string vogais = "aeiouAEIOU";
   string semvogais = "";
   foreach(char c in frase){
    if(!vogais.Contains(c)){
        semvogais +=c;
    }
   }
return semvogais;
  }








}
using System;

class ex04
{
   
  static void Main()
    {
        string arquivo = @"J:\Lista 6\ex04.txt.txt";

        if(File.Exists(arquivo)){
            string texto = File.ReadAllText(arquivo);
            int contadorA = ContadorA(texto);
            int contadorB = ContadorB(texto);

            Console.WriteLine($"Números de caracteres'a' dentro do texto é de {contadorA} e os números de caracteres'b' dentro do texto é de {contadorB}");
             
        }
            else{
                Console.WriteLine("Arquivo não encontrado");
            }
    }
        
    

  static int ContadorA(string texto){
    int contador=0;
 foreach(char c in texto){
    if(c == 'a' || c == 'A'){
        contador ++;

    }

 }
 return contador;


 }

static int ContadorB(string texto){
    int contador=0;
    foreach(char c in texto){
        if(c== 'b' || c == 'B'){
            contador++;
        }
    }
    return contador;


}


}
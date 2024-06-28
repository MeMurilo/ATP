using System.Security.AccessControl;
using System.Xml;

class ex05{
static void Main(){

string arquivo=@"J:\Lista 6\ex05.txt.txt";

if(File.Exists(arquivo)){
    string[] linhas= File.ReadAllLines(arquivo);

   foreach(string linha in linhas){
     Console.WriteLine(linha);
   }

   


}
int qlinhas= ContadorLinhas(arquivo);
Console.WriteLine($"Quantidade de linhas: {qlinhas}");


}

static int ContadorLinhas(string arquivo){
    string []linhas= File.ReadAllLines(arquivo);

    return linhas.Length;
 }
}
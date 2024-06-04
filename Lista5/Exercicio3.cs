class Exercicio3{

//A-main 🙏

static void Main(){
    int[] X= new int[10];
    PreencherVetor(X);
int[] negativos = CopiarNegativos(X);

Console.WriteLine($"\n Valores negativos: ");
Vetor(negativos);

int [] positivos=CopiarPositivos(X);
Console.Write($"\n Valores positivos ");
Vetor(positivos);



}



//Procedimento para inserir os elementos.
static void PreencherVetor(int [] v){
    Console.WriteLine("Digite os 10 elementos");
    for(int i=0; i < v.Length; i++){
        Console.Write($"Elemento [{i+1}]:  ");
        v[i]=int.Parse(Console.ReadLine());

    }
}

//função para contar os negativos 

static int[] CopiarNegativos(int[] v)
    {
        int countNegativos = 0;
        for (int i = 0; i < v.Length; i++)
        {
            if (v[i] < 0)
                countNegativos++;
        }

        int[] negativos = new int[countNegativos];
        int n = 0;
        for (int i = 0; i < v.Length; i++)
        {
            if (v[i] < 0)
            {
                negativos[n] = v[i];
                n++;
            }
        }
        return negativos;
    }


//valores positivos 
 
 static int[] CopiarPositivos(int[]v){

    int countPositivos=0;
    for(int i = 0; i <v.Length; i++){
        if(v[i] > 0){
            countPositivos++;
        }
    }
    int[] positivos=new int[countPositivos];
    int p=0;
    for(int i=0; i<v.Length;i++){
        if(v[i] > 0)
        {
            positivos[p]=v[i];
            p++; 
        }
    }
    return positivos;
 }








//Exibição do vetor 
static void Vetor(int[]v){
    Console.WriteLine("Números: ");
    for(int i=0; i< v.Length;i++){
        Console.WriteLine(v[i] + "");

    }
    Console.WriteLine();
}






}
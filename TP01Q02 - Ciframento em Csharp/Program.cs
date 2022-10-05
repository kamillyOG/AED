using System;

namespace TP01Q02___Ciframento_em_Csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i=0; i!=-1; i++){
                string palavra= Console.ReadLine();
                if (palavra.ToUpper() == "FIM") {
                    i=-2;
                    continue;
                }
                Console.WriteLine(Ciframento(palavra));
            }
        }

        static string Ciframento(string mensagem){
            string nova="";
            for(int i=0; i<mensagem.Length; i++){
                int converte = ((int)mensagem[i])+3;
                nova+= (char)converte;
            }
            return nova;
        }
    }
}

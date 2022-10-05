using System;

namespace TP01Q03___Alteração_Aleatória_em_Csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("valores: m e d");
            for(int i=0; i!=-1; i++){
                string palavra= Console.ReadLine();
                if (palavra.ToUpper() == "FIM") {
                    i=-2;
                    continue;
                }
                Console.WriteLine(Aleatorio(palavra));
            }
        }

        static string Aleatorio(string mensagem){
            Random gerador = new Random ( 4 ) ;
            char valor1 = (char) ('a'+(Math.Abs (gerador.Next( ))% 26));
            char valor2 = (char) ('a'+(Math.Abs (gerador.Next( ))% 26));
            string nova="";
            for(int i=0; i<mensagem.Length; i++){
                nova+= mensagem[i]==valor1 ? valor2 : mensagem[i];
            }
            return nova;
        }
    }
}

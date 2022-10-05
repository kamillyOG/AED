using System;

namespace TP01Q06___Ciframento_em_Csharp___Recursivo
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
                Console.WriteLine(Ciframento(palavra, 0));
            }
        }

        static string Ciframento(string mensagem, int n){
            if(mensagem.Length-1== n){
                char aux = (char) (((int) mensagem[n])+3);
                return Convert.ToString(aux);
            }
            string nova= ((char) (((int) mensagem[n])+3)) + Ciframento(mensagem, n+1);
            return nova;
        }
    }
}

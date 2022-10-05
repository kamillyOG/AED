using System;

namespace TP01Q05___Palíndromo_em_Csharp___Recursivo
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
            }
        }

        static string Palindromo(string palavra, int n){
            if(n==0){
                return Convert.ToString(palavra[n]);
            }
            string nova = palavra[n] + Palindromo(palavra, n-1);
            return nova;
        } 
    }
}

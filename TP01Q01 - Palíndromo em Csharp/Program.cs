using System;

namespace TP01Q01___Palíndromo_em_Csharp
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
                Console.WriteLine(Palindromo(palavra));

            }
        }

        static string Palindromo(string palavra){
            string nova="";
            for(int i=palavra.Length-1; i>=0; i--){
                nova+=palavra[i];
            }
            return palavra == nova ? "SIM" : "NAO";
        } 
    }
}

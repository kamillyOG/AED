using System;

namespace TP01Q07___Is_em_Csharp___Recursivo
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
                string IsVogal=(Vogais(palavra.ToLower(), 0));
                string IsConsoante=(Consoantes(palavra.ToLower(), 0));
                string IsInteiros=(Inteiros(palavra, 0));
                string IsReal=(Real(palavra, 0));


                Console.WriteLine(IsVogal + " " + IsConsoante + " " + IsInteiros + " " + IsReal);
            }
        }

        static string Vogais(string msg, int i){
            if(msg.Length==i){
                return "SIM";
            }
            if(msg[i] != 'a' && msg[i] != 'e' && msg[i] != 'i' && msg[i] != 'o' && msg[i] != 'u'){
                return "NAO";
            } 
            return Vogais(msg, i+1);
        }

        static string Consoantes(string msg, int i){
            if(msg.Length==i){
                return "SIM";
            }
            if(msg[i] != 'b' && msg[i] != 'c' && msg[i] != 'd' && msg[i] != 'f' && msg[i] != 'g' && msg[i] != 'h' && msg[i] != 'j' && msg[i] != 'k' && msg[i] != 'l' && msg[i] != 'm' && msg[i] != 'n' && msg[i] != 'p' && msg[i] != 'q' && msg[i] != 'r' && msg[i] != 's' && msg[i] != 't' && msg[i] != 'v' && msg[i] != 'w' && msg[i] != 'x' && msg[i] != 'y' && msg[i] != 'z'){
                return "NAO";
            } 
            return Consoantes(msg, i+1);
        }

        static string Inteiros(string msg, int i){
            if(msg.Length==i){
                return "SIM";
            }
            if(msg[i] != '0' && msg[i] != '1' && msg[i] != '2' && msg[i] != '3' && msg[i] != '4' && msg[i] != '5' && msg[i] != '6' && msg[i] != '7' && msg[i] != '8' && msg[i] != '9'){
                return "NAO";
            } 
            return Inteiros(msg, i+1);
        }

        static string Real(string msg, int i){
            if(msg.Length==i){
                return "SIM";
            }
            if(msg[i] != '0' && msg[i] != '1' && msg[i] != '2' && msg[i] != '3' && msg[i] != '4' && msg[i] != '5' && msg[i] != '6' && msg[i] != '7' && msg[i] != '8' && msg[i] != '9' && msg[i] != '.' && msg[i] != ','){
                return "NAO";
            } 
            return Real(msg, i+1);
        }
    }
}

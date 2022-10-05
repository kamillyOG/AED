using System;

namespace TP01Q04___Is_em_Csharp
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
                string IsVogal=(Vogais(palavra.ToLower()));
                string IsConsoante=(Consoantes(palavra.ToLower()));
                string IsInteiros=(Inteiros(palavra));
                string IsReal=(Real(palavra));


                Console.WriteLine(IsVogal + " " + IsConsoante + " " + IsInteiros + " " + IsReal);
            }
        }

        static string Vogais(string msg){
            for(int i=0; i<msg.Length; i++){
                if(msg[i] != 'a' && msg[i] != 'e' && msg[i] != 'i' && msg[i] != 'o' && msg[i] != 'u'){
                    return "NAO";
                }
            }
            return "SIM";
        }

        static string Consoantes(string msg){
            for(int i=0; i<msg.Length; i++){
                if(msg[i] != 'b' && msg[i] != 'c' && msg[i] != 'd' && msg[i] != 'f' && msg[i] != 'g' && msg[i] != 'h' && msg[i] != 'j' && msg[i] != 'k' && msg[i] != 'l' && msg[i] != 'm' && msg[i] != 'n' && msg[i] != 'p' && msg[i] != 'q' && msg[i] != 'r' && msg[i] != 's' && msg[i] != 't' && msg[i] != 'v' && msg[i] != 'w' && msg[i] != 'x' && msg[i] != 'y' && msg[i] != 'z'){
                    return "NAO";
                }
            }
            return "SIM";
        }

        static string Inteiros(string msg){
            for(int i=0; i<msg.Length; i++){
                if(msg[i] != '0' && msg[i] != '1' && msg[i] != '2' && msg[i] != '3' && msg[i] != '4' && msg[i] != '5' && msg[i] != '6' && msg[i] != '7' && msg[i] != '8' && msg[i] != '9'){
                    return "NAO";
                }
            }
            return "SIM";
        }

        static string Real(string msg){
            for(int i=0; i<msg.Length; i++){
                if(msg[i] != '0' && msg[i] != '1' && msg[i] != '2' && msg[i] != '3' && msg[i] != '4' && msg[i] != '5' && msg[i] != '6' && msg[i] != '7' && msg[i] != '8' && msg[i] != '9' && msg[i] != '.' && msg[i] != ','){
                    return "NAO";
                }
            }
            return "SIM";
        }
    }
}

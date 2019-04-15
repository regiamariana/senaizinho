using System;

namespace scndexcs
{
    class Program2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("bodia sejem benvindos meuza migo!!!!!!!!!!!!!!!!");
            bool querSair = false;
            passageiro [] passageiros = new passageiro[2];
            int numPassageiros = 0;
            do{
                System.Console.WriteLine("escolia uma opisao");
            System.Console.WriteLine("1 - Registrar passage");
            System.Console.WriteLine("2 - exibi pasageros");
            System.Console.WriteLine("0 - sair");
            int codigo = int.Parse(Console.ReadLine());

            switch(codigo){
                case 1 :

                System.Console.WriteLine("dgt seu nome");
                passageiro p = new passageiro();
                p.setNome(Console.ReadLine());

                passageiros[numPassageiros] = p;
                numPassageiros++;
                System.Console.WriteLine("prbns vc consegui se cadastrar");
                break;
                case 2:
                foreach (var passageiro in passageiros){
                    if (passageiro != null){
                    System.Console.WriteLine(passageiro.getNome());}
                }
                break;
            }

            }while(!querSair);

            
        }
    }
}

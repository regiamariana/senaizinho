using System;

namespace pizzaresoluçao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("bem vindo ao pitzuca");
            int resposta = 0;
            do
            {
                System.Console.WriteLine ("escolha uma opção:");
                System.Console.WriteLine ("1 - cadastro");
                System.Console.WriteLine ("2 - login");
                System.Console.WriteLine ("3 - listar usuários");
                System.Console.WriteLine ("9 - sair");
                resposta = int.Parse(Console.ReadLine());

                switch (resposta)
                {
                    case 1:
                    break;

                    case 2: 
                    break;

                    case 3:
                    break;

                    case 4:
                    break;

                    default:
                    break;
                }
                
            } while (resposta != 9);
        }
    }
}

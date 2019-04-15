using System;

namespace firstexcs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("bem vindo ao sportore bank");

            contacorrente conta1 = new contacorrente();

            conta1.titular = "Cesar";

            conta1.agencia = 132;

            conta1.numeroConta = 999;

            conta1.Depositar( 10000);

            contacorrente conta2 = new contacorrente();
            conta2.titular= "Tsukamoto";
            conta2.agencia= 132;
            conta2.numeroConta= 1;
            conta2.Depositar(9000);

            System.Console.WriteLine($"---------primeira conta---------");
            System.Console.WriteLine($"Titular: {conta1.titular}");
            System.Console.WriteLine($"Agência: {conta1.agencia}");
            System.Console.WriteLine($"Conta: {conta1.numeroConta}");
            System.Console.WriteLine($"Saldo: {conta1.saldo}");
            System.Console.WriteLine($"--------------------------------");

            System.Console.WriteLine($"---------primeira conta---------");
            System.Console.WriteLine($"Titular: {conta2.titular}");
            System.Console.WriteLine($"Agência: {conta2.agencia}");
            System.Console.WriteLine($"Conta: {conta2.numeroConta}");
            System.Console.WriteLine($"Saldo: {conta2.saldo}");
            System.Console.WriteLine($"--------------------------------");

            
            bool valorRetornado = conta1.Sacar (10001);
            if(valorRetornado){
                System.Console.WriteLine("parabéns vc eh burgues safad");
            }else{
                System.Console.WriteLine("sem dinhero irmao");
            }
            System.Console.WriteLine($"saldo depois do saque: {conta1.exibirSaldo()}");

            conta1.Transferir(100, conta2);
            
        }
    }
}

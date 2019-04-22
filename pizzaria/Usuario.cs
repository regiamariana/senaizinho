using System;
namespace pizzaria
{
    public class Usuario
    {

        static int contador = 0;

        public string nome {get; set;}

        public string sobrenome {get; set;}

        public static void inserir (){
            string nome;
            System.Console.WriteLine("Digite o nome do usuário");
            nome = Console.ReadLine();
            
        }

      
        public static void listarUsuario (){}


        /* public static bool cadastro(){
            System.Console.WriteLine("------Cadastro------");
            System.Console.WriteLine("Digite seu e-mail");
            string email = Console.ReadLine();
            
                
            if (email.Contains("@") && email.Contains(".")){
                System.Console.WriteLine("email válido!");
                return true;
            }else{
                System.Console.WriteLine("digite um email válido");
                return false;
           
            }
            System.Console.WriteLine("Digite uma senha");
            string senha = Console.ReadLine();
            if(senha.Length > 6 && senha.Length < 12){
                System.Console.WriteLine("senha correta!");
            }else{
                System.Console.WriteLine("digite uma senha válida");
            }*/
        }

        }
    }

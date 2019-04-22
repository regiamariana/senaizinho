using System;
namespace pizzaresoluçao
{
    public class Usuario
    {
        public int id {get; set;}
         public string email {get; set;}

        public string senha {get; set;}

        public string nome {get; set;}

        public DateTime datatCriacao {get; set;}

        public static void Inserir (){
            string nome;
            string email;
            string senha;
        }

    }
}
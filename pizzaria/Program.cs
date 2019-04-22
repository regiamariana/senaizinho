using System;

namespace pizzaria {
    class Program {
        static void Main (string[] args) {
                bool sair = false;
                System.Console.WriteLine ("escolha uma opção:");
                System.Console.WriteLine ("1 - cadastro");
                System.Console.WriteLine ("2 - login");
                System.Console.WriteLine ("3 - listar usuários");
                System.Console.WriteLine ("9 - sair");
                int respostaUsuario = int.Parse (Console.ReadLine ());
                int contador = 0;
                Cadastro[] cadastro = new Cadastro[contador];
                do {
                    switch (respostaUsuario) {
                        case 1:
                            //Usuario u = new Usuario();
                            //Usuario.cadastro();
                            //contador ++
                            Cadastro c = new Cadastro ();
                            System.Console.WriteLine ("------Cadastro------");
                            System.Console.WriteLine ("Digite seu e-mail");
                            c.email = Console.ReadLine ();

                            if (c.email.Contains ("@") || c.email.Contains (".")) {
                                System.Console.WriteLine ("email válido");
                                System.Console.WriteLine (" ");
                                System.Console.WriteLine ("Digite uma senha");
                                string senha = Console.ReadLine ();

                                if (senha.Length > 6 && senha.Length < 12) {
                                    System.Console.WriteLine ("senha correta!");
                                    contador++;
                                } else {
                                    System.Console.WriteLine ("digite uma senha válida");
                                    System.Console.WriteLine (" ");
                                    continue;
                                }
                            } else {
                                System.Console.WriteLine ("digite um email válido");
                                continue;
                            }

                            System.Console.WriteLine ($"o Login é {c.email} e a senha é {c.senha}");
                            break;

                        case 2:
                            System.Console.WriteLine ("-------Login-------");
                            System.Console.WriteLine ("digite seu email");
                            string logE = Console.ReadLine ();
                            System.Console.WriteLine ("digite sua senha");
                            string logS = Console.ReadLine ();

                            foreach (Cadastro item in cadastro) {
                                if (logE.Equals (item.email) && logS.Equals (item.senha)) {
                                    System.Console.WriteLine ($"vc está contectado {item.nome, item.sobrenome}");
                                } else {
                                    System.Console.WriteLine ("tente novamente");
                                    continue;
                                }
                            }

                            break;

                    while (!sair);
                    }
                    }}}
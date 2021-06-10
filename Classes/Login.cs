using System;
using ProjetoProdutos.Interfaces;

namespace ProjetoProdutos.Classes
{
    public class Login : Usuario, ILogin
    {
        bool Logado = true;

        public Login()
        { }

        public void Logar(Usuario usuario)
        {
            Login cadastrar = new Login();

            Login deslogar = new Login();

            string opcao;

            Console.WriteLine("\nSistema de Produtos!");
            do
            {
                Console.WriteLine(@"
==========================
| Escolha uma das opções |
|------------------------|
| Login - 1              |
| Cadastro - 2           |
| Sair - X               |
==========================");
                Console.Write("Resposta: ");
                opcao = Console.ReadLine().ToLower();

                switch (opcao)
                {
                    case "1":
                        Console.WriteLine("\nLogin\n");

                        Console.WriteLine("Digite seu Email:");
                        string emailVerify = Console.ReadLine();
                        Console.WriteLine("Digite sua Senha:");
                        string senhaVerify = Console.ReadLine();

                        if (del == true)
                        {
                            Console.WriteLine("\nO usuário foi deletado ou não existe!");
                        }
                        else if (del == false)
                        {

                            if (emailVerify == usuario.Email && senhaVerify == usuario.Senha)
                            {
                                Console.WriteLine("\nBem vindo!");
                                Console.WriteLine(@"
=========================
|    O que deseja?      |
|-----------------------|
| Cadastrar Produto- 1  |
| Deletar usuário - 2   |
| Sair - X              |
=========================");
                                Console.Write("Resposta: ");
                                string opcao2 = Console.ReadLine().ToLower();

                                switch (opcao2)
                                {
                                    case "1":
                                        break;

                                    case "2":
                                        Deletar(usuario, Nome, emailVerify, senhaVerify);
                                        break;

                                    case "x":
                                        deslogar.Deslogar(Logado);
                                        break;

                                    default:
                                        Console.WriteLine("Opção inválida");
                                        break;
                                }
                            }
                        }

                        else
                        {
                            Console.WriteLine("\nNenhum usuário com esses dados!");
                        }
                        break;

                    case "2":
                        usuario.Cadastrar(cadastrar);
                        break;

                    case "x":
                        Console.WriteLine("\nTchau!");
                        break;

                    default:
                        Console.WriteLine("\nOpção inválida!");
                        break;
                }
            } while (opcao != "x");
        }

        public void Deslogar(bool logado)
        {
            if (Logado == true)
            {
                logado = false;
                Console.WriteLine($"\nO usuário foi deslogado!");
            }
        }

        void ILogin.Login()
        {
            throw new NotImplementedException();
        }

        void ILogin.Logar(string usuario)
        {
            throw new NotImplementedException();
        }

        void ILogin.Deslogar(bool logado)
        {
            throw new NotImplementedException();
        }
    }
}
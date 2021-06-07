using System;

namespace ProjetoProdutos.Classes
{
    public class Usuario
    {
        public int Codigo;

        public string Nome;

        public string Email;

        private string Senha;

        private int DataCadastro;

        public void Cadastrar()
        {
            Console.WriteLine("Cadastro\n");
            Console.WriteLine("Digite o seu nome:");
            Nome = Console.ReadLine();
            Console.WriteLine("\nDigite o seu Email");
            Email = Console.ReadLine();
            Console.WriteLine("\nDigite a senha");
            Senha = Console.ReadLine();
        }

        public void Deletar()
        {

        }
    }
}
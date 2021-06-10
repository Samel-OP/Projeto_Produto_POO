using System;
using System.Collections.Generic;
using ProjetoProdutos.Interfaces;

namespace ProjetoProdutos.Classes
{
    public class Usuario : IUsuario
    {
        public int Codigo { get; set; }

        public string Nome { get; set; }

        public string Email { get; set; }

        public string Senha { get; set; }

        private DateTime DataCadastro { get; set; }

        public bool del { get; set; } = false;


        List<Usuario> conta = new List<Usuario>();

        void Usuarios()
        { }

        void Remove(Usuario usuario)
        { }

        private void Usuarios(int _Codigo, string _Nome, string _Email, string _Senha)
        {
            this.Codigo = _Codigo;
            this.Nome = _Nome;
            this.Email = _Email;
            this.Senha = _Senha;
        }

        public void Cadastrar(Usuario usuario)
        {
            conta.Add(usuario);

            Console.WriteLine("\nCadastro\n");
            Console.WriteLine("Digite o seu nome:");
            Nome = Console.ReadLine();
            Console.WriteLine("Digite o seu Email");
            Email = Console.ReadLine();
            Console.WriteLine("Digite a senha");
            Senha = Console.ReadLine();
            DataCadastro = DateTime.Now;
            del = false;

            Console.WriteLine($"\nUsuário criado com sucesso em {DataCadastro}");
        }

        public void Deletar(Usuario usuario, string Nome, string emailVerify, string senhaVerify)
        {
            Console.WriteLine("Escreva o nome do usuário que deseja excluir:");
            conta.Find(x => x.Email == emailVerify && x.Senha == senhaVerify);
            Console.Write("Resposta: ");
            string delete = Console.ReadLine();

            if (delete == usuario.Nome)
            {
                conta.Remove(usuario);
                Console.WriteLine("\nUsuário excluído com sucesso!");
                del = true;
            }

            else
            {
                Console.WriteLine("\nNão há usuário com esse nome!");
            }
        }

        void IUsuario.Usuarios()
        {
            throw new NotImplementedException();
        }

        public void Remove(string usuario)
        {
            throw new NotImplementedException();
        }

        public void Cadastrar(int _Codigo, string _Nome, string _Email, string _Senha)
        {
            throw new NotImplementedException();
        }

        public string Cadastrar(string usuario)
        {
            throw new NotImplementedException();
        }

        public string Deletar(string usuario, string Nome, string emailVerify, string senhaVerify)
        {
            throw new NotImplementedException();
        }
    }
}
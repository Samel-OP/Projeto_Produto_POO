namespace ProjetoProdutos.Interfaces
{
    public interface ILogin
    {
        void Login();

        void Logar(string usuario);

        void Deslogar(bool logado);
    }
}
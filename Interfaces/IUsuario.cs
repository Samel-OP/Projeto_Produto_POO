namespace ProjetoProdutos.Interfaces
{
    public interface IUsuario
    {
       void Usuarios();

       void Remove(string usuario);

       void  Cadastrar(int _Codigo, string _Nome, string _Email, string _Senha);

       string Cadastrar(string usuario);

       string Deletar(string usuario, string Nome, string emailVerify, string senhaVerify);
    }
}
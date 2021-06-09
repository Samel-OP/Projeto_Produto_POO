using System.Collections.Generic;
using ProjetoProdutos.Classes;

namespace ProjetoProdutos.Interfaces
{
    public interface IMarca
    {
        string Cadastrar(Marca marca);

        List<Marca> Listar();

        string Deletar(Marca marca);
    }
}
using System;
using System.Collections.Generic;
using ProjetoProdutos.Interfaces;


namespace ProjetoProdutos.Classes
{
     public class Marca : IMarca
    {
        // Atributos
        private int Codigo { get; set; }
        private string NomeMarca { get; set; }
        private DateTime DataCadastro { get; set; }

        // Construtores
        public Marca() {

        }

        public Marca(int _codigo, string _nomeMarca) {
            this.Codigo = _codigo;
            this.NomeMarca = _nomeMarca;
            this.DataCadastro = DateTime.Now;
        }
        
        // Lista de Marcas
        List<Marca> listaMarcas = new List<Marca>();

        // Métodos
        public string Cadastrar(Marca marca)
        {
            listaMarcas.Add(marca);
            return ($"Marca {marca.NomeMarca} cadastrada");
        }

        public string Deletar(Marca marca)
        {
            listaMarcas.Remove(marca);
            return ($"Marca {marca.NomeMarca} deletada");
        }

        public List<Marca> Listar()
        {
            return listaMarcas;
        }
    }
}
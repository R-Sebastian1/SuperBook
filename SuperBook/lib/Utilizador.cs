using System.Collections.Generic;

namespace SuperBook
{
    class Utilizador : Pessoa //pertence a superclass pessoa
    {
        public Utilizador(string nome, int id)
        {
            this.nome = nome;
            this.id = id;
        }
        public List<Livros> livro = new List<Livros>();//lista aqui
        //public Livros livro;

        public override string informacao()
        {
            return $"Nome do utilizador: {nome}.\nID do utilizador: {id}.\n"; //Livro emprestado: { livros.informacao}
        }
    }
}

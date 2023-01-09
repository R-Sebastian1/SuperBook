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

        
        public override string informacao()
        {
            return $"Nome do utilizador: {nome}.\nID do utilizador: {id}.\n";
        }
    }
}

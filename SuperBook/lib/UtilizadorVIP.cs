
using System.Collections.Generic;


namespace SuperBook
{
    class UtilizadorVIP : Pessoa //Utilizador VIP pertence a superclass Pessoa, por isso não temos de defenir todos os ints e strings
    {
        public UtilizadorVIP(string nome, int id)
        {
            this.nome = nome;
            this.id = id;

        }

        public override string informacao()
        {
            return $"Nome do utilizador VIP: {nome}.\nID do utilizador VIP: {id}.\n";
        }
    }
}

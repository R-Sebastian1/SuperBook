using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SuperBook
{
    class Livros    
    {
        public string nome;
        public int id;
        public string ListaAutores;
        public long ano;

        public bool Disponivel { get; internal set; }
        public bool Devolvido { get; internal set; }
        public DateTime DataEmprestimo { get; internal set; }
        public DateTime DataDevolucaoPrevista { get; internal set; }

        public Livros(string nome, int id, string ListaAutores, long ano)
            {
            this.nome = nome;
            this.id = id;
            this.ListaAutores= ListaAutores;
            this.ano = ano;
            Disponivel = true;
            Devolvido = true;
            }

        public string informacao()
        {
            Console.WriteLine("\nOs livros existentes\n");
            return $"Nome: {nome}.\nID: {id}.\nAutor: {ListaAutores}.\nAno: {ano}.\n";
        }
        public string info()
        {
            return $"Data da devolução: {DataDevolucaoPrevista}\n";
        }

        public string infoDisponivel()
        {          
            return $"Livro está disponivel: {Disponivel}.";            
        }
    }
}

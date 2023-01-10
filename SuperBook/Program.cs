using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SuperBook
{
    class Program
    {
        static List<Utilizador> listaUtilizador = new List<Utilizador>();       //a lista do Utilizador normal
        static List<UtilizadorVIP> listaUtilizadorVIP = new List<UtilizadorVIP>();  //a lista do utilizador VIP
        static List<Livros> listaLivros = new List<Livros>();   //lista dos livros

        //+1 lista requisições-tem de ter um bool e juntar as penalidades
        //+1 lista de livros emprestados --esta lista tem de ter penalidades
        //3 penalidades com comparação da data atual com a data do emprestimo

        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.DarkBlue;    //so para dar cor xD

            int opcao;
            do
            {
                Console.Clear();
                Console.WriteLine("\n\n\n\n");
                Console.WriteLine("\t\t\t\t\t ********** Biblioteca Super Book ********** \n\t");
                Console.WriteLine("\t\t\t\t\t ************* Seja bem vindo ************** \n\t");
                Console.WriteLine("\t\t\t\t\t *        Escolha o que pretende fazer     * \n\t");
                Console.WriteLine("\t\t\t\t\t *         1 - Utilizadores                * \n\t");   /* Aqui é o menu principal */
                Console.WriteLine("\t\t\t\t\t *         2 - Utilizadores VIP            * \n\t");
                Console.WriteLine("\t\t\t\t\t *         3 - Livros                      * \n\t");
                Console.WriteLine("\t\t\t\t\t *         3 - Guardar e sair              * \n\t");
                Console.WriteLine("\t\t\t\t\t ******************************************* \n\t");
                opcao = int.Parse(Console.ReadLine());
                switch (opcao)
                {
                    case 0: break;
                    case 1:
                        subMenuUtilizador();
                        break;
                    case 2:
                        subMenuUtilizadorVIP();
                        break;
                    case 3:
                        subMenuLivros();
                        break;
                    default:
                        Console.WriteLine("Opcão inválida");
                        break;
                }
            } while (opcao != 0);
        }


        private static void subMenuUtilizador()
        {
            int opcao;
            do
            {
                Console.Clear();
                Console.WriteLine("\n\n\n\n");
                Console.WriteLine("\t\t\t\t\t ******************************************* \n\t");
                Console.WriteLine("\t\t\t\t\t *          1 - Inserir Utilizador         * \n\t");
                Console.WriteLine("\t\t\t\t\t *          2 - Apagar Utilizador          * \n\t");
                Console.WriteLine("\t\t\t\t\t *          3 - Listar Utilizador          * \n\t");   //SubMenu onde metemos os clientes
                Console.WriteLine("\t\t\t\t\t *          4 - Procurar Utilizador        * \n\t");
                Console.WriteLine("\t\t\t\t\t *               0 - Voltar                * \n\t");
                Console.WriteLine("\t\t\t\t\t *******************************************");
                opcao = int.Parse(Console.ReadLine());
                Console.Clear();
                switch (opcao)
                {
                    case 0:
                        break;
                    case 1:
                        inserirUtilizador();
                        pressionarEnterParaContinuar();
                        break;
                    case 2:
                        apagarUtilizador();
                        pressionarEnterParaContinuar();
                        break;
                    case 3:
                        listarUtilizador();
                        pressionarEnterParaContinuar();
                        break;
                    case 4:
                        procurarUtilizador();
                        pressionarEnterParaContinuar();
                        break;
                    default:
                        Console.WriteLine("Opção inválida");
                        break;
                }
            } while (opcao != 0);
        }

        private static void subMenuUtilizadorVIP()
        {
            int opcao;
            do
            {
                Console.Clear();
                Console.WriteLine("\n\n\n\n");
                Console.WriteLine("\t\t\t\t\t *********************************************** \n\t");
                Console.WriteLine("\t\t\t\t\t *          1 - Inserir Utilizador VIP         * \n\t");
                Console.WriteLine("\t\t\t\t\t *          2 - Apagar Utilizador VIP          * \n\t");
                Console.WriteLine("\t\t\t\t\t *          3 - Listar Utilizador VIP          * \n\t");       //SubMenu dos VIPS
                Console.WriteLine("\t\t\t\t\t *          4 - Procurar Utilizador VIP        * \n\t");
                Console.WriteLine("\t\t\t\t\t *                0 - Voltar                   * \n\t");
                Console.WriteLine("\t\t\t\t\t ***********************************************");
                opcao = int.Parse(Console.ReadLine());
                Console.Clear();
                switch (opcao)
                {
                    case 0:
                        break;
                    case 1:
                        inserirUtilizadorVIP();
                        pressionarEnterParaContinuar();
                        break;
                    case 2:
                        apagarUtilizadorVIP();
                        pressionarEnterParaContinuar();
                        break;
                    case 3:
                        listarUtilizadorVIP();
                        pressionarEnterParaContinuar();
                        break;
                    case 4:
                        procurarUtilizadorVIP();
                        pressionarEnterParaContinuar();
                        break;
                    default:
                        Console.WriteLine("Opção inválida");
                        break;
                }
            } while (opcao != 0);
        }

        private static void subMenuLivros()
        {
            int opcao;
            do
            {
                Console.Clear();
                Console.WriteLine("\n\n\n\n");
                Console.WriteLine("\t\t\t\t\t *********************************************** \n\t");
                Console.WriteLine("\t\t\t\t\t *               1 - Inserir Livro             * \n\t");
                Console.WriteLine("\t\t\t\t\t *               2 - Apagar Livro              * \n\t");
                Console.WriteLine("\t\t\t\t\t *               3 - Listar Livros             * \n\t");
                Console.WriteLine("\t\t\t\t\t *               4 - Consultar livros          * \n\t");   //SubMenu dos Livros
                Console.WriteLine("\t\t\t\t\t *               5 - Emprestar livro           * \n\t");
                Console.WriteLine("\t\t\t\t\t *               6 - Devolver livro            * \n\t");
                Console.WriteLine("\t\t\t\t\t *                0 - Voltar                   * \n\t");
                Console.WriteLine("\t\t\t\t\t ***********************************************");
                opcao = int.Parse(Console.ReadLine());
                Console.Clear();
                switch (opcao)
                {
                    case 0:
                        break;
                    case 1:
                        inserirLivro();
                        pressionarEnterParaContinuar();
                        break;
                    case 2:
                        apagarLivro();
                        pressionarEnterParaContinuar();
                        break;
                    case 3:
                        listarLivros();
                        pressionarEnterParaContinuar();
                        break;
                    case 4:
                        procurarLivros();
                        pressionarEnterParaContinuar();
                        break;
                        case 5:
                        emprestarLivro(false);
                        pressionarEnterParaContinuar();
                        break;
                    case 6:
                        devolveLivro(true);
                        pressionarEnterParaContinuar();
                        break;
                    default:
                        Console.WriteLine("Opção inválida");
                        break;
                }
            } while (opcao != 0);
        }
        private static void inserirUtilizador()
        {
            Console.Write("Insira o nome do novo utilizador: ");
            var nome = Console.ReadLine();
            Console.Write("Insira um ID ao utilizador: ");
            var id = int.Parse(Console.ReadLine());
            Utilizador utilizador = new Utilizador(nome, id);   //magia de adicionar novos utilizadores a lista dos utilizadores normais
            listaUtilizador.Add(utilizador);
            Console.WriteLine("Novo utilizador introduzido com successo");
        }

        private static void apagarUtilizador()
        {
            Console.Write("Insira o ID do utilizador que quer remover: ");
            var idUtilizador = int.Parse(Console.ReadLine());
            var index = listaUtilizador.FindIndex(utilizador => utilizador.id.Equals(idUtilizador));    //procura o id introduzido, ve se esta na lista
            if (index != -1)    //ve a posiçao do utilizador e apaga
            {
                listaUtilizador.RemoveAt(index);            
                Console.WriteLine("Utilizador foi removido com successo!");
            }
            else
            {
                Console.WriteLine($"Não existe nenhum Utilizador com esse ID {idUtilizador}."); //se não houver, aparece esta mensagem
            }
        }

        private static void listarUtilizador()
        {
            if (listaUtilizador.Count == 0)
            {
                Console.WriteLine("Não existe nenhum utilizador para mostrar");   //faz contagem da lista, se estiver vazia aparece isto
                return;
            }

            foreach (Utilizador utilizador in listaUtilizador)  //percorre os elementos
            {
                Console.WriteLine(utilizador.informacao()); //e da a informaça dos elementos existentes
            }
        }

        private static void procurarUtilizador()
        {
            Console.WriteLine("Está à procura de algum utilizador? \n");
            Console.Write("Insira o ID: ");
            var idUtilizador = int.Parse(Console.ReadLine());
            var index = listaUtilizador.FindIndex(utilizador => utilizador.id == idUtilizador); //pega no id inserido pelo utilizador e vê se há algum igual ao que tem na lista
            if (index != -1)
            {
                var utilizadorEncontrado = listaUtilizador[index];
                Console.WriteLine(utilizadorEncontrado.informacao());
            }
            else
            {
                Console.WriteLine("Utilizador não foi encontrado!");    //se não, bota esta mensagem
            }
        }
        private static void inserirUtilizadorVIP()  //daqui para baixo é exatamente igual, mas para VIPS :D
        {
            Console.Write("Insira o nome do novo utilizador: ");
            var nome = Console.ReadLine();
            Console.Write("Insira um ID ao utilizador: ");
            var id = int.Parse(Console.ReadLine());
            UtilizadorVIP utilizadorvip = new UtilizadorVIP(nome, id);
            listaUtilizadorVIP.Add(utilizadorvip);
            Console.WriteLine("Novo utilizador introduzido com successo");
        }

        private static void apagarUtilizadorVIP()
        {
            Console.Write("Insira o ID do utilizador que quer remover: ");
            var idUtilizadorVIP = int.Parse(Console.ReadLine());
            var index = listaUtilizadorVIP.FindIndex(utilizadorVIP => utilizadorVIP.id.Equals(idUtilizadorVIP));
            if (index != -1)
            {
                listaUtilizadorVIP.RemoveAt(index);
                Console.WriteLine("Utilizador foi removido com successo!");
            }
            else
            {
                Console.WriteLine($"Não existe nenhum Utilizador com esse ID {idUtilizadorVIP}.");
            }
        }

        private static void listarUtilizadorVIP()
        {
            if (listaUtilizadorVIP.Count == 0)
            {
                Console.WriteLine("Não existe nenhum utilizador para mostrar");
                return;
            }

            foreach (UtilizadorVIP utilizadorVIP in listaUtilizadorVIP)
            {
                Console.WriteLine(utilizadorVIP.informacao());
            }
        }

        private static void procurarUtilizadorVIP()
        {
            Console.WriteLine("Está à procura de algum utilizador? \n");
            Console.Write("Insira o ID: ");
            var idUtilizadorVIP = int.Parse(Console.ReadLine());
            var index = listaUtilizadorVIP.FindIndex(utilizadorVIP => utilizadorVIP.id == idUtilizadorVIP);
            if (index != -1)
            {
                var utilizadorVIPEncontrado = listaUtilizadorVIP[index];
                Console.WriteLine(utilizadorVIPEncontrado.informacao());
            }
            else
            {
                Console.WriteLine("Utilizador não foi encontrado!");
            }
        }

        private static void inserirLivro() //exatamente ao de cima mas com mais duas coisas: +1 string +1 int (long)
        {
            Console.Write("Insira o nome do Livro: ");
            var nome = Console.ReadLine();
            Console.Write("Insira um ID ao Livro: ");
            var id = int.Parse(Console.ReadLine());
            Console.Write("Insira o Nome do Autor: ");
            var ListaAutores = Console.ReadLine();
            Console.Write("Insira o ano do Livro: ");
            var ano = long.Parse(Console.ReadLine());
            Livros livro = new Livros(nome, id, ListaAutores, ano);
            listaLivros.Add(livro);
            Console.WriteLine("Novo Livro introduzido com successo");
        }

        private static void apagarLivro()
        {
            Console.Write("Insira o ID do utilizador que quer remover: ");
            var idLivro = int.Parse(Console.ReadLine());
            var index = listaLivros.FindIndex(livro => livro.id.Equals(idLivro));
            if (index != -1)
            {
                listaLivros.RemoveAt(index);
                Console.WriteLine("O livro foi removido com successo!");
            }
            else
            {
                Console.WriteLine($"Não existe nenhum livro com esse ID {idLivro}.");
            }
        }

        private static void listarLivros()
        {
            if (listaLivros.Count == 0)
            {
                Console.WriteLine("Não existe nenhum livro para mostrar");
                return;
            }

            foreach (Livros livros in listaLivros)
            {
                Console.WriteLine(livros.informacao());
                Console.WriteLine(livros.infoDisponivel()); //aqui mostra na listagem dos livros que está ou não disponivel!
            }
        }

        private static void procurarLivros()
        {
            Console.WriteLine("Está à procura de algum Livro? \n");
            Console.Write("Insira o ID: ");
            var idLivros = int.Parse(Console.ReadLine());
            var index = listaLivros.FindIndex(livros => livros.id == idLivros);
            if (index != -1)
            {
                var livroEncontrado = listaLivros[index];
                Console.WriteLine(livroEncontrado.informacao());
            }
            else
            {
                Console.WriteLine("Este livro não foi encontrado!");
            }
        }

        private static void emprestarLivro(bool utilizador)    //não faço ideia o que estou a fazer !! XD
        {
            Console.WriteLine("Quer emprestar um livro a um Utilizador?");
            Console.WriteLine("Insira o ID do livro que quer emprestar: ");
            var idLivros= int.Parse(Console.ReadLine());
            Console.WriteLine("Insira o ID do utilizador a quem quer emprestar o livro: ");
            var idUtilizador= int.Parse(Console.ReadLine());
            var index = listaLivros.FindIndex(livros => livros.id == idLivros);
            var index1 = listaUtilizador.FindIndex(utilizador => utilizador.id == idUtilizador);
            var livro = listaLivros[index];

             if(livro.Disponivel)

             {
                    livro.Disponivel = utilizador;
                    livro.DataEmprestimo = DateTime.Now;
                    livro.DataDevolucaoPrevista = DateTime.Now.AddMinutes(1);//minutos (melhor) se for superior, ativa as penalidades
                    Console.WriteLine("Livro emprestado com successo!");
                    Console.WriteLine(livro.info());             

             }
             else
             {
                    Console.WriteLine("Livro não disponível para empréstimo");
             }
           
        }

        private static void devolveLivro(bool utilizador)
        {
            Console.WriteLine("Quer devolver um livro a um Utilizador?");
            Console.WriteLine("Insira o ID do livro que quer devolver: ");
            var idLivros = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira o ID do utilizador a quem quer devolver o livro: ");
            var idUtilizador = int.Parse(Console.ReadLine());
            var index = listaLivros.FindIndex(livros => livros.id == idLivros);
            var index1 = listaUtilizador.FindIndex(utilizador => utilizador.id == idUtilizador);
            var livro = listaLivros[index];

            if (livro.Devolvido)

            {
                livro.Devolvido = utilizador;
                livro.DataEmprestimo = DateTime.Now;
                var tempo = livro.DataDevolucaoPrevista- livro.DataEmprestimo;
                Console.WriteLine($"Data restante para penalisação: {tempo}");
                if(livro.Devolvido!=true)//aqui da para ver ao devolver o livro, o gajo trouxe o livro a tempo
                {
                    Console.WriteLine("Ira haver penalização");
                }
                else
                {
                    Console.WriteLine("Não haverá penalização");
                }

            }
            else
            {
                Console.WriteLine("Livro não disponível para empréstimo");
            }
        }

        private static void pressionarEnterParaContinuar()  //com isto permite que a info apareça :D
        {
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Pressione enter para continuar...");
            Console.ReadKey();
        }
    }

}


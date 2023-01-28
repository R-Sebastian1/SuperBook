using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;

namespace SuperBook
{
    class Program
    {
        static List<Utilizador> listaUtilizador = new List<Utilizador>();       //a lista do Utilizador normal
        static List<UtilizadorVIP> listaUtilizadorVIP = new List<UtilizadorVIP>();  //a lista do utilizador VIP
        static List<Livros> listaLivros = new List<Livros>();   //lista dos livros
        static List<Livros> livros = new List<Livros>();

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
                Console.WriteLine("\t\t\t\t\t *         1 - Inserir Utilizadores        * \n\t");   /* Aqui é o menu principal */
                Console.WriteLine("\t\t\t\t\t *         2 - Inserir Utilizadores VIP    * \n\t");
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
                        emprestarLivro(false,false);
                        pressionarEnterParaContinuar();
                        break;
                    case 6:
                        devolveLivro(true,true);
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

        private static void emprestarLivro(bool utilizador, bool utilizadorVIP)    //empresta livro e faz um data set
        {
            int opcao;
            do
            {
                Console.WriteLine("\n\n\n\n");
                Console.WriteLine("\t\t\t\t\t *********************************************** \n\t");
                Console.WriteLine("\t\t\t\t\t *        Está na secção de emprestar livros   * \n\t");
                Console.WriteLine("\t\t\t\t\t *         Selecione quem irá levar o livro    * \n\t");
                Console.WriteLine("\t\t\t\t\t *            1 - Utilizador Comum             * \n\t");
                Console.WriteLine("\t\t\t\t\t *              2 - Utilizador VIP             * \n\t");
                Console.WriteLine("\t\t\t\t\t *                 0 - Voltar                  * \n\t");
                Console.WriteLine("\t\t\t\t\t *********************************************** \n\t");
                opcao = int.Parse(Console.ReadLine());
                switch(opcao)
                {
                    case 1:
                        Console.Write("Insira o ID do livro que quer emprestar: ");
                        var idLivros = int.Parse(Console.ReadLine());
                        Console.Write("Insira o ID do utilizador a quem quer emprestar o livro: ");
                        var idUtilizador = int.Parse(Console.ReadLine());
                        var index = listaLivros.FindIndex(livros => livros.id == idLivros);
                        var index1 = listaUtilizador.FindIndex(utilizador => utilizador.id == idUtilizador);
                        var livros = listaLivros[index];

                        if (livros.Disponivel ==true)

                        {
                            livros.Disponivel = utilizador;
                            livros.DataEmprestimo = DateTime.Now;
                            livros.DataDevolucaoPrevista = DateTime.Now.AddMinutes(1);//minutos (melhor) se for superior, ativa as penalidades
                            Console.WriteLine("Livro emprestado com successo!");
                            Console.WriteLine(livros.info());
                        }
                        else
                        {
                            Console.WriteLine("Livro não disponível para empréstimo");
                        }
                        break;
                    case 2:
                        Console.Write("Insira o ID do livro que quer emprestar: ");
                        var idLivros1 = int.Parse(Console.ReadLine());
                        Console.Write("Insira o ID do Utilizador VIP a quem quer emprestar o livro: ");
                        var idUtilizadorVIP = int.Parse(Console.ReadLine());
                        var index2 = listaLivros.FindIndex(livros => livros.id == idLivros1);
                        var index3 = listaUtilizadorVIP.FindIndex(utilizadorVIP => utilizadorVIP.id == idUtilizadorVIP);
                        var livro1 = listaLivros[index2];

                        if(livro1.Disponivel==true)
                        {
                            livro1.Disponivel = utilizadorVIP;
                            livro1.DataEmprestimo = DateTime.Now;
                            livro1.DataDevolucaoPrevista = DateTime.Now.AddMinutes(1);
                            Console.WriteLine("Livro emprestado com sucesso");
                        }
                        else
                        {
                            Console.WriteLine("Livro não está disponível para empréstimo!");
                        }
                        break;
                    default:
                        break;

                }
            } while (opcao != 0);            

        }

        private static void devolveLivro(bool utilizador, bool utilizadorVIP) //devole livro e verifica as datas para ver se haverá penalizações
        {
            int opcao;
            do
            {
                Console.WriteLine("\n\n\n\n");
                Console.WriteLine("\t\t\t\t\t *********************************************** \n\t");
                Console.WriteLine("\t\t\t\t\t *        Está na secção de devolver livros    * \n\t");
                Console.WriteLine("\t\t\t\t\t *        Selecione quem irá devolver livros   * \n\t");
                Console.WriteLine("\t\t\t\t\t *            1 - Utilizador Comum             * \n\t");
                Console.WriteLine("\t\t\t\t\t *              2 - Utilizador VIP             * \n\t");
                Console.WriteLine("\t\t\t\t\t *                 0 - Voltar                  * \n\t");
                Console.WriteLine("\t\t\t\t\t *********************************************** \n\t");
                opcao = int.Parse(Console.ReadLine());
                switch(opcao)
                {
                    case 1:

                        Console.Write("Insira o ID do livro que quer devolver: ");
                        var idLivros = int.Parse(Console.ReadLine());
                        Console.Write("Insira o ID do utilizador que devolve o livro: ");
                        var idUtilizador = int.Parse(Console.ReadLine());
                        var index = listaLivros.FindIndex(livros => livros.id == idLivros);
                        var index1 = listaUtilizador.FindIndex(utilizador => utilizador.id == idUtilizador);
                        var livros = listaLivros[index];

                        if(livros.Devolvido)
                        {
                            livros.Devolvido = utilizador;
                            livros.DataEmprestimo = DateTime.Now;
                            var tempo = livros.DataDevolucaoPrevista - livros.DataEmprestimo;
                            Console.WriteLine($"Tempo restante até à penalização: {tempo}");

                            int minutos = tempo.Minutes;
                            int secundos = tempo.Seconds;

                            if (livros.Devolvido!=true)
                            {
                                Console.WriteLine("Ira haver penalização!");
                                if(minutos<=0) //aqui está a penalização para quem traz os livros atrasados
                                {
                                    Console.WriteLine("Penalidade leve - 1 euro"); //podemos fazer um switch case para penalidades!
                                }
                                else if (minutos < -2)
                                {
                                    Console.WriteLine("Penalidade média - 2 euros");
                                }
                                else if (minutos < -3)
                                {
                                    Console.WriteLine("Penalidade grave - 3 euros");
                                }
      
                            }
                            else
                            {
                                Console.WriteLine("Não haverá penalização");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Livro já devolvido!");
                        }
                        break;
                    case 2:
                        Console.WriteLine("Insira o ID do livro que quer devolver: ");
                        var idLivros1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Insira o ID do utilizador VIP que devolve o livro: ");
                        var idUtilizadorVIP = int.Parse(Console.ReadLine());
                        var index2 = listaLivros.FindIndex(livros => livros.id == idLivros1);
                        var index3 = listaUtilizadorVIP.FindIndex(utilizadorVIP => utilizadorVIP.id == idUtilizadorVIP);
                        var livro1 = listaLivros[index2];
                        if(livro1.Devolvido)
                        {
                            livro1.Devolvido = utilizadorVIP;
                            livro1.DataEmprestimo = DateTime.Now;
                            var tempo1 = livro1.DataDevolucaoPrevista - livro1.DataEmprestimo;
                            Console.WriteLine($"Tempo restante até à penalização: {tempo1}");

                            int minutos = tempo1.Minutes;
                            int secundos = tempo1.Seconds;

                            if (livro1.Devolvido!=true)
                            {
                                Console.WriteLine("Ira haver penalização!");
                                Console.WriteLine("Ira haver penalização!");
                                if (minutos <= 0) //aqui está a penalização para quem traz os livros atrasados
                                {
                                    Console.WriteLine("Penalidade leve - 1 euro"); //podemos fazer um switch case para penalidades!
                                }
                                else if (minutos < -2)
                                {
                                    Console.WriteLine("Penalidade média - 2 euros");
                                }
                                else if (minutos < -3)
                                {
                                    Console.WriteLine("Penalidade grave - 3 euros");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Não haverá penalização!");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Livro já devolvido!");
                        }
                        break;
                }
            } while (opcao != 0);
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


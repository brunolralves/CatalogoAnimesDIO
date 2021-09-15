using CatalogoAnimesDIO.Classes;
using System;

namespace CatalogoAnimesDIO
{
    class Program
    {
        static AnimeRepository repository = new();

        static void Main(string[] args)
        {
            string userOption = GetUserOption();

            while (userOption.ToUpper() != "X")
            {
                switch (userOption)
                {
                    case "1":
                        GetAnimes();
                        break;
                    case "2":
                        InsertAnime();
                        break;
                    case "3":
                       // UpdateAnime();
                        break;
                    case "4":
                        //DeleteAnime();
                        break;
                    case "5":
                        //ShowAnime();
                        break;

                    default:
                        break;
                }
            }
        }

        private static void InsertAnime()
        {
            
        }

        private static void GetAnimes()
        {
            Console.WriteLine("Listar Animes");
            var list = repository.List();

            if (list.Count == 0)
            {
                Console.WriteLine("Nenhum Anime cadastrado.");
                return;
            }

            foreach (var anime in list)
            {
                Console.WriteLine($"#ID {anime.GetId()}: - {anime.GetTitle()}");
            }
        }

        private static string GetUserOption()
        {
            Console.WriteLine();
            Console.WriteLine("Catálogo de Animes");
            Console.WriteLine("Informe a opção desejada:");

            Console.WriteLine("1- Listar Animes");
            Console.WriteLine("2- Inserir novo Anime");
            Console.WriteLine("3- Atualizar Anime");
            Console.WriteLine("4- Excluir Anime");
            Console.WriteLine("5- Visualizar Anime");
            Console.WriteLine("C- Limpar tela");
            Console.WriteLine("X- Sair");
            Console.WriteLine();

            string userOption = Console.ReadLine().ToUpper();
            Console.WriteLine();
            return userOption;

        }
    }
}

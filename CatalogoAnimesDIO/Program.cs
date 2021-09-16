﻿using CatalogoAnimesDIO.Classes;
using CatalogoAnimesDIO.Enum;
using System.Collections.Generic;
using System;
using System.Linq;

namespace CatalogoAnimesDIO
{
    class Program
    {
        static AnimeRepository repository = new();

        static void Main(string[] args)
        {

            string userOption = " ";
            do
            {
                userOption = GetUserOption();
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
                    case "C":
                        Console.Clear();
                        break;
                    case "X":
                        Console.WriteLine("Volte sempre!!");
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                        break;
                }
            } while (userOption.ToUpper() != "X");
        }

        private static void InsertAnime()
        {
            Console.WriteLine("Inserir novo Anime");

            foreach (int i in System.Enum.GetValues(typeof(Gender)))
            {
                Console.WriteLine($"{i} - {System.Enum.GetName(typeof(Gender), i)} ");
            }

            Console.Write("Digite o gênero entre as opções acima: ");
            int inputGender = int.Parse(Console.ReadLine());

            Console.Write("Digite o Título do Anime: ");
            string inputTitle = Console.ReadLine();

            Console.Write("Digite o Ano de Início da Anime: ");
            int inputYear = int.Parse(Console.ReadLine());

            Console.Write("Digite a Descrição do Anime: ");
            string inputDescription = Console.ReadLine();

            Anime newAnime = new Anime(id: repository.NextId(),
                                        gender: (Gender)inputGender,
                                        title: inputTitle,
                                        year: inputYear,
                                        description: inputDescription);

            repository.Insert(newAnime);

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

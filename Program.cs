using System;
using DIO.Series.Entities;
using DIO.Series.Enums;
using DIO.Series.Repositories;

namespace DIO.Series
{
    class Program
    {
        static SerieRepository serieRepository = new SerieRepository();
        static void Main(string[] args)
        {
            string userOption = GetUserOption();

            while(userOption.ToUpper() != "X")
            {
                switch(userOption)
                {
                    case "1":
                        ListSeries();
                    break;

                    case "2":
                        InsertSerie();
                    break;

                    case "3":
                        UpdateSerie();
                    break;

                    case "4":
                        DeleteSerie();
                    break;

                    case "5":
                        ShowSerie();
                    break;

                    case "C":
                        Console.Clear();
                    break;

                    default:
                        throw new ArgumentOutOfRangeException("Opção selecionada não existe!"); 
                }

                userOption = GetUserOption();
            }
           
        }

        private static void ShowSerie()
        {
            //Solicitar o id da série a ser mostrada
            Console.Write("Digite o id da série e ser mostrada: ");
            int getId = int.Parse(Console.ReadLine());

            //Chama o método para bubscar a série escolhida
            var serie = serieRepository.findById(getId);

            //Mostra a série na tela
            Console.WriteLine(serie);
        }

        private static void DeleteSerie()
        {
            //Solicitar o id da série e ser deletada
            Console.Write("Digite o ID da série e ser deletada: ");
            int getId = int.Parse(Console.ReadLine());

            //Marca a série como inativa
            serieRepository.delete(getId);
        }

        private static void UpdateSerie()
        {
            Console.Write("Digite o ID da série: ");
            int getId = int.Parse(Console.ReadLine());

            foreach (int i in Enum.GetValues(typeof(GenderEnum)))
            {
                Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(GenderEnum), i));
            }

            Console.Write("Digite o gênero entre as opções acima: ");
            int getGender = int.Parse(Console.ReadLine());

            Console.Write("Digite o título da série: ");
            string getTitle = Console.ReadLine();

            Console.Write("Digite o ano de início da série: ");
            int getYear = int.Parse(Console.ReadLine());

            Console.Write("Digite a descrição da série: ");
            string getDescription = Console.ReadLine();

            SerieEntity newSerie = new SerieEntity(
                id: serieRepository.nextId(),
                gender: (GenderEnum) getGender,
                title: getTitle,
                description: getDescription,
                year: getYear);

            serieRepository.update(getId,newSerie);
        }

        private static void InsertSerie()
        {
            Console.WriteLine("Inserir uma nova série:");

            foreach (int i in Enum.GetValues(typeof(GenderEnum)))
            {
                Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(GenderEnum), i));
            }

            Console.Write("Digite o gênero entre as opções acima!");
            int getGender = int.Parse(Console.ReadLine());

            Console.Write("Digite o título da série: ");
            string getTitle = Console.ReadLine();

            Console.Write("Digite o ano de início da série: ");
            int getYear = int.Parse(Console.ReadLine());

            Console.Write("Digite a descrição da série: ");
            string getDescription = Console.ReadLine();

            SerieEntity newSerie = new SerieEntity(
                id: serieRepository.nextId(),
                gender: (GenderEnum) getGender,
                title: getTitle,
                description: getDescription,
                year: getYear);

            serieRepository.insert(newSerie);
        }

        private static void ListSeries()
        {
            Console.WriteLine("Listar Séries:");

            var series =  serieRepository.list();

            if(series.Count == 0)
            {
                Console.WriteLine("Nenhuma Série Cadastrada!");
                return;
            }

            foreach(var serie in series)
            {
               var excluded = serie.GetExcluded();

                Console.WriteLine("#ID {0}: - {1} {2}", serie.ShowId(), serie.ShowTitle(), (excluded ? "- Excluido" : ""));
                //Console.WriteLine("#ID {0}: - {1} {2}", serie.ShowId(), serie.ShowTitle(), serie.GetExcluded());
            }
        }

        private static string GetUserOption()
            {
                Console.WriteLine();
                Console.WriteLine("DIO Séries a seu dispor!!!");
                Console.WriteLine("Informe a opção desejada:");

                Console.WriteLine("1- Listar séries");
                Console.WriteLine("2- Inserir nova série");
                Console.WriteLine("3- Atualizar série");
                Console.WriteLine("4- Excluir série");
                Console.WriteLine("5- Visualizar série");
                Console.WriteLine("C- Limpar Tela");
                Console.WriteLine("X- Sair");
                Console.WriteLine();

                string getUserOption = Console.ReadLine().ToUpper();
                Console.WriteLine();
                return getUserOption;
            }
    }
}

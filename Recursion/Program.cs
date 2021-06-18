using System;
using System.Collections.Generic;

namespace Recursion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Сколько сколько фильмов в прокате:");
            int filmAmount = Convert.ToInt32(Console.ReadLine());

            List<int> filmsList = new List<int>();

            int count = 1;
            while (count <= filmAmount)
            {
                Console.WriteLine($"Введите продолжительность фильма в минутах:");
                int filmLength = Convert.ToInt32(Console.ReadLine());

                filmsList.Add(filmLength);
                count++;
            }

            NodeForFilm._amountAndLenght = filmsList;

            NodeForFilm nodeForFilm = new NodeForFilm(NodeForFilm._TIMEWORKCINEMA);
            nodeForFilm.CreateGraph();

            ResultModel resultModel = nodeForFilm.GetResult();

            foreach (int w in resultModel.CurrentLenghtFilm)
            {
                Console.Write(w + "  ");
            }


        }
    }
}

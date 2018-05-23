using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domino
{
    class Program
    {
        public static void Main(string[] args)
        {
            var dominoes = InitializeDominoes();

            var snake = MakeSnake(dominoes);

            foreach (var domino in snake)
            {
                Console.Write($"[{domino.GetValues()[0]}, {domino.GetValues()[1]}] ");
            }
            Console.ReadLine();
        }

        public static List<Domino> MakeSnake(List<Domino> dominoes)
        {
            var snake = new List<Domino>();
            snake.Add(dominoes[0]);
            dominoes.RemoveAt(0);

            while(dominoes.Count !=0 )
            {
                for (int i = 0; i < dominoes.Count; i++)
                {
                    if (snake[snake.Count - 1].GetValues()[1] == dominoes[i].GetValues()[0])
                    {
                        snake.Add(dominoes[i]);
                        dominoes.RemoveAt(i);
                    }
                }
            }

            return snake;
        }

        public static List<Domino> InitializeDominoes()
        {
            var dominoes = new List<Domino>();
            dominoes.Add(new Domino(5, 2));
            dominoes.Add(new Domino(4, 6));
            dominoes.Add(new Domino(1, 5));
            dominoes.Add(new Domino(6, 7));
            dominoes.Add(new Domino(2, 4));
            dominoes.Add(new Domino(7, 1));
            return dominoes;
        }
    }
}

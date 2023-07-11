using GameProjectSimulation.Abstract;
using GameProjectSimulation.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProjectSimulation.Concrete
{
    internal class GameManager : IGameService
    {
        public void Add(Game game)
        {
            Console.WriteLine("Oyun Eklendi");
        }

        public void Delete(Game game)
        {
            Console.WriteLine("Oyun Silindi");
        }

        public void SellGame(Game game, Gamer gamer, Campaign campaign)
        {
            Console.WriteLine("Oyun Satıldı");
        }

        public void Update(Game game)
        {
            Console.WriteLine("Oyun Güncellendi");
        }
    }
}

using GameProjectSimulation.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProjectSimulation.Abstract
{
    public interface IGameService
    {
        void SellGame(Game game, Gamer gamer, Campaign campaign);
        void Add(Game game);
        void Update(Game game);
        void Delete(Game game);
    }
}

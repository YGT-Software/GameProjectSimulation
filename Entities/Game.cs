using GameProjectSimulation.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProjectSimulation.Entities
{
    public class Game : IEntities
    {
        public int GameId { get; set; }
        public string GameName { get; set; }
        public int GamePrice { get; set; }
    }
}

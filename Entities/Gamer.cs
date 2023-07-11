using GameProjectSimulation.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProjectSimulation.Entities
{
    public class Gamer : IEntities
    {
        public int GamerId { get; set; }
        public string GamerName { get; set; }
        public string GamerLastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string NationalityId { get; set; }
    }
}

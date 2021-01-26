using GameStore.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameStore.Entities
{
    class Game:IGame
    {
        public int Id { get; set; }
        public string GameCode { get; set; }
        public string Name { get; set; }
        public double Cost { get; set; }

    }
}

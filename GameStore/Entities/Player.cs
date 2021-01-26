using System;
using System.Collections.Generic;
using System.Text;

namespace GameStore.Entities
{
    class Player
    {
        public int Id { get; set; }
        public string TCNO { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Username { get; set; }
        public DateTime Birthday { get; set; }
    }
}

using GameStore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GameStore.Managers
{
    class PlayerManager
    {
        static List<Player> Players = null;

        public PlayerManager()
        {
            if( Players == null )
            {
                Players = new List<Player>();
            }
        }

        public List<Player> GetPlayers()
        {
            return Players;
        }
        public void AddPlayer(Player player)
        {
            Players.Add(player);
        }
        public Player GetPlayer(string username)
        {
            return Players.Where(i => i.Username == username).First();
        }
        public void UpdatePlayer(Player player)
        {
            var element = Players.FirstOrDefault(i=>i.TCNO == player.TCNO);
            element.Name = player.Name;
            element.Username = player.Username;
            element.Surname = player.Surname;
            element.Birthday = player.Birthday;
        }
        public void DeletePlayer(Player player)
        {
            Players.Remove(player);
        }
    }
}

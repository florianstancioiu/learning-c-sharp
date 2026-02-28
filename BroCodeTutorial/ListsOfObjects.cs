using System.Collections.Generic;

namespace LearningCSharp.BroCodeTutorial
{
    public class ListsOfObjects
    {
        public ListsOfObjects()
        {
            List<Player> players = new List<Player>();

            players.Add(new Player("John"));
            players.Add(new Player("Jane"));
            players.Add(new Player("Florian"));

            foreach(Player player in players)
            {
                Console.WriteLine(player);
            }

            Console.WriteLine("wazzap from lists of objects");
        }
    }

    class Player
    {
        public String name;

        public Player(String name)
        {
            this.name = name;
        }

        public override string ToString()
        {
            return $"The player's name is: {name}";
        }
    }
}
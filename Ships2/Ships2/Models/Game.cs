using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ships2.Models
{
    public enum field
    {
        Hidden,
        Hit,
        Miss,
        Ship
    }

    public class Game
    {
        public Game()
        {
            player1 = new field[25];
            player2 = new field[25];
            IEnumerable numbers1 = Enumerable.Range(0, 25).OrderBy(x => Guid.NewGuid()).Take(5);
            foreach (int x in numbers1)
            {
                player1[x] = field.Ship;
            }
            IEnumerable numbers2 = Enumerable.Range(0, 25).OrderBy(x => Guid.NewGuid()).Take(5);
            foreach (int x in numbers2)
            {
                player2[x] = field.Ship;
            }
            turn = 1;
        }

        public field[] player1 { get; set; }
        public field[] player2 { get; set; }
        public int turn { get; set; }

    }
}
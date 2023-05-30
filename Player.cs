using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTestTask
{
    class Player : IComparable<Player>
    {
        public string Name
        { get; set; }
        public int Score
        { get; set; }
        public string Tostring()
        {
            return $"{Name}:{Score}";
        }
        public int CompareTo(Player p)
        {
            return Score.CompareTo(p.Score);
        }
        //public static bool operator <(Player this_, Player other)
        //{
        //    return this_.Score <= other.Score;
        //}
        //public static bool operator >(Player this_, Player other)
        //{
        //    return this_.Score >= other.Score;
        //}
        public Player(string name, int score)
        {
            Name = name;
            Score = score;
        }
    }
}

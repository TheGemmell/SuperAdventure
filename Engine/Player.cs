using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Player
    {
        public int CurrentHitPoints { get; set; }
        public int TotalHitPoints { get; set; }
        public int Gold { get; set; }
        public int Exp { get; set; }
        public int Level { get; set; }

        public Player()
        {
            CurrentHitPoints = 10;
            TotalHitPoints = 10;
            Gold = 25;
            Exp = 0;
            Level = 1;

        }

    }
}

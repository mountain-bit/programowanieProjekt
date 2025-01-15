using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public enum ShotResult
    {
        Miss,
        Hit,
        Sunk
    }

    public class Shot
    {
        public int X { get; }
        public int Y { get; }
        public ShotResult Result { get; private set; }

        public Shot(int x, int y)
        {
            X = x;
            Y = y;
            Result = ShotResult.Miss;
        }

        public void SetResult(ShotResult result)
        {
            Result = result;
        }
    }
}

   


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab04
{
    public class Result
    {
        public int changedAndWon;//изменил выбор и победил
        public int changedAndLost;//изменил выбор и потерял
        public int keepAndWon;//не менял выбор и победил
        public int keepAndLost;//не изменил выбор и потерял

        public Result()
        {
            changedAndWon = 0;
            changedAndLost = 0;
            keepAndWon = 0;
            keepAndLost = 0;

        }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab04
{
    public class Result
    {
        public int ChangedAndWon;//изменил выбор и победил
        public int ChangedAndLost;//изменил выбор и потерял
        public int KeepAndWon;//не менял выбор и победил
        public int KeepAndLost;//не изменил выбор и потерял

        public Result()
        {
            ChangedAndWon = 0;
            ChangedAndLost = 0;
            KeepAndWon = 0;
            KeepAndLost = 0;

        }


    }
}

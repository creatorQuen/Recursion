using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion
{
    public class ResultModel
    {
        public int EmptyTime;

        public List<int> CurrentLenghtFilm;

        public ResultModel(int emptyTime, List<int> currentTime)
        {
            EmptyTime = emptyTime;
            CurrentLenghtFilm = currentTime;
        }
    }
}

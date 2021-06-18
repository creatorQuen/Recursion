using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion
{
    public class NodeForFilm
    {
        public static int _TIMEWORKCINEMA = 840;
        public static List<int> _amountAndLenght;
        public int EmptyTime;

        public List<int> CurrentLenghtFilm;
        public List<NodeForFilm> Next;

        public NodeForFilm(int emptyTime, List<int> currentLenghtFilm = null)
        {
            EmptyTime = emptyTime;

            if (currentLenghtFilm != null)
            {
                CurrentLenghtFilm = currentLenghtFilm;
            }
            else
            {
                CurrentLenghtFilm = new List<int>();
            }

            Next = new List<NodeForFilm>();
        }


        public void CreateGraph()
        {
            foreach (int film in _amountAndLenght)
            {
                if (film <= EmptyTime)
                {
                    List<int> tmp = new List<int>();

                    foreach (int q in CurrentLenghtFilm)
                    {
                        tmp.Add(q);
                    }
                    tmp.Add(film);

                    NodeForFilm node = new NodeForFilm(EmptyTime - film, tmp);

                    Next.Add(node);
                    node.CreateGraph();
                }
            }
        }


        public ResultModel GetResult()
        {
            if (Next.Count == 0)
            {
                foreach (var q in _amountAndLenght)
                {
                    if (!CurrentLenghtFilm.Contains(q))
                    {
                        return new ResultModel(_TIMEWORKCINEMA, CurrentLenghtFilm);
                    }
                }

                return new ResultModel(EmptyTime, CurrentLenghtFilm);
            }
            else
            {
                List<ResultModel> results = new List<ResultModel>();

                foreach (NodeForFilm q in Next)
                {
                    if (q.EmptyTime != _TIMEWORKCINEMA)
                    {
                        results.Add(q.GetResult());
                    }
                }

                ResultModel minResult = results[0];
                foreach (ResultModel q in results)
                {
                    if (minResult.EmptyTime > q.EmptyTime)
                    {
                        minResult = q;
                    }
                }
                return minResult;
            }
        }


    }
}


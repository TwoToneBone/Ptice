using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ptice
{
    class Program
    {
        static void Main(string[] args)
        {
            string n = Console.ReadLine();
            string answers = Console.ReadLine();
            string adrian = "ABC";
            string bruno = "BABC";
            string goran = "CCAABB";

            Result adrianR = new Result();
            Result brunoR = new Result();
            Result goranR = new Result();

            List<Result> resultList = new List<Result>();
            List<string> outputs = new List<string>();

            adrianR.Name = "Adrian";
            brunoR.Name = "Bruno";
            goranR.Name = "Goran";

            adrianR.Score = Score(answers, adrian, adrian.Count());
            brunoR.Score = Score(answers, bruno, bruno.Count());
            goranR.Score = Score(answers, goran, goran.Count());

            resultList.Add(adrianR);
            resultList.Add(brunoR);
            resultList.Add(goranR);

            int maxScore = resultList.Max(a => a.Score);
            var vinners = resultList.Where(a => a.Score == maxScore);

            outputs.Add(maxScore.ToString());

            foreach (var item in vinners)
            {
                outputs.Add(item.Name);
            }

            foreach (string s in outputs)
            {
                Console.WriteLine(s);
            }

        }

        static int Score(string answers, string tactic, int patternLength)
        {
            int score = 0;

            for (int i = 0; i < answers.Length; i++)
            {
                if (answers[i] == tactic[i % patternLength])
                {
                    score++;
                }
            }

            return score;
        }

        struct Result
        {
            public string Name;
            public int Score;
        }
    }
}

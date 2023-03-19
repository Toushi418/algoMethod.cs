using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algoMethod.cs.入力を受け取る.複数の入力を受け取る
{
    internal class _10
    {
        public void use_10()
        {
            var S = Console.ReadLine();
            var NM = Console.ReadLine().Split(' ');
            var N = int.Parse(NM[0]);
            var M = int.Parse(NM[1]);

            StringBuilder sb = new StringBuilder(S);
            sb[N - 1] = S[M - 1];
            sb[M - 1] = S[N - 1];

            S = sb.ToString();
            Console.WriteLine(S);
        }
    }
}

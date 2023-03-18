using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algoMethod.cs.入力を受け取る.複数の入力を受け取る
{
    internal class _5
    {
        public void use_5()
        {
            var line = Console.ReadLine();
            var l = line.Split(' ');
            int A = int.Parse(l[0]);
            int B = int.Parse(l[1]);
            int C = int.Parse(l[2]);

            Console.WriteLine((A + B + C) / 3);
        }
    }
}

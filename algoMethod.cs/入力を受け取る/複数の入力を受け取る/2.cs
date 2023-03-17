using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algoMethod.cs.入力を受け取る.複数の入力を受け取る
{
    internal class _2
    {
        public void use_2()
        {
            var line = Console.ReadLine();
            var l = line.Split(' ');
            var A = int.Parse(l[0]);
            var B = int.Parse(l[1]);

            if (A > B)
            {
                Console.WriteLine(A);
            }
            else
            {
                Console.WriteLine(B);
            }
        }
    }
}

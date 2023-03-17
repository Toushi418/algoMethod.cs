using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algoMethod.cs.入力を受け取る.複数の入力を受け取る
{
    internal class _3
    {
        public void use_3()
        {
            var line = Console.ReadLine();
            var l = line.Split(' ');
            var A = int.Parse(l[0]);
            var B = int.Parse(l[1]);

            if ((A % 10) > (B % 10))
            {
                Console.WriteLine(B);
            }
            else
            {
                Console.WriteLine(A);
            }
        }
    }
}

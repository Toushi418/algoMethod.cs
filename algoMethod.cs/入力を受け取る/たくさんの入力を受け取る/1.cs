using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algoMethod.cs.入力を受け取る.たくさんの入力を受け取る
{
    internal class _1
    {
        public void use_1()
        {
            var N = int.Parse(Console.ReadLine());
            var numbers = Console.ReadLine().Split(' ').Select(s => int.Parse(s)).ToArray(); ;
            int sum = 0;

            for (var i = 0; i < N; i++)
            {
                sum += numbers[i];
            }
        }
    }
}

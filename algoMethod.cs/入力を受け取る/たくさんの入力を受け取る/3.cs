using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algoMethod.cs.入力を受け取る.たくさんの入力を受け取る
{
    internal class _3
    {
        public　void use_3()
        {
            var N = int.Parse(Console.ReadLine());
            var line = Console.ReadLine().Split(' ');
            var numbers = line.Select(s => int.Parse(s)).ToArray();

            for (var i = 0; i < N; i++)
            {
                Console.WriteLine(numbers[i] % 10);

            }
        }
    }
}

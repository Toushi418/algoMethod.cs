using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algoMethod.cs.入力を受け取る.たくさんの入力を受け取る
{
    internal class _4
    {
        public void use_4()
        {
            var N = int.Parse(Console.ReadLine());
            var numbers = Console.ReadLine().Split(' ').Select(s => int.Parse(s)).ToArray();

            for (var i = 0; i < N; i++)
            {
                if (numbers[i] % 3 == 0)
                    Console.WriteLine(numbers[i]);
            }
        }
    }
}

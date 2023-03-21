using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algoMethod.cs.入力を受け取る.たくさんの入力を受け取る
{
    internal class _2
    {
        public void use_2()
        {
            var N = int.Parse(Console.ReadLine());
            var line = Console.ReadLine();
            var numbers = line.Split(' ').Select(s => int.Parse(s)).ToArray();

            var result = 1;

            for (var i = 0; i < N; i++)
            {
                result *= numbers[i];
            }

            Console.WriteLine(result);
        }
    }
}

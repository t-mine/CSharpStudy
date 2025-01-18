using CSharpStudy.Models;
using CSharpStudy.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpStudy.Chapters;

public static class Chapter3
{
    public static void Do()
    {
        // メソッドを引数に渡す
        static int Count(int[] numbers, Func<int, bool> judge)
        {
            int count = 0;
            foreach (int number in numbers)
            {
                if (judge(number))
                {
                    count++;
                }
            }
            return count;
        }
        var judge = (int x) => x > 5;
        var numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        var count = Count(numbers, judge);
        Console.WriteLine(count);
    }
}

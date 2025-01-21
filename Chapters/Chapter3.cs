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
        var numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        var count = Count(numbers, x => x > 5);
        Console.WriteLine(count);

        // 問題3.1
        var nums = new List<int> { 12, 87, 94, 53, 20, 40, 35, 76, 91, 31, 17, 48 };
        // 問題3.1-1
        Console.WriteLine("問題3.1-1");
        var ok89s = nums.Where(num => num % 8 == 0 || num % 9 == 0);
        foreach (int number in ok89s)
        {
            Console.WriteLine(number);
        }
        // 問題3.1-2
        Console.WriteLine("問題3.1-2");
        nums.ForEach(x =>
        {
            Console.WriteLine((double)x / 2);
        });
        // 問題3.1-3
        Console.WriteLine("問題3.1-3");
        var over50 = nums.Where(x => x > 50);
        foreach (int number in over50)
        {
            Console.WriteLine(number);
        }
        // 問題3.1-4
        Console.WriteLine("問題3.1-4");
        var doubles = nums.Select(x => x * 2).ToList();
        foreach (int number in doubles)
        {
            Console.WriteLine(number);
        }
        // 問題3.2
        var cities = new List<string>
        {
            "Tokyo", "New Delhi", "Bangkok", "London", "Paris", "Berlin",
            "Canberra", "Hong Kong"
        };
        // 問題3.2-1
        //Console.WriteLine("問題3.2-1");
        //Console.WriteLine("都市名を入力してEnterを押してください");
        //var name = Console.ReadLine();
        //var index = cities.FindIndex(x => x == name);
        //Console.WriteLine(index);
        // 問題3.2-2
        Console.WriteLine("問題3.2-2");
        var oCount = cities.Count(x=>x.Contains("o"));
        Console.WriteLine(oCount);
        // 問題3.2-3
        Console.WriteLine("問題3.2-3");
        var containsOs = cities.Where(x => x.Contains("o"));
        foreach (var item in containsOs)
        {
            Console.WriteLine(item);
        }
        // 問題3.2-4
        Console.WriteLine("問題3.2-4");
        var wordCounts = cities
            .Where(x => x.StartsWith("B"))
            .Select(x => x.Length);
        foreach (var wordCount in wordCounts)
        {
            Console.WriteLine(wordCount);
        }
    }
}

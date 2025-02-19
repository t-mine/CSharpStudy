using CSharpStudy.Models;
using CSharpStudy.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.XPath;

namespace CSharpStudy.Chapters;

public static class Chapter8
{
    public static void Do()
    {
        // 問題8.1
        var str = "Cozy lummox gives smart squid who asks for job pen";
        // 問題8.1.1
        var alphaStr = str.Where(c => 'a' <= c && c <= 'z');
        var dict = new Dictionary<string, int>();
        foreach (var c in alphaStr)
        {
            var key = c.ToString().ToUpper();
            if (dict.ContainsKey(key))
            {
                dict[key] = dict[key] + 1;
            }
            else
            {
                dict.Add(key, 1);
            }
        }
        dict = dict.OrderBy(x => x.Key).ToDictionary();
        foreach (var item in dict)
        {
            Console.WriteLine($"{item.Key}:{item.Value}");
        }
        // 問題8.1.1 スマートな解法
        var dict2 = str
            .Where(char.IsLetter)
            .Select(char.ToUpper)
            .GroupBy(c => c)
            .OrderBy(x => x.Key)
            .ToDictionary(g => g.Key, g => g.Count());
        foreach (var item in dict2)
        {
            Console.WriteLine($"{item.Key}:{item.Value}");
        }
        // 問題8.1.2
        var alphaStr3 = str.Where(c => 'a' <= c && c <= 'z');
        var dict3 = new SortedDictionary<string, int>();
        foreach (var c in alphaStr3)
        {
            var key = c.ToString().ToUpper();
            if (dict3.ContainsKey(key))
            {
                dict3[key] = dict3[key] + 1;
            }
            else
            {
                dict3.Add(key, 1);
            }
        }
        foreach (var item in dict3)
        {
            Console.WriteLine($"{item.Key}:{item.Value}");
        }
        // 問題8.2.1
        var abb = new Abbreviations();
        Console.WriteLine($"Count:{abb.Count}");
        // 問題8.2.2
        abb.Remove("EU");
        Console.WriteLine($"Count after remove:{abb.Count}");
        // 問題8.2.4
        abb.GetDictByKeyLength(3)
            .Select(item => $"{item.Key}={item.Value}")
            .ToList()
            .ForEach(s => Console.WriteLine(s));
    }
}

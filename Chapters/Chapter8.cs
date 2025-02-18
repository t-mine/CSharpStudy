using CSharpStudy.Models;
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
            var key = c.ToString().ToLower();
            if (dict.ContainsKey(key))
            {
                dict[key] = dict[key] + 1;
            }
            else
            {
                dict.Add(key, 1);
            }
        }
        foreach (var item in dict)
        {
            Console.WriteLine($"{item.Key}:{item.Value}");
        }
        // 問題8.1.1 スマートな解法
        var dict2 = str
            .Where(char.IsLetter)
            .Select(char.ToLower)
            .GroupBy(c => c)
            .ToDictionary(g => g.Key, g => g.Count());
        foreach (var item in dict2)
        {
            Console.WriteLine($"{item.Key}:{item.Value}");
        }
    }
}

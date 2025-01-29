using CSharpStudy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpStudy.Chapters;

public static class Chapter4
{
    public static void Do()
    {
        // 問題4.1
        List<string> langs =
        [
            "C#","Java","Ruby","PHP","Python","TypeScript","JavaScript","Swift","Go"
        ];
        // 問題4.1.1
        foreach (string lan in langs)
        {
            if (lan.Contains("S"))
            {
                Console.WriteLine(lan);
            }
        }
        for (int i = 0; i < langs.Count; i++)
        {
            var lan = langs[i];
            if (lan.Contains("S"))
            {
                Console.WriteLine(lan);
            }
        }
        int j = 0;
        while (j < langs.Count)
        {
            var lan = langs[j];
            if (lan.Contains("S"))
            {
                Console.WriteLine(lan);
            }
            j++;
        }
    }
}

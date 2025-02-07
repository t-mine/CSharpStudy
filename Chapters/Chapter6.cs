using CSharpStudy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.XPath;

namespace CSharpStudy.Chapters;

public static class Chapter6
{
    public static void Do()
    {
        // 問題6.1
        var str1 = Console.ReadLine();
        var str2 = Console.ReadLine();
        var equal = str1.Equals(str2, StringComparison.OrdinalIgnoreCase);
        Console.WriteLine(equal);
    }
}

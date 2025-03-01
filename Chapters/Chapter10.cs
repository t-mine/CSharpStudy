using CSharpStudy.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpStudy.Chapters;

class Chapter10
{
    public static void Do()
    {
        Section1();

        // 問題10.1
        var path = @"./Files/Class1.cs";
        // 問題10.1.1
        var count = FileCounter.CountFiles(path);
        Console.WriteLine(count);
        // 問題10.1.2
        var count2 = FileCounter.CountFiles2(path);
        Console.WriteLine(count2);
        // 問題10.1.3
        var count3 = FileCounter.CountFiles3(path);
        Console.WriteLine(count3);
        // 問題10.2
        var path2 = @"./Files/Class1.cs";
        var lines = File.ReadAllLines(path2);
        var lineWithLineNumbers = lines.Select(line => $"{Array.IndexOf(lines, line) + 1}: {line}");
        using (var wr = new StreamWriter(@"./Files/Class1WithLineNumbers.cs"))
        {
            foreach (var line in lineWithLineNumbers)
            {
                wr.WriteLine(line);
            }
        }

    }

    private static void Section1()
    {
        var filePath = @"./Files/Greeting.txt";
        if (File.Exists(filePath))
        {
            using var reader = new StreamReader(filePath, Encoding.UTF8);
            while(!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                Console.WriteLine(line);
            }
        }
    }
}

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

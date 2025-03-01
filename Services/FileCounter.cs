using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpStudy.Services;

static class FileCounter
{
    public static int CountFiles(string path)
    {
        int count = 0;
        var sr = new StreamReader(path);
        while(!sr.EndOfStream)
        {
            var line = sr.ReadLine();
            if (line?.Contains(" class ") == true)
            {
                count++;
            }
        }
        return count;
    }

    public static int CountFiles2(string path)
    {
        var lines = File.ReadAllLines(path);
        return lines.Count(x => x.Contains(" class "));
    }

    public static int CountFiles3(string path)
    {
        var lines = File.ReadLines(path);
        return lines.Count(x => x.Contains(" class "));
    }
}

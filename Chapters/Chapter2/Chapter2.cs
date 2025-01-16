using CSharpStudy.Models;
using CSharpStudy.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpStudy.Chapters.Chapter2;

public static class Chapter2
{
    public static void Do()
    {
        // 2.1 距離換算プログラム
        double meterPerFeet = 0.3048;
        for (int feet = 1; feet <= 10; feet++)
        {
            double meter = feet * meterPerFeet;
            Console.WriteLine($"{feet}ft = {meter:0.0000}m");
        }
        // 2.2 売上集計プログラム
        var sales = new SalesCounter("./Files/sales.csv");
        var amountPerSales = sales.GetPerStoreSales();
        foreach (var amount in amountPerSales)
        {
            Console.WriteLine($"{amount.Key} {amount.Value}円");
        }
    }
}

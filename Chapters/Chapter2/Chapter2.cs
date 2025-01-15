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
        static List<Sale> ReadSales(string filePath)
        {
            List<Sale> sales = new List<Sale>();
            string[] lines = File.ReadAllLines(filePath); // ReadAllLinesは何万行もあるファイルには不向き
            foreach (string line in lines)
            {
                string[] items = line.Split(",");
                // newのとき()を省略できる
                Sale sale = new Sale
                {
                    ShopName = items[0],
                    ShopCategory = items[1],
                    Amount = int.Parse(items[2])
                };
                sales.Add(sale);
            }
            return sales;
        }
        var sales = new SalesCounter(ReadSales("./Files/sales.csv"));
        var amountPerSales = sales.GetPerStoreSales();
        foreach (var amount in amountPerSales)
        {
            Console.WriteLine($"{amount.Key} {amount.Value}円");
        }
    }
}

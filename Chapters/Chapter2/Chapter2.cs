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
        // 問題2.1
        var songs = new List<Song>();
        var song1 = new Song("冬のソナタ", "wai", 240);
        var song2 = new Song("頭の中の消しゴム", "ten", 350);
        songs.Add(song1);
        songs.Add(song2);
        foreach (var song in songs)
        {
            var lengthMin = song.Length / 60;
            var lengthSec = song.Length % 60;
            Console.WriteLine($"{song.Title}の演奏時間は {lengthMin}:{lengthSec:00} です。");
        }
        // 問題2.2
        static double InchToMeter(int inch)
        {
            var meterPerInch = 0.0254;
            return (double)inch * meterPerInch;
        }
        for (int inch = 0; inch <= 10; inch++)
        {
            var meter = InchToMeter(inch);
            Console.WriteLine($"{inch}inch = {meter:0.0000}m");
        }
    }
}

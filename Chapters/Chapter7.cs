using CSharpStudy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.XPath;

namespace CSharpStudy.Chapters;

public static class Chapter7
{
    public static void Do()
    {
        // 問題7.1
        int[] numbers = [5, 10, 17, 9, 3, 21, 10, 40, 21, 3, 35];
        // 問題7.1.1
        var max = numbers.Max();
        Console.WriteLine(max);
        // 問題7.1.2
        var last2Numbers = numbers.Skip(numbers.Length - 2).ToArray();
        Console.WriteLine($"Second Last: {last2Numbers[0]}, Last: {last2Numbers[1]}");
        // 問題7.1.3
        numbers.Select(n => n.ToString("000")).ToList().ForEach(n => Console.WriteLine(n));
        // 問題7.1.4
        numbers.Order().Take(3).ToList().ForEach(n => Console.WriteLine(n));
        // 問題7.1.5
        var result = numbers.Distinct().Count(n => n > 10);
        Console.WriteLine($"result:{result}");
        // 問題7.2
        var books = new List<Book> {
             new Book { Title = "C#プログラミングの新常識", Price = 3800, Pages = 378 },
             new Book { Title = "ラムダ式とLINQの極意", Price = 2500, Pages = 312 },
             new Book { Title = "ワンダフル・C#ライフ", Price = 2900, Pages = 385 },
             new Book { Title = "一人で学ぶ並列処理プログラミング", Price = 4800, Pages = 464 },
             new Book { Title = "フレーズで覚えるC#入門", Price = 5300, Pages = 604 },
             new Book { Title = "私でも分かったASP.NET Core", Price = 3200, Pages = 453 },
             new Book { Title = "楽しいC#プログラミング教室", Price = 2540, Pages = 348 },
         };
        // 問題7.2.1 "ワンダフル・C#ライフ"
        var book = books.FirstOrDefault(b => b.Title == "ワンダフル・C#ライフ");
        Console.WriteLine($"Title:{book.Title}, Price:{book.Price}, Pages:{book.Pages}");
        // 問題7.2.2
        var CSharpBooksCount = books.Where(b => b.Title.Contains("C#")).Count();
        Console.WriteLine($"Number of books that contain C# is : {CSharpBooksCount}");
        // 問題7.2.3
        var CSharpBooksPagesAvg = books.Where(b => b.Title.Contains("C#")).Average(b => b.Pages);
        Console.WriteLine($"Average number of pages of books that contain C# is : {CSharpBooksPagesAvg}");
        // 問題7.2.4
        var title = books.FirstOrDefault(b => b.Price >= 4000)?.Title;
        Console.WriteLine($"Title of the book that costs more than 4000 is : {title}");
        // 問題7.2.5
        var pageCount = books.Where(b => b.Price < 4000).Max(b => b.Pages);
        Console.WriteLine($"Number of pages of the most expensive book that costs less than 4000 is : {pageCount}");
        // 問題7.2.6
        var selectedBooks = books.Where(b => b.Pages >= 400).OrderByDescending(b => b.Price).ToList();
        selectedBooks.ForEach(b => Console.WriteLine($"Title:{b.Title}, Price:{b.Price}"));
        // 問題7.2.7
        var hogeBooks = books.Where(b => b.Title.Contains("C#") && b.Pages <= 500).ToList();
        hogeBooks.ForEach(b => Console.WriteLine($"Title:{b.Title}"));
    }
}

using CSharpStudy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpStudy.Services;

internal class SalesCounter
{
    private readonly IEnumerable<Sale> _sales;

    public SalesCounter(string path)
    {
        _sales = ReadSales(path);
    }

    /// <summary>
    /// 店舗別売上を求める
    /// </summary>
    /// <returns></returns>
    public IDictionary<string, int> GetPerStoreSales()
    {
        var dict = new Dictionary<string, int>();
        foreach (Sale sale in _sales)
        {
            if (dict.ContainsKey(sale.ShopName))
            {
                dict[sale.ShopName] += sale.Amount;
            }
            else
            {
                dict[sale.ShopName] = sale.Amount;
            }
        }
        return dict;
    }

    /// <summary>
    /// カテゴリ別売上を求める
    /// </summary>
    /// <returns></returns>
    public IDictionary<string, int> GetPerCategorySales()
    {
        var dict = new Dictionary<string, int>();
        foreach (Sale sale in _sales)
        {
            if (dict.ContainsKey(sale.ShopCategory))
            {
                dict[sale.ShopCategory] += sale.Amount;
            }
            else
            {
                dict[sale.ShopCategory] = sale.Amount;
            }
        }
        return dict;
    }

    private static IEnumerable<Sale> ReadSales(string filePath)
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

}

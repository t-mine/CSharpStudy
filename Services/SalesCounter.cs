using CSharpStudy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpStudy.Services;

internal class SalesCounter
{
    private readonly List<Sale> _sales;

    public SalesCounter(List<Sale> sales)
    {
        _sales = sales;
    }

    /// <summary>
    /// 店舗別売上を求める
    /// </summary>
    /// <returns></returns>
    public Dictionary<string, int> GetPerStoreSales()
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

}

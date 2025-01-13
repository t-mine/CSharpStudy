using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpStudy.Models;

public class Sale
{
    /// <summary>
    /// 店舗名
    /// </summary>
    public string ShopName { get; set; } = string.Empty;

    /// <summary>
    /// 商品カテゴリ
    /// </summary>
    public string ShopCategory { get; set; } = string.Empty;

    /// <summary>
    /// 売上高
    /// </summary>
    public int Amount { get; set; }
}

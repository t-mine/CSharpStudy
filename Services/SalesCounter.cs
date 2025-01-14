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
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpStudy.Models;

public class Student : Person
{
    /// <summary>
    /// 学年
    /// </summary>
    public int Grade { get; set; }
    /// <summary>
    /// 組
    /// </summary>
    public int ClassNumber { get; set; }
}

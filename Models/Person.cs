using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpStudy.Models;

public class Person
{
    public string Name { get; set; } = string.Empty;

    public DateTime BirthDay { get; set; }

    public int GetAge()
    {
        var today = DateTime.Today;
        int age = today.Year - BirthDay.Year;
        if (today < BirthDay.AddYears(age))
        {
            age--;
        }
        return age;
    }
}

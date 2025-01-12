using CSharpStudy.Models;


// 問題1.1
var dorayaki = new Product()
{
    Code = 98,
    Name = "どらやき",
    Price = 210
};
const double TAX = 0.1;
var priceIncludeTax = dorayaki.Price + dorayaki.Price * TAX;
Console.WriteLine($"{dorayaki.Name}の値段は{priceIncludeTax}円です。");

// 問題1.2
void PrintObjects(MyClass classA, MyStruct structA)
{
    Console.WriteLine($"{nameof(classA)}の{nameof(classA.X)}は{classA.X}です。");
    Console.WriteLine($"{nameof(classA)}の{nameof(classA.Y)}は{classA.Y}です。");
    Console.WriteLine($"{nameof(structA)}の{nameof(structA.X)}は{structA.X}です。");
    Console.WriteLine($"{nameof(structA)}の{nameof(structA.Y)}は{structA.Y}です。");
    // 2倍にする
    classA.X = classA.X * 2;
    classA.Y = classA.Y * 2;
    structA.X = structA.X * 2;
    structA.Y = structA.Y * 2;
}
// 初期化
var classA = new MyClass() { X = 1, Y = 2};
var structA = new MyStruct() { X = 3, Y = 4 };
// メソッド呼び出し
PrintObjects(classA, structA);
// プリント
Console.WriteLine($"{nameof(classA)}の{nameof(classA.X)}は{classA.X}です。");
Console.WriteLine($"{nameof(classA)}の{nameof(classA.Y)}は{classA.Y}です。");
Console.WriteLine($"{nameof(structA)}の{nameof(structA.X)}は{structA.X}です。");
Console.WriteLine($"{nameof(structA)}の{nameof(structA.Y)}は{structA.Y}です。");

// 問題1.3
var student = new Student()
{
    Name = "八九寺真宵",
    Grade = 5,
    ClassNumber = 1,
};
Console.WriteLine($"{nameof(student)}の{nameof(student.Name)}は{student.Name}です。");
Console.WriteLine($"{nameof(student)}の{nameof(student.Grade)}は{student.Grade}です。");
Console.WriteLine($"{nameof(student)}の{nameof(student.ClassNumber)}は{student.ClassNumber}です。");

Person person = student;
Object obj = student;
using CSharpStudy.Chapters;

var chapters = new List<(string Title, Action Do)>
{
    ("Chapter1", Chapter1.Do),
    ("Chapter2", Chapter2.Do),
    ("Chapter3", Chapter3.Do),
    ("Chapter4", Chapter4.Do),
    ("Chapter5", Chapter5.Do),
    ("Chapter6", Chapter6.Do),
};

foreach (var chapter in  chapters)
{
    Console.WriteLine();
    Console.WriteLine($"{chapter.Title} =========================");
    chapter.Do();
}
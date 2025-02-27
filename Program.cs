﻿using CSharpStudy.Chapters;

var chapters = new List<(string Title, Action Do)>
{
    ("Chapter1", Chapter1.Do),
    ("Chapter2", Chapter2.Do),
    ("Chapter3", Chapter3.Do),
    ("Chapter4", Chapter4.Do),
    ("Chapter5", Chapter5.Do),
    ("Chapter6", Chapter6.Do),
    ("Chapter7", Chapter7.Do),
    ("Chapter8", Chapter8.Do),
    ("Chapter9", Chapter9.Do),
    ("Chapter10", Chapter10.Do),
};

foreach (var chapter in  chapters)
{
    Console.WriteLine();
    Console.WriteLine($"{chapter.Title} =========================");
    chapter.Do();
}
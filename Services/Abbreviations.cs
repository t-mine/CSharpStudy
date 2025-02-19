using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpStudy.Services;

// 略語と対応する日本語を管理するクラス
public class Abbreviations
{
    private readonly Dictionary<string, string> _dict = new();

    public int Count {
        get
        {
            return _dict.Count;
        }
    }

    // コンストラクター
    public Abbreviations()
    {
        var lines = File.ReadAllLines("./Files/Abbreviations.txt");
        _dict = lines
            .Select(line => line.Split('='))
            .ToDictionary(x => x[0], x => x[1]);
    }

    // 要素を追加
    public void Add(string abbr, string japanese) =>
        _dict[abbr] = japanese;

    // 要素を削除
    public bool Remove(string abbr) =>
        _dict.Remove(abbr);

    // 省略語から対応する日本語を取り出す
    public string? Get(string abbr) =>
        _dict.ContainsKey(abbr) ? _dict[abbr] : null;

    // 省略語から指定文字数の日本語を取り出す
    public Dictionary<string, string> GetDictByKeyLength(int keyLength) =>
        _dict.Where(x => x.Key.Length == keyLength).ToDictionary();

    // 日本語から対応する省略語を取り出す
    public string? ToAbbreviation(string japanese) =>
        _dict.FirstOrDefault(x => x.Value == japanese).Key;

    // 日本語の部分文字列を引数に与え、それが含まれる要素(Key,Value)をすべて取り出す
    public IEnumerable<(string, string)> FindAll(string substring)
    {
        foreach (var (key, value) in _dict)
        {
            if (value.Contains(substring))
            {
                yield return (key, value);
            }
        }
    }
 }

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpStudy.Files
{
    /// <summary>
    /// StringのUtilクラスのサンプル
    /// </summary>
    class Class1
    {
        /// <summary>
        /// 文字列を指定した文字列で分割する
        /// </summary>
        /// <param name="str">分割する文字列</param>
        /// <param name="separator">分割する文字列</param>
        /// <returns>分割された文字列の配列</returns>
        public static string[] Split(string str, string separator)
        {
            return str.Split(new string[] { separator }, StringSplitOptions.None);
        }
        /// <summary>
        /// 文字列を指定した文字列で結合する
        /// </summary>
        /// <param name="strs">結合する文字列の配列</param>
        /// <param name="separator">結合する文字列</param>
        /// <returns>結合された文字列</returns>
        public static string Join(string[] strs, string separator)
        {
            return string.Join(separator, strs);
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ensyuu_kome2
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 4; i++)//*が増えるループを5回
            {
                string m = "    ";
                string n = "*";
                string o = string.Concat(Enumerable.Repeat("**", i));//ループの回数だけ**増加
                if (i == 1)//1行目は*一つから始めたい
                {
                    Console.WriteLine(m+n);
                }
                m = m.Remove(0, i);//文字列mの最初からi番目の文字を削除
                Console.WriteLine(m+n+o.ToString());//奇数にするため+nをした
                }
        }
    }
}

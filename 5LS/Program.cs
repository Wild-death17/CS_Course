namespace _5LS
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //1 {
            //     static bool firstlast(string str)
            //     {
            //         char a = str[0], b = str[(str.Length - 1)];
            //         if (a == b)
            //             return true;
            //         return false;
            //     }
            // }
            //2 {
            //     int cnt = 0;
            //     string[] arr = new string[4];
            //     for (int i = 0; i < 4; i++)
            //     {
            //         Console.WriteLine("Please Enter A Word : ");
            //         arr[i] = Console.ReadLine();
            //     }
            //     foreach (var i in arr)
            //     {
            //         if (firstlast(i))
            //             cnt++;
            //     }
            //     Console.WriteLine(cnt);
            // }
            // 3 {
            //     static bool ischarhere(string str, char a)
            //     {
            //         if (str.IndexOf(a) != str.LastIndexOf(a))
            //             return true;
            //         return false;
            //     }
            // }
            // 4 {
            //     static bool IsArreyRich(string[] str)
            //     {
            //         foreach (var i in str)
            //         {
            //             if (i.IndexOf(i[0]) == i.LastIndexOf(i[0]))
            //                 return false;
            //         }
            //         return true;
            //     }
            // }
            // 4.2 {
            //     static bool IsArreyRich(string[] str)
            //     {
            //         foreach (var i in str)
            //         {
            //             if (!ischarhere(i, i[0]))
            //                 return false;
            //         }
            //         return true;
            //     }
            // }
            // 5 {
            //     static string LngstString(string[] _str)
            //     {
            //         string k = _str[0];
            //         for (int i = 1; i < _str.Length; i++)
            //         {
            //             k = (k.Length < _str[i].Length) ? _str[i] : k;
            //         }
            //         return k;
            //     }
            // }
            // 6 {
            //     static string StrUnion(string a, string b)
            //     {
            //         string str = "";
            //         foreach (var i in a)
            //         {
            //             if (b.IndexOf(i) == -1)
            //             {
            //                 str += i;
            //             }
            //         }
            //         return str;
            //     }
            // }
            // 6.2 {
            // static bool stringHasChar(string str, char a)
            // {
            //     if (str.IndexOf(a) != -1)
            //         return true;
            //     return false;
            // }
            // }
            // 7 {
            //     long Num = 0, Cnt = 0, All = 0;
            //     do
            //     {
            //         System.Console.Write("enter a number : ");
            //         Num = long.Parse(Console.ReadLine());
            //         All++;
            //         if (Num % 10 == 3)
            //             Cnt++;
            //     } while (Num != 500);
            //     System.Console.WriteLine($"out of {All}, {Cnt} had 3 in thair Number of units.");
            // }
            System.Console.ReadKey();
        }
    }
}
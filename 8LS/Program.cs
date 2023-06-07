
using System.Reflection.Metadata;

namespace _8LS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int w = 7;
            int q = Dbl(w) + Dbl(3);
            string str = "Hello World ";
            string _str = "14564123543252312534554";
            string[] strings = { "hn", "bf", "bf", "kkk" };
            int[] ints = { 14564, 1235432523, 12534554 };

            Console.WriteLine(q);
            Console.WriteLine(Dbl());
            Console.WriteLine(Radius());
            Console.WriteLine(Radius(0.5));
            Console.WriteLine(Radius(4, 8));
            Console.WriteLine(Radius(5, 5, 5));
            Console.WriteLine("Square: {0}", Radius(7));
            Console.WriteLine("Rectangle: {0}", Radius(7, 3));
            Console.WriteLine(str.Length);
            Console.WriteLine(Trim(str).Length);
            Console.WriteLine(TavCheck(_str));
            Console.WriteLine(fiveCounter(ints));
            Console.WriteLine(whereIsA(strings));

            // מכפיל את המספר שמקבל
            static int Dbl(int x = 0)// יצירת פרמטר אופציונלי
            {
                int y = x + 1;
                y *= 2;
                return y;
            }
            // מחשב היקף של צורה מתקבלת
            static double Radius(double x = 0, double y = 0, double z = 0, bool flag = false)// יצירת פרמטרים אופציונאלים 
            {
                if (flag)
                {
                    if (y != 0 && z == 0)
                        return ((x + y) * 2);
                    else if (y == 0 && z != 0)
                        return (x + y + z);
                    return (x * 4);
                }
                else
                {
                    if (x == 0)
                    {
                        return 80085;
                    }
                    else if (y != 0 && z == 0)
                    {
                        return ((x + y) * 2);
                    }
                    else if (y == 0 && z == 0)
                    {
                        return (x * 4);
                    }
                    else
                    {
                        return x + y + z;
                    }
                }

            }
            // מוריד את הרווח או את התו האחרון ממחרוזת 
            static string Trim(string x, char y = ' ')
            {
                if (x[x.Length - 1] == y)
                {
                    return x.Substring(0, x.Length - 1);
                }
                return x;
            }
            // סופר כמה 5 יש במחרוזת
            static int TavCheck(string x, char y = '5')
            {
                int cnt = 0;
                foreach (char c in x)
                {
                    if (c == y) { cnt++; }
                }
                return cnt;
            }
            // סופר כמה 5 יש במערך מספרים ככלל
            static int fiveCounter(int[] x)
            {
                int cnt = 0;
                foreach (var i in x)
                {
                    string str = Convert.ToString(i);
                    cnt += TavCheck(str);
                }
                return cnt;
            }
            // נמצא במערך A בודק איפה התו  
            static char whereIsA(string[] str)
            {
                int doc = -1;
                int i = 0;
                while(i < str.Length)
                {
                    if (str[i++].IndexOf('A') != -1)
                        doc = i+1;
                }
                if (doc <= (str.Length / 2) && doc != -1)
                    return 'L';
                else if (doc > (str.Length / 2))
                    return 'R';
                return 'N';
            }
            // בודק איפה ה5 נמצא במערך 
            static char FindEdge(int[] ints)
            {
                int R = ints.Length - 1;
                int L = 0;
                while(L <= R) {
                    if (ints[L++] == 5)
                        return 'L';
                    if (ints[R++] == 5)
                        return 'R';
                }
                return 'N';
            }
            // בודק איפה ה5 נמצא במערך
            static char whereIs5(int[] ints)
            {
                int doc = -1;
                for (int i = 0; i < ints.Length; i++)
                {
                    if ( ints[i] == 5)
                    {
                        doc = i;
                    }
                }
                if (doc <= (ints.Length / 2) && doc != -1)
                    return 'L';
                else if (doc > (ints.Length / 2))
                    return 'R';
                return 'N';
            }
        }
    }
}
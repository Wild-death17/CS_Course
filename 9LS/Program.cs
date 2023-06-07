namespace _9LS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] w = { 3, 7, 9, 11 };
            int[] m = { 4, 6, 3, 9, 12, 70 };
            int[] a = { 43, 14, 231, 5625, 31 };

            //Console.WriteLine(SOD_Segregation_Of_Duties(w)); // OutPuts 30
            //Console.WriteLine(SOD_Segregation_Of_Duties(m)); // OutPuts 104
            //Console.WriteLine(Lama("LamaLo")); // OutPuts oLaaamaL
            //Console.WriteLine(Lamakacha("LamaLo")); // OutPuts oLaaamaL
            //Console.WriteLine(Sumof3(162392)); // OutPuts 18

            //DoingSomthingIDK(a);
            //foreach (var item in a) { Console.Write($" {item} "); }
            // OutPuts 34  0  132  0  13

            static int SOD_Segregation_Of_Duties(int[] a, int n = 0)
            {
                if (n == a.Length - 1)
                {
                    return a[n];
                }
                return a[n] + SOD_Segregation_Of_Duties(a, n + 1);
            }


            static string Lama(string s, int n = 0)
            {
                return Kacha(s, n) + s[n];
            }


            static string Kacha(string s, int n = 0)
            {
                if (n >= s.Length / 2)
                {
                    return s[n].ToString();
                }
                return s[s.Length - 1 - n] + Lama(s, n + 1);
            }


            static string Lamakacha(string s)
            {
                string str = s[s.Length / 2].ToString();
                for (int i = s.Length / 2; i > 0; i--)
                {
                    str += s[i].ToString();
                    str = s[s.Length - i].ToString() + str;
                }
                return str + s[0];
            }


            static int Sumof3(int n)
            {
                if (n == 0)
                    return n;
                int d = n % 10;
                if (d % 3 == 0)
                    return d + Sumof3(n / 10);
                return Sumof3(n / 10);
            }



            static void DoingSomthingIDK(int[] a, int n = 0)
            {
                if (n < a.Length)
                {
                    a[n] = (n % 2 == 1) ? SetToZero(a[n]) : SwapNumber(a[n]);
                    DoingSomthingIDK(a, n + 1);
                }
            }
            static int SetToZero(int x)
            {
                return x % 1;
            }
            static int SwapNumber(int x)
            {
                int r = 0;
                while (x > 0)
                {
                    r = x % 10 + 10 * r;
                    x /= 10;
                }
                return r;
            }
        }

    }
}
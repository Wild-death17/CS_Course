namespace _4LS
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Console.Write("Enter a Number : ");
            // int ans = int.Parse(Console.ReadLine());
            // int cnt = 0;
            // do
            // {
            //     cnt += ans % 10;
            //     ans = ans / 10;
            // } while (ans != 0);
            // Console.WriteLine(cnt);

            // static int sumOfDigit(int x)
            // {
            //     int cnt = 0;
            //     do
            //     {
            //         cnt += x % 10;
            //         x = x / 10;
            //     } while (x != 0);
            //     return cnt;
            // }

            /*
            int[] arr = { 14, 105, 24, 12, 13, 15, 68, 32, 51, 43 };
            int k = BiggestOfArrey(arr);
            Console.WriteLine(k);

            static int BiggestOfArrey(int[] x)
            {
                int y = x[0];
                 for(int i = 0; i < x.Length ; i++)
                {
                    y = (y > x[i])  ? y : x[i];
                }
                return y;
            }*/

            /*
            static int sumOfBiggestDigitOfArrey(int[] x) {
                int NumBgstSum = x[0];
                int gstSum = 0;
                for (int i = 0; i < x.Length; i++)
                {
                    int num = x[i];
                    int Sum = 0;
                    while (num != 0)
                    {
                        Sum += k % 10;
                        num = num / 10;
                    }
                    if (gstSum < Sum)
                    {
                        BgstSum = Sum;
                        NumBgstSum = x[i];
                    }
                }
                return NumBgstSum;
            }*/

            /*
            static int DigitsByString(int y)
            {
                int sum = 0;
                string num = y.ToString();
                foreach (char i in num)
                {
                    sum += i - '0';
                    // ASCII מוריד את ערך טבלת ה
                    // ומשנה אותו מתו לערך מספר אמיתי
                }
                return sum;  
            }*/
        }
    }
}
namespace _6LS
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /* class Parabula
            {
                private int a;
                private int b;
                private int c;
                public void parabula(int a, int b, int c)
                {

                }}
            */
            /*  
               string[] strrey = new string[4];
              strrey[0] = "abcydef";
              strrey[1] = "abcdeya";
              strrey[2] = "abcdeyda";
              strrey[3] = "abcededya";

              System.Console.WriteLine(/*sameEdgesAndCharyInStrrey(strrey));
             */
            /*
             static int sameEdgesAndCharyInStrrey(string[] str)
             {
                int cnt = 0;
                foreach (var i in str)
                {
                    if (i[0] == i[(i.Length - 1)] && i.IndexOf('y') != -1)
                    {
                        cnt++;
                    }
                }
                return cnt;
             }
            */

            /*
             static int sameEdgesAndCharyInStrrey2(string[] str)
              {
                int cnt = 0;
                foreach (var i in str)
                {
                    if (sameEdgesAndisTherey(i))
                    {
                        cnt++;
                    }
                }
                return cnt;
             }
             static bool sameEdgesAndisTherey(string str)
              {
                if (str[0] == str[(str.Length - 1)] && str.IndexOf('y') != -1)
                    return true;
                return false;
             }
            */

            /*
             static int sameEdgesAndCharyInStrrey(string[] str)
             {
                int cnt = 0;
                foreach (var i in str)
                {
                    if (sameEdges(i) && isTherey(i))
                    {
                        cnt++;
                    }
                }
                return cnt;
             }
             static bool sameEdges(string str)
             {
                if (str[0] == str[(str.Length - 1)])
                    return true;
                return false;
             }

             static bool isTherey(string str)
             {
                if (str.IndexOf('y') != -1)
                    return true;
                return false;
             }
            */

            /*
              string str = "abcdefghighg";
              System.Console.WriteLine(biggestTavInString(str));
              static char biggestTavInString(string str)
              {
                  int Bigst = 0, Current = 0;
                  char BestTav = '0';
                  foreach (var i in str)
                  {
                      Current = AmountOfCharinString(str, i);
                      if (Bigst < Current)
                      {
                          Bigst = Current;
                          // למצוא את הגדול ביותר
                          BestTav = i;
                      }
                  }
                  return BestTav;
              }
              static int AmountOfCharinString(string a, char b)
              {
                  int cnt = 0;
                  foreach (var k in a)
                  {
                      if (k == b)
                          cnt++;
                  }
                  return cnt;
              }
            */
            System.Console.ReadKey();



        }
    }
}
            /* 
            var in c# is a multitype variable
            first type that is assigned to the var is the type of the variable
            the type can NOT be reassigned to a different type  
            and can not be redeclaired
            (lazy programer variable for not assigning a specific type)
            */
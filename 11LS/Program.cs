namespace _11LS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student St1 = new Student("Moshe", "Choen", 55, 80);
            Student St2 = new Student("Niki", "Kazakevich");
            Student St3 = new Student("Choice", "Cohen", 0, 36);
            Student[] Students = new Student[] { St1, St2, St3 };
            string[] strings = { "sirBogy", "length", "enter", "zoo", "tom Hardy", "incel", "nati", "hello", "cSharp", "Sintext" };
            Console.WriteLine(sod(strings, strings.Length - 1));
            static string sod(string[] s, int n)
            {
                string x = s[n][0].ToString();
                if (n == 0)
                    return x;
                return x + sod(s, n - 1);
            }
            //--------------------------------
            if (St1.GetCS() > St2.GetCS())
            {
                if (St1.GetCS() > St3.GetCS())
                {
                    Console.WriteLine(St1.GetName);
                }
                else
                {
                    Console.WriteLine(St3.GetName);
                }
            }
            else
            {
                if (St2.GetCS() > St3.GetCS())
                {
                    Console.WriteLine(St2.GetName);
                }
                else
                {
                    Console.WriteLine(St3.GetName);
                }
            }
            //-------------------------------------
            Student Biggest = Students[0];
            for (int i = 1; i < Students.Length; i++)
            {
                Biggest = (Biggest.GetCS() < Students[i].GetCS()) ? Students[i] : Biggest;
                //--Flawd-Bcs-ReAssign-Biggest-Every-Time---
            }
            Console.WriteLine($"{Biggest.GetName()} Is The Best At CSarp");
            //------Same-Thing-Better-Method--\/-----------
            Student Biggest1 = Students[0];
            for (int i = 1; i < Students.Length; i++)
            {
                if (Biggest1.GetCS() < Students[i].GetCS())
                {
                    Biggest1 = Students[i];
                }
            }
            Console.WriteLine($"{Biggest1.GetName()} Is The Best At CSarp");
            //----------------------------------------
            static string FindBiggestName(Student[] Stdnts)
            {
                Student Biggest = Stdnts[0];
                for (int i = 1; i < Stdnts.Length; i++)
                {
                    if (Biggest.GetCS() < Stdnts[i].GetCS())
                    {
                        Biggest = Stdnts[i];
                    }
                }
                return Biggest.GetName();
            }
        }
    }
}
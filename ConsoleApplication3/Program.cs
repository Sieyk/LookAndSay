using System;
using System.IO;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            String s = "1";
            System.IO.StreamWriter file = new System.IO.StreamWriter(Directory.GetCurrentDirectory()+"Output.txt");
            Boolean threeCheck = false;
            Boolean twoCheck = false;
            file.WriteLine(s);
            //System.IO.File.WriteAllText(@"C:\Users\Sieyk\Documents\output.txt", s);
            //Console.Out.WriteLine(s);
            for (int i = 0; i < 1000; i++)
            {
                char[] n = s.ToCharArray();
                String nn = "";
                for (int num = 0; num < n.Length; num++)
                {
                    threeCheck = false;
                    twoCheck = false;
                    if (num + 2 < n.Length)
                        if (n[num] == n[num + 1] && n[num + 1] == n[num + 2])
                            threeCheck = true;
                    if (num + 1 < n.Length)
                        if (n[num] == n[num + 1])
                            twoCheck = true;
                    if (threeCheck)
                    {
                        nn += "3" + n[num];
                        num += 2;
                        continue;
                    }
                    else if (twoCheck)
                    {
                        nn += "2" + n[num];
                        num += 1;
                        continue;
                    }
                    else
                    {
                        nn += "1" + n[num];
                        continue;
                    }
                }
                s = nn;
                file.WriteLine("\n");
                file.WriteLine(s);
                //System.IO.File.AppendAllText(@"C:\Users\Sieyk\Documents\output.txt", "\n" + s);
                //Console.Out.WriteLine();
                //Console.Out.WriteLine(s);
            }
            file.Close();
            Console.Read();
        }
    }
}

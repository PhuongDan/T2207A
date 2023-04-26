using System.Collections.Generic;
using T2207A;
using T2207A_VSCode;

public class Program
{
    public static void Main(String[] args)




    {
        Thread t = new Thread(DemoRun);
        t.IsBackground = true;
        t.Start("Hello");
    }
    static void DemoRun(object o)
    {
        string s = (string)o;
        for (int i = 0; i < 20; i++)
        {
            Console.WriteLine(s+"i=" + i);
            try
            {
                Thread.Sleep(1000);
            }
            catch (Exception e) { }
        }
    }

    static void DemoRun(object o)
    {
        string s = (string)o;
        for (int i = 0; i < 200; i++)
        {
            lock(o)
            {
                Console.WriteLine(s + "i=" + i);
            }
            try
            {
                Thread.Sleep(1000);
            }
            catch (Exception e) { }
        }
    }
}
      


  
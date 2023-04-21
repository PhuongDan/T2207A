using System.Collections.Generic;
using T2207A;
using T2207A_VSCode;

public class Program
{
    public static void Main(String[] args)




    {
        int x = 10;
        Console.WriteLine(x);   //print
        String s = "T2207A";
        double pi = 3.14259;
        if (x > 5)
        {
            x--;
        }
        else
        {
            x++;
        }
        int[] arr = new int[5];
        arr[0] = 1;
        arr[1] = 15;
        arr[2] = 9;
        arr[3] = 55;
        arr[4] = -16;


        foreach (int i in arr)
        {
            Console.WriteLine(i);
        }
        string cmd = Console.ReadLine();
        Console.WriteLine("Chuoi vua nhap" + cmd);
        string cmd2 = Console.ReadLine();
        int n = Convert.ToInt32(cmd2);
        Console.WriteLine("So vua nhap" + cmd2);
        if (isPrimed(n))
        {
            Console.WriteLine(n + " la so nguyen to");
        }

        List<int> ints = new List<int>();
        ints.Add(4);
        ints.Add(8);

        Student st = new Student();
        st.Run();
        st.Learn();
        st.Learn();
        st.Learn("ABC");
        Console.WriteLine(st.name);
        st.name = "Pham Van Nghia";


        Human h = new Human();
        Human h2 = new Human() { Telephone = "34236535" };

        h.family[0] = "Dinhphuongdan";
        Console.WriteLine(h.family[0]);
        h2[0] = "dan";

        List<string> strs = new List<string>();
        strs.Add("Hello");
        Console.WriteLine(strs[0]);

        //  Car c = new Car(); trong c# khong co abstract class

        PhoneBook phoneBook = new PhoneBook();


    }



    public static bool isPrimed(int n)
    {
        if (n < 2) return false;
        if (n < 4) return true;
        for (int i = 2; i <= n / 2; i++)
        {
            if (n % i == 0) return false;
        }
        return true;
    }
}
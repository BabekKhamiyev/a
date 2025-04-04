using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11;

internal static class ExtentionMethods
{
    public static bool IsOdd(int num)
    {
        bool tekdir=false;
        if (!(num%2==0))
            tekdir=true;
        return tekdir;
    }


    public static bool IsEven(int num)
    {
        bool cutdur = false;
        if (num % 2 == 0)
            cutdur = true;
        return cutdur;
    }

    public static string ToCapitalize(string soz)
    {
        string sozz = " ";
        foreach (char c in soz)
        {
            sozz += c.ToString().ToUpper();
        }
        return sozz;
    }
    public static int[] GetValueIndexes(char a, string b)
    {
        int[] ints = new int[0];
        
        for (int i = 0;i<b.Length;i++)
        {
            if (a== b[i])
            {
                Array.Resize(ref ints , ints.Length+1);
                ints[^1] = i;
            }
        }
        return ints;
    }

    public static bool CustomContains(string soz, string cumle)
    {
       bool var=false;
        string[] a=new string[0];
        string sozz = "";
        for (int i = 0; i < cumle.Length; i++)
        {
            if (cumle[i] == ' ')
            {
                Array.Resize(ref a , a.Length+1);
                a[^1] = sozz;
                sozz = "";
            }
            sozz += cumle[i];
        }

        foreach (string s in a)
        {
            if (s == soz)
            {
                var = true;
            }
        }
        
        
        return var; 
    }


}

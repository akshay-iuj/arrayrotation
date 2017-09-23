using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayLeftRoataion
{
    class Program
    {
        //static void Main(string[] args)
        //{
        //    string[] tokens_n = Console.ReadLine().Split(' ');
        //    int n = Convert.ToInt32(tokens_n[0]);
        //    int k = Convert.ToInt32(tokens_n[1]);
        //    string[] a_temp = Console.ReadLine().Split(' ');
        //    int[] a = Array.ConvertAll(a_temp, Int32.Parse);
        //    int seriesstarter = 0;
        //    seriesstarter = (n - 1) <= k ? k : k % n;
        //    for (int i = 0; i < a.Length; i++)
        //    {
        //        if (seriesstarter <= n - 1)
        //            Console.Write(a[seriesstarter++] + " ");
        //        else
        //        {
        //            seriesstarter = 0;
        //            Console.Write(a[seriesstarter++] + " ");
        //        }

        //    }
        //    Console.ReadKey();
        //}

        //static void Main(string[] args)
        //{
        //    var arr = oddNumbers(2, 5);
        //}

        //static int[] oddNumbers(int l, int r)
        //{
        //    int[] arr = new int[((r - l) / 2)+1];
        //    int c = 0;
        //    for (int i = l + 1; i <= r; i++)
        //    {
        //        if (i % 2 != 0)
        //        {
        //            arr[c] = i;
        //            c++;
        //        }

        //    }
        //    return arr;
        //}


        static void Main(String[] args)
        {
            int t = Convert.ToInt32(Console.ReadLine());
            string[] total = new string[t];
            for (int a0 = 0; a0 < t; a0++)
            {
               string expression = Console.ReadLine();
                total[a0] = expression;
            }
            for (int i = 0; i < t; i++)
            {
               if(total[i].Length%2!=0)
                {
                    Console.WriteLine("NO");
                }
                else
                {
                    var a = total[i].Substring(0, (total[i].Length) / 2);
                    var b= total[i].Substring((total[i].Length) / 2, (total[i].Length) / 2);
                    int c = 0;
                    for (int j = 0,k= (total[i].Length-1) / 2; j < (total[i].Length)/2; j++,k--)
                    {
                        if (indetical(a[j]) == b[k])
                        {
                            c++;
                        }
                       
                    }
                    if (c == (total[i].Length ) / 2)
                    {
                        Console.WriteLine("YES");
                    }
                    else
                    {
                        Console.WriteLine("NO");
                    }

                }
            }
            Console.ReadKey();

           
        }

        public static char indetical(char character)
        {
            switch (character)
            {
                case '{':
                        return '}';
                   
                case '[':
                    return ']';
                  
                case '(':
                    return ')';
                   
                default:
                    break;
                    
            }
            return ' ';           
        }

    }
}

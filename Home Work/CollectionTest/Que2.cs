using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Home_Work.CollectionTest
{
    internal class Que2
    {
        static void Main(string[] args)
        {
            string n = "THE SKY IS THE LIMIT";
            string[] a = n.Split(" ");
            int[] arr=new int[a.Length];
            string[] arr2 = new string[a.Length];
            
            int sum = 0;
            for (int i = 0; i < a.Length; i++)
            {
                string n1 = a[i];
                for (int i1 = 0; i1 < n1.Length; i1++)
                {
                    int c = 0;
                    for (char j = 'A'; j <= 'Z'; j++)
                    {
                        if (n1[i1] == j)
                        {
                            c++;
                            sum += c;
                            break;
                        }
                        else
                            c++;
                    }
                    if (i1 == n1.Length - 1)
                    {
                        arr[i] = sum;
                        arr2[i] = n1 + " " + sum;
                        sum = 0;
                    }
                }
            }
            Array.Sort(arr);
            for(int i = 0; i < arr.Length; i++)
            {
                for(int j = 0; j < arr2.Length; j++)
                {
                    string[] ne = arr2[j].Split();
                    int con=Convert.ToInt32(ne[1]);
                    if(con==arr[i])
                    {
                        Console.Write(ne[0]+" ");
                        break;
                    }
                }
            }
        }
    }
}

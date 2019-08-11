using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Solution
{

    // Complete the rotLeft function below.
    static int[] rotLeft(int[] a, int d)
    {
        // modulo nya saja 
        int len = a.Length;
        int mod = d % len;
        int selisih = len - mod;
        

        // geser sebanyak ini


        // kalau geser ke kiri lebih cepat 
        if (selisih > mod)
        {
            
            //geser sebanyak k;
            int k = 5;
            if (mod - k <= 0)
            {
                int[] temp = null;
                for (int i = 0; i < mod; i += k)
                {
                    temp = new int[len];
                    // ambil nilai paling kiri taruh di temp
                    int[] val = new int[k];
                    for (int y = 0; y < k; y++)
                    {
                        val[y] = a[y];
                        temp[len - k + y] = val[y];
                    }

                    // geser semua nilai ke kiri taruh di temp
                    for (int x = 0; x < len - k; x++)
                    {
                        temp[x] = a[x + k];
                    }

                    a = temp;
                }
                return a;
                
            //}
            //else {
            //    int[] temp = null;
            //    for (int i = 0; i < mod; i++)
            //    {
            //        temp = new int[len];
            //        // ambil nilai paling kiri taruh di temp
            //        int val = a[0];
            //        temp[len - 1] = val;

            //        // geser semua nilai ke kiri taruh di temp
            //        for (int x = 0; x < len - 1; x++)
            //        {
            //            temp[x] = a[x + 1];
            //        }

            //        a = temp;
            //    }
            //    return a;
            //}
        }
        // geser kanan kalau lebih cepat
        else
        {
            int lonc2 = selisih % 2;
            if (lonc2 == 0)
            {
                int[] temp = null;
                for (int i = 0; i < selisih; i+=2)
                {
                    temp = new int[len];
                    // ambil nilai paling kanan taruh di temp
                    int val = a[len - 1];
                    temp[1] = val;
                    int val1 = a[len - 2];
                    temp[0] = val1;

                    // ambil nilai a kanan taruh di temp
                    for (int x = 0; x < len - 2; x++)
                    {
                        temp[x + 2] = a[x];
                    }

                    a = temp;
                }

                return a;
            }
            else
            {
                int[] temp = null;
                for (int i = 0; i < selisih; i++)
                {
                    temp = new int[len];
                    // ambil nilai paling kanan taruh di temp
                    int val = a[len - 1];
                    temp[0] = val;

                    // ambil nilai a kanan taruh di temp
                    for (int x = 0; x < len - 1; x++)
                    {
                        temp[x + 1] = a[x];
                    }

                    a = temp;
                }

                return a;
            }
        }

    }

    static void Main(string[] args)
    {
        
        string[] nd = Console.ReadLine().Split(' ');

        int n = Convert.ToInt32(nd[0]);

        int d = Convert.ToInt32(nd[1]);

        int[] a = Array.ConvertAll(Console.ReadLine().Split(' '), aTemp => Convert.ToInt32(aTemp))
        ;
        int[] result = rotLeft(a, d);

        System.Diagnostics.Debug.WriteLine("Result : "+ result);

    }
}

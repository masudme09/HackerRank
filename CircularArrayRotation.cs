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

namespace CircularArrayRotation
{
  class Result
  {

    /*
     * Complete the 'circularArrayRotation' function below.
     *
     * The function is expected to return an INTEGER_ARRAY.
     * The function accepts following parameters:
     *  1. INTEGER_ARRAY a
     *  2. INTEGER k
     *  3. INTEGER_ARRAY queries
     */

    public static List<int> circularArrayRotation(List<int> a, int k, List<int> queries)
    {
      List<int> result = new();
      int length = a.Count();
      int[] resArr = new int[length];
      List<int> rotatedArray = new();
      for (int i = 0; i < length; i++)
      {
        if (i + k < length)
          resArr[i + k] = a[i];
        else
        {
          var pos = (i + k) % length;
          resArr[pos] = a[i];
        }
      }
      foreach (int position in queries)
        result.Add(resArr[position]);

      return result;
    }



    public static void run()
    {
      List<int> alice_score = new List<int>(){
        17, 28, 30
      };
      List<int> queries = new List<int>();
      queries.Add(2);
      queries.Add(1);

      List<int> result = circularArrayRotation(alice_score, 1, queries);

      Console.WriteLine(string.Join(",", result));
    }
  }


}

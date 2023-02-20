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

namespace PlusMinus
{
  class Result
  {

    /*
     * Complete the 'plusMinus' function below.
     *
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static void plusMinus(List<int> arr)
    {
      float positive_count = 0;
      float negative_count = 0;
      float zero_count = 0;
      // count the element
      float count = arr.Count;

      for (int i = 0; i < count; i++)
      {
        // get count of positive elements
        switch (arr[i])
        {
          case > 0:
            positive_count++;
            break;
          // get count of negative elements
          case < 0:
            negative_count++;
            break;
          // get count of zero elements
          default:
            zero_count++;
            break;
        }
      }


      // calculate ratio and report it
      switch (count)
      {
        case 0:
          System.Console.WriteLine("{0:N6}", 0);
          System.Console.WriteLine("{0:N6}", 0);
          System.Console.WriteLine("{0:N6}", 0);
          break;
        default:
          System.Console.WriteLine($"{positive_count / count:N6}");
          System.Console.WriteLine($"{negative_count / count:N6}");
          System.Console.WriteLine($"{zero_count / count:N6}");
          break;
      }

    }



    public static void run()
    {
      List<int> n = new List<int>() { -100, 28, 30, 0, -3, 0, 4, 6, -9, 100 };
      // List<int> n = new List<int>() { };

      Result.plusMinus(n);
    }
  }


}

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

namespace MiniMax
{
  class Result
  {

    /*
      * Complete the 'miniMaxSum' function below.
      *
      * The function accepts INTEGER_ARRAY arr as parameter.
      */

    public static void miniMaxSum(List<int> arr)
    {
      int min_number = arr.Min();
      int max_number = arr.Max();
      double maxSum = 0;
      double minSum = 0;

      foreach (int el in arr)
      {
        if (el == min_number && el == max_number)
        {
          minSum = el * 4;
          maxSum = el * 4;
          break;
        }
        else if (el == min_number)
        {
          minSum = minSum + el;

        }
        else if (el == max_number)
        {
          maxSum = maxSum + el;
        }
        else
        {
          minSum = minSum + el;
          maxSum = maxSum + el;
        }
      }

      Console.WriteLine($"{minSum} {maxSum}");
    }

    public static void run()
    {
      List<int> n = new List<int>() { 396285104, 573261094, 759641832, 819230764, 364801279 };
      // 5 5 5 5 5
      // List<int> n = new List<int>() { };
      // List<int> n = new List<int>() { 5, 5, 5, 5, 5 };


      Result.miniMaxSum(n);
    }

  }



}
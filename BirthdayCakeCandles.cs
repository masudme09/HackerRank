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

namespace BirthDayCakeCandles
{
  class Result
  {

    /*
    * Complete the 'birthdayCakeCandles' function below.
    *
    * The function is expected to return an INTEGER.
    * The function accepts INTEGER_ARRAY candles as parameter.
    */
    public static int birthdayCakeCandles(List<int> candles)
    {
      int max = candles.Max();
      int count = candles.Where(e => e == max).Count();

      return count;
    }

    public static void run()
    {
      List<int> n = new List<int>() { 4, 4, 2, 3 };

      Console.WriteLine(Result.birthdayCakeCandles(n));
    }

  }



}
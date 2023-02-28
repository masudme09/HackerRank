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

namespace CountAppleAndOranges
{
  class Result
  {

    /*
     * Complete the 'countApplesAndOranges' function below.
     *
     * The function accepts following parameters:
     *  1. INTEGER s
     *  2. INTEGER t
     *  3. INTEGER a
     *  4. INTEGER b
     *  5. INTEGER_ARRAY apples
     *  6. INTEGER_ARRAY oranges
     */

    public static void countApplesAndOranges(int range_apple_side, int range_orange_side,
    int apple_pos, int orange_pos, List<int> apples_dist_relative, List<int> oranges_dist_relative)
    {

      int temp_pos, apple_count = 0, orrange_count = 0;
      foreach (int dist in apples_dist_relative)
      {
        temp_pos = apple_pos + dist;
        if (temp_pos >= range_apple_side && temp_pos <= range_orange_side)
        {
          apple_count++;
        }
      }

      foreach (int dist in oranges_dist_relative)
      {
        temp_pos = orange_pos + dist;
        if (temp_pos >= range_apple_side && temp_pos <= range_orange_side)
        {
          orrange_count++;
        }
      }

      Console.WriteLine(apple_count);
      Console.WriteLine(orrange_count);

    }

    public static void run()
    {
      int s = 7, t = 11, a = 5, b = 15;
      List<int> apples_dist = new List<int>() { -2, 2, 1 };
      List<int> oranges_dist = new List<int>() { 5, -6 };

      Result.countApplesAndOranges(s, t, a, b, apples_dist, oranges_dist);
    }
  }


}

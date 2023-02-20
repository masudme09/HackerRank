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

namespace CompareTriplets
{
  class Result
  {

    /*
     * Complete the 'compareTriplets' function below.
     *
     * The function is expected to return an INTEGER_ARRAY.
     * The function accepts following parameters:
     *  1. INTEGER_ARRAY a
     *  2. INTEGER_ARRAY b
     */

    public static List<int> compareTriplets(List<int> a, List<int> b)
    {

      // declare score variable
      int alice = 0;
      int bob = 0;

      // index
      int index = 0;

      // result
      List<int> result = new List<int>();

      // loop through alice and update score
      a.ForEach(delegate (int el)
      {
        index = a.FindIndex(0, 3, x => x == el);
        if (el > b[index])
        {
          alice++;
        }
        else if (b[index] > el)
        {
          bob++;
        }
      });

      result.Add(alice);
      result.Add(bob);

      return result;
    }



    public static void run()
    {

      List<int> bob_score = new List<int>();
      List<int> alice_score = new List<int>();
      int[] alice_scores = { 17, 28, 30 };
      int[] bob_scores = { 99, 16, 8 };

      foreach (int ite in alice_scores)
      {
        alice_score.Add(ite);
      }

      foreach (int ite in bob_scores)
      {
        bob_score.Add(ite);

      }

      List<int> result = CompareTriplets.Result.compareTriplets(alice_score, bob_score);

      Console.WriteLine("Alice Scores: " + string.Join(",", alice_score));
      Console.WriteLine("Bob Scores: " + string.Join(",", bob_score));


      Console.WriteLine(string.Join(",", result));
    }
  }


}

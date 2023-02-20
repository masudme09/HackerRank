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

namespace DiagonalDifference
{
  class Result
  {

    /*
     * Complete the 'diagonalDifference' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts 2D_INTEGER_ARRAY arr as parameter.
     */

    public static int diagonalDifference(List<List<int>> arr)
    {
      return Math.Abs(difference(arr));
    }

    public static int difference(List<List<int>> arr)
    {
      List<int> leftDiagonal_elements = new List<int>();
      List<int> rightDiagonal_elements = new List<int>();

      int j = arr.Count() - 1;

      for (int i = 0; i < arr.Count(); i++)
      {
        leftDiagonal_elements.Add(arr[i][i]);
        rightDiagonal_elements.Add(arr[i][j]);
        j--;
      }
      return leftDiagonal_elements.Sum() - rightDiagonal_elements.Sum();
    }

    public static void run()
    {

      List<int> first_row = new List<int>()
      {
        1, 2, 3
      };
      List<int> second_row = new List<int>(){
        4, 5, 6
      };
      List<int> third_row = new List<int>(){
        9, 8, 9
      };

      List<List<int>> input = new List<List<int>>(){
        first_row,
        second_row,
        third_row
      };

      int result = diagonalDifference(input);

      Console.WriteLine("Result: " + result);
    }

  }



}
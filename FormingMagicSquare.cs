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

namespace FormingMagicSquare
{
  class Result
  {

    /*
    * Complete the 'formingMagicSquare' function below.
    *
    * The function is expected to return an INTEGER.
    * The function accepts 2D_INTEGER_ARRAY s as parameter.

    * The rules (3 x 3)
    * The magic constant is 15
    * A magic square always has the number 5 at the very center of it
    * Even numbers should be on the corners.
    * Odd numbers are on the edges.
    * Thanks: https://luillyfe.medium.com/forming-magic-squares-8e526b45c8db
    */

    public static int formingMagicSquare(List<List<int>> s)
    {
      List<List<List<int>>> all_magic_squares = new List<List<List<int>>>();
      all_magic_squares = generate_all_magic_squares();
      int cost = 0;

      foreach (List<List<int>> magic in all_magic_squares)
      {
        // int temp_cost = calculate_cost(s, magic);
        // if (temp_cost < cost)
        // {
        //   cost = temp_cost;
        // }
      }

      return cost;

    }

    private static List<List<List<int>>> generate_all_magic_squares()
    {
      int magic_constant = get_magic_constant(3);
      List<List<int>> corner_candidates = gen_permutations(new List<int> { 2, 4, 6, 8 });
      List<List<List<int>>> squares = new List<List<List<int>>>();

      // get permutations of corner canditates
      // take each permutation and fill it up to form magic_square
      // return all of the square that follow rules

      foreach (List<int> candidate in corner_candidates)
      {
        List<List<int>> square = new List<List<int>>();
        square[1][1] = 5;
        square[0][0] = candidate[0];
        square[0][2] = candidate[1];
        square[2][0] = candidate[2];
        square[2][2] = candidate[2];


        square[0][1] = magic_constant - (square[0][0] + square[0][2]);
        square[1][0] = magic_constant - (square[0][0] + square[2][0]);
        square[1][2] = magic_constant - (square[0][2] + square[2][2]);
        square[2][1] = magic_constant - (square[2][0] + square[2][2]);

        squares.Add(square);
      }

      // remove squares that are not magic
      return squares;

    }

    // private static int calculate_cost(List<List<int>> original_array, List<List<int>> magic_array)
    // {

    // }

    public static List<List<int>> gen_permutations(List<int> numbers)
    {
      List<List<int>> result = new List<List<int>>();
      permute(numbers, 0, result);
      return result;
    }

    private static void permute(List<int> numbers, int startIndex, List<List<int>> result)
    {
      if (startIndex == numbers.Count)
      {
        result.Add(new List<int>(numbers));
        return;
      }

      for (int i = startIndex; i < numbers.Count; i++)
      {
        // Swap the current number with the number at startIndex
        int temp = numbers[startIndex];
        numbers[startIndex] = numbers[i];
        numbers[i] = temp;

        // Recursively permute the remaining numbers
        permute(numbers, startIndex + 1, result);

        // Swap the numbers back to their original positions
        temp = numbers[startIndex];
        numbers[startIndex] = numbers[i];
        numbers[i] = temp;
      }
    }

    // we are interested about integer division only
    private static int get_magic_constant(int arr_length)
    {
      return arr_length * (arr_length * arr_length + 1) / 2;
    }

    public static void run()
    {
      List<int> n = new List<int>() { -100, 28, 30, 0, -3, 0, 4, 6, -9, 100 };
      // List<int> n = new List<int>() { };

    }
  }

}

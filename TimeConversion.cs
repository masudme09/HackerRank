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

namespace TimeConversion
{
  class Result
  {

    /*
     * Complete the 'timeConversion' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts STRING s as parameter.
     */

    public static string timeConversion(string s)
    {
      string[] times = s.Split(':');
      int first_part = Int32.Parse(times[0]);
      int second_part = Int32.Parse(times[1]);
      int third_part = Int32.Parse(times[2].Remove(2, 2));
      string day_night_info = times[2].Remove(0, 2);
      string result = "";

      switch (day_night_info)
      {
        case "AM":
          if (first_part == 12)
          {
            result = $"{"00"}:{times[1]}:{times[2].Remove(2, 2)}";
          }
          else
          {
            result = $"{times[0]}:{times[1]}:{times[2].Remove(2, 2)}";
          }
          break;
        case "PM":
          if (first_part == 12)
          {
            result = $"{times[0]}:{times[1]}:{times[2].Remove(2, 2)}";
          }
          else
          {
            string first_part_up = (first_part + 12).ToString("D2");
            result = $"{first_part_up}:{times[1]}:{times[2].Remove(2, 2)}";
          }
          break;
        default:
          break;
      }

      return result;
    }

    public static void run()
    {
      string n = "10:55:45PM";

      Console.WriteLine(Result.timeConversion(n));
    }

  }
}
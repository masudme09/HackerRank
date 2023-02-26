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

namespace GradingStudents
{
  class Result
  {

    /*
     * Complete the 'gradingStudents' function below.
     *
     * The function is expected to return an INTEGER_ARRAY.
     * The function accepts INTEGER_ARRAY grades as parameter.
     */

    public static List<int> gradingStudents(List<int> grades)
    {

      List<int> updated_grades = new List<int>();

      // loop through all the grades
      // check the grade fall near the next grade
      // if yes then update and else add original one

      // less than 38 then no rounding
      // (grade + 0, 1 or 2 ) divisible by 5? then update with that

      foreach (int grade in grades)
      {
        if (grade < 38)
        {
          updated_grades.Add(grade);
        }
        else
        {
          int rem2, rem3;
          Math.DivRem(grade + 1, 5, out rem2);
          Math.DivRem(grade + 2, 5, out rem3);

          if (rem2 == 0)
          {
            updated_grades.Add(grade + 1);

          }
          else if (rem3 == 0)
          {
            updated_grades.Add(grade + 2);

          }
          else
          {
            updated_grades.Add(grade);

          }

        }
      }

      return updated_grades;

    }



    public static void run()
    {
      List<int> n = new List<int>() { 73, 67, 38, 33 };

      Result.gradingStudents(n).ForEach(Console.WriteLine);
    }
  }


}

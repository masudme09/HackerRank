namespace InputOutput
{
  class Result
  {
    public static void main()
    {
      int a = Int32.Parse(Console.ReadLine());
      string[] bc = Console.ReadLine().Split(" ");
      string end = Console.ReadLine();
      int b, c;
      b = Int32.Parse(bc[0]);
      c = Int32.Parse(bc[1]);

      int sum = a + b + c;
      Console.WriteLine($"{end} {sum}");
    }

  }
}
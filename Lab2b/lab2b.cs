using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine ("Enter a number:");
    int first = Int32.Parse(Console.ReadLine());
    Console.WriteLine("Enter a second number:");
    int second = Int32.Parse(Console.ReadLine());

    int sum = first + second;
    int difference = first - second;
    int product = first * second;
    int quotient = first / second;
    int remainder = first % second;

    Console.WriteLine("Sum = " + sum);
    Console.WriteLine("Diff = " + difference);
    Console.WriteLine("Product = " + product);
    Console.WriteLine("Quotient = " + quotient);
    Console.WriteLine("Remainder = " + remainder);
  }
}
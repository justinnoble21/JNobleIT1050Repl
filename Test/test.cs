using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine ("What is your name?");
    string input = Console.ReadLine();
    respond(input);
  
  }

  public static void respond(string input) {
    if (input == " ") 
    {
      write("That's blank!");
      return;
    }


    char c = char.ToUpper(input[0]);

    string name = c + input.Substring(1);

    write($"Oh, I see! {name}... Nice name!");
  }

  public static void write(string input) {
    Console.WriteLine(input);
  }

}

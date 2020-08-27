using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine ("What is your name?");
  }

  public void respond(string input) {
    if (input == " ") 
    {
      write("That's blank!");
      return;
    }

    string name = char.ToUpper(input[0]) + name.Substring(1);

    write($"Oh, I see! {name}... Nice name!");
  }

  public void write(string input) {
    Console.WriteLine(input);
  }

}
using System;

class Program  {
  
  public static void Main (string[] args) {
// Declare the text String
    String Twitter = "Platea dictumst quisque sagittis purus sit amet volutpat consequat mauris.";
// Create the if/else Statement
    if (Twitter.Length <= 140){
    Console.WriteLine("Posted");}
    
    else if (Twitter.Length > 140){
    Console.WriteLine("Rejected");}
  }
}
using System;

class Program {
  public static void Main (string[] args) {
    Console.WriteLine ("Hello World");
    Faculty f1 = new Faculty("Tony", "Murray");
    f1.School = "Tri-C";
    f1.DateOfEmployment = Convert.ToDateTime("11/11/2016");
    f1.GrantTenure();
    f1.Intro();
    
  }
}
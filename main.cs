using System;

class Program {
  public static void Main (string[] args) {
    Console.WriteLine ("Hello World");
    Faculty f1 = new Faculty("Tony", "Murray");
    f1.School = "Tri-C";
    f1.DateOfEmployment = Convert.ToDateTime("11/11/2000");
    Console.WriteLine("Tenure status: "+ f1.Tenured);
    Console.WriteLine("I will now attempt to grant Tenure status.");
    f1.GrantTenure();
    Console.WriteLine("New Tenure status: "+ f1.Tenured);
    f1.Intro();
    f1.Promote();
    f1.Intro();
    f1.Promote();
    f1.Intro();
    f1.Promote();
    f1.Intro();
    Console.WriteLine("New faculty:");
    Faculty f2 = new Faculty("Sarah", "Marshall");
    f2.School = "OSU";
    f2.DateOfEmployment = Convert.ToDateTime("11/25/2016");
    f2.Intro();
    Console.WriteLine("Tenure status: "+ f2.Tenured);
    Console.WriteLine("I will now attempt to grant Tenure status.");
    f2.GrantTenure();
    Console.WriteLine("New Tenure status: "+ f2.Tenured);
  }
}
using System;

class Faculty : Person
{
  private string Id{get;set;}
  private string Title{get;set;}
  public DateTime DateOfEmployment{get;set;}
  private double YearlySalary{get;set;}
  private bool Tenured{get;set;}
  public Faculty()
  {
    Title = "Instructor";
  }
  public Faculty(string fname, string lname)
  {
    FirstName=fname;
    LastName=lname;
    Title="Instructor";
  }
  public void GrantTenure()
  {
    if (DateOfEmployment.AddYears(5)<= DateTime.Today)
      Tenured = true;
    else
      Tenured = false;
  }
  public void Promote()
  {
    
  }
  public override void Intro()
  {
    base.Intro();
    Console.WriteLine("I am Tenured:"+ Tenured);
  }
}
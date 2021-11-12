using System;

class Faculty : Person
{
  private string Id{get;set;}
  public string Title{get;set;}
  public DateTime DateOfEmployment{get;set;}
  public double YearlySalary{get;set;}
  public string School{get;set;}
  public bool Tenured{get;set;}
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
    if (Title == "Instructor" && DateOfEmployment.AddYears(2)<=DateTime.Today)
    {
      Title = "Assistant Professor";
      Console.WriteLine("Faculty promoted to Assistant Professor rank.");
    }
    else if (Title == "Assistant Professor"&& DateOfEmployment.AddYears(5)<=DateTime.Today)
      {
      Title = "Associate Professor";
      Console.WriteLine("Faculty has been promoted to Associate Professor rank.");
      }
    else if (Title == "Associate Professor"&& DateOfEmployment.AddYears(10)<=DateTime.Today)
    {
      Title = "Professor";
      Console.WriteLine("Faculty promoted to Professor rank.");
    }
    else if (Title == "Professor")
      Console.WriteLine("No more promotion possible");
    else 
      Console.WriteLine("Not Eligible for promotion.");
  }
  public override void Intro()
  {
    base.Intro();
    Console.WriteLine("I work as a "+ Title+ " at "+School+", and have been here since "+DateOfEmployment.Year);
    
  }
}
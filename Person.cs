using System;
class Person {
  public string FirstName{get;set;}
  public string LastName{get;set;}
  public DateTime DateOfBirth{get;set;}
  public string SocialSecurity{get;set;}
  public string Email{get;set;}
  public string PhoneNumber{get;set;}
  public virtual void Intro()
  {
    Console.WriteLine("My name is "+FirstName);
    
  }
}

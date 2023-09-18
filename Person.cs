using System;
using System.ComponentModel.DataAnnotations;
namespace AttributePractice {

public class Person{

    [Required]
    public string FirstName {get;set;}
    [PersonalInformation(1)]
    public string LastName {get;set;}
    [PersonalInformation(3)]
    public string SSN {get;set;}
    public Person(){
        FirstName="";
        LastName="";
    }
    [Obsolete]
    public Person(string fname, string lname){
        FirstName=fname;
        LastName=lname;
    }
    public override string ToString()
    {
        return$"{LastName}, {FirstName}";
    }
}


}
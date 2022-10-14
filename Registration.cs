using System.Collections.Generic;
using System;
public enum TitlePeople{
    CurrentStudent = 1,Student = 2,Teacher =3};
public class Register {
    static PersonList personList = new PersonList();

 static void NamePeople(){
        Console.WriteLine("--------------------");
        Console.WriteLine("Input your Name People :");
        Console.WriteLine("1 = CurrentStudent");
        Console.WriteLine("2 = Student");
        Console.WriteLine("3 = Teacher");
        TitlePeople SearchPeople = (TitlePeople)int.Parse(Console.ReadLine());
        switch (SearchPeople) {
            case TitlePeople.CurrentStudent;
            return "CurrentStudent";
            break;
            case TitlePeople.Student;
            return "Student";
            break;
            case TitlePeople.Teacher;
            return "Teacher";
            break;
            default:
            break;
    }
       return "Error";
    }


    enum NamePrefix{
        Mr=1,Ms=2,Mrs=3
    }
    
public string Prefix(){
        
        Console.WriteLine("-------------------------------");
        Console.WriteLine("1=Mr.");
        Console.WriteLine("2=Ms.");
        Console.WriteLine("3=Mrs.");
        Console.WriteLine("Choose your Name Prefix :");
        
        NamePrefix SeachPrefix = (NamePrefix)int.Parse(Console.ReadLine());
        switch(SeachPrefix)
        {
            case NamePrefix.Mr;
            return "Mr";
            break;
            case NamePrefix.Ms;
            return "Ms";
            break;
            case NamePrefix.Mrs;
            return "Mrs";
            break;
            default:
            break;
 }
 return "Error";
}
enum NameReligion{
        Buddhist=1,Christ=2,Islam=3
    }

public string Religion(){
        
        Console.WriteLine("-------------------------------");
        Console.WriteLine("1=Buddhist");
        Console.WriteLine("2=Christ");
        Console.WriteLine("3=Islam");
        Console.WriteLine("Choose your Religion :");
        
        NameReligion SeachReligion = (NameReligion)int.Parse(Console.ReadLine());
        switch(SeachReligion)
        {
            case NameReligion.Buddhist;
            return "Buddhist";
            break;
            case NameReligion.Christ;
            return "Christ";
            break;
            case NameReligion.Islam;
            return "Islam";
            break;
            default:
            break;
 }
 return "Other";
}
enum NameLevelOfEducation{
        M4=1, M5=2, M6=3
    }
public string LevelOfEducation(){
        Console.WriteLine("-------------------------------");
        Console.WriteLine("1=M.4");
        Console.WriteLine("2=M.5");
        Console.WriteLine("3=M.6");
        Console.WriteLine("Choose your Level Of Education :");
        
        NameLevelOfEducation SeachLevelOfEducation = (NameLevelOfEducation)int.Parse(Console.ReadLine());
        switch(SeachLevelOfEducation)
        {
            case NameLevelOfEducation.M4;
            return "M4";
            break;
            case NameLevelOfEducation.M5;
            return "M5";
            break;
            case NameLevelOfEducation.M6;
            return "M6";
            break;
            default:
            break;
 }
 return "Error";
}

}
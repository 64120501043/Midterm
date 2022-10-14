public class Student: person{
    public int LevelOfEducation;
    public string School;

    public Student(string Prefix, string Name , string SurName,
     int Age , string Religion, string Allergy,int LevelOfEducation,string School) 
     : base(Prefix,Name,SurName,Age,Religion,Allergy){

        this.LevelOfEducation=LevelOfEducation;
        this.School=School;
    }
    public string GetLevelOfEducation() {
        return this.LevelOfEducation;
    }
    public string GetSchool() {
        return this.School;
    }
}
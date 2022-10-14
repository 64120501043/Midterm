public class CurrentStudent: person{
    public int StudentID;
    public bool Admain;
    public string EMail;
    public int PassWord;

    public CurrentStudent(string Prefix, string Name , string SurName,
     int Age , string Religion, string Allergy,int StudentID,bool Admain, string EMail,int PassWord) 
     : base(Prefix,Name,SurName,Age,Religion,Allergy){
        
        this.StudentID=StudentID;
        this.Admain=Admain;
        this.EMail=EMail;
        this.PassWord=PassWord;
    }
    public string GetStudentID() {
        return this.StudentID;
    }
    public string GetAdmain() {
        return this.Admain;
    }
    public string GetEMail() {
        return this.EMail;
    }
    public int GetPassWord() {
        return this.PassWord;
    }
}
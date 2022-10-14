public class Teacher: person{
    public string Rank;
    public bool Car;
    public string CarRegistration;
    public bool Admain;
    public string EMail;
    public int PassWord;

    public Teacher(string Prefix, string Name ,
     string SurName, int Age , string Religion, 
     string Allergy,string Rank,bool Car,string CarRegistration,bool Admain,
     string EMail,int PassWord) 
     : base(Prefix,Name,SurName,Age,Religion,Allergy){

        this.Rank=Rank;
        this.Car=Car;
        this.CarRegistration=CarRegistration;
        this.Admain=Admain;
        this.EMail=EMail;
        this.PassWord=PassWord;
    }
    public string GetRank() {
        return this.Rank;
    }
    public string GetCar() {
        return this.Car;
    }
    public string GetCarRegistration() {
        return this.CarRegistration;
    }
    public int GetAdmain() {
        return this.Admain;
    }
    public string GetEMail() {
        return this.EMail;
    }
    public string GetPassWord() {
        return this.PassWord;
    }
}
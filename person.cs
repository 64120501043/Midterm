public class person {
    public string Prefix;
    public string Name;
    public string SurName;
    public int Age;
    public string Religion;
    public string Allergy;

    public person( string Prefix, string Name , string SurName, int Age , string Religion, string Allergy){
        this.Prefix=Prefix;
        this.Name=Name;
        this.SurName=SurName;
        this.Age=Age;
        this.Religion=Religion;
        this.Allergy=Allergy;
    }
    public string GetPrefix() {
        return this.Prefix;
    }
    public string GetName() {
        return this.Name;
    }
    public string GetSurName() {
        return this.SurName;
    }
    public int GetAge() {
        return this.Age;
    }
    public string GetReligion() {
        return this.Religion;
    }
    public string GetAllergy() {
        return this.Allergy;
    }
}
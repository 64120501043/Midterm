using System.Collections.Generic;
using System;
class PersonList {
    private List<CurrentStudent> CurrentStudentList;
    private List<Student> StudentList;
    private List<Teacher> TeacherList;

    public PersonList() {
        this.CurrentStudentList = new List<CurrentStudent>();
        this.StudentList = new List<Student>();
        this.TeacherList = new List<Teacher>();
    }
    //---------------------------------------------------------------------------------
    public void AddNewCurrentStudent(CurrentStudent currentStudent) {
        this.CurrentStudentList.Add(currentStudent);
    }

    public void SeachCurrentStudentList() {
        Console.WriteLine("List CurrentStudent");
        Console.WriteLine("************");

        foreach(CurrentStudent person in this.CurrentStudentList) {
             Console.WriteLine("Name {0} {1} {2} ", person.GetPrefix(),person.GetName(),person.GetSurName());
        }
        Console.WriteLine("Type exit to return to menu");
    }
    //---------------------------------------------------------------------------------
    public void AddNewStudent(Student student) {
        this.StudentList.Add(student);
    }
    public void SeachStudentList() {
        Console.WriteLine("List Student");
        Console.WriteLine("************");

        foreach(Student person in this.StudentList) {
             Console.WriteLine("Name {0} {1} {2} ", person.GetPrefix(),person.GetName(),person.GetSurName());
        }
        Console.WriteLine("Type exit to return to menu");
    }
    //---------------------------------------------------------------------------------
    public void AddNewTeachert(Teacher teacher) {
        this.TeacherList.Add(teacher);
    }
    public void SeachTeacherList() {
        Console.WriteLine("List Teacher");
        Console.WriteLine("************");

        foreach(Teacher person in this.TeacherList) {
             Console.WriteLine("Name {0} {1} {2} ", person.GetPrefix(),person.GetName(),person.GetSurName());
        }
        Console.WriteLine("Type exit to return to menu");
    }
}
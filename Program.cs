using System;
enum Menu {
    RegisterForTheEvent = 1,
    ShowAttendanceStatistics = 2,
    Login = 3 
}

public class Program {

    static PersonList CurrentStudentList;
    static PersonList StudentList;
    static PersonList TeacherList;

    static void PreparePersonListWhenProgramIsLoad(){
        Program.CurrentStudentList = new PersonList();
        Program.StudentList = new PersonList();
        Program.TeacherList = new PersonList();
    }

    static void Main(string[] args) {
        PreparePersonListWhenProgramIsLoad();
        PrintListMenuScreen();
    }

    static void PrintListMenuScreen() {
        Console.Clear();

        PrintListMenuScreen();
        InputMenuFromKeyboard();
    }

    static void PrintListMenuScreen(){
            
        Console.WriteLine("Welcome to Idia camp 2022");
        Console.WriteLine("-----------------------------------");
        Console.WriteLine("1.Register for the event");
        Console.WriteLine("2.Show attendance statistics");
        Console.WriteLine("3.Login");
        Console.Write("Please input Menu:");
        Console.WriteLine("-----------------------------------");

        Menu menu = (Menu)(int.Parse(Console.ReadLine()));

        PresentMenu(menu);{
        switch (menu) {
            case RegisterForTheEventMenu();
                break;
            case ShowAttendanceStatistics();
                break;
            case Login();
                break;
            default:
                break;
        }
        }
    }
    static void RegisterForTheEventMenuventMenu  (){
        Console.WriteLine("--------------------");
        Console.WriteLine("Input your Name People :");
        Console.WriteLine("1 = CurrentStudent");
        Console.WriteLine("2 = Student");
        Console.WriteLine("3 = Teacher");

    }

    static void InputNamePeopleFromKeyboard() {
        Console.Write("Please input NamePeople:");
        NamePeople namePeople = (NamePeople)(int.Parse(Console.ReadLine()));

        NamePeople(namePeople);
    }
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
    sstatic void RegisterForTheEventMenuventMenu){
        SchoolStudent schoolStudent = new SchoolStudent(SelectNameTitle(),InputFirstName(),InputLastName(),InputAge(),InputAllergic(),SelectReligion(),SelectSchoolGrade(),InputSchoolName());
        Program.personList.AddNewPerson(schoolStudent);
        Console.Clear();
        PrintListMenuScreen();
    }

    //ยังไม่แก้
    static void ShowPersons() {
        Console.WriteLine("Show Persons");
        Console.WriteLine("************");

        Program.personList.FetchPersonList();
    }

    static void ShowInputRegistrationNewTeacherScreen() {
        Console.Clear();

        PrintHeaderRegistrationTeacher();

        int totalNewTeacher = TotalNewTeacher();
        inputNewTeacherFromKeyboard(totalNewTeacher);
    }

    static void ShowInputRegistrationNewStudentScreen() {
        Console.Clear();

        PrintHeaderRegisterStudent();

        int totalStudent = TotalNewStudent();
        InputNewStudentFromKeyboard(totalStudent);
    }

    static void PrintRegisterCurrentStudent() {
        Console.WriteLine("Register New Current Student");
        Console.WriteLine("*********************");
    }

    static void PrintRegisterStudent() {
        Console.WriteLine("Register New Student");
        Console.WriteLine("*********************");
    }

    static void PrintRegisterTeacher() {
        Console.WriteLine("Register New Teacher");
        Console.WriteLine("*********************");
    }

    static int TotalNewStudent() {
        Console.Write("Input Total new Student: ");

        return int.Parse(Console.ReadLine());
    }

    static int TotalNewTeacher() {
        Console.Write("Input Total new Teacher: ");

        return int.Parse(Console.ReadLine());
    }

    static bool SelectCarUse(){
        Console.WriteLine("Please Select");
        Console.WriteLine("1 : Yes");
        Console.WriteLine("2 : No");
        Console.Write("Do you use your car?");
        Menu menu =(Menu) (int.Parse(Console.ReadLine()));
        switch(menu){
            case 1:
            return true;
            break;
            case 2:
            return false;
            default:
            return BackTotheSelectCarUse();
            break;
            
        }
         static bool BackTotheSelectCarUse(){
            Console.Clear();
            Console.WriteLine("Wrong number just use only 1,2");
            return SelectCarUse();
        }

        static void ShowAttendanceStatistics(){
            Program.personList.FetchPersonNum();
            PrintListMenuScreen();
        }


    static void InputCurrentStudentFromKeyboard() {
            Console.Clear();
            PrintCurrentStudent();

            CurrentStudent currentStudent = new CurrentStudent(GetPrefix(),InputName(),InputSurName(),InputAge(),InputStudentID(),InputAllergy(),GetReligion(),GetAdmin());

            Program.currentStudent.AddNewCurrentStudent(currentStudent);
            BackToMainMenu();
        }
    static void InputStudentFromKeyboard() {
            Console.Clear();
            PrintStudent();

            Student student = new Student(GetPrefix(),InputName(),InputSurName(),InputAge(),InputAllergy(),GetLevelOfEducation(),GetReligion(),GetAdmin());

            Program.student.AddNewStudent(student);
            BackToMainMenu();
        }
    static void InputTeacherFromKeyboard() {
            Console.Clear();
            PrintTeacher();

            Teacher teacher = new Teacher(GetPrefix(),InputName(),InputSurName(),InputAge(),InputAllergy(),GetReligion(),GetAdmin());

            Program.teacher.AddNewTeacher();
            BackToMainMenu();
        }    
    static void BackToMainMenu() {
        Console.Clear();
        PrintListMenu();
        InputMenuFromKeyboard();
    }

    static void PreparePersonListWhenProgramIsLoad() {
        Program.personList = new PersonList();
    }
    static string InputPrefix() {
        Console.Write("Prefix");
    }

    static string InputName() {
        Console.Write("Name :");

        return Console.ReadLine();
    }

    static string InputSurName() {
        Console.Write("SurName :");

        return Console.ReadLine();
    }

    static string InputAge() {
        Console.Write("Age : ");

        return Console.ReadLine();
    }

    static string InputReligion() {
        Console.Write("Religion: ");

        return Console.ReadLine();
    }

    static string InputAllergy() {
        Console.Write("Allergy: ");

        return Console.ReadLine();
    }
}











/* //เมนูหลักเข้าสู่ระบบ
        
    }
    }        
        //ยังไม่เข้า
        //ถ้ายังไม่เข้า
        //ลงทะเบียนเข้าร่วมงาน
        //แสดงสถิติผู้เข้าร่วมงาน
        //เข้าสู้ระบบ


        //เข้าสู่ระบบ
        //ลงทะเบียนเข้าร่วมงาน
        //แสดงข้อมูลนักศึกษาปัจจุบันทั้งหมด
        //แสดงข้อมูลนักเรียนทั้งหมด
        //แสดงข้อมูลอาจารย์ทั้งหมด

        //ออกจากระบบ

        //เข้าสู่ระบบ
        //ใส่ email password
        //ถ้าemailไม่ตรงกับตอนสมัคร แสดง “Incorrect email or password. Please try again.”
        //แล้วให้ใส่ email password ใหม่อีกครั้ง

        //ถ้าถูกต้องให้วนกลับไปแหน้าเมนูหลัก

        //เข้า กับ ยังไม่เข้า
        //1.2ลงทะเบียนเข้าร่วมงาน
        //1.2.1 นักศึกษาปัจจุบัน
        /*คำนำหน้าชื่อ
        ชื่อ
        นามสกุล
        รหัสนักศึกษา
        อายุ
        สิ่งที่แพ้
        ศาสนา
        เป็นผู้ดูแลระบบหรือไม่
        อีเมลล์ (หากเป็นผู้ดูแลระบบ)
        รหัสผ่าน (หากเป็นผู้ดูแลระบบ)
        //1.2.2 นักเรียน
        คำนำหน้าชื่อ
        ชื่อ
        นามสกุล
        อายุ
        ระดับชั้นการศึกษา
        สิ่งที่แพ้
        ศาสนา
        โรงเรียน
        //1.2.3 อาจารย์
        คำนำหนา้ชื่อ
        ชื่อ
        นามสกุล
        อายุ
        ตำแหน่ง
        สิ่งที่แพ้
        ศาสนา
        นำรถยนต์มาเข้าร่วมหรือไม่
        ทะเบียนรถ
        เป็นผู้ดูแลระบบหรือไม่
        อีเมลล์ (หากเป็นผู้ดูแลระบบ)
        รหัสผ่าน (หากเป็นผู้ดูแลระบบ)
        // คำนำหน้าชื่อ
        นาย นาง นางสาว
        // ศาสนา
        พุทธ คริสต์ อิสลาม อื่นๆ
        // ระดับชั้นการศึกษา
        ม.4  ม.5  ม.6
        //ตำแหน่ง
        คณบดี หัวหน้าภาควิชา อาจารย์ประจำ

        //ถ้าข้อมูลซ้ำกันให้ขึ้นว่า “User is already registered. Please try again.”
        //ถ้าuser กรอก email ซ้ำกันให้ขึ้นว่า “Invalid email. Please try again.”

        เสร้จแล้วกับไปหน้าเมนูหลัก

        //แสดงสถิติผู้เข้าร่วมงาน 
        จำนวนอาจารย์ที่ลงทะเบียนทั้งหมด
        จำนวนนักเรียนที่ลงทะเบียนทั้งหมด
        จำนวนนักศึกษาปัจจุบันที่ลงทะเบียนทั้งหมด
        จำนวนนักเรียนเฉพาะระดับชั้นมัธยมศึกษาปีที่ 4 ที่ลงทะเบียนทั้งหมด
        จำนวนนักเรียนเฉพาะระดับชั้นมัธยมศึกษาปีที่ 5 ที่ลงทะเบียนทั้งหมด
        จำนวนนักเรียนเฉพาะระดับชั้นมัธยมศึกษาปีที่ 6 ที่ลงทะเบียนทั้งหมด
        
        เสร้จแล้วกับไปหน้าเมนูหลัก

        //แสดงข้อมูลนักศึกษาปัจจุบันที่เข้าร่วมทั้งหมด
        คำนำหน้าชื่อ ชื่อ นามสกุล

        เสร้จแล้วกับไปหน้าเมนูหลัก

        //แสดงข้อมูลนักเรียนที่เข้าร่วมทั้งหมด
        คำนำหน้าชื่อ ชื่อ นามสกุล

        เสร้จแล้วกับไปหน้าเมนูหลัก

        //แสดงข้อมูลอาจารย์ที่เข้าร่วมทั้งหมด
        คำนำหน้าชื่อ ชื่อ นามสกุล

        //ออกจากระบบ ให้ไปยังหน้าเมนูหลัก เพื่อกด ออกจากระบบ*/


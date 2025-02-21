// Task 1: Student Management System
// Task: Create a class Student with:
// Fields: name, studentID, and gradeLevel.
// Add a method ShowStudentInfo() to display the details.
// In Main(), create a few Student objects and display their details.



class Student
{
    private string name;
    private int studentId;
    private int gradeLevel;

    public Student(string name, int studentId, int gradeLevel)
    {
        this.name = name;
        this.studentId = studentId;
        this.gradeLevel = gradeLevel;
    }

    public string Name
    {
        get {return name;}
        set {name = value;}
    }

    public int StudentId
    {
        get {return studentId;}
        set {studentId = value;}
    }

    public int GradeLevel
    {
        get {return gradeLevel;}
        set {gradeLevel = value;}
    }

    public void Showdetails()
    {
        Console.WriteLine($"Student details are\nStudent name{this.Name}\nStudent Id{this.StudentId}\nStudend grade level is{this.GradeLevel}\n");
    }
}

class Program
{
    public static void Main(string[] args)
    {
        Student student = new Student("John",1,10);
        Student student1 = new Student("Maria",2,11);
        Student student2 = new Student("Jennifer",3,9);

        student.Showdetails();
        student1.Showdetails();
        student2.Showdetails();
    }
}
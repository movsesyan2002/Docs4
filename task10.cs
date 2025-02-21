// Task 10: Simulating Course Enrollment
// Task: Create a class Course with:
// Fields: courseName, instructor, and maxStudents.
// Use a constructor to initialize these fields.
// Add a method ShowCourseDetails().
// In Main(), create a few courses and display their details.

class Course
{
    private string courseName;
    private string instructor;
    private int maxStudents;

    public Course(string courseName, string instructor, int maxStudents)
    {
        this.courseName = courseName;
        this.instructor = instructor;
        this.maxStudents = maxStudents;
    }

    public string CourseName
    {
        get { return courseName; }
        set { courseName = value; }
    }

    public string Instructor
    {
        get { return instructor; }
        set { instructor = value; }
    }

    public int MaxStudents 
    {
        get { return maxStudents; }
        set { maxStudents = value;}
    }

    public void ShowCharacterInfo() 
    {
        Console.WriteLine($"The Character name {this.CourseName} and Character level {this.Instructor} and students count {this.MaxStudents}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Course[] courses = new Course[3];

        for (int i = 0; i < courses.Length; i++)
        {
            Console.Write("Enter Course name:  ");
            string? coursename = Console.ReadLine();
            
            Console.Write("Enter course instructor:  ");
            string? instructor = Console.ReadLine();

            Console.Write("Enter course max students");
            if (int.TryParse(Console.ReadLine(),out int studentscount) == false) 
            {
                Console.WriteLine("You enter invalid argument");
            }

            courses[i] = new Course(coursename, instructor, studentscount);

        }

        for (int i = 0; i < courses.Length; i++)
        {
            courses[i].ShowCharacterInfo();
        }
    }
}
class Student
{
    private int StudentId;
    private string StudentName="";
    private int StudentAge;
    private double StudentMarks;

    public int GetStudentId()
    {
        return StudentId;
    }

    public string Name
    {
        get { return StudentName; }

        set
        {
            if (!string.IsNullOrEmpty(value))
            {
                StudentName = value;
            }
        }
    }

    public int Age
    {
        get { return StudentAge; }
        set
        {
            if (value >= 5 && value <= 100)
            {
                StudentAge = value;
            }
        }
    }

    public double Marks
    {
        get { return StudentMarks; }
        set
        {
            if (value >= 0 && value <= 100)
            {
                StudentMarks = value;
            }
        }
    }

    public Student(int id, string name, int age, double marks)
    {
        StudentId = id;
        Name = name;
        Age = age;
        Marks = marks;
    }

    public string GetGrade()
    {
        if (StudentMarks >= 80)
        {
            return "A+";
        }
        else if (StudentMarks >= 75)
        {
            return "A";
        }
        else if (StudentMarks >= 70)
        {
            return "A-";
        }
        else if (StudentMarks >= 65)
        {
            return "B+";
        }
        else if (StudentMarks >= 60)
        {
            return "B";
        }
        else if (StudentMarks >= 55)
        {
            return "B-";
        }
        else if (StudentMarks >= 50)
        {
            return "C+";
        }
        else if (StudentMarks >= 45)
        {
            return "C";
        }
        else if (StudentMarks >= 40)
        {
            return "D";
        }
        else
        {
            return "F";
        }
    }

    public void DisplayStudentDetails()
    {
        Console.WriteLine($"Student ID: {StudentId}");
        Console.WriteLine($"Student Name: {StudentName}");
        Console.WriteLine($"Student Age: {StudentAge}");
        Console.WriteLine($"Student Marks: {StudentMarks}");
        Console.WriteLine($"Student Grade: {GetGrade()}");
    }
}
class Program
{
    static void Main(string[] args)
    {
        Student student1 = new Student(1858, "Md. Riyad", 23, 87);
        student1.DisplayStudentDetails();
        Console.WriteLine();
        Student student2 = new Student(1842, "Waywch Kurni", 12, 77.5);
        student2.DisplayStudentDetails();
    }
}

public class Students
{
    public string name { set; get; }
    public Courses[] course_details = new Courses[5];
}

public class Courses
{
    public string name { set; get; }
    public double grade { set; get; }
    public int credits { set; get; }
}

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Enter the Name of the student: ");
        string student_name = Console.ReadLine();

        Students Student1 = new Students { name = student_name };
        double[] Grade_product = new double[5];
        int Credit_sum = 0;
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("Enter the name of the course: ");
            string course_name = Console.ReadLine();

            Console.WriteLine("Enter the Grade you got: ");
            double course_grade = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the credits of the course: ");
            int course_credit = Convert.ToInt32(Console.ReadLine());

            Courses course = new Courses { name = course_name, grade = course_grade, credits = course_credit };
            Student1.course_details[i] = course;
            Grade_product[i] = course.grade * course.credits;
            Credit_sum = Credit_sum + course.credits;
        }

        double sum = 0;
        for (int i = 0; i < 5; i++) {
            sum = sum + Grade_product[i];
        }

        double Final_GPA = Math.Round(sum / Credit_sum,2);
        Console.WriteLine(sum);
        Console.WriteLine(Credit_sum);

        Console.WriteLine("Student Name: " + Student1.name);
        Console.WriteLine("""Courses            Grades            Credits""");
        for (int i = 0; i < 5; i++)
        {
            // Using String formatting I've Printed the Table.
            // {Var, -24} here The "24" signifies that the Variable field should be 24 spaces wide.
            // The " - " symbol is to left align it in that user-defined 20 space width.

            Console.WriteLine($"{Student1.course_details[i].name, -24}{Student1.course_details[i].grade, -16} {Student1.course_details[i].credits}");
        }
        Console.WriteLine("Final GPA: " + Final_GPA);
    }
}
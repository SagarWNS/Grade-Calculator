// See https://aka.ms/new-console-template for more information
const int CreditH_ENG = 3, CreditH_Alg = 3, CreditH_Bio = 4, CreditH_CS = 4, CreditH_Psy = 3;


string Student_Names()
{
    Console.WriteLine("Enter the Student Name: ");
    string Name = Console.ReadLine();
    return Name;
}

double Student_grades()
{
    Console.WriteLine("Enter your English Grade:");
    int English_Grade = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Enter your Algebra Grade:");
    int Alg_Grade = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Enter your Biology Grade:");
    int Bio_Grade = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Enter your CS Grade:");
    int CS_Grade = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Enter your Psychology Grade:");
    int Psy_Grade = Convert.ToInt32(Console.ReadLine());

    int Credit_sum = CreditH_ENG + CreditH_Alg + CreditH_Bio + CreditH_CS + CreditH_Psy;
    int Sum = (English_Grade * CreditH_ENG) + (Alg_Grade * CreditH_Alg) + (Bio_Grade * CreditH_Bio) + (CS_Grade * CreditH_CS) + (Psy_Grade * CreditH_Psy);

    double GPA = Math.Round((double)Sum / (double)Credit_sum, 2);
    Console.WriteLine("*****************");
    return GPA;
}

Console.WriteLine("How many Students GPA you want to calculate? :");
int num = Convert.ToInt32(Console.ReadLine());

string[] Names = new string[num];
double[] GPAs = new double[num];

for (int i = 0; i < num; i++)
{
    Names[i] = Student_Names();
    GPAs[i] = Student_grades();
}

for (int i = 0; i < num; i++)
{
    Console.WriteLine((i+1) +". "+ Names[i] + " : " + GPAs[i]);
}
Console.WriteLine("*****************");




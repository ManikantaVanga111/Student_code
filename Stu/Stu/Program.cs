
namespace Stu { 
    class Student
{
    public int RollNo { get; set; }
    public string Name { get; set; }
    public int Math { get; set; }
    public int Science { get; set; }
    public int English { get; set; }
    public int Language { get; set; }
    public int SST { get; set; }
}
class Scorecard
{
    int n = 0;
    Student[] students;
    public void AcceptDetails()
    {
        Console.WriteLine("Enter the number of students");
        n = Convert.ToInt16(Console.ReadLine());
        students = new Student[n];
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"Enter Details for Student {i + 1}");
            Console.WriteLine("Enter Roll No");
            int rollno = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Enter Student Name");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Marks for Maths");
            int maths = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Enter Marks for Science");
            int science = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Enter Marks for English");
            int english = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Enter Marks for Language");
            int lang = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Enter Marks for SST");
            int sst = Convert.ToInt16(Console.ReadLine());
            students[i] = new Student() { RollNo = rollno, Name = name, Math = maths, Science = science, English = english, Language = lang, SST = sst };
        }
    }
    public void showdetails()
    {
        int sum = 0;
           
        int avg = 0;
        int max = 0;
        for (int i = 0; i < students.Length; i++)
        {
            Console.WriteLine($"Roll No: {students[i].RollNo} Name: {students[i].Name}");
            Console.WriteLine($"Math: {students[i].Math}, Science: {students[i].Science}, English: {students[i].English}, Language: {students[i].Language}, SST: {students[i].SST}");
            sum = students[i].Math + students[i].Science + students[i].English + students[i].Language + students[i].SST;
            Console.WriteLine($"Total Score of student is {sum}");
            avg = sum / 5;
            Console.WriteLine("the average marks of student is" + avg);
            if (avg >= 90 && avg < 100)
            {
                Console.WriteLine("the grade of student is A");
            }
            else if (avg >= 80 && avg < 90)
            {
                Console.WriteLine("The grade of student is B");
            }
            else if (avg >= 70 && avg < 80)
            {
                Console.WriteLine("The grade of student is C");
            }
            else if (avg >= 60 && avg < 70)
            {
                Console.WriteLine("The grade of student is D");
            }
            else if (avg >= 50 && avg < 60)
            {
                Console.WriteLine("The grade of student  is E");
            }
            else
            {
                Console.WriteLine("The grade of student  is F");
            }
               
            if (sum > max)
            {
                max = sum;

            }
        }
        Console.WriteLine($"the maximum score is {max}");
    }
    public void avg()
    {
        double avgMath = 0, avgScience = 0, avgEnglish = 0, avgLanguage = 0, avgSST = 0;
        foreach (Student student in students)
        {
            avgMath += student.Math;
            avgScience += student.Science;
            avgEnglish += student.English;
            avgLanguage += student.Language;
            avgSST += student.SST;
        }
        avgMath /= students.Length;
        avgScience /= students.Length;
        avgEnglish /= students.Length;
        avgLanguage /= students.Length;
        avgSST /= students.Length;
        Console.WriteLine($"\nAverage Marks\nMath: {avgMath:F2}\nScience: {avgScience:F2}\nEnglish: {avgEnglish:F2}\nLanguage: {avgLanguage:F2}\nSocial Studies: {avgSST:F2}");
    }
    public void status()
    { int fail = 0;
        for (int i = 0; i < students.Length; i++)
        {
            if (students[i].Math >= 35 && students[i].Science >= 35 && students[i].English >= 35 && students[i].Language >= 35 && students[i].SST >= 35)
            {
                Console.WriteLine($"student of name:{students[i].Name} rollnumber:{students[i].RollNo} is pass");
            }
            else
            { 
                    fail++;
                Console.WriteLine($"student of name:{students[i].Name} rollnumber:{students[i].RollNo} ");
            }
        }
        Console.WriteLine($"The number of students who needs to mandatorily repeat the examination {fail}");



    }
        public void result()
        {
            Console.WriteLine("Enter roll number");
            int r=Convert.ToInt32( Console.ReadLine() );
            for(int i = 0; i < students.Length; i++)
            {
                if (students[i].RollNo==r)
                {
                    Console.WriteLine(students[i].Name);
                    Console.WriteLine(students[i].RollNo);
                    Console.WriteLine(students[i].English);
                    Console.WriteLine(students[i].Science);
                    Console.WriteLine(students[i].Math);
                    Console.WriteLine(students[i].SST);
                    Console.WriteLine(students[i].Language);
                }
            }

        }
}
internal class Program
{
    static void Main(string[] args)
    {
        Scorecard sc = new Scorecard();
        sc.AcceptDetails();
        sc.showdetails();
        sc.avg();
        sc.status();
        sc.result();
    }
}
}
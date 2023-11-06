namespace Week6Task1;
internal class Program
{
    static void Main(string[] args)
    {
        List<Exam> exams = new List<Exam>();
        while (true)
        {
            Console.WriteLine("1. Create an exam");
            Console.WriteLine("2. List of exams with more than 50 points");
            Console.WriteLine("3. List of exams due in the last 1 week");
            Console.WriteLine("4. List of exams lasting more than 1 hour");

            int answer = Convert.ToInt32((Console.ReadLine()));

            switch (answer)
            {
                case 1:
                    Console.Write("Student Name: ");
                    string studentName = Console.ReadLine();
                    Console.Write("Student Surname: ");
                    string studentSurname = Console.ReadLine();
                    Console.Write("Student Age: ");
                    int studentAge = Convert.ToInt32((Console.ReadLine()));
                    Console.Write("Subject: ");
                    string subject = Console.ReadLine();
                    Console.Write("Point: ");
                    int point = Convert.ToInt32((Console.ReadLine()));
                    Console.Write("Start Date (Year,Month,Day): ");
                    DateTime startD = Convert.ToDateTime(Console.ReadLine());
                    Console.Write("End Date (Year,Month,Day): ");
                    DateTime endD = Convert.ToDateTime(Console.ReadLine());
                    Student student = new Student(studentName, studentSurname, studentAge);
                    Exam exam = new Exam(student, subject, point);
                    exams.Add(exam);
                    break;

                case 2:
                    Console.WriteLine("List of exams with more than 50 points");
                    var result1 = exams.FindAll(exam => exam.Point > 50);
                    foreach (var Exam in result1)
                    {
                        Console.WriteLine(Exam);
                    }
                    break;

                case 3:
                    //Console.WriteLine("List of exams due in the last 1 week");
                    //var result2 = exams.FindAll(exam => );
                    //foreach (var Exam in result2)
                    //{
                    //    Console.WriteLine(Exam);
                    //}
                    break;

                case 4:
                    //Console.WriteLine("List of exams lasting more than 1 hour");
                    //var result3 = exams.FindAll(exam => );
                    //foreach (var Exam in result3)
                    //{
                    //    Console.WriteLine(Exam);
                    //}
                    break;

            }
        }
    }
}


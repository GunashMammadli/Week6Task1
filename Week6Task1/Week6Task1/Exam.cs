namespace Week6Task1;
internal class Exam
{
    public Student Student { get; set; }
    public string Subject { get; set; }
    public int Point { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
   

    public Exam(Student student, string subject, int point)
    {
        Student = student;
        Subject = subject;
        Point = point;
        StartDate = DateTime.Now;
    }

    //public DateTime Duration () 
    //{ 
    //    var duration = EndDate - StartDate;
    //    return duration ;
    //}

    public override string ToString()
    {
        return $"Student Name: {Student.Name}\nSubject: {Subject}\nPoint: {Point}";
    }
}

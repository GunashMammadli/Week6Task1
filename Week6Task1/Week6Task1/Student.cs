namespace Week6Task1;
internal class Student
{
    public string Name { get; set; }
    public string Surname { get; set; }
    public int Age { get; set; }

    public Student(string name, string surname, int age)
    {
        Name = name;
        Surname = surname;
        Age = age;
    }
}

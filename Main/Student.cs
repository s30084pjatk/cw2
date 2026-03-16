using ConsoleApp1;

public class Student : Person
{
    public string NrStudenta { get; set; }

    public Student(string nrStudenta)
    {
        NrStudenta = nrStudenta;
    }
}
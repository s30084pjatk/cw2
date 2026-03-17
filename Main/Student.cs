using ConsoleApp1;
public class Student : Person
{
    public Student(int idPerson, string imie, string nazwisko, EnumTypWypozyczajacego enumTyp, string nrStudenta) : base(idPerson, imie, nazwisko, EnumTypWypozyczajacego.Student)
    {
        NrStudenta = nrStudenta;
    }
    public string NrStudenta { get; set; }
}
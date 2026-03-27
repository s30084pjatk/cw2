using ConsoleApp1;

public class Student : Person_parent
{
    public Student(int idPerson, string imie, string nazwisko, EnumTypWypozyczajacego enumTypWypozyczajacego,
        string nrStudenta) :
        base(idPerson, imie, nazwisko, EnumTypWypozyczajacego.Student)
    {
        NrStudenta = nrStudenta;
        Service.Users.Add(this);
    }

    public string NrStudenta { get; set; }
}
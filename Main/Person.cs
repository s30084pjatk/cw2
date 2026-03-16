namespace ConsoleApp1;

public abstract class Person
{
    protected Person(int idPerson, string imie, string nazwisko, EnumTypWypozyczajacego enumTyp)
    {
        this.idPerson = idPerson;
        this.imie = imie;
        this.nazwisko = nazwisko;
        EnumTyp = enumTyp;
    }

    public int idPerson { get; set; }
    public string imie { get; set; }
    public string nazwisko { get; set; }
    public EnumTypWypozyczajacego EnumTyp { get; set; }
}
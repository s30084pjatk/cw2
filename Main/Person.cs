namespace ConsoleApp1;

public abstract class Person
{
    public string idPerson { get; set; }
    public string imie { get; set; }
    public string nazwisko { get; set; }
    public EnumTypWypozyczajacego EnumTyp { get; set; }
}
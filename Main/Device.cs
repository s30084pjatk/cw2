namespace ConsoleApp1;

public abstract class Device
{
    protected Device(int id, string nazwa, bool dostepnosc)
    {
        Id = id;
        Nazwa = nazwa;
        Dostepnosc = dostepnosc;
    }

    public int Id { get; set; }
    public string Nazwa { get; set; }
    public bool Dostepnosc { get; set; }
}
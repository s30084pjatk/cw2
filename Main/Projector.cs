using ConsoleApp1;

public class Projector : Device
{
    public Projector(int id, string nazwa, bool dostepnosc, int jasnosc, string rozdzielczosc) : base(id, nazwa, dostepnosc)
    {
        Jasnosc = jasnosc;
        Rozdzielczosc = rozdzielczosc;
    }

    public int Jasnosc { get; set; }
    public string Rozdzielczosc { get; set; }
}
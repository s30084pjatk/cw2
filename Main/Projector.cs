namespace ConsoleApp1;

public class Projector : Device
{
    public Projector(DateTime dataWypozyczenia, DateTime dataZwrotu, int karaPerDzien, int kaucja, int waga, bool dostepnosc,
        int jasnosc, string rozdzielczosc)
        : base(dataWypozyczenia, dataZwrotu, karaPerDzien, kaucja, waga, dostepnosc)
    {
        Jasnosc = jasnosc;
        Rozdzielczosc = rozdzielczosc;
    }

    
    public int Jasnosc { get; set; }

    public string Rozdzielczosc { get; set; }

}
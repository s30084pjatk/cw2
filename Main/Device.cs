namespace ConsoleApp1;

public class Device
{
    public Device(DateTime dataWypozyczenia, DateTime dataZwrotu, int karaPerDzien, int kaucja, int waga, bool dostepnosc)
    {
        this.dataWypozyczenia = dataWypozyczenia;
        this.dataZwrotu = dataZwrotu;
        this.karaPerDzien = karaPerDzien;
        this.kaucja = kaucja;
        this.waga = waga;
        this.dostepnosc = dostepnosc;
    }

    
    public DateTime dataWypozyczenia{ get; set; }
    public DateTime dataZwrotu { get; set; }
    public int karaPerDzien { get; set; }
    public int kaucja { get; set; }
    public int waga { set; get; }
    public bool dostepnosc { set; get; }
}
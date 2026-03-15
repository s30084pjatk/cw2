namespace ConsoleApp1;


public class Mouse : Device
{
    public Mouse(DateTime dataWypozyczenia, DateTime dataZwrotu, int karaPerDzien, int kaucja, int waga,bool dostepnosc,
        bool bezprzewodowa, int dpi)
        : base(dataWypozyczenia, dataZwrotu, karaPerDzien, kaucja, waga, dostepnosc)
    {
        Bezprzewodowa = bezprzewodowa;
        DPI = dpi;
    }

    
    public bool Bezprzewodowa { get; set; }
    public int DPI { get; set; }
}
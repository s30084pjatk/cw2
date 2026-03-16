using ConsoleApp1;

public class Mouse : Device
{
    public Mouse(int id, string nazwa, bool dostepnosc, bool bezprzewodowa, int dpi) : base(id, nazwa, dostepnosc)
    {
        Bezprzewodowa = bezprzewodowa;
        DPI = dpi;
    }
    
    public bool Bezprzewodowa { get; set; }
    public int DPI { get; set; }
}
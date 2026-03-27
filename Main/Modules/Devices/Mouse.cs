using ConsoleApp1;

public class Mouse : Device_parent
{
    public Mouse(int id, string nazwa, bool dostepnosc, bool bezprzewodowa, int dpi) : base(id, nazwa, dostepnosc)
    {
        Bezprzewodowa = bezprzewodowa;
        DPI = dpi;
        Service.Devices.Add(this);
    }

    public bool Bezprzewodowa { get; set; }
    public int DPI { get; set; }
}
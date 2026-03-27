using ConsoleApp1;

public class Laptop : Device_parent
{
    public Laptop(int id, string nazwa, bool dostepnosc, int ramGb, string cpu) : base(id, nazwa, dostepnosc)
    {
        RamGB = ramGb;
        CPU = cpu;
        Service.Devices.Add(this);
    }

    public int RamGB { get; set; }
    public string CPU { get; set; }
}
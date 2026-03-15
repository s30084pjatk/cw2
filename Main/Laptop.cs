using ConsoleApp1;

public class Laptop : Device
{
    public Laptop(DateTime dataWypozyczenia, DateTime dataZwrotu, int karaPerDzien, int kaucja, int waga, bool dostepnosc, int ramGb,
        string cpu, int dyskGb) : base(dataWypozyczenia, dataZwrotu, karaPerDzien, kaucja, waga, dostepnosc)
    {
        RamGB = ramGb;
        CPU = cpu;
        DyskGB = dyskGb;
    }
    

    
    public int RamGB { get; set; }
    public string CPU { get; set; }
    public int DyskGB { get; set; }

}
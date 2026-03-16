namespace ConsoleApp1;

public class Pracownik:Person
{
    public Pracownik(EnumPracownikPoziomDostepu poziomDostepu)
    {
        PoziomDostepu = poziomDostepu;
    }

    public EnumPracownikPoziomDostepu PoziomDostepu { get; set; }
}
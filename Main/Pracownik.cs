namespace ConsoleApp1;
public class Pracownik : Person
{
    

    public Pracownik(
        int idPerson, 
        string imie, 
        string nazwisko, 
        EnumPracownikPoziomDostepu poziomDostepu)
        : base(idPerson, imie, nazwisko, EnumTypWypozyczajacego.Pracownik)
    {
        PoziomDostepu = poziomDostepu;
    }
    public EnumPracownikPoziomDostepu PoziomDostepu { get; set; }
}
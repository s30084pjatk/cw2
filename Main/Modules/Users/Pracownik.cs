namespace ConsoleApp1;

public class Pracownik : Person_parent
{
    public Pracownik(int idPerson, string imie, string nazwisko, EnumPracownikPoziomDostepu poziomDostepu) : base(
        idPerson, imie, nazwisko, EnumTypWypozyczajacego.Pracownik)
    {
        PoziomDostepu = poziomDostepu;
        Service.Users.Add(this);
    }

    public EnumPracownikPoziomDostepu PoziomDostepu { get; set; }
}
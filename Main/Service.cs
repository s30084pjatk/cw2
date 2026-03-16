namespace ConsoleApp1;

public class Service
{
    public List<Device> Devices = new();
    public List<Person> Users = new();
    public List<Wypozyczenie> Rentals = new();

    public void DodajSprzet(Device device)
    {
        Devices.Add(device);
    }
    

    public void DodajUzytkownika(Person person)
    {
        Users.Add(person);
    }

    public void Wypozycz(Device device, Person person)
    {
        
    }

    public void Zwroc(Device device)
    {
    }

    public void PokazDostepnySprzet()
    {
    }
    
    public void PokazSprzetWypozyczony()
    {
    }
    
    public void PokazAktywneWypozyczenia()
    {
    }
    
    public void PokazPrzeterminowaneWypozyczenia()
    {
    }
    
    public void GenerujRaport()
    {
    }
    
  
}


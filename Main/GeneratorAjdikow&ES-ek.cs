namespace ConsoleApp1;

public class GeneratorAjdikow
{
    private static int lastDeviceId;
    private static int lastPersonId;
    private static int lastRentalId;
    private static int lastIndexNO=21370;

    public static int LastDeviceId() {
        return ++lastDeviceId;
    }
    public static int LastPersonId() {
        return ++lastPersonId;
    }
    public static int LastRentalId() {
        return ++lastRentalId;
    }
    
    public static int LastIndexNO() {
        return ++lastIndexNO; 
    }

}
namespace ConsoleApp1;

public class GeneratorAjdikow
{
    private static int lastDeviceId;
    private static int lastPersonId;
    private static int lastRentalId;

    public static int LastDeviceId() {
        return ++lastDeviceId;
    }
    public static int LastPersonId() {
        return ++lastPersonId;
    }
    public static int LastRentalId() {
        return ++lastRentalId;
    }

}
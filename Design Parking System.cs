public class Program
{
    public static void Main()
    {
        ParkingSystem parkingSystem = new ParkingSystem(1, 1, 0);
        Console.WriteLine(parkingSystem.AddCar(1)); // true 
        Console.WriteLine(parkingSystem.AddCar(2)); // true
        Console.WriteLine(parkingSystem.AddCar(3)); // false
        Console.WriteLine(parkingSystem.AddCar(1)); // false
    }
}

public class ParkingSystem
{
    private int _big;
    private int _medium;
    private int _small;

    public ParkingSystem(int big, int medium, int small)
    {
        _big = big;
        _medium = medium;
        _small = small;
    }
    
    public bool AddCar(int carType) 
    {
        switch (carType)
        {
            case 1:
            {
                if (_big == 0)
                    return false;
                _big--;
                return true;
            }
            case 2:
            {
                if (_medium == 0)
                    return false;
                _medium--;
                return true;
            }
            default:
            {
                if (_small == 0)
                    return false;
                _small--;
                return true;
            }
        }
    }
}
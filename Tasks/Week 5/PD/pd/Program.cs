using System;

public class Angle
{
    private int degrees;
    private float minutes;
    private char direction;

    public Angle(int deg, float min, char dir)
    {
        degrees = deg;
        minutes = min;
        direction = dir;
    }

    public void SetAngle(int deg, float min, char dir)
    {
        degrees = deg;
        minutes = min;
        direction = dir;
    }

    public override string ToString()
    {
        return degrees.ToString() + "\u00b0" + minutes.ToString("F1") + "' " + direction;
    }
}

public class Ship
{
    private int shipNumber;
    private Angle latitude;
    private Angle longitude;

    public Ship(int number, Angle lat, Angle lon)
    {
        shipNumber = number;
        latitude = lat;
        longitude = lon;
    }

    public void PrintPosition()
    {
        Console.WriteLine("Latitude: " + latitude.ToString() + ", Longitude: " + longitude.ToString());
    }

    public void PrintSerialNumber()
    {
        Console.WriteLine("Ship number: " + shipNumber);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Angle lat = new Angle(17, 31.5f, 'S');
        Angle lon = new Angle(149, 34.8f, 'W');
        Ship myShip = new Ship(1234, lat, lon);
        myShip.PrintSerialNumber();
        myShip.PrintPosition();
        Console.ReadLine();
    }
}

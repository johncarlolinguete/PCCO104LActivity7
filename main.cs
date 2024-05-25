using System;

public class Car
{
    
    public string Make { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }

   
    private string _color;
    private double _price;
    private bool _isRunning;

    
    public Car()
    {
        Make = "Unknown";
        Model = "Unknown";
        Year = DateTime.Now.Year;
        _color = "Unknown";
        _price = 0.0;
        _isRunning = false;
    }

    public Car(string make, string model, int year, string color, double price)
    {
        Make = make;
        Model = model;
        Year = year;
        _color = color;
        _price = price;
        _isRunning = false;
    }

    public Car(string make, string model, int year) : this(make, model, year, "Unknown", 0.0) { }

    
    public void Start()
    {
        _isRunning = true;
        Console.WriteLine("The car has started.");
    }

    public void Stop()
    {
        _isRunning = false;
        Console.WriteLine("The car has stopped.");
    }

    
    private void DisplayDetails()
    {
        Console.WriteLine($"Make: {Make}");
        Console.WriteLine($"Model: {Model}");
        Console.WriteLine($"Year: {Year}");
        Console.WriteLine($"Color: {_color}");
        Console.WriteLine($"Price: ${_price}");
        Console.WriteLine($"IsRunning: {_isRunning}");
    }

    
    public void ShowCarDetails()
    {
        DisplayDetails();
    }
}

class Program
{
    static void Main(string[] args)
    {
      
        Car car1 = new Car();
        Car car2 = new Car("Toyota", "Camry", 2020);
        Car car3 = new Car("Ford", "Mustang", 2018, "Red", 25000);

       
        car1.Start();
        car2.Stop();

       
        car3.ShowCarDetails();
    }
}

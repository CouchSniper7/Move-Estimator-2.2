using System;

class Program {
  public static void Main (string[] args) {
    const double baseRate = 200.00;
    const double hourlyRate = 150.00;
    const double milageRate = 2.00;
    Console.WriteLine("Welcome to Malcolm Movers");
    Console.WriteLine("Please Enter Number of Hours For Move: ");
    double hours = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Please Enter Miles to Desired Moving Location: ");
    double miles = Convert.ToDouble(Console.ReadLine());
    double total = (miles * milageRate) + (hours * hourlyRate) + baseRate;
    Console.WriteLine("For {0} hours and {1} miles the total is ${2}", hours, miles, total);
  
  }
}
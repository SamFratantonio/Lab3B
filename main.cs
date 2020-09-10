using System;

class MainClass {
  public static double commission(double amt)
  {
    return(200 + (0.09 * amt));
  }
  public static void Main (string[] args) {
    Console.WriteLine("Enter Salesperson Name: ");
    string sName = Console.ReadLine();
    Console.WriteLine("Enter Sales Amount: ");
    double sAmt = double.Parse(Console.ReadLine());
    Console.WriteLine("Sales commission for " + sName + " is " + commission(sAmt));
    Console.Write("Performance Is ");
    if (sAmt < 3000)
    {
      Console.WriteLine("Poor");
    }
    else if ((sAmt >= 3000) && (sAmt <= 4999))
    {
      Console.WriteLine("Average");
    }
    else if ((sAmt >= 5000) && (sAmt <= 9999))
    {
      Console.WriteLine("Good");
    }
    else if ((sAmt >= 10000) && (sAmt <= 14999))
    {
      Console.WriteLine("Excellent");
    }
    else if (sAmt >= 15000)
    {
      Console.WriteLine("Outstanding");
    }
  }
}
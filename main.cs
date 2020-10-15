using System;

class MainClass {
  public static void Main (string[] args) {
    AppOne();
    AppTwo();
  }

  public static void AppOne() {
    Console.WriteLine ("Ender radius of cylinder:");
    double radius = Double.Parse(Console.ReadLine());

    Console.WriteLine ("Ender height of cylinder:");
    double height = Double.Parse(Console.ReadLine());

    Console.WriteLine("The calculated volume of the cylinder is equal to " + CylinderVolume(radius, height));
  }

  public static double CylinderVolume(double radius, double height) {
    double volume = 3.14 * radius * radius * height;
    return volume;
  }

  public static void AppTwo() {
    Console.WriteLine("Enter length of first side:");
    double length1 = Double.Parse(Console.ReadLine());

    Console.WriteLine("Enter length of second side:");
    double length2 = Double.Parse(Console.ReadLine());

    Console.WriteLine("The length of the hypotenuse is equal to " + DetermineHypotenuse(length1, length2));
  }

  public static double DetermineHypotenuse(double length1, double length2) {
    return Math.Sqrt((length1 * length1) + (length2 * length2));
  }
}
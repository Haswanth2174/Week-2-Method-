
Main();
void Main()
{
    try
    {
    // Prompting the user to input the length of the rectangle
    Console.WriteLine("Please enter the length of the Rectangle");
    double l = Convert.ToDouble(Console.ReadLine());
    // Prompting the user to input the breadth of the rectangle
    Console.WriteLine("Please enter the breadth of the Rectangle");
    double b = Convert.ToDouble(Console.ReadLine());
    //creted a method to calculate the area of the rectangle
    double area = CalculateArea(l, b);
    Console.WriteLine($"The area of the rectangle is {area}");// displaying the area of the rectangle
    }
    catch (Exception ex)
    {// handling the exception errors
        Console.WriteLine($"The application has the following error.{ex.Message}.Please restart the application...");
    }
}

static double CalculateArea(double l, double b)
{
    double area = l*b;// formula for calculating the area of the rectangle
    return area;
}

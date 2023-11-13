class program
{
static void Main()
{
    Calculate();
}
static void Calculate() 
{
      Console.WriteLine("Calculator");
      Console.WriteLine("----------------------------");
      Console.WriteLine("1.Add");
      Console.WriteLine("2.Substract");
      Console.WriteLine("3.Multiply");
      Console.WriteLine("4.Divide");
      
      Console.Write("Enter Choice(1-4):");
      int operand = Int32.Parse(Console.ReadLine());
      
      int a, b, c;
      
      switch (operand) {
      case 1:
        Console.Write("Enter first number: ");
        a = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter second number: ");
        b = Convert.ToInt32(Console.ReadLine());
        c = a + b;
        Console.WriteLine("result = "+ c);
        break;
      case 2:
        Console.Write("Enter first number: ");
        a = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter second number: ");
        b = Convert.ToInt32(Console.ReadLine());
        c = a - b;
        Console.WriteLine("result = "+ c);
        break;
      case 3:
        Console.Write("Enter first number:");
        a = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter second number:");
        b = Convert.ToInt32(Console.ReadLine());
        c = a * b;
        Console.WriteLine("result = "+ c);
        break;
      case 4:
        Console.Write("Enter first number: ");
        a = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter second number: ");
        b = Convert.ToInt32(Console.ReadLine());
        c = a / b;
        Console.WriteLine("result = "+ c);
        break;
      default:
        Console.WriteLine("Invalid Choice");
        break;
      }
    Console.WriteLine("enter any key to close");
      Console.ReadKey();
    }
}
// See https://aka.ms/new-console-template for more information
using System.IO;
using System.Globalization;

// # 1
var path = ".\\sample.txt";
using var sr = new StreamReader(path);
{
    Console.WriteLine(sr.ReadToEnd());
};

// # 2

try
{
    var input = Int32.Parse(Console.ReadLine());
    if ((input > 1000) ||  (input < 0))
    {
        throw new Exception("Number greater than 1000 or less than 0");
    }
} catch (Exception e)
{
    Console.Error.WriteLine(e.ToString());
}

// # 3
int getAverage(int[] nums)
{
    try
    {
        if (nums.Length == 0){
            throw new Exception("Input Array Empty");
        }
        return nums.Sum() / nums.Length;
    }
    catch (Exception e)
    {
        Console.Error.WriteLine(e.ToString());
        return 0;
    }
}
Console.WriteLine(getAverage([5, 7, 8, 9, 10]));

// # 4
try
{
    var input = Int32.Parse(Console.ReadLine());
    Console.WriteLine($"Number: {input}");
}
catch (FormatException e)
{
    Console.Error.WriteLine(e.ToString());
}
catch (ArgumentNullException e)
{
    Console.Error.WriteLine(e.ToString());
}

// # 5
try
{
    Console.WriteLine("Enter Number: ");
    Console.WriteLine("Type 0 to continue");
    var input = "";
    int[] inputs = [];
    do
    {
        input = Console.ReadLine();
        int num = Int32.Parse(input);
        inputs.Append(num);
    } while (input != "0");
    Console.WriteLine(inputs);
}catch (OverflowException e)
{
    Console.Error.WriteLine(e.ToString());
}
catch (ArgumentNullException e)
{
    Console.Error.WriteLine(e.ToString());
}
catch (FormatException e)
{
    Console.Error.WriteLine(e.ToString());
}

// # 6
int divide (int numA, int numB)
{
    try
    {
        return numA / numB;
    }catch(DivideByZeroException e)
    {
        Console.Error.WriteLine(e.ToString());
        return 0;
    }
}
Console.WriteLine($"Divide: {divide(20, 0)}");

// # 7
try
{
    Console.WriteLine("Enter Date(dd/mm/yyyy):");
    var input = Console.ReadLine();
    DateTime date = DateTime.ParseExact(input, "dd/MM/yyyy", CultureInfo.CurrentCulture);
}catch(FormatException e)
{
    Console.Error.WriteLine();
}

// # 8
try
{
    var input = Double.Parse(Console.ReadLine());
    if(input < 0)
    {
        throw new Exception("Input number is negative");
    }
    Console.WriteLine($"Square root of {input} = {Math.Sqrt(input)}");
}catch(Exception e)
{
    Console.Error.WriteLine(e.ToString());
}

// # 9
string str = Console.ReadLine();
try
{
    str = str.ToUpper();
}catch(NullReferenceException e)
{
    Console.Error.WriteLine(e.Message);
}
Console.WriteLine($"New string: {str}");

// # 10
int getFactorial(int num)
{
    try
    {
        int ret = num;
        if (ret == 1)
        {
            return 1;
        }
        else
        {
            return ret * getFactorial(num - 1);
        }
    }catch(OverflowException e)
    {
        Console.Error.WriteLine(e.ToString());
        return 0;
    }
}
Console.WriteLine($"Factorial of 5 = {getFactorial(5)}");
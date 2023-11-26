using System;
using System.Xml.Linq;

internal class Program
{
    private static void Main(string[] args)
    {
        /*
         
        // Concatenation
        // First Way
        int age = 32;
        string name = "Ammar";
        Console.WriteLine("Hello " + name + " your age is " + age);
        // Second Way
        Console.WriteLine("Hello {0} Your age is {1}", name, age);
        // interpolation
        Console.WriteLine($"Hello {name} your age is {age}");
         
         */

        /*

          // Type Casting
         // 1. implicit casting (automatically) 
         // char -> int -> long -> float -> double
         // from less space to bigger
         // ASCII Code 
         char myChar = 'd';
         int myInt = myChar;
         Console.WriteLine("this is int " + myInt);
         long myLong = 53534;
         double myDouble = myLong;
         Console.WriteLine("this is double " + myDouble);

         // 2. Explicit Casting (Manually)
         // convert a larger type to a smaller size type
         // double -> float -> long -> int -> char
         myInt = (int)myLong;
         Console.WriteLine("my int "+ myInt);
         myInt = (int)myDouble;
         Console.WriteLine("my int " + myInt.GetType());
         string g = Convert.ToString(myChar);
         Console.WriteLine("g= "+g+g.GetType());
         // Convert.
         // 1. ToBoolean()
         // 2. ToInt32()
         // 3. ToString()
         // 4. ToDouble()     
         // 5. ToChar()
         */

        /*
         
        
        // User Input: Console.ReadLine() => string
        // get name and age from user
        Console.Write("Enter Your Name: ");
        string name = Console.ReadLine();
        Console.Write("Enter Your Age: ");
        int age = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter Your Salary: ");
        double salary = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"Hello {name}, And Your Age is {age}, Your Salary is {salary}");
         
         */


        // Operations

        /*
           // Arthimetic Operations

        int x = 30;
        int y = 10;
        int answer = 0;
        // Addition
        answer = x + y;
        Console.WriteLine("answer" + answer);
        // Subtraction
        answer = x - y;
        Console.WriteLine($"x - y = {answer}");
        // Multiplication
        answer = x * y;
        Console.WriteLine($"x * y = {answer}");
        // Division
        answer = x / y;
        Console.WriteLine($"x / y = {answer}");
        // Modulus
        answer = x % y;
        Console.WriteLine($"x % y = {answer}");

        // Increment ++
        // Pre: add then do
        // Post: do then add
        Console.WriteLine($"x= {x++}"); // 30 
        // x = 31
        Console.WriteLine($"x= {++x}"); // x = 32
        Console.WriteLine($"x = {++x}"); // x = 33
        Console.WriteLine($"x = {x++}"); // x = 33 
        // x=34
        Console.WriteLine($"x = {x}"); // x =34
        Console.WriteLine("--------------------------------------------------");
        // Decrement -- 
        Console.WriteLine($"x = {x--}"); // x = 34
        // x = 33
        Console.WriteLine($"x = {--x}"); // x = 32
        Console.WriteLine($"x = {--x}"); // x = 31
        Console.WriteLine($"x = {x--}"); // x = 31
        // x = 30
        Console.WriteLine($"x = {x}"); // x = 30
        Console.WriteLine("--------------------------------------------------");



         
         */

        /*
         
        // Assignment Operations

        int x = 40, y = 20;
        x += 20; // x = x + 20 = 60
        // x = 60
        Console.WriteLine($"x:{x}");
        x -= 20; // x = x - 20 = 40
        // x = 40
        Console.WriteLine($"x:{x}");
        x /= y; // x = x / y = 2
        Console.WriteLine($"x:{x}");
        // x = 2
        x *= y; // x = x * y = 40
        // x = 40
        Console.WriteLine($"x:{x}");
        x %= y; // x = x % y = 0 // 40 % 20 =0
        Console.WriteLine($"x:{x}");
         
         */


        /*
          // Comparison Operation

         // Equal == 
         Console.WriteLine(10 == 3); // Boolean => False
         // Not Equal !=
         Console.WriteLine(10 != 3); // Boolean => True
         // Greater Than >
         Console.WriteLine(10 > 3); // Boolean => True
         // Less Than  <
         Console.WriteLine(10 < 3); // Boolean => False
         // Less Than or Equal <=
         Console.WriteLine(10 <= 9); // Boolean => False
         // Grater Than or Equal >=
         Console.WriteLine(10 >= 9); // Boolean => True
         // Arithmatic  + Comparison
         Console.WriteLine((30 / 10) * 2 > (30 % 12) * 10); // 6 > 60 => False



         */














        // Logical Operations
        int x = 20;
        // and &&
        Console.WriteLine(x < 5 && x < 10);
        // and
        // false and false = false
        // false and true = false
        // true and false = false
        // true and true = true
        // or || 
        Console.WriteLine(x > 5 || x < 4); // true or false  = true
                                           // or 
                                           // false or false = false
                                           // false or true = true
                                           // true or false = true
                                           // true or true = true

        // not !
        Console.WriteLine(!(x < 5 || x < 4)); // !(false or false)=> !(false)=> true
    }
}
internal class Program
{
    private static void Main(string[] args)
    {
        //Data Types
        /*
            1. string => "نصوص"
            2. int => ارقام
            3. [double] fload => ارقام او ارقام كسرية
            4. char => character, رمز او حرف واحد
            5. bool => boolean, true or false
         */
        // Variables
        //  data type varName = value;
        // toys toysBox = toys;

        // this var contain my name
        string myName = "Ammar";
        // output my name to console
        Console.WriteLine(myName);

        // this var contains my salary
        double mySalaryFromDouble = 2000;
        string mySalaryFromString = "2000";

        // I'd like to add sum numbers 
        mySalaryFromDouble = mySalaryFromDouble + 500;
        mySalaryFromString = mySalaryFromString + 500;
        Console.WriteLine(mySalaryFromDouble); // 2000
        Console.WriteLine(mySalaryFromString); // 2000

        // this var contain my first letter 
        char myLetter = ';';
        Console.WriteLine(myLetter);

        // this var contains answer to my question 
        bool areYouGoing;
        areYouGoing = true;
        Console.WriteLine(areYouGoing);

        // naming convintion:
        // 1.اسم ذو معنى 
        // 2.can't start with syobol except (_)
        // 3.four cases for variable naming 
        // camelCase
        // PascalCase
        // snake_case
        // kebab-case

        int _myAge = 20;
        Console.WriteLine(_myAge);

        // Multi variables
        // first form 
        int x = 20;
        int y = 20;
        int z = 20;
        // second form
        int b, c, d;
        b = c = d = 20;

        // concatination
        string name = "Ali";
        int age = 20;
        // First Form Concat
        Console.WriteLine("Hello" + name+ ", your age is "+age);
        // Second Form Concat
        Console.WriteLine("Hello {0}, your age is {1}",age,name); // الواسطة!



    }
}
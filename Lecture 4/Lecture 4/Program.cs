internal class Program
{
    private static void Main(string[] args)
    {

        // Conditions
        // Comparsion Operations
        /*
         * 1. Less than: a < b
         * 2. Less than or equal to: a <= b      
         * 3. Greater than: a>b
         * 4. Greater than or equal to: a >= b
         * 5. Equal to: a == b
         * 6. Not equalto: a!= b
         */
        // If Statement
        /*
         * if (condition) { Block of Code } else { Block of Code }
         */
        if (100 > 20)
        {
            Console.WriteLine("100 is greater than 20");
        }
        else {
            Console.WriteLine("No, 100 is not greater than 20");
        }

        // ------------------------------------------------------------------

        // Else If
        int grades = 90;
        if (grades >= 90)
        {
            Console.WriteLine("Excellent");
        }
        else if (grades >= 80 && grades < 90)
        {
            Console.WriteLine("Very Good");
        }
        else if (grades >= 50 && grades < 80)
        {
            Console.WriteLine("Good");
        }
        else {
            Console.WriteLine("Falid");
        }

        // ------------------------------------------------------------------

        // Nested If
        if (100>60) {
            if (100 > 200) { }
            else {
                if (200 < 300) {
                    Console.WriteLine("if (200 < 300)");
                }
                else {
                    Console.WriteLine("else (200 < 300)");
                } 
            }
        } else {
            Console.WriteLine("Outer else");
        }

        // ------------------------------------------------------------------

        // Ternary Operator
        bool answer = (100>200)?true: false;
        if (answer == true)
        {
            Console.WriteLine("Yes, 100 is greater than 200");
        }
        else {
            Console.WriteLine("No, 100 is not greater than 200");
        }
        // ------------------------------------------------------------------

        // grade program
        Console.Write("Name: ");
        string name = Console.ReadLine();
        Console.Write("Grades: ");
        double grades = Convert.ToDouble(Console.ReadLine());
        if (grades >= 90 && grades <= 100)
        {
            Console.WriteLine($"Name: {name}, Grade Answer: Excellent");
        }
        else if (grades >= 80 && grades < 90)
        {

            Console.WriteLine($"Name: {name}, Grade Answer: Very Good");
        }
        else if (grades >= 50 && grades < 80)
        {
            Console.WriteLine($"Name: {name}, Grade Answer: Good");
        }
        else
        {
            Console.WriteLine($"Name: {name}, Grade Answer: F");
        }




        // Switch

        /*
         Syntax
         switch(x){
            case 1: block of code
             break;

             case 2: block of code
             break;
             ...
             case 100 : block of code
             break;
     }       

         */



        Console.Write("Enter day number: ");
        int day = Convert.ToInt32(Console.ReadLine());

        switch (day)
        {
            case 1:
                Console.WriteLine("Sun");
                break; // exit the switch
            case 2:
                Console.WriteLine("Mon");
                break;
            case 3:
                Console.WriteLine("Tue");
                break;
            case 4:
                Console.WriteLine("Wed");
                break;
            case 5:
                Console.WriteLine("Thur");
                break;
            case 6:
                Console.WriteLine("Fri");
                break;
            case 7:
                Console.WriteLine("Sat");
                break;
            default:
                Console.WriteLine("invalid data");
                break;
        }
    }
}
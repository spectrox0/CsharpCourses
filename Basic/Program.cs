using System;
using System.ComponentModel;
using Microsoft.VisualBasic;
class HelloWord 
{
    static void Main(string[] args) 
    {
        // Hello word
        Console.WriteLine("Hello, C#");

        string myString = "This is a string";
        Console.WriteLine(myString);
        myString = "This is a new string";
        Console.WriteLine(myString);
        int myInt = 3;
        Console.WriteLine(myInt);
        myInt += 4;
        Console.WriteLine(myInt);
        // Float and double, float is 32 bit and double is 64 bit, float fill less memory
        float myFloat = 3.14f;
        Console.WriteLine(myFloat);
        double myDouble = 3.14;
        Console.WriteLine(myDouble);

        //  Can add float and double together
        Console.WriteLine(myDouble + myFloat + myInt);

        //  Dynamic value can change type of value , this is not recomended
        dynamic myDynamic = 100;
        Console.WriteLine(myDynamic);
        myDynamic = "This is a string";
        Console.WriteLine(myDynamic + myDouble);

        string myString2 = "This is a string";

        //  This infers the type of variable
        var myVar = "T";

        Console.WriteLine(myString2 + myVar);
        // Check the type of myVar
        Console.WriteLine(myVar.GetType());

        //  Boolean
        bool myBool = true;
        Console.WriteLine(myBool);

        //  Char
        char myChar = 'a';
        Console.WriteLine(myChar);

        // Interpolation
        Console.WriteLine($"This is my string: {myString2} and this is my int: {myInt}");
        

        // Create constants , the difference with var is that we must assing a type
        const string myConst = "This is a constant";
        Console.WriteLine(myConst);

        //  Structures

        // Arrays
        var myArray = new string[] { "one", "two", "three" };
        Console.WriteLine(myArray);
        var myArray2 = new dynamic[] { "one", 2, "three" };
        Console.WriteLine(myArray2);

        myArray2[1] = "two";

        // Dictionary 
        var myDictionary = new Dictionary<string, int>{
            {"one", 1},
            {"two", 2},
            {"three", 3}
        };
        Console.WriteLine(myDictionary["one"]);



        // Sets

        var mySet = new HashSet<string> { "one", "two", "three" };
        Console.WriteLine(mySet);

        // Tuples
        var myTuple = ("one", 2, "three");
        Console.WriteLine(myTuple);

        //  Loops 

        for (int i =0; i < 10; i++)
        {
            Console.WriteLine(i);
        }

        // Foreach
        foreach(var item in myArray)
        {
            Console.WriteLine(item);
        }

        foreach (var item in myDictionary) {
            Console.WriteLine(item);
        }
        foreach (var item in mySet) {
            Console.WriteLine(item);
        }


        // Flow control
        if (myInt == 3 && myBool)
        {
            Console.WriteLine("myInt is 3");
        }
        else if (myInt == 4)
        {
            Console.WriteLine("myInt is 4");
        }
        else
        {
            Console.WriteLine("myInt is not 3 or 4");
        }

        //  Switch
        switch(myInt)
        {
            case 3:
                Console.WriteLine("myInt is 3");
                break;
            case 4:
                Console.WriteLine("myInt is 4");
                break;
            default:
                Console.WriteLine("myInt is not 3 or 4");
                break;
        }
    // Functions
    myFunction();
    static void myFunction()
    {
    Console.WriteLine("This is my function");
    }
    Console.WriteLine(myFunctionWithReturn(3));

    static int myFunctionWithReturn(int param) {
            return 10 * param;
    }

    var instance = new MyClass("Alejandro Velazco");

    Console.WriteLine(instance.MyName);

    }

    class MyClass 
    {
        public string MyName { get; set; }
        // Constructor
        public MyClass(string MyName)
        {
            this.MyName = MyName;
        }
    }

}

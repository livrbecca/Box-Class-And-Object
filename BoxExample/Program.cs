using System;

namespace YTCC1
{
    class Program
    // class: blueprint for a data-type. allows you to define your own DT
    // which can be a combination of other base types (string, int, ect) and methods
    {
        static void Main(string[] args)
        {
            // to use Box datatype: we want a variable that represents Box
            // create/initialize Object of class type Box
            Box boxObject = new Box(); // box = new instance of Box, it is now an object,not a variable

            Console.WriteLine("Enter a length: ");
            double n1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter a breadth: ");
            double n2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter a Height: ");
            double n3 = double.Parse(Console.ReadLine());


            // doing boxObject. shows the properties you have access to
            boxObject.Length = n1; // SETTING the values (thanks to {get; set;})
            boxObject.Breadth = n2;
            boxObject.Height = n3;
            double volume = boxObject.getVolume();
            double area = boxObject.getArea();
            // example of 'get' / getting: because you are viewing the values
            Console.WriteLine($"Box dimensions are:  {boxObject.Length}, {boxObject.Breadth}, {boxObject.Height}\nthe volume is {volume}\nthe area is {area}");



            // INITIALIZNG A NEW BOX OBJECT: can have multiple objects of the same data type long as names are diff
            Box boxObj2 = new Box();


            Console.WriteLine("Enter a length: ");
            n1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter a breadth: ");
            n2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter a Height: ");
            n3 = double.Parse(Console.ReadLine());


            // doing boxObject. shows the properties you have access to
            boxObj2.Length = n1; // SETTING the values (thanks to {get; set;})
            boxObj2.Breadth = n2;
            boxObj2.Height = n3;
            //volume = boxObj2.getVolume();
            //area = boxObj2.getArea();
            // instead of declaring variables, call the methods in the formatted string

            Console.WriteLine($"Second Box dimensions are:  {boxObj2.Length}, {boxObj2.Breadth}, {boxObj2.Height}\nthe volume is {boxObj2.getVolume()}\nthe area is {boxObj2.getVolume()}");


        }
    }

}
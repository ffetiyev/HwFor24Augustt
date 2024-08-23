using Hw24Aug;


 Console.WriteLine("choose one of the options:\r\n1. Square\r\n2. Rectangular\r\n0. Quit");

error1:int option = Convert.ToInt32(Console.ReadLine());

if (option == 1)
{  
    Console.WriteLine("Enter the side of Square:");
    Square square1 = new Square()
    {
     side = Convert.ToInt32(Console.ReadLine()),
    };

    Console.WriteLine( "Area of square is:" + square1.CalcArea());
}

if (option == 2)
{
    Console.WriteLine("Enter the length of Rectangular:");

    Rectangular rectangular1 = new Rectangular();
    rectangular1.length = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Enter the width of Rectangular:");
    rectangular1.width = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Area of rectangular is:" + rectangular1.CalcArea());
}
 if(option == 0)
    {
    Console.WriteLine("Program is finished");
    }
 if (option != 1 && option != 2 && option != 0)
    {
    Console.WriteLine("choose valid option");
        goto error1;
    }



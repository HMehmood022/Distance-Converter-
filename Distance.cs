using System;//allows us to take advantage of the system library, for example WriteLine etc.


namespace Distance{//namespace keyword is used to organise code elements.
    public class DistanceConverter//our public class
{  
    public static void Main()//our main method
    {
         Console.WriteLine(Console.ForegroundColor);//used to change the colour of our console output text.
        Console.ForegroundColor
            = ConsoleColor.Red;// The console shall output text in red colour.

        double miles;// this is our integar for miles.
        double convertedMiles; // this is our integar for the converted miles.
        double feet; // this is our integar for feet.
        double convertedFeet; // this is the integar for our converted feet output.
        double meters; // this is the integar for our meters.
        double convertedMeters; // this is the integar for our converted meters.


        Console.WriteLine(" Welcome to Hishaam's Distance converter! "); // this is the opening message of the application;
        Console.WriteLine(" ---------------------------------------- ");

        Console.WriteLine(" Please enter an option number: "); // the user is asked to enter their option number.
        Console.WriteLine(" ---------------------------------------- ");

        Console.WriteLine(" 1 - Miles to Feet. ");// the user is presented with a list of choices along with their respective numbers.
        Console.WriteLine(" 2 - Feet to Miles. ");
        Console.WriteLine(" 3 - Miles to Meters. ");

        Console.WriteLine(" ---------------------------------------- ");
        int choice = int.Parse(Console.ReadLine()); //this is our choice integar, it will be used for our switch statement.

    // A switch statement is used for our menu choices. If the user enters a number between 1-3 they are met with an output.
    switch(choice)  
    {
    case 1: //this is the first choice- Miles to feet.

        Console.WriteLine( " Please enter the amount of miles you wish to convert to feet: " );
        miles = Convert.ToDouble((Console.ReadLine()));// Double is used in order to allow decimal numbers.
        convertedMiles = (miles*5280);//this is the formula used to convert miles to feet.
        Console.WriteLine( "The number of miles you have input is equivalent to " + convertedMiles + " feet. " ); //The text along with result is displayed.

        break;

    case 2: // this is the second choice- feet to miles.

        Console.WriteLine( " Please enter the amount of feet you wish to convert to miles: "); 
        feet = Convert.ToDouble((Console.ReadLine()));
        convertedFeet = (feet/5280);//this is the formula used to convert feet to miles.
        Console.WriteLine( "The number of miles you have input is equivalent to " + convertedFeet + " miles. "); //The text is displayed along with the result of the formula.

        break;

    case 3: //this is the final choice- miles to meters.

        Console.WriteLine( " Please enter the amount of miles you wish to convert to meters: ");
        meters = Convert.ToDouble((Console.ReadLine()));
        convertedMeters = (meters*1609);
        Console.WriteLine( "The number of miles you have input is equivalent to " + convertedMeters + " meters. "); //The text is displayed along with the result of the formula.

    break;


        
    




    }


}






}
}


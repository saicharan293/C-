//0 - 10 cost 2rs per unit
//10 - 50 cost 20rs per unit
//> 50 cost is 50rs per unit

//int amount = 0;
//int reading;


//do
//{
//    Console.Write("Enter the number of units: ");
//    reading = int.Parse(Console.ReadLine());
//    if(reading <= 10)
//    {
//        amount = reading * 2;
//    }else if (reading <= 50)
//    {
//        amount = 20 + (20 * (reading - 10));
//    }
//    else
//    {
//        amount = 100 + (50 * (reading - 50));
//    }
//    Console.WriteLine("No of units: " + reading + " and its charge: " + amount + " rs");


//} while (reading != 0 );
int amount = 0;
int reading;

do
{
    Console.Write("Enter the number of units: ");
    reading = int.Parse(Console.ReadLine());
    switch (reading)
    {
        case <= 0:
            Console.WriteLine("Please enter proper input value ");
            break;
        case <= 10:
        default:
            amount = 2 * reading;
            Console.WriteLine("No of units: " + reading + " and its charge: " + amount);
            break;
        case <= 50:
            amount = 20 + (20 * (reading - 10));
            //40-- 20 + 20*(40-10)=2*10+20*30=20
            //20-- 20 + 20*(20-10)=2*10+20*10
            //50-- 20 + 20*(50-10)=2*10+20*40
            Console.WriteLine("No of units: " + reading + " and its charge: " + amount);
            break;
        case > 50:
            //100 is the unit value upto 50
            amount = 100 + (50 * (reading - 50));
            //71 = 100 + (50)21=1150
            Console.WriteLine("No of units: " + reading + " and its charge: " + amount);
            break;

    }
} while (reading > -1);


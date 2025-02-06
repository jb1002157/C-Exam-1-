
int counter = 1;
int number1 = 249107;
int number2 = 249107;
int number3 = 249107;
int number4 = 249107;
int number5 = 249107;
int number6 = 249107;
int number7 = 249107;
int number8 = 249107;
int number9 = 249107;
int number10 = 249107;
while (counter < 11)
{
    Console.WriteLine("Enter number " + counter);

    int number = Convert.ToInt32(Console.ReadLine());
    if (counter == 1)
    {
        number1 = number;
    }
    else if (counter == 2)
    {
        number2 = number;
    }
    else if (counter == 3)
    {
        number3 = number;
    }
    else if (counter == 4)
    {
        number4 = number;
    }
    else if (counter == 5)
    {
        number5 = number;
    }
    else if (counter == 6)
    {
        number6 = number;
    }
    else if (counter == 7)
    {
        number7 = number;
    }
    else if (counter == 8)
    {
        number8 = number;
    }
    else if (counter == 9)
    {
        number9 = number;
    }
    else
    {
        number10 = number;
    }
    counter++;
};
int largestnumber = number1;
if (number1 < number2)
{
    largestnumber = number2;
}
if (largestnumber < number3)
{
    largestnumber = number3;
}
if (largestnumber < number4)
{
    largestnumber = number4;
}
if (largestnumber < number5)
{
    largestnumber = number5;
}
if (largestnumber < number6)
{
    largestnumber = number6;
}
if (largestnumber < number7)
{
    largestnumber = number7;
}
if (largestnumber < number8)
{
    largestnumber = number8;
}
if (largestnumber < number9)
{
    largestnumber = number9;

}
if (largestnumber < number10)
{
    largestnumber = number10;
}
Console.WriteLine("Your inputs:");
Console.WriteLine(number1);
Console.WriteLine(number2);
Console.WriteLine(number3);
Console.WriteLine(number4);
Console.WriteLine(number5);
Console.WriteLine(number6);
Console.WriteLine(number7);
Console.WriteLine(number8);
Console.WriteLine(number9);
Console.WriteLine(number10);
Console.WriteLine("Largest input =" + largestnumber);
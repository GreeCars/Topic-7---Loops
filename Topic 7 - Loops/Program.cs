// See https://aka.ms/new-console-template for more information
using System.Reflection.Emit;

bool done = false; // We can set this to ‘true’ to end the loop
int entry = 12345, tries = 0, pin = 0;
Console.WriteLine("WELCOME TO THE BANK OF ALDWORTH.");
while (!done)
{
    Console.WriteLine("ENTER YOUR PIN: ");
    while (!Int32.TryParse(Console.ReadLine(), out pin))
        Console.WriteLine("Please enter a valid number");
    tries++;
    if (pin == entry)
    {
        Console.WriteLine("Pin Accepted.");
        done = true; // This ends the loop
    }
    else if (tries == 5)
    {
        Console.WriteLine("Too many incorrect tries. Access denied");
        done = true; // This ends the loop
    }
}

int age;
while (!int.TryParse(Console.ReadLine(), out age))
    Console.WriteLine("Please enter a valid number.");
Console.WriteLine();

Random generator = new Random();
int guess = 0, secretNumber;
secretNumber = generator.Next(1, 11);

while (guess != secretNumber)
{
    Console.WriteLine("Please guess the secret number.  It could be anything from 1 to 10.");
    guess = Convert.ToInt32(Console.ReadLine());

    if (guess == secretNumber)
        Console.WriteLine("Congradulations, you guessed it!!");
    else
        Console.WriteLine("Sorry but no.");
    Console.WriteLine();
}
Console.WriteLine();

int num1 = 1, num2 = 0;
int total;

Console.WriteLine("Hit ENTER to roll the dice.");
Console.ReadLine();
while (num1 != num2)
{
    num1 = generator.Next(1, 7);
    num2 = generator.Next(1, 7);
    total = num1 + num2;
    Console.WriteLine("Die 1 - " + num1);
    Console.WriteLine("Die 2 - " + num2);
    Console.WriteLine("Total - " + total);
    Console.WriteLine();
}
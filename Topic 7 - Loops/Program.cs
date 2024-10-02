// See https://aka.ms/new-console-template for more information
using System;
using System.Reflection.Emit;

bool done = false; // We can set this to ‘true’ to end the loop
int entry = 12345, tries = 0, pin = 0, maxTries = 5;
Console.WriteLine("WELCOME TO THE BANK OF ALDWORTH.");
while (!done)
{
    Console.WriteLine("ENTER YOUR PIN: ");
    Console.WriteLine(maxTries + " tries left.");
    while (!Int32.TryParse(Console.ReadLine(), out pin))
        Console.WriteLine("Please enter a valid number");
    tries++;
    maxTries--;
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
int guess = 0, secretNumber, guessTries = 0;
secretNumber = generator.Next(1, 11);

while (guess != secretNumber && guessTries < 5)
{
    Console.WriteLine("Please guess the secret number.  It could be anything from 1 to 10.");
    guess = Convert.ToInt32(Console.ReadLine());
    guessTries++;

    if (guess == secretNumber)
        Console.WriteLine("Congradulations, you guessed it!!");
    else if (guessTries == 5)
    {
        Console.WriteLine("Sorry, too many tries.");
    }
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

int count = 0, displayCount; // This will count the number of times we have looped
Console.WriteLine("How many times do you want me to display?");
displayCount = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Type in a message, and I'll display it multiple times.");
Console.Write("Message: ");
string message = Console.ReadLine();
while (count < displayCount)
{
    Console.WriteLine((count * 10) + ". " + message);
    count += 1; // Adds 1 to our counter
}
Console.WriteLine();

int totalTask = 0;
int countTask = 0;
int numbers = 5; // User will enter this many numbers.
int input;

Console.WriteLine("You will be prompted to enter 5 numbers and I will add them for you.");
while (count < numbers)
{
    Console.WriteLine("Please enter a number:");
    input = Convert.ToInt32(Console.ReadLine());
    totalTask += input; // Adds the entered number to the running total
    countTask++; // Increases our counter so we know how many values have been read in
}
Console.WriteLine();
Console.WriteLine("The total is: " + totalTask);
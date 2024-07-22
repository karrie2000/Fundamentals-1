// See https://aka.ms/new-console-template for more information
using System.Reflection.Metadata.Ecma335;

// Console.WriteLine("Hello, World!");

for (var i = 0; i <= 255; i++)
{
    Console.WriteLine(i);
}

var sum = 0;
for(var i=0; i < 5;
i++)
{
Random rand = new Random();
 var randomNum = rand.Next(10, 20);
 sum += randomNum;
    Console.WriteLine($"This is a random number: {randomNum}");

    }
     Console.WriteLine($"This is the sum of random numbers: {sum}");
    



for (var i = 1; i <= 100; i++)
{
    if
    (
        i % 3 == 0 && i % 5 != 0 
        )
        {
            Console.WriteLine( $" This is only a dividen of 3: {i} Fizz!");
           

        }
        else if
        (
            i % 5 == 0 && i % 3 != 0
            )
        {
             Console.WriteLine( $" This is only a dividen of 5: {i} Buzz!");
    
        }
        else if
        (
            i % 5 == 0 && i % 3 == 0
            )
        {
             Console.WriteLine( $" This is a dividen of 3 nd  5: {i} FizzBuzz!");
}
}



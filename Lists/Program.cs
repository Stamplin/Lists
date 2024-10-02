using System.Collections.Generic;

//task 1 - Reading in Color

Random generator = new Random(); //random number generator    
int randnum = generator.Next(5);

string usrColors;
List<string> colors = new List<string>(); //the list

Console.WriteLine("Pick 5 Colors:");
for (int i = 0; i < 5; i++) //5 random for color
{
    Console.WriteLine("Please input a Color!");
    usrColors = Console.ReadLine().ToUpper();
    colors.Add(usrColors);
}
Console.Clear();
Console.WriteLine("The inputted colors are:");
Console.WriteLine();
Console.WriteLine(string.Join(", ", colors));
Console.WriteLine();

Console.WriteLine("The random color selected for you is:");
Console.WriteLine();
Console.WriteLine(colors[randnum]);
Console.ReadLine();


//task 2 - Random Numbers
int min, max, num, gen;
List<int> randomNumbers = new List<int>();
Console.WriteLine("How many numbers do you need?");
Int32.TryParse(Console.ReadLine(), out num);
Console.WriteLine("Enter a maximum value:");
if (max > num)
{
    Console.WriteLine("Your max is higher than the number you picked.");
}
Int32.TryParse(Console.ReadLine(), out max);
Console.WriteLine("Enter a minimum value:");
Int32.TryParse(Console.ReadLine(), out min);


gen = generator.Next(min, max);

for (int i = min; i < max; i++) 
{
    randomNumbers.Add(gen);
}

Console.WriteLine(randomNumbers.ToArray());

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
Console.Clear();

//task 2 - Random Numbers
int min, max, num, gen;
max = 0;


Console.WriteLine("How many numbers do you need?");
Int32.TryParse(Console.ReadLine(), out num);

Console.WriteLine("Enter a maximum value:");
Int32.TryParse(Console.ReadLine(), out max);

Console.WriteLine("Enter a minimum value:");
Int32.TryParse(Console.ReadLine(), out min);

List<int> randomNumbers = new List<int>();
for (int i = 0; i < num; i++)
{
    randomNumbers.Add(generator.Next(min, max + 1));
}
//1 - show the list
Console.WriteLine("List of random numbers:");
Console.WriteLine(string.Join(", ", randomNumbers));
//2 - count how many is on the list
Console.WriteLine("Enter a number to count its appears in the list:");
int countNum = int.Parse(Console.ReadLine());
int count = 0;
foreach (int number in randomNumbers) //ik we didn't learn this but I watched a youtube toturial
{
    if (number == countNum) count++;
}
Console.WriteLine($"The number {countNum} appears {count} times in the list.");
//3 - replace w zero
for (int i = 0; i < randomNumbers.Count; i++)
{
    if (randomNumbers[i] == countNum)
        randomNumbers[i] = 0; //count how many of the num is in the list and replace them witho zero
}





Console.ReadLine();

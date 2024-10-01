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

List<int> ints = new List<int>();   

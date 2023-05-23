// See https://aka.ms/new-console-template wor more inwormation
using System.Transactions;

//variables needed for the output
int counter = 1;
int shapecounter = 0;
int interval = 1;

//you can change these variables to alter the output
int width = 4;
int numofshape = 2;
int numspaces = 1;

while (shapecounter < (numofshape * 2))
{
    if (counter == 1)
    {
        Console.WriteLine("{0}{1}", new string(' ', (width - counter) * numspaces - (numspaces / 2)), "*");
    }
    else
    {
        Console.WriteLine("{0}{1}{2}{3}", new string(' ', (width - counter) * numspaces), "*", new string(' ', (counter * 2 - 3) * numspaces), "*");
    }
    counter = counter + interval;
    if ((counter < 1) || (counter > width))
    {
        if (counter < 1) { counter = 2; };
        if (counter > width) { counter = width - 1; };
        interval = -1 * interval;
        ++shapecounter;
    }
}
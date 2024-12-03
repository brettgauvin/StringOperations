// Take a string and capitalize every other letter

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

string name = "Brett Gauvin";

string staggeredLetters = skyLineConvert(name);

static string skyLineConvert(string name)
{
    string x = "";
    for (int i = 0; i < name.Length; i++)
    {
        if (i % 2 == 0)
        {
            // even value for i
            x += name[i].ToString().ToUpper();
        }
        else
        {
            // odd value for i
            x += name[i].ToString().ToLower();
        }
    }
    return x;
}

Console.WriteLine($"{name} in skyline format is {staggeredLetters}");
Console.ReadLine();
Console.WriteLine("--------------------------------------------------------------------");


// Reverse a string
string backwards = reverse(name);

static string reverse(string name)
{
    string reverseString = "";

    // reverse for loop. count from end of name to the beginning
    for (int i = name.Length -1; i >= 0; i--)
    {
        reverseString += name[i].ToString();
    }

    return reverseString;
}

Console.WriteLine($"{name} spelled backwards is {backwards}");
Console.ReadLine();
Console.WriteLine("--------------------------------------------------------------------");

// Swap letters
string startingString = "Following the light of the sun, we left the Old World";

char[] endingString = startingString.ToCharArray();

var dict = new Dictionary<char, char>();

dict.Add('a', '@');
dict.Add('e', '#');
dict.Add('i', '!');
dict.Add('o', '0');
dict.Add('u', '^');

Console.WriteLine("Here are the character substitutions");

foreach (var item in dict)
{
    Console.WriteLine(item);
}

for (int i = 0; i < startingString.Length; i++)
{
    if (dict.ContainsKey(startingString[i]))
    {
        endingString[i] = dict[startingString[i]];
    }
}

Console.WriteLine(startingString);
Console.WriteLine(endingString);
Console.ReadLine();

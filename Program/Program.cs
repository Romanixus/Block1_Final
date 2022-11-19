string[] arrayString = { "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten" };

var list = new List<string>();

for (int i = 0; i < arrayString.Length; i++)
{
    if (arrayString[i].Length <= 3)
    {
        list.Add(arrayString[i]);
    }
}

string[] newArrayString = list.ToArray();

for (int i = 0; i < newArrayString.Length; i++)
    {
        Console.Write($"{newArrayString[i]} ");
    }
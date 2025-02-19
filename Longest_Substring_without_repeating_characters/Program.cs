
//Input: "abcabcbb" find the longest substring without repeating characters.
//Output: The longest substring is "abc".

string input = "abcabcbb";
List<string> substrings = new List<string>();
for (int i = 0; i < input.Length; i++)
{
    string substring = "";
    for (int j = i; j < input.Length; j++)
    {
        if (substring.Contains(input[j]))
        {
            break;
        }
        substring += input[j];
    }
    substrings.Add(substring);

}
var a = substrings.OrderByDescending(x => x.Length).FirstOrDefault();
Console.WriteLine($"The longest substring is \"{a}\".");
Console.ReadLine();
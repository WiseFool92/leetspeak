using System;
using System.Text.RegularExpressions;

namespace LeetSpeak
{
  public class LeetSpeakTranslate
  {
    public string LeetSpeakConverter(string userEntry)
    {
      char[] charArray = userEntry.ToCharArray();

      for (int i = 0; i < charArray.Length; i++)
      {
        if (charArray[i] == 'e' || charArray[i] == 'E')
        {
          charArray[i] = '3';
        }
        else if (charArray[i] == 'o' || charArray[i] == 'O')
        {
          charArray[i] = '0';
        }
        else if (charArray[i] == 'I')
        {
          charArray[i] = '1';
        }
        else if (charArray[i] == 't' || charArray[i] == 'T')
        {
          charArray[i] = '7';
        }
        else if (charArray[i] == 's')
        {
          if (Regex.IsMatch(charArray[i-1].ToString(), @"^[a-zA-Z]+$") && i != 0)
          {
            charArray[i] = 'z';
          }
        }
      }

      string transformedString = string.Join("", charArray);
      return transformedString;
    }
    public static void Main()
    {
      Console.WriteLine("Enter a sentence to translate to leetspeak!");
      string userInput = Console.ReadLine();
      LeetSpeakTranslate userTransformation = new LeetSpeakTranslate();
      string finalAnswer = userTransformation.LeetSpeakConverter(userInput);
      Console.WriteLine(finalAnswer);
    }
  }
}
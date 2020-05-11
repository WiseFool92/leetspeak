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
          if (charArray[i-1] != ' ')
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

    }
  }
}
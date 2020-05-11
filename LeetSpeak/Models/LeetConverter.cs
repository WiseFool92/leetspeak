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
      }

      string transformedString = string.Join("", charArray);
      return transformedString;
    }
    public static void Main()
    {

    }
  }
}
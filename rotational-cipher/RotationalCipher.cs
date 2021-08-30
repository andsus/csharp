using System.Linq;
using System.Text;

public static class RotationalCipher
{
    private static int ALPHABET_SIZE = 26;
    public static string Rotate(string text, int shiftKey) =>
        string.Concat(text.Select(c => Rotate(c, shiftKey)));


    private static char Rotate(char c, int shiftKey)
    {
        if (!char.IsLetter(c))
            return c;
        int firstChar = char.IsLower(c) ? 'a' : 'A';
        return (char)(firstChar + ((c - firstChar + shiftKey) % ALPHABET_SIZE));
    }

}
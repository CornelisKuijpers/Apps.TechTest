using ReverseString.Interfaces;

namespace ReverseString
{
    public class StringManupulation : IStringManupulation
    {
        public string ReverseString(string value)
        {
            char[] charArray = value.ToCharArray();
            // creating character array of size
            // equal to length of string
            char[] temp = new char[charArray.Length];
            int x = 0;
            for (int i = 0; i < charArray.Length; i++)
            {
                if ((charArray[i] >= 'a' && charArray[i] <= 'z')
                    || (charArray[i] >= 'A' && charArray[i] <= 'Z'))
                {
                    // storing elements in array
                    temp[x] = charArray[i];
                    x++;
                }
            }

            // reversing the character array
            reverse(temp, 0, x);
            x = 0;
            for (int i = 0; i < charArray.Length; i++)
            {
                if (charArray[i] >= 'a' && charArray[i] <= 'z'
                    || charArray[i] >= 'A' && charArray[i] <= 'Z')
                {
                    // updating the origional string
                    charArray[i] = temp[x];
                    x++;
                }
            }

            return new string(charArray);
        }

        private static void reverse(char[] charArray, int l, int r)
        {
            for (int i = l; i < r / 2; i++)
            {
                char temp = charArray[i];
                charArray[i] = charArray[r - 1 - i];
                charArray[r - 1 - i] = temp;
            }
        }
    }
}
using System;

namespace LatihanDasar
{
    class Polindrome
    {
        public static void Main(string[] args)
        {
            string[] kata;
            string kalimat = "katak itu di makam atau di buru";
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("CheckPolindrome");
            kata = kalimat.Split(new char[] { ' ', '.', ',' }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < kata.Length; i++)
            {
                checkPalindrome(kata[i]);
            }
            Console.ReadLine();
        }
        public static string checkPalindrome(string text)
        {
            int l = 0;
            int r = text.Length - 1;
            int flag = 0;
            while (r > l)
            {
                if (text[l] != text[r])
                {
                    flag = 1;
                    break;
                }
                l++;
                r--;
            }
            if (flag == 0)
            {
                Console.WriteLine(text + " : is a Polindrome");
            }
            else
            {
                Console.WriteLine(text + " : is NOT a Polindrome");
            }
            return text;
        }
    }
}

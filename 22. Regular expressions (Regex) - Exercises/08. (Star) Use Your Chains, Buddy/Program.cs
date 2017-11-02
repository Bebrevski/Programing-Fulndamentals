namespace UseYourChainsBuddy
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Text.RegularExpressions;

    class Chains
    {
        static void Main()
        {
            StringBuilder r = new StringBuilder();

            string pattern = @"(?<=<p>).*?(?=<\/p>)";

            string html = Console.ReadLine();

            MatchCollection matches = Regex.Matches(html, pattern);

            foreach (Match m in matches)
            {
                StringBuilder t = new StringBuilder();
                string v = m.Value;

                for (int i = 0; i < v.Length; i++)
                {
                    if (char.IsLower(v[i]) || char.IsDigit(v[i]))
                    {
                        t.Append(v[i]);
                    }
                    else
                    {
                        t.Append(" ");
                    }
                }

                char[] temp = Regex.Replace(t.ToString(), @"\s+", " ").ToCharArray();

                for (int i = 0; i < temp.Length; i++)
                {
                    if (temp[i] >= 'a' && temp[i] <= 'm')
                    {
                        temp[i] = (char)(temp[i] + 13);
                    }
                    else if (temp[i] > 'm' && temp[i] <= 'z')
                    {
                        temp[i] = (char)(temp[i] - 13);
                    }
                }

                r.Append(new string(temp));
            }

            Console.WriteLine(r);
        }
    }
}
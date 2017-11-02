using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Hornet_Comm
{
    class PrivateMessage
    {
        public string RecipientCode { get; set; }
        public string Message { get; set; }
    }
    class Broadcast
    {
        public string Frequency { get; set; }
        public string Message { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<PrivateMessage> privateMessage = new List<PrivateMessage>();
            List<Broadcast> broadcast = new List<Broadcast>();

            Regex privatePattern = new Regex(@"^([0-9]+) \<\-\> ([a-zA-Z0-9]+)$");
            Regex broadcastPattern = new Regex(@"^([^0-9]+) \<\-\> ([a-zA-Z0-9]+)$");

            string input = Console.ReadLine();

            while (!input.Equals("Hornet is Green"))
            {
                if (privatePattern.IsMatch(input))
                {
                    //Задължително с друпи - иначе дава грешки!!!!!!!!!!!!!!

                    Match match = privatePattern.Match(input);

                    string recipientCode = match.Groups[1].Value;
                    string message = match.Groups[2].Value;

                    string newCode = string.Empty;

                    for (int i = recipientCode.Length - 1; i >= 0; i--)
                    {
                        newCode += recipientCode[i];
                    }

                    PrivateMessage current = new PrivateMessage()
                    {
                        RecipientCode = newCode,
                        Message = message
                    };

                    privateMessage.Add(current);

                }
                else if (broadcastPattern.IsMatch(input))
                {
                    Match match = broadcastPattern.Match(input);

                    string message = match.Groups[1].Value;
                    string frequency = match.Groups[2].Value;

                    string newFreq = string.Empty;

                    for (int i = 0; i < frequency.Length; i++)
                    {
                        char currentChar = frequency[i];

                        if (currentChar >= 'a' && currentChar <= 'z')
                        {
                            newFreq += (char)(currentChar - ' ');
                        }
                        else if (currentChar >= 'A' && currentChar <= 'Z')
                        {
                            newFreq += (char)(currentChar + ' ');
                        }
                        else
                        {
                            newFreq += currentChar;
                        }
                    }

                    Broadcast current = new Broadcast()
                    {
                        Frequency = newFreq,
                        Message = message
                    };

                    broadcast.Add(current);
                }

                input = Console.ReadLine();
            }

            Console.WriteLine("Broadcasts:");

            if (broadcast.Count.Equals(0))
            {
                Console.WriteLine("None");
            }

            foreach (Broadcast line in broadcast)
            {
                Console.WriteLine("{0} -> {1}"
                    , line.Frequency
                    , line.Message);
            }

            Console.WriteLine("Messages:");

            if (privateMessage.Count.Equals(0))
            {
                Console.WriteLine("None");
            }

            foreach (PrivateMessage line in privateMessage)
            {
                Console.WriteLine("{0} -> {1}"
                    , line.RecipientCode
                    , line.Message);
            }

            //THE COOL WAY - WITH LINQ AND TERNARY OPERATOR
            //Console.WriteLine(messages.Any() ? string.Join("\n", messages) : "None");
        }
    }
}

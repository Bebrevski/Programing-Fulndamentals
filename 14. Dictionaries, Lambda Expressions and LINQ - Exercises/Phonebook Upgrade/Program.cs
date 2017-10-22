using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phonebook
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, string> phonebook = new SortedDictionary<string, string>();

            string input = Console.ReadLine();

            while (!input.Equals("END"))
            {
                string[] tokens = input.Split();

                string command = tokens[0];

                if (command.Equals("A"))
                {
                    string name = tokens[1];
                    string phone = tokens[2];

                    if (!phonebook.ContainsKey(name))
                    {
                        phonebook.Add(name, string.Empty);
                    }

                    phonebook[name] = phone;

                }
                else if (command.Equals("S"))
                {
                    string name = tokens[1];

                    if (phonebook.ContainsKey(name))
                    {
                        Console.WriteLine("{0} -> {1}"
                            , name, phonebook[name]);
                    }
                    else
                    {
                        Console.WriteLine("Contact {0} does not exist.", name);
                    }
                }
                else if (command.Equals("ListAll"))
                {
                    foreach (KeyValuePair<string,string> contact in phonebook)
                    {
                        Console.WriteLine("{0} -> {1}"
                            ,contact.Key
                            ,contact.Value);
                    } 
                }

                input = Console.ReadLine();
            }
        }
    }
}

using System;
using System.IO;

namespace DNS_Checker
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insert DNS record");
            string s = Console.ReadLine();
            bool found = false;

            if (File.ReadAllText("latestdomains.txt").Contains(s))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("There is a match");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else if (File.ReadAllText("Malware.txt").Contains(s))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("There is a match");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else if (File.ReadAllText("malware-nl.txt").Contains(s))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("There is a match");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else if (File.ReadAllText("notrack-malware.txt").Contains(s))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("There is a match");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else if (File.ReadAllText("phishing_army_blocklist_extended.txt").Contains(s))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("There is a match");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else if (File.ReadAllText("phishing-nl.txt").Contains(s))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("There is a match");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else if (File.ReadAllText("Prigent-Phishing.txt").Contains(s))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("There is a match");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else if (File.ReadAllText("ransomware-nl.txt").Contains(s))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("There is a match");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else if (File.ReadAllText("urlhaus.abuse.ch.txt").Contains(s))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("There is a match");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else if (File.ReadAllText("urlhaus-filter-domains.txt").Contains(s))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("There is a match");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("No match found");
                Console.ForegroundColor = ConsoleColor.White;
            }
        }
    }
}

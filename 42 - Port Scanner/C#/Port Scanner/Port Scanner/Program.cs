using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Text.RegularExpressions;
using System.Text;
using System.Threading.Tasks;

namespace Port_Scanner
{
    class Program
    {
        static void Main(string[] args)
        {
            // Regex patterns to match IP and Hostname
            var ValidIP = @"^(([0-9]|[1-9][0-9]|1[0-9]{2}|2[0-4][0-9]|25[0-5])\.){3}([0-9]|[1-9][0-9]|1[0-9]{2}|2[0-4][0-9]|25[0-5])$";
            var ValidHostname = @"^(([a-zA-Z0-9]|[a-zA-Z0-9][a-zA-Z0-9\-]*[a-zA-Z0-9])\.)*([A-Za-z0-9]|[A-Za-z0-9][A-Za-z0-9\-]*[A-Za-z0-9])$";

            // List to store open ports
            List<string> openPortList = new List<string>();

            // Obtain and validate address input
            Console.Write("Enter an address to scan: ");
            string address = Console.ReadLine();
            while (!Regex.IsMatch(address, ValidIP) && !Regex.IsMatch(address,ValidHostname))
            {
                Console.WriteLine("Please enter a valid hostname or IP Address");
                Console.Write("Enter an address to scan: ");
                address = Console.ReadLine();
            }

            Console.WriteLine("Scanning address, please wait...");


            TcpClient tcpClient = new TcpClient();
            Ping p = new Ping();
            
            if (p.Send(address) != null) // Ensure host is online
            {
                for (int i = 1; i < 65535; i++) // Scan entire port range
                {
                    try
                    {
                        Console.WriteLine("Checking port {0}", i);
                        tcpClient.Connect(address, i);
                        openPortList.Add(address + ":" + i.ToString() + " is open!");
                    } catch (Exception) { }
                    
                }
            }

            // Print results to screen
            Console.Clear();
            foreach (string s in openPortList)
                Console.WriteLine(s);

            Console.Read();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        public static string IP { get; private set; }
        public static int portnum { get; private set; }
        public static string name { get; private set; }
        static void Main(string[] args)
        {
            bool end;
            string qest_end;

            Console.WriteLine("Test APC SNMP Config Creator\r");
        Start:
            Console.WriteLine("\r");
            ip_get();
            portnum_get();
            name_get();
            clac();





            //End Code
            Console.WriteLine("Do you want to exit? Y/N");
            qest_end = Console.ReadLine();
            end = "y".Equals(qest_end, StringComparison.OrdinalIgnoreCase);
            switch (end)
            {
                case true:
                    Console.WriteLine("Press any key to close");
                    Console.ReadKey();
                    break;
                case false:
                    goto Start;
            }
        }

        static void ip_get()
        {
            

            Console.WriteLine("IP");
            IP = Convert.ToString(Console.ReadLine());
            
            
            
        }
        static void portnum_get()
        {

            Console.WriteLine("\r");
            Console.WriteLine("Number Of Ports");
            portnum = Convert.ToInt32(Console.ReadLine());
            


        }
        static void name_get()
        {
            Console.WriteLine("\r");
            Console.WriteLine("Device Name");
            name = Convert.ToString(Console.ReadLine());


        }
        static void clac() 
        {
            string confirmation;
            bool conferm;


            Console.WriteLine("\n");
            Console.WriteLine(IP);
            Console.WriteLine(portnum);
            Console.WriteLine(name);
            Console.WriteLine("\r");
            Console.WriteLine("Is this correct? Y/N ");
            confirmation = Console.ReadLine();
            conferm = "y".Equals(confirmation, StringComparison.OrdinalIgnoreCase);
            Console.WriteLine("\r");
            switch (conferm)
            {
                case true:
                    output();
                    break;
                case false:
                    return;
                    


            }





        }
        static void output()
        {
            float stage = 0;
            Console.WriteLine("coppy from here >");
            while (stage < portnum)
            {
                stage = (stage + 1);
                Console.WriteLine("  - platform: snmp");
                Console.Write("\tname: ");
                Console.Write("\"");
                Console.Write(name);
                Console.Write("_");
                Console.Write(stage);
                Console.WriteLine("\"");
                Console.Write("\thost: \"");
                Console.Write(IP);
                Console.WriteLine("\"");
                Console.Write("\tbaseoid: 1.3.6.1.4.1.318.1.1.12.3.3.1.1.4.");
                Console.WriteLine(stage);
                Console.WriteLine("\tversion: \"2c\"");
                Console.WriteLine("\tpayload_on: \"1\"");
                Console.WriteLine("\tpayload_off: \"2\"");
            }
            Console.WriteLine("< to here");
        }   
         
    }
}

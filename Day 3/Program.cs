using System;
using System.IO;

namespace Day_3
{
    class Program
    {
        static void Main(string[] args)
        {
            /**
            * Read each position of each line input and save into an array
            */

            var lines = File.ReadAllLines("input.txt");
            var totalLines = lines.Length;
            int [] setCount = new int[12];
            foreach(var line in lines)
            {
                for(int i=0; i< line.Length ; i++)
                {
                    if(line[i] == '1')
                    {
                        setCount[i]++;
                    }
                }
            }

            /**
            * If the count is less than totalLines/2, then append 0 to the string
            */
            String binaryNumber = string.Empty;
            for(int i=0; i<setCount.Length; i++)
            {
                if(setCount[i] < totalLines/2)
                {
                   binaryNumber += 0;                }
                else
                {
                   binaryNumber += 1;
                }
            }

            /**
            * Convert the binary number to decimal
            */
            int decimalNumber = Convert.ToInt32(binaryNumber, 2);
            
            string complement = binaryNumber.Replace('1', '2').Replace('0', '1').Replace('2', '0');
            int complementNumber = Convert.ToInt32(complement, 2);

            /**
            * Print binaryNumber
            */
            Console.WriteLine(binaryNumber);
            Console.WriteLine(decimalNumber);
            Console.WriteLine(complementNumber);
            Console.WriteLine(decimalNumber * complementNumber);
        }
    }
}
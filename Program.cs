using System;
using System.Collections.Generic;
using System.IO;

namespace fft_CONVERTER
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sampleArray = new int[1000];
            int index = 0;
            String line;
            try
            {
                //Pass the file path and file name to the StreamReader constructor
                StreamReader sr = new StreamReader("C:\\TestSample.txt");

                //Read the first line of text
                line = sr.ReadLine();

                //Continue to read until you reach end of file
                while (line != null)
                {
                    //write the lie to console window
                //    Console.WriteLine(line);
                    //Read the next line
                    line = sr.ReadLine();
                    sampleArray[index++] = Convert.ToInt32(line);
                }

                //close the file
                sr.Close();
          //      Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Executing finally block.");
            }
            for(int i =0; i < 990; i++)
                Console.WriteLine(sampleArray[i]);
            List<List<int>> frequencyDomain = new List<List<int>>();
            List<int> ranges = new List<int>();
            int min = 30;
            int max = 30;
            for (int i = 31; i < 990; i++)
            {
                if (sampleArray[i] < sampleArray[min])
                    min = i;
                if (sampleArray[i] > sampleArray[max])
                    max =i;
            }

            int indVal = sampleArray[min] - 10;
            int rangeInd = 0;
            while (indVal < sampleArray[max] + 10)
            {
                ranges.Add(indVal);
                ranges.Add(indVal + 30);
              //  frequencyDomain.Add(rangeInd);
                List<int> tval = new List<int>();
                for (int i = 0; i < 1000; i++)
                {

                    if (indVal <= sampleArray[i] && sampleArray[i] <= indVal + 30)
                        tval.Add(sampleArray[i]);
                }
                frequencyDomain.Add(tval);
                indVal += 31;
                rangeInd++;
            }

            Console.WriteLine("Hello World!");
        }
    }
}

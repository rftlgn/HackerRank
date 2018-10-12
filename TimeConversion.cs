using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution
{

    /*
     * Complete the timeConversion function below.
     */
    static string timeConversion(string s)
    {
        /*
         * Write your code here.
         */
        string[] date = s.Split(':');
        string sec = date[2].Substring(0, 2);
        string noon = date[2].Substring(2);

        int hr = Convert.ToInt32(date[0]);
        int min = Convert.ToInt32(date[1]);
        int seconds = Convert.ToInt32(sec);

        if (noon == "AM")
        {
            if (hr == 12)
            { hr = 0; }
        }
        else if (noon == "PM")
        {
            if (hr != 12)
            { hr = (hr + 12) % 24; }
            
        }

        string newDate = String.Format("{0:d2}:{1:d2}:{2:d2}",hr, min, seconds);
        return newDate;

    }

    static void Main(string[] args)
    {
        //TextWriter tw = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string s = Console.ReadLine();

        string result = timeConversion(s);
        Console.WriteLine(result);
        Console.ReadLine();
        /*
        tw.WriteLine(result);

        tw.Flush();
        tw.Close();
        */
    }
}

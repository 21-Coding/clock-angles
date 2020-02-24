using System;
using System.Text.RegularExpressions;

public class ClockAngle
{
    public static void Main()
    {
        clockChekcer();

        void clockChekcer()
        {
            Console.WriteLine("Please enter an hour:");
            string stringHour = Console.ReadLine();
            int errorCounterHour = Regex.Matches(stringHour,@"[a-zA-Z]").Count;
            
            if (errorCounterHour > 0)
            {
                Console.WriteLine("Please enter a numerical value");
                clockChekcer();
            }
            else
            {
            int intHour = int.Parse(stringHour);
            if (intHour > 12)
            {
                Console.WriteLine("Please enter a number between 1 - 12");
                clockChekcer();
            }
            else
            {

            Console.WriteLine("Please enter a minute:");
            string stringMinute = Console.ReadLine();
            int errorCounterMinute = Regex.Matches(stringMinute,@"[a-zA-Z]").Count;


            if (errorCounterMinute > 0)
            {
                Console.WriteLine("Please enter a numerical value");
                clockChekcer();
            }
            else
            {
            int intMinute = int.Parse(stringMinute);
            if (intMinute > 59)
            {
                Console.WriteLine("Please enter a number between 1 - 59");
                clockChekcer();
            }
            else
            {

            int hourAngle = ((intHour * 30) + (intMinute / 2));
            int minuteAngle = (intMinute * 6);

            int result = Math.Abs(hourAngle - minuteAngle);

            Console.WriteLine(result + " degrees");
            }
            }
            }
            }
        }
    }
}
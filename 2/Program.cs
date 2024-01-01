namespace _2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CalendarService service = new CalendarService();
            Console.WriteLine(@"Usage:
Use one of commands:
""check"" to check is year leap
""calc"" to calc interval length
""day"" to get the name of day of week
""quit"" to quit
");
            while(true)
            {
                string command = AskUser("Input the command:");
                switch(command)
                {
                    case "check":
                        int year = int.Parse(AskUser("Input the year"));
                        Console.Write($"Is year {year} leap? ");
                        Console.WriteLine(service.IsLeapYear(year));
                        break;
                    case "calc":
                        DateTime date1 = AskDateTime("first date");
                        DateTime date2 = AskDateTime("second date");
                        int length = service.CalcIntervalLength(date1, date2);
                        Console.WriteLine($"Length between two dates is {length}");
                        break;
                    case "day":
                        DateTime date = AskDateTime("for day of week calculation");
                        Console.WriteLine("This day is " + service.GetDayOfWeek(date));
                        break;
                    case "exit":
                    default:
                        return;
                }
            }
        }
        
        static string AskUser(string text)
        {
            Console.WriteLine(text);
            return Console.ReadLine();
        }

        static DateTime AskDateTime(string text)
        {
            return new DateTime(int.Parse(AskUser($"Enter Year ({text})")),
                int.Parse(AskUser($"Enter Month ({text})")), 
                int.Parse(AskUser($"Enter Day ({text})")));
        }
    }
}

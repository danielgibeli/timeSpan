using System;

namespace timeSpan
{
    class Program
    {
        static void Main(string[] args)
        {
            TimeSpan t = new TimeSpan(0, 1, 30);
            Console.WriteLine(t);
            Console.WriteLine(t.Ticks);
            Console.WriteLine("---------------------------");

            TimeSpan t1 = new TimeSpan();
            TimeSpan t2 = new TimeSpan(900000000L);
            TimeSpan t3 = new TimeSpan(2, 11, 21);
            TimeSpan t4 = new TimeSpan(1, 2, 11, 21);
            TimeSpan t5 = new TimeSpan(1, 2, 11, 21, 321);
            Console.WriteLine(t1);
            Console.WriteLine(t2);
            Console.WriteLine(t3);
            Console.WriteLine(t4);
            Console.WriteLine(t5);
            Console.WriteLine("---------------------------");

            TimeSpan t11 = TimeSpan.FromDays(1.5);
            TimeSpan t22 = TimeSpan.FromHours(1.5);
            TimeSpan t33 = TimeSpan.FromMinutes(1.5);
            TimeSpan t44 = TimeSpan.FromSeconds(1.5);
            TimeSpan t55 = TimeSpan.FromMilliseconds(1.5);
            TimeSpan t66 = TimeSpan.FromTicks(900000000L);
            Console.WriteLine(t11);
            Console.WriteLine(t22);
            Console.WriteLine(t33);
            Console.WriteLine(t44);
            Console.WriteLine(t55);
            Console.WriteLine(t66);
            Console.WriteLine("---------------------------");

            DateTime d = new DateTime(2001, 8, 15, 13, 45, 58, 275);
            Console.WriteLine(d);
            Console.WriteLine("1) Date: " + d.Date);
            Console.WriteLine("2) Day: " + d.Day);
            Console.WriteLine("3) DayOfWeek: " + d.DayOfWeek);
            Console.WriteLine("4) DayOfYear: " + d.DayOfYear);
            Console.WriteLine("5) Hour: " + d.Hour);
            Console.WriteLine("6) Kind: " + d.Kind);
            Console.WriteLine("7) Millisecond: " + d.Millisecond);
            Console.WriteLine("8) Minute: " + d.Minute);
            Console.WriteLine("9) Month: " + d.Month);
            Console.WriteLine("10) Second: " + d.Second);
            Console.WriteLine("11) Ticks: " + d.Ticks);
            Console.WriteLine("12) TimeOfDay: " + d.TimeOfDay);
            Console.WriteLine("13) Year: " + d.Year);
            Console.WriteLine("---------------------------");

            string s1 = d.ToLongDateString();
            string s2 = d.ToLongTimeString();
            string s3 = d.ToShortDateString();
            string s4 = d.ToShortTimeString();
            string s5 = d.ToString();
            string s6 = d.ToString("yyyy-MM-dd HH:mm:ss");
            string s7 = d.ToString("yyyy-MM-dd HH:mm:ss.fff");
            Console.WriteLine(s1);
            Console.WriteLine(s2);
            Console.WriteLine(s3);
            Console.WriteLine(s4);
            Console.WriteLine(s5);
            Console.WriteLine(s6);
            Console.WriteLine(s7);
            Console.WriteLine("---------------------------");


            /* 
                        Console.WriteLine("---------------------------");
                        DateTime x = (2000, 10, 8);
                        DateTime y = (2000, 10, 10);
                        DateTime y = x.Add(timeSpan);
                        DateTime y = x.AddDays(double);
                        DateTime y = x.AddHours(double);
                        DateTime y = x.AddMilliseconds(double);
                        DateTime y = x.AddMinutes(double);
                        DateTime y = x.AddMonths(int);
                        DateTime y = x.AddSeconds(double);
                        DateTime y = x.AddTicks(long);
                        DateTime y = x.AddYears(int);
                        DateTime y = x.Subtract(timeSpan);
                        TimeSpan t = x.Subtract(dateTime);
            */
            Console.WriteLine("---------------------------");

            TimeSpan t1111 = TimeSpan.MaxValue;
            TimeSpan t2111 = TimeSpan.MinValue;
            TimeSpan t3111 = TimeSpan.Zero;
            Console.WriteLine(t1111);
            Console.WriteLine(t2111);
            Console.WriteLine(t3111);
            Console.WriteLine("---------------------------");

            TimeSpan tt = new TimeSpan(2, 3, 5, 7, 11);
            Console.WriteLine(t);
            Console.WriteLine("Days: " + tt.Days);
            Console.WriteLine("Hours: " + tt.Hours);
            Console.WriteLine("Minutes: " + tt.Minutes);
            Console.WriteLine("Milliseconds: " + tt.Milliseconds);
            Console.WriteLine("Seconds: " + tt.Seconds);
            Console.WriteLine("Ticks: " + tt.Ticks);
            Console.WriteLine("TotalDays: " + tt.TotalDays);
            Console.WriteLine("TotalHours: " + tt.TotalHours);
            Console.WriteLine("TotalMinutes: " + tt.TotalMinutes);
            Console.WriteLine("TotalSeconds: " + tt.TotalSeconds);
            Console.WriteLine("TotalMilliseconds: " + tt.TotalMilliseconds);
            Console.WriteLine("---------------------------");

            TimeSpan t1222 = new TimeSpan(1, 30, 10);
            TimeSpan t2222 = new TimeSpan(0, 10, 5);
            TimeSpan sum = t1222.Add(t2222);
            TimeSpan dif = t1222.Subtract(t2222);
            TimeSpan mult = t2222.Multiply(2.0);
            TimeSpan div = t2222.Divide(2.0);
            Console.WriteLine(t1222);
            Console.WriteLine(t2222);
            Console.WriteLine(sum);
            Console.WriteLine(dif);
            Console.WriteLine(mult);
            Console.WriteLine(div);
            Console.WriteLine("---------------------------");

            DateTime d1 = new DateTime(2000, 8, 15, 13, 5, 58, DateTimeKind.Local);
            DateTime d2 = new DateTime(2000, 8, 15, 13, 5, 58, DateTimeKind.Utc);
            DateTime d3 = new DateTime(2000, 8, 15, 13, 5, 58);
            Console.WriteLine("d1: " + d1);
            Console.WriteLine("d1 Kind: " + d1.Kind);
            Console.WriteLine("d1 to Local: " + d1.ToLocalTime());
            Console.WriteLine("d1 to Utc: " + d1.ToUniversalTime());
            Console.WriteLine("---------------------------");
            Console.WriteLine();
            Console.WriteLine("d2: " + d2);
            Console.WriteLine("d2 Kind: " + d2.Kind);
            Console.WriteLine("d2 to Local: " + d2.ToLocalTime());
            Console.WriteLine("d2 to Utc: " + d2.ToUniversalTime());
            Console.WriteLine("---------------------------");
            Console.WriteLine();
            Console.WriteLine("d3: " + d3);
            Console.WriteLine("d3 Kind: " + d3.Kind);
            Console.WriteLine("d3 to Local: " + d3.ToLocalTime());
            Console.WriteLine("d3 to Utc: " + d3.ToUniversalTime());
            Console.WriteLine("---------------------------");

            DateTime d4 = DateTime.Parse("2000-08-15 13:05:58");
            DateTime d5 = DateTime.Parse("2000-08-15T13:05:58Z"); // cria local DateTime
            Console.WriteLine("d1: " + d4);
            Console.WriteLine("d1 Kind: " + d4.Kind);
            Console.WriteLine("d1 to Local: " + d4.ToLocalTime());
            Console.WriteLine("d1 to Utc: " + d4.ToUniversalTime());
            Console.WriteLine();
            Console.WriteLine("d2: " + d5);
            Console.WriteLine("d2 Kind: " + d5.Kind);
            Console.WriteLine("d2 to Local: " + d5.ToLocalTime());
            Console.WriteLine("d2 to Utc: " + d5.ToUniversalTime());
            Console.WriteLine();
            Console.WriteLine(d5.ToString("yyyy-MM-ddTHH:mm:ssZ")); // cuidado!
            Console.WriteLine(d5.ToUniversalTime().ToString("yyyy-MM-ddTHH:mm:ssZ"));
        }
    }
}

using System;
using System.ComponentModel;
using System.IO;
using System.Reflection;
using Humanizer;

namespace Sample
{
    class Program
    {
        public enum Days
        {
            None = 0,
            [Description("No God, Please No! Noooooooo!")]
            Monday,
            Tuesday,
            Wednesday,
            [Description("Almost Friday")]
            Thursday,
            [Description("Thank God!")]
            Friday,
            Saturday,
            Sunday,
            Weekend = Saturday | Sunday
        }

        static void Main(string[] args)
        {
            // String
            Console.WriteLine($"{Environment.NewLine}📑 - String");
            Console.WriteLine("NameOfProperty".Humanize());
            Console.WriteLine("PascalCaseInputString".Humanize());
            Console.WriteLine("snake_case_input_string".Humanize());
            Console.WriteLine("snake_case_input_string".Humanize(LetterCasing.Title));
            Console.WriteLine("String humanized that will be dehumanized".Dehumanize());
            Console.WriteLine("NameOfProperty".Dasherize());
            Console.WriteLine("NameOfProperty".Underscore());
            Console.WriteLine("This string will be truncated by Humanizer lib.".Truncate(20, Truncator.FixedLength));
            Console.WriteLine("This string will be truncated by Humanizer lib.".Truncate(12, Truncator.FixedNumberOfCharacters));
            Console.WriteLine("This string will be truncated by Humanizer lib.".Truncate(5, Truncator.FixedNumberOfWords));
            Console.WriteLine("This string will be truncated by Humanizer lib.".Truncate(5, "###", Truncator.FixedNumberOfWords));


            // DateTime
            Console.WriteLine($"{Environment.NewLine}📅 - DateTime");
            Console.WriteLine(DateTime.UtcNow.AddHours(-30).Humanize());
            Console.WriteLine(DateTime.UtcNow.AddHours(-2).Humanize());
            Console.WriteLine(DateTime.UtcNow.AddHours(30).Humanize());
            Console.WriteLine(DateTime.UtcNow.AddHours(2).Humanize());


            // TimeSpan
            Console.WriteLine($"{Environment.NewLine}⌚ - TimeSpan");
            Console.WriteLine(TimeSpan.FromTicks(10000).Humanize(precision: 2));
            Console.WriteLine(TimeSpan.FromMilliseconds(1000).Humanize(precision: 2));
            Console.WriteLine(TimeSpan.FromSeconds(73.5).Humanize(precision: 2));
            Console.WriteLine(TimeSpan.FromMinutes(63.49).Humanize(precision: 2));
            Console.WriteLine(TimeSpan.FromHours(23.59).Humanize(precision: 2));
            Console.WriteLine(TimeSpan.FromDays(1.5).Humanize(precision: 2));


            // ByteSize
            Console.WriteLine($"{Environment.NewLine}📏 - Byte Sizes");
            Console.WriteLine(1024.Bits());
            Console.WriteLine((1024).Bytes());
            Console.WriteLine((1024).Kilobytes());
            Console.WriteLine((1024).Megabytes());
            Console.WriteLine((1024).Gigabytes());
            Console.WriteLine((1024).Terabytes());
            Console.WriteLine((2).Gigabytes() + (512).Megabytes() - (2.5).Gigabytes());
            Console.WriteLine((2500).Kilobytes() + (25).Megabytes() + (1.2500).Gigabytes());
            Console.WriteLine((1024).Kilobytes().ToFullWords());
            Console.WriteLine((1024).Megabytes().ToFullWords());


            // Metrics
            Console.WriteLine($"{Environment.NewLine}📏 - Metrics");
            Console.WriteLine(0.12.ToMetric());
            Console.WriteLine(14123.ToMetric());
            Console.WriteLine(160015123.ToMetric());
            Console.WriteLine("120m".FromMetric());
            Console.WriteLine("14.123k".FromMetric());
            Console.WriteLine("160.015123M".FromMetric());


            // Quantities
            Console.WriteLine($"{Environment.NewLine}🧮 - Quantities");
            Console.WriteLine("process".ToQuantity(10));
            Console.WriteLine("process".ToQuantity(100, ShowQuantityAs.Words));
            Console.WriteLine("users".ToQuantity(1.5));
            Console.WriteLine("words".ToQuantity(1));


            // Enum
            Console.WriteLine($"{Environment.NewLine}🔢 - Enums");
            Console.WriteLine(Days.Monday.Humanize());
            Console.WriteLine(Days.Wednesday.Humanize().Transform(To.UpperCase));
            Console.WriteLine(Days.Friday.Humanize().Transform(To.LowerCase));
            Console.WriteLine("thank god!".DehumanizeTo<Days>());


            // Collections
            Console.WriteLine($"{Environment.NewLine}🔠 - Collections");
            Console.WriteLine(new string[] { "To be", "not to be" }.Humanize("or"));
            Console.WriteLine(new int[] { 1, 2, 3, 4, 5 }.Humanize("maybe"));
            Console.WriteLine(new int[] { 1, 2, 3, 4, 5 }.Humanize(s => s.Ordinalize(), "and"));


            Console.ReadLine();
        }
    }
}

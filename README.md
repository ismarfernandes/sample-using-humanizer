# Sample using Humanizer

This is a code sample of the use of some features of the [Humanizer](https://github.com/Humanizr/Humanizer) lib.

## Output

```csharp

    📑 - String
    "NameOfProperty".Humanize(); // => Name of property
    "PascalCaseInputString".Humanize(); // => Pascal case input string
    "snake_case_input_string".Humanize(); // => snake case input string
    "snake_case_input_string".Humanize(LetterCasing.Title); // => Snake Case Input String
    "String humanized that will be dehumanized".Dehumanize(); // => StringHumanizedThatWillBeDehumanized
    "NameOfProperty".Dasherize(); // => NameOfProperty
    "NameOfProperty".Underscore(); // => name_of_property
    "This string will be truncated by Humanizer lib.".Truncate(20, Truncator.FixedLength); // => This string will be…
    "This string will be truncated by Humanizer lib.".Truncate(12, Truncator.FixedNumberOfCharacters); // => This string w…
    "This string will be truncated by Humanizer lib.".Truncate(5, Truncator.FixedNumberOfWords); // => This string will be truncated…
    "This string will be truncated by Humanizer lib.".Truncate(5, "###", Truncator.FixedNumberOfWords); // => This string will be truncated###

    📅 - DateTime
    DateTime.UtcNow.AddHours(-30).Humanize(); // => yesterday
    DateTime.UtcNow.AddHours(-2).Humanize(); // => 2 hours ago
    DateTime.UtcNow.AddHours(30).Humanize(); // => 2 days from now
    DateTime.UtcNow.AddHours(2).Humanize(); // => an hour from now

    ⌚ - TimeSpan
    TimeSpan.FromTicks(10000).Humanize(precision: 2); // => 1 millisecond
    TimeSpan.FromMilliseconds(1000).Humanize(precision: 2); // => 1 second
    TimeSpan.FromSeconds(73.5).Humanize(precision: 2); // => 1 minute, 13 seconds
    TimeSpan.FromMinutes(63.49).Humanize(precision: 2); // => 1 hour, 3 minutes
    TimeSpan.FromHours(23.59).Humanize(precision: 2); // => 23 hours, 35 minutes
    TimeSpan.FromDays(1.5).Humanize(precision: 2); // => 1 day, 12 hours

    📏 - Byte Sizes
    1024.Bits(); // => 128 B
    (1024).Bytes(); // => 1 KB
    (1024).Kilobytes(); // => 1 MB
    (1024).Megabytes(); // => 1 GB
    (1024).Gigabytes(); // => 1 TB
    (1024).Terabytes(); // => 1024 TB
    (2).Gigabytes() + (512).Megabytes() - (2.5).Gigabytes(); // => 0 b
    (2500).Kilobytes() + (25).Megabytes() + (1.2500).Gigabytes(); // => 1.28 GB
    (1024).Kilobytes().ToFullWords(); // => 1 megabyte
    (1024).Megabytes().ToFullWords(); // => 1 gigabyte

    📏 - Metrics
    0.12.ToMetric(); // => 120m
    14123.ToMetric(); // => 14.123k
    160015123.ToMetric(); // => 160.015123M
    "120m".FromMetric(); // => 0.12
    "14.123k".FromMetric(); // => 14123
    "160.015123M".FromMetric(); // => 160015123

    🧮 - Quantities
    "process".ToQuantity(10); // => 10 processes
    "process".ToQuantity(100, ShowQuantityAs.Words); // => one hundred processes
    "users".ToQuantity(1.5); // => 1.5 users
    "words".ToQuantity(1); // => 1 word

    🔢 - Enums
    Days.Monday.Humanize(); // => No God, Please No! Noooooooo!
    Days.Wednesday.Humanize().Transform(To.UpperCase); // => WEDNESDAY
    Days.Friday.Humanize().Transform(To.LowerCase); // => thank god!
    "thank god!".DehumanizeTo<Days>(); // => Friday

    🔠 - Collections
    new string[] { "To be", "not to be" }.Humanize("or"); // => To be or not to be
    new int[] { 1, 2, 3, 4, 5 }.Humanize("maybe"); // => 1, 2, 3, 4, maybe 5
    new int[] { 1, 2, 3, 4, 5 }.Humanize(s => s.Ordinalize(), "and"); // => 1st, 2nd, 3rd, 4th, and 5th
```

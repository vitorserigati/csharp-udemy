using System.Globalization;
DateTime d1 = new DateTime(2023, 11, 25);
DateTime d2 = new DateTime(2023, 01, 29, 18, 45, 3);
DateTime d3 = new DateTime(2023, 01, 29, 18, 45, 3, 500);

DateTime d4 = DateTime.Now;
DateTime d5 = DateTime.Today;
DateTime d6 = DateTime.UtcNow;

DateTime d7 = DateTime.Parse("2000-08-15");
DateTime d8 = DateTime.Parse("2023-01-29 18:55");

DateTime d9 = DateTime.Parse("29/01/2023");
DateTime d10 = DateTime.Parse("29/01/2023 18:57");

DateTime d11 = DateTime.ParseExact("2000-08-15", "yyyy-MM-dd", CultureInfo.InvariantCulture);
DateTime d12 = DateTime.ParseExact("29/01/2023 19:00", "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);


Console.WriteLine(d1);
Console.WriteLine(d2);
Console.WriteLine(d3);
Console.WriteLine(d4);
Console.WriteLine(d5);
Console.WriteLine(d6);
Console.WriteLine(d7);
Console.WriteLine(d8);
Console.WriteLine(d9);
Console.WriteLine(d10);
Console.WriteLine(d11);
Console.WriteLine(d12);

Console.WriteLine("-----------------------------");
Console.WriteLine("Propriedades do DateTime: ");

DateTime d = new DateTime(2001, 8, 15, 13, 45, 58, 257);
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

string s1 =  d.ToLongDateString();
string s2 =  d.ToLongTimeString();
string s3 =  d.ToShortDateString();
string s4 =  d.ToShortTimeString();

Console.WriteLine("formating: ToLongDateString: " + s1);
Console.WriteLine("formating: ToLongTimeString: " + s2);
Console.WriteLine("formating: ToShortDateString: " + s3);
Console.WriteLine("formating: ToShortTimeString: " + s4);
string s6 = d.ToString("yyyy/MM/dd");
Console.WriteLine("formating: Máscara de formatação yyyy/MM/dd: " + s6);

DateTime dd = d.AddHours(2);
Console.WriteLine($"d: {d}");
Console.WriteLine($"d2: {dd}");

// Datas com C# - #A0167
using System.Globalization;

var data = DateTime.Now;
Console.WriteLine(data);

// Obtendo valores da Data
var data2 = new DateTime(2020, 10, 12, 8, 30, 0);
Console.WriteLine(data2);
Console.WriteLine($"Dia: {data2.Day}, Mês: {data2.Month}, Ano: {data2.Year}");
Console.WriteLine((int)data2.DayOfWeek);

// Formatando Datas - #A0169
Console.WriteLine("---------- Formatando Datas ----------");
var dataFormat = DateTime.Now;

// Y - year, M = month, d = day, h = hour, s = second
var format = String.Format("{0:yyyy}", dataFormat);

Console.WriteLine($"{dataFormat:dd-MM-yy hh:mm:ss zzzz}");
Console.WriteLine(format);

// Padrões de formatação
Console.WriteLine("---------- Padrões de formatação ----------");
var formatPattern = String.Format("{0:g}", dataFormat);
Console.WriteLine(formatPattern);

// Adicionando valores
Console.WriteLine("---------- Adicionando valores ----------");
var data3 = DateTime.Now;

Console.WriteLine(data3.AddDays(-12));
Console.WriteLine(data3.AddMonths(1));
Console.WriteLine(data3.AddYears(1));
Console.WriteLine(data3.AddHours(2));

Console.WriteLine(data3);

// Comparando datas
Console.WriteLine("---------- Comparando datas ----------");
DateTime data4 = DateTime.Now;

if (data4.Date == DateTime.Now.Date)
{
    Console.WriteLine("É igual");
}
else
{
    Console.WriteLine("Não é igual");
}

Console.WriteLine(data4.Date + " " + DateTime.Now.Date);

// CultureInfo #A0173

Console.WriteLine("---------- CultureInfo ----------");

var en = new CultureInfo("en-US");
var pt = new CultureInfo("pt-PT");
var br = new CultureInfo("pt-BR");
var de = new CultureInfo("de-DE");
var atual = CultureInfo.CurrentCulture;

Console.WriteLine(DateTime.Now.ToString("D", en));
Console.WriteLine(DateTime.Now.ToString("D", de));
Console.WriteLine(DateTime.Now.ToString("D", pt));
Console.WriteLine(DateTime.Now.ToString("D", br));
Console.WriteLine(DateTime.Now.ToString("D", atual));

// Timezone
Console.WriteLine("---------- Timezone ----------");
var utcDate = DateTime.UtcNow;
Console.WriteLine(DateTime.Now);
Console.WriteLine(utcDate);
Console.WriteLine(utcDate.ToLocalTime());

var timezoneAustralia = TimeZoneInfo.FindSystemTimeZoneById("Pacific/Auckland");
Console.WriteLine(timezoneAustralia);
var horaAustralia = TimeZoneInfo.ConvertTimeFromUtc(utcDate, timezoneAustralia);
Console.WriteLine(horaAustralia);

var timezones = TimeZoneInfo.GetSystemTimeZones();
foreach (var timezone in timezones)
{
    Console.WriteLine(timezone.Id);
    Console.WriteLine(timezone);
    Console.WriteLine(TimeZoneInfo.ConvertTimeFromUtc(utcDate, timezone));
    Console.WriteLine("------");
}

// Timespan
Console.WriteLine("---------- Timespan ----------");
var timespan = new TimeSpan();
Console.WriteLine(timespan);
var timespanNanosegundos = new TimeSpan(1);
Console.WriteLine(timespanNanosegundos);
var timeSpanHoraMinutoSegundo = new TimeSpan(14, 6, 20);
Console.WriteLine(timeSpanHoraMinutoSegundo);
var timeSpanDiaHoraMinutoSegundo = new TimeSpan(2, 14, 6, 20);
var timeSpanDiaHoraMinutoSegundoMilissegundo = new TimeSpan(2, 14, 6, 20, 50);
Console.WriteLine(timeSpanDiaHoraMinutoSegundo);
Console.WriteLine(timeSpanDiaHoraMinutoSegundoMilissegundo);

Console.WriteLine(timeSpanHoraMinutoSegundo - timeSpanDiaHoraMinutoSegundo);
Console.WriteLine(timeSpanDiaHoraMinutoSegundo.Days);
Console.WriteLine(timeSpanDiaHoraMinutoSegundo.Add(new TimeSpan(12, 0, 0)));

Console.WriteLine(DateTime.DaysInMonth(2024, 5));

bool IsWeekDay(DayOfWeek today)
{
    // sábado ou domingo
    return today == DayOfWeek.Sunday || today == DayOfWeek.Saturday;
}

Console.WriteLine(IsWeekDay(new DateTime().DayOfWeek));
// Se é horario de verão
Console.WriteLine(DateTime.Now.IsDaylightSavingTime());

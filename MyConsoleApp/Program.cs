
Console.WriteLine("Hello, World!");
Console.WriteLine("The current time is " + DateTime.Now);

// Days until next Christmas
var today = DateTime.Today;
var nextChristmas = new DateTime(today.Year, 12, 25);

var daysUntilChristmas = (nextChristmas - today).Days;

Console.WriteLine($"There are {daysUntilChristmas} days until next Christmas.");


    
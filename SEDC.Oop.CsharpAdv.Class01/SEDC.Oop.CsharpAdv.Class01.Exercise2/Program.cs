


string more = "yes";
List<DateTime> dateTimeList = new List<DateTime>();

while (more == "yes")
{
    Console.WriteLine("Enter the date you want to be checked");
    string input = Console.ReadLine();
    DateTime newDateTime = Convert.ToDateTime(input);
    dateTimeList.Add(newDateTime);
    Console.WriteLine("Do you want to check more dates?");
    more = Console.ReadLine().ToLower();
}

foreach (DateTime dateTime in dateTimeList)
{
    if (dateTime.DayOfWeek == 0 || dateTime.DayOfWeek == DayOfWeek.Saturday || (dateTime.Month == 1 && dateTime.Day == 7) || (dateTime.Month == 1 && dateTime.Day == 1) || (dateTime.Month == 4 && dateTime.Day == 20) || (dateTime.Month == 5 && dateTime.Day == 1) || (dateTime.Month == 8 && dateTime.Day == 3) || (dateTime.Month == 10 && dateTime.Day == 12) || (dateTime.Month == 10 && dateTime.Day == 23) || (dateTime.Month == 12 && dateTime.Day == 8))
    {
        Console.WriteLine("The day is not a working day!");
        continue;
    }
    Console.WriteLine("It is a working day unfortunately :( ");
}
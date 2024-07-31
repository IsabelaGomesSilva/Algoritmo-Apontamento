


DateTime dt = new DateTime(2024, 7, 22);
DateTime dt1 = new DateTime(2024, 7, 23);
DateTime dt2 = new DateTime(2024, 7, 24);
DateTime dt3 = new DateTime(2024, 7, 25);
DateTime dt4 = new DateTime(2024, 7, 26);
DateTime dt5 = new DateTime(2024, 7, 29);
DateTime dt6 = new DateTime(2024, 7, 30);

DateTime dtInvalid = new DateTime(2024, 7, 19);
DateTime dtInvalid1 = new DateTime(2024, 7, 18);
DateTime dtin = new DateTime(2024, 7, 31);

DateTime today = new DateTime(2024, 7, 30);

List<DateTime> datas = [dt, dt1, dt2,dt3, dt4, dt5, dt6,dtin,  dtInvalid1, dtInvalid ];
foreach (var data in datas)
{
    if (data > today)
    {
        Console.WriteLine($"Date invalid {data}"); 
        continue;
    }   
           
    DateTime limit = data.AddDays(9 - (int)data.DayOfWeek );
    if(today <= limit) 
       Console.WriteLine($"Data valida  {limit } {  (int)data.DayOfWeek}!");
    else
        Console.WriteLine("Date invalid");

}
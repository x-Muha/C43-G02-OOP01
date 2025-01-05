using System.Linq.Expressions;

namespace Assignment_01_OOP
{
    internal class Program
    {
        enum WeekDays
        {
            Monday,
            Tuesday, 
            Wednesday, 
            Thursday,
            Friday,
            Saturday,
            Sunday   
        }
        enum Seasons
        {
            Spring,
            Summer,
            Autumn,
            Winter
        }
        [Flags]
        enum Permissions:byte
        {
            Read = 1,
            Write = 2,
            Delete = 4,
            Execute = 8
        }
        enum Colors
        {
            Red,
            Green,
            Blue,
        }
        static void Main(string[] args)
        {
            #region Q1
            //WeekDays Day = default;
            //for (int i = 0; i < 7; i++)
            //{
            //    Console.WriteLine(Day);
            //    Day++;
            //} 
            #endregion

            #region Q2

            //Seasons Season = default;
            //while(!Enum.TryParse(Console.ReadLine(), true, out Season));

            //String message = Season switch
            //{
            //    Seasons.Spring => "March to May",
            //    Seasons.Summer => "June to August",
            //    Seasons.Autumn => "September to November",
            //    Seasons.Winter => "December to February"
            //};
            //Console.WriteLine(message);

            #endregion

            #region Q3

            //Permissions User = default;
            //User = User | Permissions.Read; // Add Read Permission 
            //User = User | Permissions.Delete; // Add Delete Permission 

            //Console.WriteLine((int)User); // 5 = 0b 0000 0101

            //User = User & ~Permissions.Delete; // Remove Delete Permission
            //Console.WriteLine((int)User); // 5 = 0b 0000 0001

            //if (User.HasFlag(Permissions.Execute)) Console.WriteLine("User Has Execute Permission.");
            //else Console.WriteLine("User Doesn't Have Execute Permission");
            //// Check for Execute Permission.

            //// Print User Permissions:
            //User = User | Permissions.Execute | Permissions.Delete;
            //Console.WriteLine("\nUser Permissions:");
            //foreach (Permissions x in Enum.GetValues(typeof(Permissions)))
            //    if (User.HasFlag(x)) Console.Write($"{x} ");
            #endregion

            #region Q4

            //String str1 = Console.ReadLine() ?? "Null";
            //bool isParsed = Enum.TryParse(str1,true,out Colors color);

            //if (isParsed) Console.WriteLine("Your Color is Primary");
            //else Console.WriteLine("Your Color is not Primary!");
            #endregion

        }
    }
}

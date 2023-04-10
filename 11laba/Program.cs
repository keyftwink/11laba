namespace _11laba
{
    internal class Program
    {

        delegate string GetNextDayOfWeek();
        static void Main(string[] args)
        {
            int dayIndex = 0;

            GetNextDayOfWeek getNextDay = () =>
            {
                dayIndex++;
                switch (dayIndex)
                {
                    case 1:
                        return "Понедельник";
                    case 2:
                        return "Вторник";
                    case 3:
                        return "Среда";
                    case 4:
                        return "Четверг";
                    case 5:
                        return "Пятница";
                    case 6:
                        return "Суббота";
                    case 7:
                        return "Воскресенье";
                    default:
                        dayIndex = 1;
                        return "Понедельник";
                }

            };

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(getNextDay());
            }
        }
    }
}
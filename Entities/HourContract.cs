using System;

namespace ConsoleApplication7.Entities
{
    class HourContract
    {
        public DateTime Date { get; set; } // declarando a função DateTime para trabalhar com horas, dias, meses e anos.
        public double ValuePerHour { get; set; }
        public int Hours { get; set; }

        public HourContract()
        {
        }

        public HourContract(DateTime date, double valuePerHour, int hours)
        {
            Date = date;
            ValuePerHour = valuePerHour;
            Hours = hours;

        }

        public double TotalValue()
        {
            return Hours * ValuePerHour;
        }
    }
}

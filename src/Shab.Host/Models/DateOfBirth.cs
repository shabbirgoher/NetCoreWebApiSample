using System;

namespace Shab.Host.Models
{
    public class DateOfBirth
    {
        public DateTime Date{ get; }

        public DateOfBirth(DateTime date)
        {
            Date = date;
        }
    }
}
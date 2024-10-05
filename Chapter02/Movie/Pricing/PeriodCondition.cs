using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objects
{
    public class PeriodCondition : DiscountCondition
    {
        private DayOfWeek dayOfWeek;
        private TimeSpan startTime;
        private TimeSpan endTime;

        public PeriodCondition(DayOfWeek dayOfWeek, TimeSpan startTime, TimeSpan endTime)
        {
            this.dayOfWeek = dayOfWeek;
            this.startTime = startTime;
            this.endTime = endTime;
        }

        public bool IsSatisfiedBy(Screening screening)
        {
            return screening.GetStartTime().DayOfWeek == dayOfWeek &&
                   startTime <= screening.GetStartTime().TimeOfDay &&
                   endTime >= screening.GetStartTime().TimeOfDay;
        }
    }
}

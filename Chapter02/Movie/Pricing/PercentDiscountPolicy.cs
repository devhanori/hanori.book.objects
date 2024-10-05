using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objects
{
    public class PercentDiscountPolicy : DiscountPolicy
    {
        private double percent;

        public PercentDiscountPolicy(double percent, params DiscountCondition[] conditions)
            : base(conditions)
        {
            this.percent = percent;
        }

        protected override Money GetDiscountAmount(Screening screening)
        {
            return screening.GetMovieFee().Times(percent);
        }
    }
}

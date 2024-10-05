using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objects
{
    public class AmountDiscountPolicy : DiscountPolicy
    {
        private Money discountAmount;

        public AmountDiscountPolicy(Money discountAmount, params DiscountCondition[] conditions)
            : base(conditions)
        {
            this.discountAmount = discountAmount;
        }

        protected override Money GetDiscountAmount(Screening screening)
        {
            return discountAmount;
        }
    }
}

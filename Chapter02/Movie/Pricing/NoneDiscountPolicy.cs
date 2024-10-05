using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objects
{
    public class NoneDiscountPolicy : DiscountPolicy
    {
        protected override Money GetDiscountAmount(Screening screening)
        {
            return Money.Zero;
        }
    }
}

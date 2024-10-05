using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objects
{
    public class Movie
    {
        private string title;
        private TimeSpan runningTime;
        private Money fee;
        private DiscountPolicy discountPolicy;

        public Movie(string title, TimeSpan runningTime, Money fee, DiscountPolicy discountPolicy)
        {
            this.title = title;
            this.runningTime = runningTime;
            this.fee = fee;
            this.discountPolicy = discountPolicy;
        }

        public Money GetFee()
        {
            return fee;
        }

        public Money CalculateMovieFee(Screening screening)
        {
            return fee.Minus(discountPolicy.CalculateDiscountAmount(screening));
        }
    }
}

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objects
{
    public abstract class DiscountPolicy
    {
        private List<DiscountCondition> conditions = new List<DiscountCondition>();

        public DiscountPolicy(params DiscountCondition[] conditions)
        {
            this.conditions = conditions.ToList();
        }

        public Money CalculateDiscountAmount(Screening screening)
        {
            foreach (DiscountCondition each in conditions)
            {
                if (each.IsSatisfiedBy(screening))
                {
                    return GetDiscountAmount(screening);
                }
            }

            return Money.Zero;
        }

        protected abstract Money GetDiscountAmount(Screening screening);
    }
}

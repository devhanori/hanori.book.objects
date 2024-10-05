using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objects
{
    public class SequenceCondition : DiscountCondition
    {
        private int sequence;

        public SequenceCondition(int sequence)
        {
            this.sequence = sequence;
        }

        public bool IsSatisfiedBy(Screening screening)
        {
            return screening.IsSequence(sequence);
        }
    }
}

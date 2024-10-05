using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objects
{
    public class Money
    {
        public static readonly Money Zero = Wons(0);

        private readonly decimal amount;

        public static Money Wons(long amount)
        {
            return new Money(amount);
        }

        public static Money Wons(double amount)
        {
            return new Money((decimal)amount);
        }

        private Money(decimal amount)
        {
            this.amount = amount;
        }

        public Money Plus(Money amount)
        {
            return new Money(this.amount + amount.amount);
        }

        public Money Minus(Money amount)
        {
            return new Money(this.amount - amount.amount);
        }

        public Money Times(double percent)
        {
            return new Money(amount * (decimal)percent);
        }

        public bool IsLessThan(Money other)
        {
            return amount < other.amount;
        }

        public bool IsGreaterThanOrEqual(Money other)
        {
            return amount >= other.amount;
        }

        public override bool Equals(object obj)
        {
            if (this == obj)
            {
                return true;
            }

            if (!(obj is Money))
            {
                return false;
            }

            Money other = (Money)obj;
            return amount == other.amount;
        }

        public override int GetHashCode()
        {
            return amount.GetHashCode();
        }

        public override string ToString()
        {
            return amount.ToString() + "원";
        }

    }
}
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objects
{
    public class Reservation
    {
        private Customer customer;
        private Screening screening;
        private Money fee;
        private int audienceCount;

        public Reservation(Customer customer, Screening screening, Money fee, int audienceCount)
        {
            this.customer = customer;
            this.screening = screening;
            this.fee = fee;
            this.audienceCount = audienceCount;
        }
    }
}

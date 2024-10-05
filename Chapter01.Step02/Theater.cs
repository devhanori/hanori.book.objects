using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter01.Step02
{
    /// <summary>
    /// 소극장
    /// </summary>
    public class Theater
    {
        private TicketSeller ticketSeller;

        public Theater(TicketSeller ticketSeller)
        {
            this.ticketSeller = ticketSeller;
        }

        public void enter(Audience audience)
        {
            this.ticketSeller.sellTo(audience);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter01.Step02
{
    /// <summary>
    /// 판매원
    /// </summary>
    public class TicketSeller
    {
        private TicketOffice ticketOffice { get; set; }

        public TicketSeller(TicketOffice ticketOffice)
        {
            this.ticketOffice = ticketOffice;
        }

        public void sellTo(Audience audience)
        {
            ticketOffice.plusAmount(audience.buy(ticketOffice.getTicket()));
        }
    }
}

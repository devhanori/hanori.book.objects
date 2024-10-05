using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter01.Step01
{
    /// <summary>
    /// 판매원
    /// </summary>
    public class TicketSeller
    {
        public TicketOffice ticketOffice { get; private set; }

        public TicketSeller(TicketOffice ticketOffice)
        {
            this.ticketOffice = ticketOffice;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter01.Step03
{
    /// <summary>
    /// 매표소
    /// </summary>
    public class TicketOffice
    {
        private long amount;
        private List<Ticket> tickets { get; set; }

        public TicketOffice(long amount, params Ticket[] ticketparams)
        {
            this.amount = amount;
            this.tickets.AddRange(ticketparams);
        }

        public void sellTicketTo(Audience audience)
        {
            this.plusAmount(audience.buy(this.getTicket()));
        }

        public Ticket getTicket()
        {
            var ticket = tickets[0];
            tickets.RemoveAt(0);
            return ticket;
        }

        public void minusAmount(long amount)
        {
            this.amount -= amount;
        }

        public void plusAmount(long amount)
        {
            this.amount += amount;
        }
    }
}

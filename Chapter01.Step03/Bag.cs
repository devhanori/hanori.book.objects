using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter01.Step03
{
    /// <summary>
    /// 관람객이 소지한 가방
    /// </summary>
    public class Bag
    {
        private long amount;
        private Invitation invitation { get; set; }
        private Ticket ticket { get; set; }

        public Bag(long amount) 
        { 
            this.amount = amount;
        }

        public Bag(Invitation invitation, long amount)
        {
            this.invitation = invitation;
            this.amount = amount;
        }

        public long hold(Ticket ticket)
        {
            if (this.hasInvitation())
            {
                this.setTicket(ticket);
                return 0;
            }
            else
            {
                this.minusAmount(ticket.fee);
                this.setTicket(ticket);
                return ticket.fee;
            }
        }

        private bool hasInvitation()
        {
            return invitation != null;
        }

        private bool hasTicket()
        {
            return ticket != null;
        }

        private void setTicket(Ticket ticket)
        {
            this.ticket = ticket;
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

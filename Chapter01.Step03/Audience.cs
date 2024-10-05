using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter01.Step03
{
    /// <summary>
    /// 관람객
    /// </summary>
    public class Audience
    {
        private Bag bag { get; set; }

        public Audience(Bag bag)
        {
            this.bag = bag;
        }

        public long buy(Ticket ticket)
        {
            return this.bag.hold(ticket);
        }
    }
}

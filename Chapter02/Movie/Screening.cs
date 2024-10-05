using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objects
{
    public class Screening
    {
        private Movie movie;
        private int sequence;
        private DateTime whenScreened;

        public Screening(Movie movie, int sequence, DateTime whenScreened)
        {
            this.movie = movie;
            this.sequence = sequence;
            this.whenScreened = whenScreened;
        }

        public DateTime GetStartTime()
        {
            return whenScreened;
        }

        public bool IsSequence(int sequence)
        {
            return this.sequence == sequence;
        }

        public Money GetMovieFee()
        {
            return movie.GetFee();
        }

        public Reservation Reserve(Customer customer, int audienceCount)
        {
            return new Reservation(customer, this, CalculateFee(audienceCount), audienceCount);
        }

        private Money CalculateFee(int audienceCount)
        {
            return movie.CalculateMovieFee(this).Times(audienceCount);
        }
    }
}

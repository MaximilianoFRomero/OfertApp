using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OfertAppRomero.Model
{
    class User
    {
        private List<Offer> votedOffers = new List<Offer>();
        public string name {  get; set; }

        public void Votation(Offer offer, int vote) 
        {
            offer.votes += vote;
            this.votedOffers.Add(offer);
        }
    }
}

using OfertAppRomero.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OfertAppRomero.Controller
{
    class OfferController
    {
        private List<Offer> offers = new List<Offer>();

        public void addNewOffer(Offer offer) 
        {
            this.offers.Add(offer);
        }

        public Offer getOffer(int index) 
        {
            return this.offers[index];
        }
    }
}

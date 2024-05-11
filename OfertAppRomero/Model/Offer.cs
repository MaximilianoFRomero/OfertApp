using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OfertAppRomero.Model
{
    class Offer
    {
        public string picture {  get; set; }
        public double price {  get; set; }
        public string description { get; set; }
        public DateTime dateSince {  get; set; }
        public DateTime dateTo { get; set; }
        public double votes {  get; set; }

        public Offer(string picture, double price, string description, DateTime dateSince, DateTime dateTo, double votes) 
        {
            this.picture = picture;
            this.price = price;
            this.description = description;
            this.price = price;
            this.dateSince = dateSince;
            this.dateTo = dateTo;
            this.votes = 0;
        }
        
    }
}

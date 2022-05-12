using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_Kevin
{
    public enum Shipping
    {
        Rush1,
        Rush2,
        Rush3,
        NoRush
    }
    public class DeskQuote
    {
        public DateTime QuoteDate { get; set; }
        public decimal QuoteAmount { get; set; }
        public string CustomerName { get; set; }
        public Shipping Shipping { get; set; }
        public Desk Desk { get; set; }
    }
}

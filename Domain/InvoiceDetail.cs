using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica01.Domain
{
    public class InvoiceDetail
    {
        public Item Item { get; set; }
        public Invoice Invoice { get; set; }
        public int Amount { get; set; }
        public int SellPrice { get; set; }

        public float SubTotal()
        {
            return (Amount * SellPrice);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Home_Ria
{
    class Public_Utilities
    {
        public Public_Utilities(long priceSummer, long priceWinter, string individualHeating)
        {
            PriceSummer = priceSummer;
            PriceWinter = priceWinter;
            IndividualHeating = individualHeating;
        }
        public Public_Utilities()
        {
            PriceSummer = 0;
            PriceWinter = 0;
            IndividualHeating = String.Empty;
        }

        public long PriceSummer { get; set; }
        public long PriceWinter { get; set; }
        public string IndividualHeating { get; set; }

    }
}

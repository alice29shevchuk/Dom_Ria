using System;
using System.Collections.Generic;
using System.Text;

namespace Home_Ria
{
    class Price
    {
        public double UkrCurrency { get; set; }
        public double AmericanCurrency { get; set; }
        public double PricePerSquareMeter { get; set; }
        public Price()
        {
            UkrCurrency = 0;
            AmericanCurrency = 0;
            PricePerSquareMeter = 0;
        }
        public Price(long ukrCurrency, long americanCurrency, long pricePerSquareMeter)
        {
            UkrCurrency = ukrCurrency;
            AmericanCurrency = americanCurrency;
            PricePerSquareMeter = pricePerSquareMeter;
        }
    }
}

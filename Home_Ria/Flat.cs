using System;
using System.Collections.Generic;
using System.Text;

namespace Home_Ria
{
    class Flat
    {
        public Price price { get; set; }
        public Location location { get; set; }
        public About_Flat information_Flat { get; set; }
        public Public_Utilities public_Utilities { get; set; }
        public Realtor realtor { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public int Id { get; set; }
        public Flat()
        {
            this.price = new Price();
            this.location = new Location();
            this.information_Flat = new About_Flat();
            this.public_Utilities = new Public_Utilities();
            this.realtor = new Realtor();
            Title = String.Empty;
            Text = String.Empty;
            Id = 0;
        }
        public Flat(Price price, Location location, About_Flat information_Flat, Public_Utilities public_Utilities, Realtor realtor, string title, string text,int id)
        {
            this.price = price;
            this.location = location;
            this.information_Flat = information_Flat;
            this.public_Utilities = public_Utilities;
            this.realtor = realtor;
            Title = title;
            Text = text;
            Id = id;
        }
        public override string ToString()
        {
            return string.Format("Заголовок: {0}\nГород: {1}\nРайон: {2}\nУлица: {3}\nНомер дома: {4}\nЦена в $: {5}\nЦена в грн: {6}\nЦена за кв.м: {7}\nЭтаж: {8}\nКоличество комнат: {9}" +
                "\nОбщая квадратура: {10}\nКоммунальные услуги за лето: {11}\nКоммунальные услуги за зиму: {12}\nНаличие индивидуального отопления: {13}\nИмя риелтора: {14}\nФамилия риелтора: {15}" +
                "\nОтчество риелтора: {16}\nНомер телефона риелтора: {17}\nРейтинг риелтора: {18}\nДополнительная информация: {19}\nID: {20}\n"
                , Title, location.City, location.District, location.Street, location.HomeNumber, price.AmericanCurrency, price.UkrCurrency, price.PricePerSquareMeter, information_Flat.Floor, information_Flat.CountRoom, information_Flat.GeneralQuadrature, public_Utilities.PriceSummer, public_Utilities.PriceWinter, public_Utilities.IndividualHeating, realtor.Name, realtor.Surname, realtor.Patronymic, realtor.PhoneNumber, realtor.Rating,Text, Id);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Threading;
namespace Home_Ria
{
    class Manager_Sites:Human
    {
        //public List<Flat> flats { get; set; }
        //public Flat flat { get; set; }
        public Manager_Sites()
        {
            flat = new Flat();
            flats = new List<Flat>();
        }
        public void Add()
        {
            Read();
            flat = new Flat();
            if (flats.Count > 0)
            {
                flat.Id = flats[flats.Count - 1].Id+1;
            }
            else
            {
                flat.Id = 0;
            }
            Console.Write("Введите заголовок: ");
            flat.Title = Console.ReadLine();

            Console.Write("Введите город: ");
            flat.location.City = Console.ReadLine();
            Console.Write("Введите район: ");
            flat.location.District = Console.ReadLine();
            Console.Write("Введите улицу: ");
            flat.location.Street = Console.ReadLine();
            Console.Write("Введите номер дома: ");
            flat.location.HomeNumber = Console.ReadLine();

            Console.Write("Введите общую площадь: ");
            flat.information_Flat.GeneralQuadrature = double.Parse(Console.ReadLine());

            Console.Write("Введите стоимость в долларах за 1 кв.м: ");
            flat.price.PricePerSquareMeter = double.Parse(Console.ReadLine());

            flat.price.AmericanCurrency = flat.price.PricePerSquareMeter * flat.information_Flat.GeneralQuadrature;
            flat.price.UkrCurrency = flat.price.AmericanCurrency * 29.90;

            Console.Write("Введите этаж: ");
            flat.information_Flat.Floor = int.Parse(Console.ReadLine());
            Console.Write("Введите количество комнат: ");
            flat.information_Flat.CountRoom = int.Parse(Console.ReadLine());

            Console.Write("Введите стоимость коммунальных за лето: ");
            flat.public_Utilities.PriceSummer = long.Parse(Console.ReadLine());
            Console.Write("Введите стооимость коммунальных за зиму: ");
            flat.public_Utilities.PriceWinter = long.Parse(Console.ReadLine());
            Console.Write("Введите наличие индивидуального отопления: ");
            flat.public_Utilities.IndividualHeating = Console.ReadLine();

            Console.Write("Введите имя риелтора: ");
            flat.realtor.Name = Console.ReadLine();
            Console.Write("Введите фамилию риелтора: ");
            flat.realtor.Surname = Console.ReadLine();
            Console.Write("Введите отчество риелтора: ");
            flat.realtor.Patronymic = Console.ReadLine();
            Console.Write("Введите номер телефона риелтора: +380");
            flat.realtor.PhoneNumber = "+380" + Console.ReadLine();

            Console.Write("Введите рейтинг риелтора: ");
            flat.realtor.Rating = double.Parse(Console.ReadLine());

            Console.Write("Введите текст: ");
            flat.Text = Console.ReadLine();
            flats.Add(flat);
            Console.Clear();
            Console.Write("Объявление добавлено!");
            Thread.Sleep(1000);
            Console.Clear();
        }
        public void Save()
        {
            File.Delete("dom_ria.txt");
            foreach (var item in flats)
            {
                File.AppendAllText("dom_ria.txt", item.ToString());
            }
        }
        public void RemoveAdvertisment()
        {
            Console.WriteLine("Введите ID объявления, которое хотите удалить: ");
            int id = int.Parse(Console.ReadLine());
            if(id-1 <= flats.Count-1)
            {
                flats.Remove(flats[id-1]);
                Console.WriteLine("Удаление произведено!!!");
                Save();
            }
            else
            {
                Console.WriteLine("Объявления с таким ID НЕТ!!!");
            }
        }
    }
}

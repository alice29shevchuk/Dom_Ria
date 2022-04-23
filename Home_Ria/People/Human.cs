using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
namespace Home_Ria
{
    abstract class Human
    {
        public List<Flat> flats { get; set; }
        public Flat flat { get; set; }
        public Human()
        {
            flat = new Flat();
            flats = new List<Flat>();
        }
        public void Read()
        {
            string read_file = File.ReadAllText("dom_ria.txt");
            string[] mas = read_file.Split(':', '\n');
            string[] tmp = new string[mas.Length / 2];
            int j = 0;
            for (int i = 0; i < mas.Length; i++)
            {
                if (i % 2 != 0)
                {
                    tmp[j] = mas[i].TrimStart();
                    j++;
                }
            }
            for (int i = 0; i < tmp.Length-1; i++)
            {
                flat = new Flat();
                flat.Title = tmp[i];
                flat.location.City = tmp[i + 1];
                flat.location.District = tmp[i + 2];
                flat.location.Street = tmp[i + 3];
                flat.location.HomeNumber = tmp[i + 4];
                flat.price.AmericanCurrency = double.Parse(tmp[i + 5]);
                flat.price.UkrCurrency = double.Parse(tmp[i + 6]);
                flat.price.PricePerSquareMeter = double.Parse(tmp[i + 7]);
                flat.information_Flat.Floor = int.Parse(tmp[i + 8]);
                flat.information_Flat.CountRoom = int.Parse(tmp[i + 9]);
                flat.information_Flat.GeneralQuadrature = double.Parse(tmp[i + 10]);
                flat.public_Utilities.PriceSummer = long.Parse(tmp[i + 11]);
                flat.public_Utilities.PriceWinter = long.Parse(tmp[i + 12]);
                flat.public_Utilities.IndividualHeating = tmp[i + 13];
                flat.realtor.Name = tmp[i + 14];
                flat.realtor.Surname = tmp[i + 15];
                flat.realtor.Patronymic = tmp[i + 16];
                flat.realtor.PhoneNumber = tmp[i + 17];
                flat.realtor.Rating = double.Parse(tmp[i + 18]);
                flat.Text = tmp[i + 19];
                flat.Id = int.Parse(tmp[i + 20]);
                flats.Add(flat);
                i += 20;
            }
        }
        public void ShowAll()
        {
            if (flats.Count == 0) Read();
            foreach (var item in flats)
            {
                Console.WriteLine($"{item}");
            }
        }
    }
}

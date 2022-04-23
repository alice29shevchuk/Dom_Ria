using System;
using System.Collections.Generic;
using System.Text;

namespace Home_Ria
{
    class Realtor
    {
        public Realtor(string name, string surname, string patronymic, string phoneNumber, double rating)
        {
            Name = name;
            Surname = surname;
            Patronymic = patronymic;
            PhoneNumber = phoneNumber;
            Rating = rating;
        }
        public Realtor()
        {
            Name = String.Empty;
            Surname = String.Empty;
            Patronymic = String.Empty;
            PhoneNumber = String.Empty;
            Rating = 0.0;
        }

        public string Name { get; set; }
        public string Surname { get; set; }
        public string Patronymic { get; set; }
        public string PhoneNumber { get; set; }
        public double Rating { get; set; }

    }
}

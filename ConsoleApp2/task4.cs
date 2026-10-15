using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    internal class City
    {
        private string city_name;
        private string country_name;
        private int peaple;
        private string telephone;
        private string[] districts;
        public string CityName
        {
            get { return city_name; }
            set { city_name = value; }
        }
        public string Сountry_name
        {
            get { return country_name; }
            set { country_name = value; }
        }
        public int Peaple
        {
            get { return peaple; }
            set { peaple = value; }
        }
        public string Telephone
        {
            get { return telephone; }
            set { telephone = value; }
        }
        public string[] Districts
        {
            get { return districts; }
            set { districts = value; }
        }
    }
}

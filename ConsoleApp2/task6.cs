using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    internal class Fly
    {

        private string name;
        private string manufacturer_name;
        private DateTime date;
        private string type;

        Fly()
        {
            name = "";
            manufacturer_name = "";
            type = "";
        }
        Fly(string _name, DateTime _date, string _manufacturer_name, string _type)
        {
            name = _name;
            manufacturer_name = _manufacturer_name;
            date = _date;
            type = _type;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Manufacturer_name
        {
            get { return manufacturer_name; }
            set { manufacturer_name = value; }
        }
        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }
        public string Type
        {
            get { return type; }
            set { type = value; }
        }






    }
}

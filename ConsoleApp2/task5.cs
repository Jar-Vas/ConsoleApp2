using System;
using System.Collections.Generic;
using System.Runtime.Versioning;
using System.Text;

namespace ConsoleApp2
{
    internal class Emploee
    {
        private string fName;
        private string sName;
        private string lName;
        private DateTime birthbay;
        private string phoneNum;
        private string e_mail;
        private string post;
        private string desk;

        public string FName
        {
            get { return fName; }
            set { fName = value; }
        }
        public string SName
        {
            get { return sName; }
            set { sName = value; }
        }
        public string LName
        {
            get { return lName; }
            set { lName = value; }
        }
        public DateTime Birthbay
        {
            get { return birthbay; }
            set { birthbay = value; }
        }
        public string PhoneNum
        {
            get { return phoneNum; }
            set { phoneNum = value; }
        }
        public string E_mail
        {
            get { return e_mail; }
            set { e_mail = value; }
        }
        public string Post
        {
            get { return post; }
            set { post = value; }
        }
        public string Desk
        {
            get { return desk; }
            set { desk = value; }
        }
    }
}

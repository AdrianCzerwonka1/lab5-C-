using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Person
    {
        private string FName;
        private string MName;
        private string LName;
        private string Street1;
        private string Street2;
        private string City;
        private string State;
        private string Zip;
        private string Phone;
        private string Email;

        public string FirstName
        {
            get
            {
                return FName;
            }
            set
            {
                FName = value;
            }
        }
        public string MidName
        {
            get
            {
                return MName;
            }
            set
            {
                MName = value;
            }
        }
        public string LastName
        {
            get
            {
                return LName;
            }
            set
            {
                LName = value;
            }
        }
        public string StreetOne
        {
            get
            {
                return Street1;
            }
            set
            {
                Street1 = value;
            }
        }
        public string StreetTwo
        {
            get
            {
                return Street2;
            }
            set
            {
                Street2 = value;
            }
        }
        public string PubCity
        {
            get
            {
                return City;
            }
            set
            {
                City = value;
            }
        }
        public string PubState
        {
            get
            {
                return State;
            }
            set
            {
                State = value;
            }
        }
        public string ZipCode
        {
            get
            {
                return Zip;
            }
            set
            {
                Zip = value;
            }
        }
        public string PhoneNum
        {
            get
            {
                return Phone;
            }
            set
            {
                Phone = value;
            }
        }
        public string UserEmail
        {
            get
            {
                return Email;
            }
            set
            {
                Email = value;
            }
        }

    }




    public class Insta : Person
    {
        private string Instagram;
        private string CellPhone;
        public string UserInsta
        {
            get
            {
                return Instagram;
            }
            set
            {
                Instagram = value;
            }
        }

            public string Cell
        {
            get
            {
                return CellPhone;
            }
            set
            {
                CellPhone = value;
            }

        } } }




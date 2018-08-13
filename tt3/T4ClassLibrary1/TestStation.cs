using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace T4ClassLibrary1
{
    public abstract class TestStation
    {
        protected string z_registeredName;
        protected string z_address;
        protected string z_phoneNumber;

        public string RegisteredName
        {
            get => z_registeredName;
            set
            {
            }
        }

        public string Address
        {
            get => z_address;
            set
            {
            }
        }

        public string PhoneNumber
        {
            get => z_phoneNumber;
            set
            {
            }
        }

        public abstract string ShowStationDetails();
    }
}
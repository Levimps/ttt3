using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace T4ClassLibrary1
{
    public class VTNZ : TestStation
    {
        private IService _service;
        private static int  _requestNumber = 0;
        private static decimal _totalPrice = 0M;

        public VTNZ()
        {
           
        }

        public VTNZ(string Name, string Address, string PhoneNumber)
        {
            z_registeredName = Name;
            z_address = Address;
            z_phoneNumber = PhoneNumber;

        }

        public int RequestNumber
        {
            get => _requestNumber;
            set
            {
                _requestNumber = value;
            }
        }

        public decimal TotalPrice
        {
            get => _totalPrice;
            set
            {
            }
        }

        public override string ShowStationDetails()
        {
            return z_registeredName + "\n" + z_address + "\n" + z_phoneNumber;
        }

        public void RequestService(IService selectedService)
        {
            _service = selectedService;  //instance of interface
            _requestNumber += 1;
            _totalPrice += _service.Price;
        }

        public string ShowServiceDetail()
        {
            return "\n"+_service.Type + "\n" + _service.Price + "\n";
        }
    }
}
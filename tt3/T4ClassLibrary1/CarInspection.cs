using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace T4ClassLibrary1
{
    public class CarInspection
    {
        private string _type;
        private decimal _price;

        public CarInspection()
        {
        }

        public CarInspection(string ItemType, decimal ItemPrice)
        {
            _type = ItemType;
            _price = ItemPrice;
        }

        public string Type        //warp get=>_carInspection.Type
        {
            get =>  _type;
            set
            {
            }
        }

        public decimal Price
        {
            get => _price;
            set
            {
            }
        }

     /*   public string ShowServiceDetail()
        {
            return "Inspection Type" + _type + "\n Price" + _price;
        }*/
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace T4ClassLibrary1
{
    public class CarServiceWrap : IService
    {
        private CarInspection _carInspection;

        public CarServiceWrap()
        {
        }

        public CarServiceWrap(string serviceType, decimal servicePrice)
        {
            _carInspection = new CarInspection(serviceType, servicePrice);
        }

      
        string IService.Type { get => _carInspection.Type; set { } }

        decimal IService.Price { get => _carInspection.Price; set { } }

        /*public string ShowServiceDetail()
        {
           return  _carInspection.ShowServiceDetail();  //useless?
        }*/
    }
}
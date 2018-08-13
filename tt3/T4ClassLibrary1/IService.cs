using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace T4ClassLibrary1
{
    public interface IService
    {
        string Type { get; set; }
        decimal Price { get; set; }
    }
}
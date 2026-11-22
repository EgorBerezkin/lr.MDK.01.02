using System;
using System.Collections.Generic;

namespace DemoLib.Models
{
    public interface IOrdersModel
    {
        List<Order> Load();
    }
}

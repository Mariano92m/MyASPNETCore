using MyCoreApplication.Core;
using System;
using System.Collections.Generic;

namespace MyCoreApplication.Data
{
    public interface IBimboProductData
    {
        IEnumerable<BimboProduct> GetAll();
    }
}

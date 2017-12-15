using System;
using System.Collections.Generic;
using System.Text;

namespace Redbit.SOLID.ISP.Solution
{
    public interface IStockItemRegister
    {
        void ValidData();
        void SaveData();
    }
}

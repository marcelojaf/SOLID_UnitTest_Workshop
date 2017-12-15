using System;
using System.Collections.Generic;
using System.Text;

namespace Redbit.SOLID.ISP.Violation
{
    public interface IRegister
    {
        void ValidData();
        void SaveData();
        void SendEmail();
    }
}

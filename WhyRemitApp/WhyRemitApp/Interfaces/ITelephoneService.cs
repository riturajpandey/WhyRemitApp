using System;
using System.Collections.Generic;
using System.Text;

namespace WhyRemitApp.Interfaces
{
    public interface ITelephoneService
    {
        bool GetISDCode(string phoneNum);
    }
}

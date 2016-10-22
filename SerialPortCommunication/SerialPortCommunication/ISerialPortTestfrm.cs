using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerialPortCommunication
{
    public interface ISerialPortTestfrm
    {
        string SavePath { get; set; }
        string LoadPath { get; set; }
        Filter AppliedFilter { get; set; }

        int HueMinValue { get; set; }
        int HueMaxValue { get; set; }
        int SatMinValue { get; set; }
        int SatMaxValue { get; set; }
        int ValMinValue { get; set; }
        int ValMaxValue { get; set; }

        bool IsErodeEnabled { get; set; }
        bool IsDilateEnabled { get; set; }

        decimal ErodeValue { get; set; }
        decimal DilateValue { get; set; }
        
        int CannyMinValue { get; set; }
        int CannyMaxValue { get; set; }
    }
}

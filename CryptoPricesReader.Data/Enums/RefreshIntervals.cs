using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoPricesReader.Data.Enums
{
    public enum RefreshIntervals
    {
        HalfMinute = 30,
        Minute = 60,
        MinuteAndHalf = 90,
        TwoMinutes = 120,
        ThreeMinutes = 180,
        FiveMinutes = 300,
        TenMinutes = 600
    }
}

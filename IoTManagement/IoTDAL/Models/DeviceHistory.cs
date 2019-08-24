using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IoTDAL.Models
{
    class DeviceHistory
    {
        public int HistoryId { get; set; }
        public int DeviceId { get; set; }
        public string Temperature { get; set; }
        public string Pressure { get; set; }
        public DateTime MeasureTime { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IoTDAL.Models
{
    class DeviceModel
    {
        public int DeviceId { get; set; }
        public int HubId { get; set; }
        public string DeviceName { get; set; }
        public string DeviceModelName { get; set; }
        public string CurrentTemperature { get; set; }
        public string CurrentPressure { get; set; }
        public string IPAddress { get; set; }
        public DateTime MeasureTime { get; set; }
    }
}

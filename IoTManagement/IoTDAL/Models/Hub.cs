using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IoTDAL.Models
{
    class Hub
    {
        public int HubId { get; set; }
        public int DeviceId { get; set; }
        public string Temperature { get; set; }
    }
}

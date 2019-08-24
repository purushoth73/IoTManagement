using IoTDAL.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IoTDAL.Providers
{
    class DeviceDataProvider
    {


        public DeviceDataProvider()
        {
            
        }

        public List<DeviceHistory> getDeviceDetails(int id)
        {

            string connectionString = GetConnectionString();
            List<DeviceHistory> deviceHistory = new List<DeviceHistory>();

            DataSet devicesDataSet = new DataSet();

            using (SqlConnection connection = new SqlConnection())
            {
                connection.ConnectionString = connectionString;
                connection.Open();
                string queryString = String.Format("SELECT * from deviceHistory where deviceId={0};",id);

                SqlCommand command =
           new SqlCommand(queryString, connection);
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                // Call Read before accessing data.
                while (reader.Read())
                {
                    //Mapper
                    DeviceHistory history = new DeviceHistory();
                    history.DeviceId = Convert.ToInt32(reader["Id"]);
                    history.HistoryId = Convert.ToInt32(reader["DeviceHistoryId"].ToString());
                    history.Temperature = reader["Temperature"].ToString();
                    history.Pressure = reader["Pressure"].ToString();
                    history.MeasureTime = Convert.ToDateTime(reader["Time"].ToString());

                    deviceHistory.Add(history);
                }

                // Call Close when done reading.
                reader.Close();

                return deviceHistory;
            }
        }

        public List<DeviceModel> getDevices()
        {
            string connectionString = GetConnectionString();
            List<DeviceModel> devices = new List<DeviceModel>();

            DataSet devicesDataSet = new DataSet();

            using (SqlConnection connection = new SqlConnection())
            {
                connection.ConnectionString = connectionString;
                connection.Open();
                string queryString = "SELECT * from devices;";

                SqlCommand command =
           new SqlCommand(queryString, connection);
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                // Call Read before accessing data.
                while (reader.Read())
                {
                    //Mapper
                    DeviceModel device = new DeviceModel();
                    device.DeviceId =Convert.ToInt32(reader["Id"]);
                    device.DeviceName = reader["DeviceName"].ToString();
                    device.DeviceModelName = reader["DeviceModelName"].ToString();
                    device.CurrentTemperature = reader["DeviceName"].ToString();
                    device.CurrentPressure = reader["DeviceName"].ToString();
                    device.MeasureTime = Convert.ToDateTime(reader["DeviceName"].ToString());
                    device.IPAddress = reader["DeviceName"].ToString();
                    device.HubId = Convert.ToInt32(reader["HubId"]);

                    devices.Add(device);
                }

                // Call Close when done reading.
                reader.Close();

                return devices;
            }
        }

        static private string GetConnectionString()
        {
            return "Server=localhost\\SQLEXPRESS;Database=master;Trusted_Connection=True;";
        }
    }
}

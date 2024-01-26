using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleDetails
{
    public  class Truck:Vehicle
    {
        public double PayloadCapaciy { get; set; }
        public double TowingCapaciy { get; set; }
        public double TruckBedLengthCapaciy { get; set; }

        public Truck (string make, string model, int year, double enginesize, string fueltype, 
           
            double payloadCapaciy, double towingCapaciy, double truckBedLengthCapaciy):base(make,model, year, enginesize,fueltype)

        {

            Make = make;
            Model = model;
            Year = year;
            Enginesize = enginesize;
            Fueltype = fueltype;
            PayloadCapaciy = payloadCapaciy;
            TowingCapaciy = towingCapaciy;
            TruckBedLengthCapaciy = truckBedLengthCapaciy;



        }
        public void insertintodatabase(string connectionstring)
        {
            using (SqlConnection connection = new SqlConnection(connectionstring))
            {
                connection.ConnectionString = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=login;Data Source=DESKTOP-IS6T1F1\\SQLEXPRESS; Encrypt=false";

                connection.Open();

                SqlCommand command = new SqlCommand("INSERT INTO Truck1 ( PayloadCapacity, TowingCapacity, TruckBedLength) VALUES ( @PayloadCapacity, @TowingCapacity, @TruckBedLength)", connection);

                 command.Parameters.AddWithValue("@PayloadCapacity", PayloadCapaciy);
                command.Parameters.AddWithValue("@TowingCapacity", TowingCapaciy);
                command.Parameters.AddWithValue("@TruckBedLength", TruckBedLengthCapaciy);

                command.ExecuteNonQuery();
            }
        }
    }
}

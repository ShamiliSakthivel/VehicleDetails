using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleDetails
{
    public class Vehicle
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public double Enginesize { get; set; }
        public string Fueltype { get; set; }
       
        public Vehicle(string make, string model, int year, double enginesize, string fueltype)
        {
            Make = make;
            Model = model;
            Year = year;
            Enginesize = enginesize;
            Fueltype = fueltype;
        }
        public void insertintodatabase(string connectionstring)
        {
            using (SqlConnection connection = new SqlConnection(connectionstring))
            {
                connection.ConnectionString = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=login;Data Source=DESKTOP-IS6T1F1\\SQLEXPRESS; Encrypt=false";

                connection.Open();

                SqlCommand command = new SqlCommand(" insert into Vehicles1(Make , Model ,Year ,EngineSize ,FuelType)VALUES ( @Make , @Model ,@Year ,@EngineSize ,@FuelType)", connection);

                command.Parameters.AddWithValue("@Make",Make);
                command.Parameters.AddWithValue("@Model",Model);
                command.Parameters.AddWithValue("@Year", Year);
                command.Parameters.AddWithValue("@EngineSize ",Enginesize);
                command.Parameters.AddWithValue("@FuelType", Fueltype);

                command.ExecuteNonQuery();
            }
        }
    }
}

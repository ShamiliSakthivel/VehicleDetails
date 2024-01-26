using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic.FileIO;

namespace VehicleDetails
{
    public  class Car: Vehicle
    {
        public int NumberofDoors { get; set; }
        public string TransmissionType { get; set; }
        public string DriveType { get; set; }

        public Car(string make, string model, int year, double enginesize, string fueltype,int numberofDoors, string transmissionType, string driveType):base( make,  model,  year, enginesize, fueltype)
        {
            Make = make;
            Model = model; 
            Year = year;
            Enginesize = enginesize;
            Fueltype = fueltype;
            NumberofDoors = numberofDoors;
            TransmissionType = transmissionType;
            DriveType = driveType;
           
           

        }
        public void insertintodatabase (string connectionstring)
        {
            using (SqlConnection connection = new SqlConnection(connectionstring))
            {
                connection.ConnectionString = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=login;Data Source=DESKTOP-IS6T1F1\\SQLEXPRESS; Encrypt=false";

                connection.Open();
               
                SqlCommand command = new SqlCommand(" insert into Car1(NumberOfDoors,TransmissionType,DriveType)VALUES ( @NumberOfDoors, @TransmissionType, @DriveType)", connection);

               command.Parameters.AddWithValue("@NumberOfDoors", NumberofDoors);
                command.Parameters.AddWithValue("@TransmissionType", TransmissionType);
                command.Parameters.AddWithValue("@DriveType", DriveType);
                
                command.ExecuteNonQuery();
            }
        }
    }
}

using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic.FileIO;
using System.IO;
using System.Windows;

namespace VehicleDetails
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string connectionstring= "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=login;Data Source=DESKTOP-IS6T1F1\\SQLEXPRESS; Encrypt=false";

        public MainWindow()
        {
            InitializeComponent();
           
        }

        private void btnsave_Click(object sender, RoutedEventArgs e)
        {

            string make = txtMake.Text;
            string model = txtModel.Text;
            int year = int.Parse(txtYear.Text);
            double engineSize = double.Parse(txtEngineSize.Text);
            string fuelType = txtFuelType.Text;

            Vehicle vehicle = new Vehicle(make, model, year, engineSize, fuelType);
            vehicle.insertintodatabase(connectionstring);
            ////int numberOfDoors = int.Parse(txtNumberOfDoors.Text);
            //string transmissionType =txtTransmissionType.Text;
            //string driveType = txtDriveType.Text;

            // Creating a new Car instance
            //Car car = new Car(make, model, year, engineSize, fuelType, numberOfDoors, transmissionType, driveType);


            //car.insertintodatabase(connectionstring);

        }

        private void car_Click(object sender, RoutedEventArgs e)
        {
            Cars car = new Cars();
            car.Show();
        }

        private void Truck_Click(object sender, RoutedEventArgs e)
        {
            Trucks trucks = new Trucks();
            trucks.Show();
        }
    }
     }


        

       
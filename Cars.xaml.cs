using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace VehicleDetails
{
    /// <summary>
    /// Interaction logic for Cars.xaml
    /// </summary>
    public partial class Cars : Window
    {
        private string connectionstring = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=login;Data Source=DESKTOP-IS6T1F1\\SQLEXPRESS; Encrypt=false";

        public Cars()
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
            int numberOfDoors = int.Parse(txtNumberOfDoors.Text);
            string transmissionType = txtTransmissionType.Text;
            string driveType = txtDriveType.Text;

            // Creating a new Car instance
            Car car = new Car(make, model, year, engineSize, fuelType, numberOfDoors, transmissionType, driveType);


            car.insertintodatabase(connectionstring);

        }
    }
}

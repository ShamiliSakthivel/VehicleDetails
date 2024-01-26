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
    /// Interaction logic for Trucks.xaml
    /// </summary>
    public partial class Trucks : Window
    {
        private string connectionstring = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=login;Data Source=DESKTOP-IS6T1F1\\SQLEXPRESS; Encrypt=false";

        public Trucks()
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
            double payloadCapaciy = double.Parse(txtPayloadCapacity.Text);
            double towingCapaciy = double.Parse(txtTowingCapacity.Text);
            double truckBedLengthCapaciy = double.Parse(txtTruckBedLength.Text);

            Truck truck = new Truck(make, model, year, engineSize, fuelType, payloadCapaciy, towingCapaciy, truckBedLengthCapaciy);
            truck.insertintodatabase(connectionstring);
        }
    }
}

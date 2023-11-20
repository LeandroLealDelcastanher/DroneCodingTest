using DroneCodingTest.Models;
using DroneCodingTest.Service;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace DroneCodingTest
{
    public partial class DroneCodingTest : Form
    {
        private ICollection<Drone> _drones;
        private ICollection<DeliveryLocation> _deliveryLocations;
        private string _directory;

        public DroneCodingTest()
        {
            InitializeComponent();
        }

        private void Bt_select_file_Click(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog ofd = new OpenFileDialog())
                {
                    ofd.InitialDirectory = @"C:\";
                    ofd.Filter = "txt files (*.txt)|*.txt";
                    ofd.FilterIndex = 1;
                    ofd.RestoreDirectory = true;

                    if (ofd.ShowDialog() == DialogResult.OK && !string.IsNullOrEmpty(ofd.FileName))
                    {
                        ClearData();

                        DataManagementService.ExtractInformations(File.ReadAllText(ofd.FileName), out _drones, out _deliveryLocations);
                        _directory = System.IO.Path.GetDirectoryName(ofd.FileName);

                        LoadGrids();
                        textMessage.Text = "Successfull loaded.";
                    }
                }
            }
            catch (Exception ex)
            {
                textMessage.Text = ex.Message;
            }
        }

        private void ClearData()
        {
            _directory = string.Empty;
            _drones = null;
            _deliveryLocations = null;
            textMessage.Text = "";
            dronesGridView.Rows.Clear();
            locationsGridView.Rows.Clear();
        }

        private void LoadGrids()
        {
            foreach (var drone in _drones)
                dronesGridView.Rows.Add(drone.Name, drone.MaxWeight);

            foreach (var delivery in _deliveryLocations)
                locationsGridView.Rows.Add(delivery.Name, delivery.PackageWeight);
        }

        private void Bt_run_Click(object sender, EventArgs e)
        {
            if (_drones == null || 
                _deliveryLocations == null)
            {
                textMessage.Text = "Without data to run.";
                return;
            }

            try
            {
                var convoys = DistribuitionService.CalculateWeightDistribuition(_drones, _deliveryLocations);
                var response = DataManagementService.ToString(convoys, _drones);

                string pathName = _directory + @"\" + "Output_" + DateTime.Now.ToString("yyyyMMddHHmmss") + ".txt";
                using (FileStream fs = File.Create(pathName))
                {
                    Byte[] info = new UTF8Encoding(true).GetBytes(response);
                    fs.Write(info, 0, info.Length);
                }
                textMessage.Text = @"Successfull exported on '" + pathName + ".";
            }
            catch (Exception ex)
            {
                textMessage.Text = ex.Message;
            }
        }
    }
}

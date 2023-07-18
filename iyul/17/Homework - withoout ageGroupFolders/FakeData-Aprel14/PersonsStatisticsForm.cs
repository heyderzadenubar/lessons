using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace FakeData_Aprel14
{
    public partial class PersonStatisticsForm : Form
    {
        public PersonStatisticsForm()
        {
            InitializeComponent();
        }

        private void PersonStatisticsForm_Load(object sender, EventArgs e)
        {
            int countDirectories = Directory.GetDirectories(GlobalSettings.COUNTRIES_PATH).Length;
            //-----------Get topdirectory in Countries directory------------
            string[] countryFolderNameArray = Directory.GetDirectories(GlobalSettings.COUNTRIES_PATH, "*", SearchOption.TopDirectoryOnly);
           
            foreach (var item in countryFolderNameArray)
            {
                DirectoryInfo directoryName = new DirectoryInfo(item);
                string countryName = directoryName.Name;
                CountriesComboBox.Items.Add(countryName);
            }
            // we can use VirtualDatabase.allPersonsList data also
        }

        int countPerson;
        private void CountriesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string country = CountriesComboBox.SelectedItem.ToString();
            string pathCountryFolder = GlobalSettings.COUNTRIES_PATH+country;
            countPerson = Directory.GetFiles(pathCountryFolder).Length;
            countPersonLabel.Text = countPerson.ToString();
        }
    }
}

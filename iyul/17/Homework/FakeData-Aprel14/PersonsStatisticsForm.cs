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

        int countPersonAge_0_18 = 0, countPersonAge_19_35 = 0, countPersonAge_36_60 = 0, countPersonAge_60Plus = 0;
        private void CountriesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string country = CountriesComboBox.SelectedItem.ToString();
            string CountryFolder_0_18_PATH = GlobalSettings.COUNTRIES_PATH+country+GlobalSettings.AGE_0_18_PATH;
            string CountryFolder_19_35_PATH = GlobalSettings.COUNTRIES_PATH + country + GlobalSettings.AGE_19_35_PATH;
            string CountryFolder_36_60_PATH = GlobalSettings.COUNTRIES_PATH + country + GlobalSettings.AGE_36_60_PATH;
            string CountryFolder_60_plus_PATH = GlobalSettings.COUNTRIES_PATH + country + GlobalSettings.AGE_60_PLUS_PATH;
            if (Directory.Exists(CountryFolder_0_18_PATH))
            {
                countPersonAge_0_18 = Directory.GetFiles(CountryFolder_0_18_PATH).Length;
            }
            if (Directory.Exists(CountryFolder_19_35_PATH))
            {
                countPersonAge_19_35 = Directory.GetFiles(CountryFolder_19_35_PATH).Length;
            }
            if (Directory.Exists(CountryFolder_36_60_PATH))
            {
                countPersonAge_36_60 = Directory.GetFiles(CountryFolder_36_60_PATH).Length;
            }
            if (Directory.Exists(CountryFolder_60_plus_PATH))
            {
                countPersonAge_60Plus = Directory.GetFiles(CountryFolder_60_plus_PATH).Length;
            }
            countPerson_Age_0_18_Label.Text = countPersonAge_0_18.ToString();
            countPerson_Age_19_35_Label.Text = countPersonAge_19_35.ToString();
            countPerson_Age_36_60_Label.Text = countPersonAge_36_60.ToString();
            countPerson_Age_60_Plus_Label.Text = countPersonAge_60Plus.ToString();
        }
    }
}

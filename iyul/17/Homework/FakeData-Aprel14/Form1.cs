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
    public partial class PersonsInfoForm : Form
    {
        public PersonsInfoForm()
        {
            InitializeComponent(); 
        }
        
        private void PersonsInfoForm_Load(object sender, EventArgs e)
        {
        }
        Random rand = new Random();
        private void GeneratePersonButtonClick(object sender, EventArgs e)
        {
            PersonsStatisticsButton.Enabled = true;
            VirtualDatabase.personsList.Clear();
            for (int i = 0; i < 440; i++)  // komp donur
            {
                Persons persons = new Persons()
                {
                    Name = FakeData.NameData.GetFirstName(),
                    Surname = FakeData.NameData.GetSurname(),
                    Age = rand.Next(0, 100),
                    Email = FakeData.NetworkData.GetEmail(),
                    Country = FakeData.PlaceData.GetCountry(),
                };
                VirtualDatabase.personsList.Add(persons);
                if (!Directory.Exists(GlobalSettings.COUNTRIES_PATH + persons.Country + GlobalSettings.AGE_0_18_PATH) ||
                    !Directory.Exists(GlobalSettings.COUNTRIES_PATH + persons.Country + GlobalSettings.AGE_19_35_PATH) ||
                    !Directory.Exists(GlobalSettings.COUNTRIES_PATH + persons.Country + GlobalSettings.AGE_36_60_PATH) ||
                    !Directory.Exists(GlobalSettings.COUNTRIES_PATH + persons.Country + GlobalSettings.AGE_60_PLUS_PATH))
                {
                    if (persons.Age >= 0 && persons.Age <= 18)
                    {
                        Directory.CreateDirectory(GlobalSettings.COUNTRIES_PATH + persons.Country + GlobalSettings.AGE_0_18_PATH);
                    }
                    else if (persons.Age >= 19 && persons.Age <= 35)
                    {
                        Directory.CreateDirectory(GlobalSettings.COUNTRIES_PATH + persons.Country + GlobalSettings.AGE_19_35_PATH);
                    }
                    else if (persons.Age >= 36 && persons.Age <= 60)
                    {
                        Directory.CreateDirectory(GlobalSettings.COUNTRIES_PATH + persons.Country + GlobalSettings.AGE_36_60_PATH);
                    }
                    else if (persons.Age >= 61)
                    {
                        Directory.CreateDirectory(GlobalSettings.COUNTRIES_PATH + persons.Country + GlobalSettings.AGE_60_PLUS_PATH);
                    }
                }
                if (persons.Age >= 0 && persons.Age <= 18)
                {
                    FileStream fileStream = File.Create(GlobalSettings.COUNTRIES_PATH + persons.Country + GlobalSettings.AGE_0_18_PATH
                                        + persons.Name + "-" + persons.Surname + "-" + rand.Next(1, 100000) + ".txt");
                    fileStream.Close();
                }
                else if (persons.Age >= 19 && persons.Age <= 35)
                {
                    FileStream fileStream = File.Create(GlobalSettings.COUNTRIES_PATH + persons.Country + GlobalSettings.AGE_19_35_PATH
                                        + persons.Name + "-" + persons.Surname + "-" + rand.Next(1, 100000) + ".txt");
                    fileStream.Close();
                }
                else if (persons.Age >= 36 && persons.Age <= 60)
                {
                    FileStream fileStream = File.Create(GlobalSettings.COUNTRIES_PATH + persons.Country + GlobalSettings.AGE_36_60_PATH
                                        + persons.Name + "-" + persons.Surname + "-" + rand.Next(1, 100000) + ".txt");
                    fileStream.Close();
                }
                else if (persons.Age >= 61)
                {
                    FileStream fileStream = File.Create(GlobalSettings.COUNTRIES_PATH + persons.Country + GlobalSettings.AGE_60_PLUS_PATH
                                        + persons.Name + "-" + persons.Surname + "-" + rand.Next(1, 100000) + ".txt");
                    fileStream.Close();
                }

            }
            dataGridView1.DataSource = VirtualDatabase.personsList;

        }

        private void PersonsStatisticsButton_Click(object sender, EventArgs e)
        {
            PersonStatisticsForm personStatisticsForm = new PersonStatisticsForm();
            personStatisticsForm.ShowDialog();
        }
    }

    
}

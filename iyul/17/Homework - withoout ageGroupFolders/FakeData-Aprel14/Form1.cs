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
            for (int i = 0; i <100; i++)  // komp donur
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
                if (!Directory.Exists(GlobalSettings.COUNTRIES_PATH + persons.Country))
                {
                    Directory.CreateDirectory(GlobalSettings.COUNTRIES_PATH + persons.Country);
                    FileStream fileStream = File.Create(GlobalSettings.COUNTRIES_PATH + persons.Country + "/"
                                        + persons.Name + "-" + persons.Surname + "-" + rand.Next(1, 100000)+".txt");
                    fileStream.Close();
                }
                else
                {
                    FileStream fileStream = File.Create(GlobalSettings.COUNTRIES_PATH + persons.Country + "/"
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

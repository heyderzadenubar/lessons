using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CustomerDB.Enums;

namespace CustomerDB
{
    public partial class NewCustomerForm : Form
    {
        public NewCustomerForm()
        {
            InitializeComponent();
            Customer customer = new Customer();
            GenderComboBox.Items.Add("Kişi");  // using CustomerDB.Enums;
            GenderComboBox.Items.Add("Qadın");
            GenderComboBox.SelectedIndex = 0;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (NameTextBox.Text == "" || SurnameTextBox.Text == "" || CountryTextBox.Text == "" || CityTextBox.Text == "" || AddressTextBox.Text == "" || EmailTextBox.Text == "" || PhoneTextBox.Text == "")
            {
                foreach (Control item in groupBox1.Controls)
                {
                    if (item is TextBox)
                    {
                        if (item.Text == "")
                        {
                            item.BackColor = Color.LightGoldenrodYellow;
                        }
                        else
                        {
                            item.BackColor = Color.White;
                        }
                    }
                }
                MessageBox.Show("Məlumatları daxil edin!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (NameTextBox.Text != "" && SurnameTextBox.Text != "" && CountryTextBox.Text != "" && CityTextBox.Text != "" && AddressTextBox.Text != "" && EmailTextBox.Text != "" && PhoneTextBox.Text != "")
            {
                Customer customer = new Customer()
                {
                    Name = NameTextBox.Text,
                    Surname = SurnameTextBox.Text,
                    Country = CountryTextBox.Text,
                    City = CityTextBox.Text,
                    Address = AddressTextBox.Text,
                    Email = EmailTextBox.Text,
                    Phone = PhoneTextBox.Text
                };
                if (GenderComboBox.SelectedIndex == 0)
                {
                    customer.Gender = GenderEnum.Male;
                }
                else if (GenderComboBox.SelectedIndex == 1)
                {
                    customer.Gender = GenderEnum.Female;
                }
                VirtualDatabase.customersList.Add(customer);
                DialogResult dialogResult = MessageBox.Show("Yeni müştəri məlumatları əlavə edildi!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (dialogResult == DialogResult.OK)
                {
                    this.Close();
                }
            }
        }

        private void NewCustomerForm_Load(object sender, EventArgs e)
        {

        }

        private void GenderComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

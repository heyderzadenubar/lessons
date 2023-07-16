using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomerDB
{
    public partial class CustomerForm : Form
    {
        /*
             Homework 1:
             Bir dənə müştəri bazası proqramı yığacaqsınız. Müştəri məlumatları belə olacaq: Ad, Soyad, Cinsiyyət, Ölkə, Şəhər, Ünvan, Telefon, Email. VirtualDatabase'də
             hazır 5-6 müştəriniz olsun və app açılanda user dropdown içindən müştərini seçəndə müştəri məlumatları textbox'lara yazılsın. TextBox'ların altında yadda saxla
             button'u olacaq və o button'a click edəndə müştərinin məlumatları VirtualDatabase'dəki List'də update olacaq. Bir dənə də qırmızı delete button'u olacaq və o
             button'a click edəndə müştərinin məlumatlarının silinib silinməməsi barədə bildiriş çıxacaq ("Müştərini silmək istədiyinizdən əminsiniz mi?") və adam Yes seçsə
             həmin müştərini List'dən siləcəksiz No və ya Cancel seçsə heçnə etməyəcəksiniz. Birdə Yeni Müştəri əlavə et button'u olacaq və ona da click edəndə ayrı bir form
             pəncərəsi açılacaq və müştərinin məlumatlarını doldurub əlavə et button'una click edəndə yeni əlavə olunan müştəri məlumatları VirtualDatabase'dəki List'ə əlavə
             olunacaq və form bağlanacaq. Yeni əlavə olunan müştərini dropdown'a da əlavə etməyi unutmayın. Ölkə və şəhər'i ilkin olaraq string olaraq edin. Taskı erkən
             bitirsəz ondan sonra Ölkə və Şəhər bölməsini də dropdown ilə etməyə çalışın.
         */
        public CustomerForm()
        {
            InitializeComponent();
            FillData();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void CustomerComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (Control textbox in groupBox1.Controls)
            {
                if (textbox is TextBox)
                {
                    textbox.BackColor = Color.White;
                }
            }
            ComboBox selectedİtem = (ComboBox)sender;
            string selectedCustomerName=selectedİtem.SelectedItem.ToString();

            Customer findCustomer = VirtualDatabase.customersList.Find(item => item.Name==selectedCustomerName);
            if (findCustomer != null)
            {
                NameTextBox.Text = findCustomer.Name;
                SurnameTextBox.Text = findCustomer.Surname;
                GenderTextBox.Text = findCustomer.gender;
                CountryTextBox.Text = findCustomer.Country;
                CityTextBox.Text = findCustomer.City;
                AddressTextBox.Text = findCustomer.Address;
                EmailTextBox.Text = findCustomer.Email;
                PhoneTextBox.Text = findCustomer.Phone;
                IsDeletedCheck(findCustomer);
            }
            else
            {
                MessageBox.Show("Müştəri məlumatları tapılmadı!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            Customer FindCustomer = VirtualDatabase.customersList.Find(customer => 
                                                customer.Name == CustomerComboBox.SelectedItem.ToString());
            if (FindCustomer != null)
            {
                FindCustomer.Name = NameTextBox.Text;
                FindCustomer.Surname = SurnameTextBox.Text;
                FindCustomer.Country = CountryTextBox.Text;
                FindCustomer.City = CityTextBox.Text;
                FindCustomer.Address = AddressTextBox.Text;
                FindCustomer.Email = EmailTextBox.Text;
                FindCustomer.Phone = PhoneTextBox.Text;
                DialogResult dialogResult= MessageBox.Show("Müştəri məlumatları yeniləndi!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FillData();
            }
            else
            {
                MessageBox.Show("Müştəri məlumatları tapılmadı!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void AddNewCustomerButton_Click(object sender, EventArgs e)
        {
            NewCustomerForm newCustomerForm = new NewCustomerForm();
            newCustomerForm.ShowDialog();
            FillData();
        }

        public void FillData()
        { 
            CustomerComboBox.Items.Clear();
            foreach (var customer in VirtualDatabase.customersList) 
            {
                 CustomerComboBox.Items.Add(customer);
            }

            CustomerComboBox.SelectedItem = CustomerComboBox.Items[0];
            string selectedItemName = CustomerComboBox.Items[0].ToString();
            Customer findCustomer = VirtualDatabase.customersList.Find(item => item.Name == selectedItemName);
            if (findCustomer != null)
            {
                NameTextBox.Text = findCustomer.Name;
                SurnameTextBox.Text = findCustomer.Surname;
                GenderTextBox.Text = findCustomer.gender;
                CountryTextBox.Text = findCustomer.Country;
                CityTextBox.Text = findCustomer.City;
                AddressTextBox.Text = findCustomer.Address;
                EmailTextBox.Text = findCustomer.Email;
                PhoneTextBox.Text = findCustomer.Phone;
                IsDeletedCheck(findCustomer);
            }
            else
            {
                MessageBox.Show("Müştəri məlumatları tapılmadı!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void IsDeletedCheck(Customer customer)
        {

            if (customer.isDeleted == false)
            {
                isDeletedStatusTextBox.Text = "Qeydiyyatlı";
                isDeletedStatusTextBox.ForeColor = Color.DarkGreen;
                isDeletedStatusTextBox.Font = new Font(isDeletedStatusTextBox.Font, FontStyle.Bold);
                RecoverButton.Visible = false;
            }
            else
            {
                isDeletedStatusTextBox.Text = "Silinib";
                isDeletedStatusTextBox.ForeColor = Color.DarkRed;
                isDeletedStatusTextBox.Font = new Font(isDeletedStatusTextBox.Font, FontStyle.Bold);
                RecoverButton.Visible = true;
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
           DialogResult result= MessageBox.Show(CustomerComboBox.SelectedItem.ToString() + " adlı müştərini silmək istədiyinizdən əminsizmi?", "", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                Customer foundCustomer = VirtualDatabase.customersList.Find(i => i.Name == CustomerComboBox.SelectedItem.ToString());
                if (foundCustomer != null)
                {
                    CustomerComboBox.Items.RemoveAt(CustomerComboBox.SelectedIndex);
                    foundCustomer.isDeleted = true;
                    FillData();
                    
                }
                else
                {
                    MessageBox.Show("Müştəri məlumatları tapılmadı!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void RecoverButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Müştəri hesabını bərpa etməkdən əminsizmi?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                Customer FoundCustomer = VirtualDatabase.customersList.Find(i => i.Name == CustomerComboBox.SelectedItem.ToString());
                if (FoundCustomer != null)
                {
                    FoundCustomer.isDeleted = false;
                    FillData();
                    MessageBox.Show("Müştəri hesabı bərpa edildi", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}

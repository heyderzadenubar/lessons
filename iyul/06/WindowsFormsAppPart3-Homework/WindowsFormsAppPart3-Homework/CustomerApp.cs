using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppPart3_Homework
{
    public partial class CustomerApp : Form
    {
        /*  Homework 1:
              Ev tapşırığı olaraq FormControls formunu davam etdirməyinizi istəyirəm. Əlavə Et button'una klik edəndə tələbə məlumatlarını virtual database'ə əlavə edin
              və bir dənə əlavə button atın form'a hansı ki, o buttona basanda yeni açılan bir View'da əlavə olunan insanların məlumatları olacaq. Həmin yeni açılan
              məlumatların göstərildiyi siyahı olan pəncərə bağlanmadığı müddətcə əlavə etmə səhifəsində heçnəyə klik edilə bilməsin. İstəsəz mənim yazdığımı davam
              etdirin istəsəz də yeni bir proyekt açıb sıfırdan özünüz yazın.
          */
        public CustomerApp()
        {
            InitializeComponent();
        }

        private void Add(object sender, EventArgs e)
        {
            Customer customer = new Customer()
            {
                Name = NameTextBox.Text,
                Surname = SurnameTextBox.Text,
                Email = EmailTextBox.Text,
                Phone = Convert.ToInt32(PhoneTextBox.Text)
            };
            VirtualDatabase.CustomerList.Add(customer);
            DialogResult answer= MessageBox.Show("Yeni müştəri əlavə edildi. Başqa müştəri əlavə etmək istəyirsinizmi?",
                                                 "İnfo",MessageBoxButtons.YesNoCancel,MessageBoxIcon.Information);
            if (answer == DialogResult.Yes)
            {
                foreach (Control item in this.CustomerGroupBox.Controls )
                {
                    if (item is TextBox)
                    {
                       TextBox textBox = (TextBox)item;
                       textBox.Text= string.Empty;
                    }
                } 
            }
            else if (answer == DialogResult.No)
            {
                CustomerList.DataSource = VirtualDatabase.CustomerList;
            }
        }

        private void CustomersView(object sender, EventArgs e)
        {
            CustomerViewForm customerViewForm = new CustomerViewForm();
            customerViewForm.ShowDialog();
            
        }
    }
}

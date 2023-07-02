using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsPart2
{
    public partial class HomePage : Form
    {
        public HomePage(User user)
        {
            InitializeComponent();

            nameEdit.Text = user.Name;
            surnameEdit.Text = user.Surname;
            usernameEdit.Text = user.Username;
            passwordEdit.Text = user.Password;
            aboutUserEdit.Text = user.AboutUser;
            saveUserInfoBtn.Tag = user.Id;
        }
        

        private void EditData(object sender, EventArgs e)
        {
            User findUser = VirtualDatabase.Users.Find(m => m.Username == usernameEdit.Text);
            if (findUser != null)
            {
                findUser.Name = nameEdit.Text;
                findUser.Surname = surnameEdit.Text;
                findUser.Password = passwordEdit.Text;
                findUser.AboutUser = aboutUserEdit.Text;
                MessageBox.Show("Istifadeci melumatlari deyisdirildi", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Istifadeci tapilmadi", "Xeta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

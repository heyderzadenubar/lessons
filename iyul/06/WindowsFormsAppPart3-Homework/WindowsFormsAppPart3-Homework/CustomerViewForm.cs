﻿using System;
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
    public partial class CustomerViewForm : Form
    {
        public CustomerViewForm()
        {
            InitializeComponent();
            CustomerListBox.DataSource = VirtualDatabase.CustomerList;
        }
    }
}

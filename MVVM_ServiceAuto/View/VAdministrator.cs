﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MVVM_ServiceAuto.ViewModel;

namespace MVVM_ServiceAuto.View
{
    public partial class VAdministrator : Form
    {
        private VMAdministrator vm;

        public VAdministrator()
        {
            InitializeComponent();
            this.vm = new VMAdministrator(this);

            this.numericUpDownUserID.DataBindings.Add("Text", this.vm, "UserID", false, DataSourceUpdateMode.OnPropertyChanged);
            this.textBoxUsername.DataBindings.Add("Text", this.vm, "Username", false, DataSourceUpdateMode.OnPropertyChanged);
            this.textBoxPassword.DataBindings.Add("Text", this.vm, "Password", false, DataSourceUpdateMode.OnPropertyChanged);
            this.textBoxRole.DataBindings.Add("Text", this.vm, "Role", false, DataSourceUpdateMode.OnPropertyChanged);

            this.dataGridViewUsers.DataSource = this.vm.Users;
            this.dataGridViewUsers.SelectionChanged += DataGridViewUsers_SelectionChanged;

            this.buttonAdd.Click += delegate { vm.AddUser.Execute(); this.dataGridViewUsers.DataSource = this.vm.Users; };
            

        
        
        }

        private void DataGridViewUsers_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewUsers.SelectedRows.Count > 0) // make sure user select at least 1 row 
            {
                string username = dataGridViewUsers.SelectedRows[0].Cells["Username"].Value + string.Empty;
                string password = dataGridViewUsers.SelectedRows[0].Cells["Password"].Value + string.Empty;
                string role = dataGridViewUsers.SelectedRows[0].Cells["Role"].Value + string.Empty;
                int userID = int.Parse(dataGridViewUsers.SelectedRows[0].Cells["UserID"].Value + string.Empty);

                textBoxUsername.Text = username;
                textBoxPassword.Text = password;
                textBoxRole.Text = role;
                numericUpDownUserID.Value = userID;
            }
        }
    }
}

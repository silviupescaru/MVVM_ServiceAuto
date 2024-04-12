using System;
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
    public partial class VLogin : Form
    {
        private VMLogin vm;
        public VLogin()
        {
            InitializeComponent();
            this.vm = new VMLogin(this);
            this.textBoxUsername.DataBindings.Add("Text", this.vm, "username", false, DataSourceUpdateMode.OnValidation);
            this.textBoxPassword.DataBindings.Add("Text", this.vm, "password", false, DataSourceUpdateMode.OnValidation);

            this.buttonLogin.Click += delegate { vm.LoginUser.Execute(); };
        }
    }
}

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
    public partial class VEmployee : Form
    {

        private VMEmployee vm;

        public VEmployee()
        {
            InitializeComponent();
            this.vm = new VMEmployee(this);
            this.dataGridViewCarTable
        }
    }
}

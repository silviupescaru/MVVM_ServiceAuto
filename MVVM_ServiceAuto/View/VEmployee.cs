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

            this.numericUpDownCarID.DataBindings.Add("Text", this.vm, "CarID", false, DataSourceUpdateMode.OnValidation);
            this.textBoxOwner.DataBindings.Add("Text", this.vm, "Owner", false, DataSourceUpdateMode.OnValidation);
            this.textBoxBrand.DataBindings.Add("Text", this.vm, "Brand", false, DataSourceUpdateMode.OnValidation);
            this.textBoxColor.DataBindings.Add("Text", this.vm, "Color", false, DataSourceUpdateMode.OnValidation);
            this.comboBoxFuel.DataBindings.Add("Text", this.vm, "Fuel", false, DataSourceUpdateMode.OnValidation);
            this.dataGridViewCarTable.DataSource = this.vm.Car;

            this.buttonAdd.Click += delegate { vm.AddCar.Execute(); this.dataGridViewCarTable.DataSource = this.vm.Car; };
        }
    }
}

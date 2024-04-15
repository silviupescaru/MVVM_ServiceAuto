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

            this.numericUpDownCarID.DataBindings.Add("Text", this.vm, "carID", false, DataSourceUpdateMode.OnValidation);
            this.textBoxOwner.DataBindings.Add("Text", this.vm, "owner", false, DataSourceUpdateMode.OnValidation);
            this.textBoxBrand.DataBindings.Add("Text", this.vm, "brand", false, DataSourceUpdateMode.OnValidation);
            this.textBoxColor.DataBindings.Add("Text", this.vm, "color", false, DataSourceUpdateMode.OnValidation);
            this.comboBoxFuel.DataBindings.Add("Text", this.vm, "fuel", false, DataSourceUpdateMode.OnValidation);
            this.dataGridViewCarTable.DataSource = this.vm.Car;
        }
    }
}

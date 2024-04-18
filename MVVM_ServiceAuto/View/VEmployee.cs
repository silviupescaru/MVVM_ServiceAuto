using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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

            this.numericUpDownCarID.DataBindings.Add("Text", this.vm, "CarID", false, DataSourceUpdateMode.OnPropertyChanged);
            this.textBoxOwner.DataBindings.Add("Text", this.vm, "Owner", false, DataSourceUpdateMode.OnPropertyChanged);
            this.textBoxBrand.DataBindings.Add("Text", this.vm, "Brand", false, DataSourceUpdateMode.OnPropertyChanged);
            this.textBoxColor.DataBindings.Add("Text", this.vm, "Color", false, DataSourceUpdateMode.OnPropertyChanged);
            //this.textBoxSearchBar.DataBindings.Add("Text", this.vm, "SearchBar", false, DataSourceUpdateMode.OnValidation);

            this.comboBoxFuel.DataBindings.Add("Text", this.vm, "Fuel", false, DataSourceUpdateMode.OnPropertyChanged);
            //this.comboBoxCarFilter.DataBindings.Add("Text", this.vm, "OrderBy", false, DataSourceUpdateMode.OnValidation);
            this.dataGridViewCarTable.DataSource = this.vm.Car;

            this.buttonAdd.Click += delegate { vm.AddCar.Execute(); this.dataGridViewCarTable.DataSource = this.vm.Car; };

            this.dataGridViewCarTable.SelectionChanged += DataGridViewCarTable_SelectionChanged;

            this.buttonUpdate.Click += delegate { int selectedCar = dataGridViewCarTable.SelectedRows.Count; vm.UpdateCar.Execute(selectedCar); this.dataGridViewCarTable.DataSource = this.vm.Car; };
            this.buttonDelete.Click += delegate { int selectedCar = dataGridViewCarTable.SelectedRows.Count; vm.DeleteCar.Execute(selectedCar); this.dataGridViewCarTable.DataSource = this.vm.Car; };
            this.buttonSearch.Click += delegate { string searchedOwner = textBoxSearchBar.Text; Debug.WriteLine(searchedOwner); vm.SearchBy.Execute(searchedOwner); this.dataGridViewCarTable.DataSource = this.vm.Car; };

            //this.comboBoxCarFilter.SelectedIndexChanged += delegate { vm.OrderBy.Execute(selectedOrderOption); this.dataGridViewCarTable.DataSource = this.vm.Car; };

        }

        private void DataGridViewCarTable_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewCarTable.SelectedRows.Count > 0) // make sure user select at least 1 row 
            {
                string owner = dataGridViewCarTable.SelectedRows[0].Cells["Owner"].Value + string.Empty;
                string brand = dataGridViewCarTable.SelectedRows[0].Cells["Brand"].Value + string.Empty;
                string color = dataGridViewCarTable.SelectedRows[0].Cells["Color"].Value + string.Empty;
                string fuel = dataGridViewCarTable.SelectedRows[0].Cells["Fuel"].Value + string.Empty;
                int carID = int.Parse(dataGridViewCarTable.SelectedRows[0].Cells["CarID"].Value + string.Empty);

                textBoxOwner.Text = owner;
                textBoxBrand.Text = brand;
                textBoxColor.Text = color;
                comboBoxFuel.SelectedItem = fuel;
                numericUpDownCarID.Value = carID;
            }
        }

        private void comboBoxCarFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedOrderOption = this.comboBoxCarFilter.SelectedItem.ToString();
            vm.OrderBy.Execute(selectedOrderOption);
            this.dataGridViewCarTable.DataSource = this.vm.Car;
        }

        private void comboBoxFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedFilterOption = this.comboBoxFilterBy.SelectedItem.ToString();
            vm.FilterBy.Execute(selectedFilterOption);
            this.dataGridViewCarTable.DataSource = this.vm.Car;
        }
    }
}

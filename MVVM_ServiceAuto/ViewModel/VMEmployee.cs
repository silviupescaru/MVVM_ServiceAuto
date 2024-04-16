using MVVM_ServiceAuto.View;
using MVVM_ServiceAuto.ViewModel.CommandsEmployee;
using MVVM_ServiceAuto.Model.Repository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM_ServiceAuto.ViewModel
{
    public class VMEmployee
    {
        private uint carID;
        private string owner;
        private string brand;
        private string color;
        private string fuel;
        public DataTable Car;
        private VEmployee vEmployee;
        private Repository repository;
        public ICommands AddCar, UpdateCar, DeleteCar, FilterBy;
        public ICommands OrderBy, ListAll, Logout, SaveCSV;
        public ICommands SaveJSON, SaveXML, SaveDOC, SearchBy;

        public VMEmployee(VEmployee vEmployee) 
        {
            this.carID = 1;
            this.owner = string.Empty;
            this.brand = string.Empty;
            this.color = string.Empty;
            this.fuel = string.Empty;
            this.repository = new Repository();
            this.Car = repository.GetTable("SELECT * FROM [Car]");
            this.vEmployee = vEmployee;
            this.AddCar = new AddCarCommand(this, vEmployee);
            this.UpdateCar = new UpdateCarCommand(this, vEmployee);
            //this.DeleteCar = new DeleteCarCommand();
            //this.FilterBy = new FilterByCarCommand();
            //this.OrderBy = new OrderByCarCommand();
            //this.ListAll = new ListAllCarCommand();
            //this.SearchBy = new SearchByOwnerCommand();
            //this.Logout = new LogoutEmployeeCommand();
            //this.SaveCSV = new SaveCSVCommand();
            //this.SaveXML = new SaveXMLCommand();
            //this.SaveJSON = new SaveJSONCommand();
            //this.SaveDOC = new SaveDOCCommand();
        }

        public uint CarID 
        {
            get { return carID; } 
            set { carID = value; } 
        }

        public string Owner
        {
            get { return owner; }
            set { owner = value; }
        }

        public string Brand
        {
            get { return brand; }
            set { brand = value; }
        }

        public string Color
        {
            get { return color; }
            set { color = value; }
        }

        public string Fuel
        {
            get { return fuel; }
            set { fuel = value; }
        }

    }
}

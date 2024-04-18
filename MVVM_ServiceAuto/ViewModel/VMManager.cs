using MVVM_ServiceAuto.View;
using MVVM_ServiceAuto.ViewModel.CommandsManager;
using MVVM_ServiceAuto.Model.Repository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using MVVM_ServiceAuto.ViewModel.CommandsLogin;

namespace MVVM_ServiceAuto.ViewModel
{
    public class VMManager : INotifyPropertyChanged
    {
        private uint carID;
        private string owner;
        private string brand;
        private string color;
        private string fuel;
        public DataTable Car;
        private VManager vManager;
        private Repository repository;
        public ICommands FilterBy;
        public ICommands OrderBy, ListAll, Logout, SaveCSV;
        public ICommands SaveJSON, SaveXML, SaveDOC, SearchBy;

        public event PropertyChangedEventHandler? PropertyChanged;

        public VMManager(VManager vManager)
        {
            this.carID = 1;
            this.owner = string.Empty;
            this.brand = string.Empty;
            this.color = string.Empty;
            this.fuel = string.Empty;
            this.repository = new Repository();
            this.Car = repository.GetTable("SELECT * FROM [Car]");
            this.vManager = vManager;
            this.FilterBy = new FilterByCarCommand(this);
            this.OrderBy = new OrderByCarCommand(this);
            this.ListAll = new ListAllCarCommand(this);
            this.SearchBy = new SearchByOwnerCommand(this);
            this.Logout = new LogoutManagerCommand(new VLogin(), vManager);
            this.SaveCSV = new SaveCSVCommand(this);
            this.SaveXML = new SaveXMLCommand(this);
            this.SaveJSON = new SaveJSONCommand(this);
            this.SaveDOC = new SaveDOCCommand(this);
        }

        public uint CarID
        {
            get { return carID; }
            set { carID = value; OnPropertyChanged(nameof(CarID)); }
        }

        public string Owner
        {
            get { return owner; }
            set { owner = value; OnPropertyChanged(nameof(Owner)); }
        }

        public string Brand
        {
            get { return brand; }
            set { brand = value; OnPropertyChanged(nameof(Brand)); }
        }

        public string Color
        {
            get { return color; }
            set { color = value; OnPropertyChanged(nameof(Color)); }
        }

        public string Fuel
        {
            get { return fuel; }
            set { fuel = value; OnPropertyChanged(nameof(Fuel)); }
        }

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}

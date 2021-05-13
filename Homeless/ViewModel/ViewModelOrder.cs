﻿using Homeless.Entities;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Homeless.ViewModel
{
    public class ViewModelOrder: INotifyPropertyChanged
    {
        DB DB;

        public event PropertyChangedEventHandler PropertyChanged;
        public ObservableCollection<Order> Orders { get; set; }
        void SignalChanged([CallerMemberName] string prop = null) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));

        public Commands AddOrder { get; set; }
        public Commands ChangeOrder { get; set; }
        public Commands DeleteOrder { get; set; }

        public ViewModelOrder()
        {
            DB = DB.GetDb();
            Orders = new ObservableCollection<Order>(DB.Orders);
            SignalChanged("Orders");
        }

        private Order selectedOrder;

        public Order SelectedOrder
        {
            get => selectedOrder;
            set
            {
                selectedOrder = value;
                SignalChanged();
            }
        }
    }
}

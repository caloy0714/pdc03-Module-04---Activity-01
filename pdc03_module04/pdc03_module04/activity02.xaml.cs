﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using System.Collections.ObjectModel;

namespace pdc03_module04
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class activity02 : ContentPage
    {
        ObservableCollection<Employee> employees= new ObservableCollection<Employee>();
        
        public ObservableCollection<Employee> Employees { get { return employees; } }

        public activity02()
        {
            InitializeComponent();

            EmployeeView.ItemsSource = employees;

            employees.Add(new Employee { DisplayName = "Juan Dela Cruz", Position = "President" });
            employees.Add(new Employee { DisplayName = "Juana Dela Cruz", Position = "Vice-President" });
            employees.Add(new Employee { DisplayName = "Juane Dela Cruz", Position = "Secretary" });
            employees.Add(new Employee { DisplayName = "Juano Dela Cruz", Position = "Director" });
        }

        private void Add_Item(object sender, EventArgs e)
        {
            var menuItem = sender as MenuItem;
            if (menuItem != null)
            {

            }
        }

        private void Edit_Item(object sender, EventArgs e)
        {
            var menuItem = sender as MenuItem;
            if (menuItem != null)
            {

            }
        }

        private void Delete_Item(object sender, EventArgs e)
        {
            var menuItem = sender as MenuItem;
            if (menuItem != null)
            {

            }
        }
    }
}
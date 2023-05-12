using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace pdc03_module04
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class activity05 : ContentPage
    {
        List<Contacts> contacts;
        public activity05()
        {
            InitializeComponent();
            SetupData();
            listview.ItemsSource = contacts;
        }

        void SetupData()
        {
            contacts = new List<Contacts>();
            contacts.Add(new Contacts
            {
                Name = "Juan Cruz",
                Age = 60,
                Occupation = "Farmer",
                Country = "North Korea"
            });

            contacts.Add(new Contacts
            {
                Name = "Juana Cruza",
                Age = 67,
                Occupation = "Unemployed",
                Country = "Netherlands"
            });

            contacts.Add(new Contacts
            {
                Name = "Juano Cruz",
                Age = 44,
                Occupation = "Baker",
                Country = "Guam"
            });

            contacts.Add(new Contacts
            {
                Name = "Juan !@#$%^&*(()",
                Age = 77,
                Occupation = "Gangster",
                Country = "Pelepens"
            });

            contacts.Add(new Contacts
            {
                Name = "Juannanio Cruzalllyowo",
                Age = 50,
                Occupation = "Lover",
                Country = "Murica"
            });
        }

        async void onItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if(listview.SelectedItem != null)
            {
                var detailPage = new DetailedPage();
                detailPage.BindingContext = e.SelectedItem as Contacts;
                listview.SelectedItem = null;
                await Navigation.PushModalAsync(detailPage);
            }
        }
    }
}
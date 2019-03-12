using System;
using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinCells.Detail;
using XamarinCells.Model;

namespace XamarinCells.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListViewPage : ContentPage
    {
        public ListViewPage()
        {
            InitializeComponent();

            var list = new List<Employee>
            {
                new Employee {Name = "Luis Inacio", Function = "Developer C#"},
                new Employee {Name = "Renato Santos", Function = "Developer Java"},
                new Employee {Name = "Marilia Ferreira", Function = "Developer iOS"},
                new Employee {Name = "Joao Matos", Function = "Developer Android"},
                new Employee {Name = "Tiago Lopes", Function = "Developer Python"},
                new Employee {Name = "Bruno Novo", Function = "Developer Go"}
            };

            EmployeeList.ItemsSource = list;
        }

        private void EmployeeList_OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var emp = (Employee) e.SelectedItem;
            Navigation.PushAsync(new DetailPage(emp));
        }

        private void MenuItem_OnClickedVacation(object sender, EventArgs e)
        {
            var btn = (MenuItem)sender;
            var emp = (Employee) btn.CommandParameter;

            DisplayAlert("Title: " + emp.Name, " Message: " + emp.Name + " - " + emp.Function, "Ok");
        }

        private void MenuItem_OnClickedWelfare(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}